using Proyecto_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TPI
{
    public partial class frmConsultaServicio : Form
    {
        public frmConsultaServicio()
        {
            InitializeComponent();
        }

        private void frmAltaServicio_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            ObtenerServicios();
            limpiar_campos();
        }

        private void ObtenerServicios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Servicios WHERE 1=1";
                cmd.Parameters.Clear();
                if (!string.IsNullOrEmpty(txtnombre.Text))
                {
                    cmd.Parameters.AddWithValue("@Nombre",txtnombre.Text);
                    consulta += "AND nombre like '@Nombre%'";
                }
                if (!string.IsNullOrEmpty(txtdesc.Text))
                {
                    cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text);
                    consulta += "AND descripcion like '@descripcion%'";
                }
                if (!string.IsNullOrEmpty(txtdesde.Text) && !string.IsNullOrEmpty(txthasta.Text))
                {
                    cmd.Parameters.AddWithValue("@costo_desde", txtdesde.Text);
                    cmd.Parameters.AddWithValue("@costo_hasta", txthasta.Text);
                    consulta += "AND (costo_mensual > @costo_desde AND costo_mensual < @costo_hasta)";
                }
                if (checkActivo.Checked)
                {
                    consulta += "AND activo = 0";
                }
                else 
                {
                    consulta += "AND activo = 1";
                }
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgv_servicios.DataSource = tabla;
                
            }
            catch (Exception)
            {

                throw;
            }
            btnActualizar.Enabled = true;
        }

        private void btm_limpiarDatos_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void limpiar_campos()
        {
            txtnombre.Text = "";
            txtdesc.Text = "";
            txtdesde.Text = "";
            txthasta.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Servicios servicio = new Servicios();
            DataGridViewRow grid = dgv_servicios.SelectedRows[0];
            

            servicio.Codigo_servicio = (int)grid.Cells[0].Value;
            servicio.Nombre_servicio = (string) grid.Cells[1].Value;
            servicio.Descripcion_servivio = (string) grid.Cells[2].Value;
            servicio.Costo_mensual_servicio = (int)grid.Cells[3].Value;
            frmEditarServicios editarServicios = new frmEditarServicios();
            editarServicios.InicializarEditarServicios(servicio);
            editarServicios.ShowDialog();
            

        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ObtenerServicios();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Servicios servicio = new Servicios();
            DataGridViewRow grid = dgv_servicios.SelectedRows[0];
            servicio.Codigo_servicio = (int)grid.Cells[0].Value;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Servicios SET activo = 1 WHERE cod_servicio = @codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", servicio.Codigo_servicio);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
                MessageBox.Show("Servicio dado de baja");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

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
    public partial class frmEditarServicios : Form
    {
        public frmEditarServicios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            var serv = new Servicios();
            serv.Nombre_servicio = txtNombre.Text;
            serv.Descripcion_servivio = txtDescripcion.Text;
            serv.Codigo_servicio = Int32.Parse(txtidservicio.Text);
            serv.Costo_mensual_servicio = Int32.Parse(txtMonto.Text);


            bool resultado = AgregarServcioABD(serv);
            if (resultado)
            {
                MessageBox.Show("Persona modificada con exito....");

            }
            else
            {
                MessageBox.Show("Error al agregada la persona...");
            }

            this.Close();
        }

        private bool AgregarServcioABD(Servicios serv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Servicios SET nombre = @nombre, descripcion = @descripcion, costo_mensual = @costo_mensual WHERE cod_servicio = @codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", serv.Codigo_servicio);
                cmd.Parameters.AddWithValue("@nombre", serv.Nombre_servicio);
                cmd.Parameters.AddWithValue("@descripcion", serv.Descripcion_servivio);
                cmd.Parameters.AddWithValue("@costo_mensual", serv.Costo_mensual_servicio);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        internal void InicializarEditarServicios(Servicios servicio)
        {
            txtidservicio.Text = servicio.Codigo_servicio.ToString();
            txtNombre.Text = servicio.Nombre_servicio.ToString();
            txtDescripcion.Text = servicio.Descripcion_servivio;
            txtMonto.Text = servicio.Costo_mensual_servicio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

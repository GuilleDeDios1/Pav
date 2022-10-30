using Proyecto_TPI.Validador;
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
    public partial class frmAltaContratoObtencionCliente : Form
    {
        public frmAltaContratoObtencionCliente()
        {
            InitializeComponent();
        }

        private void altaContratoObtencionCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtNumTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Se debe ingresar telefono");
                return;
            }
            bool van1 = validador.validar_existencia_telefono(Convert.ToUInt32(txtNumTelefono.Text));
            if (!van1)
            {
                MessageBox.Show("El numero de telefono ya existe");
                return;
            }

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta1 = "INSERT INTO [dbo].[Telefonos]"
                                    + "([nro_telefono]"
                                    + ",[nro_cliente])"
                                    + "VALUES"
                                    + "(@numtell"
                                    + ",@numcliente)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numtell", long.Parse(txtNumTelefono.Text));
                cmd.Parameters.AddWithValue("@numcliente", Int32.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString()));
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta1;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                MessageBox.Show("Telefono asignado a cliente con exito");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

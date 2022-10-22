using Proyecto_TPI.Entidades;
using System.Data;
using Proyecto_TPI.Validador;
using System.Data.SqlClient;

namespace Proyecto_TPI
{
    public partial class FrmAltaServicios : Form
    {
        public FrmAltaServicios()
        {
            InitializeComponent();
        }


 

        

        private bool AgregarServcioABD(Servicios serv)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Servicios (nombre, descripcion, costo_mensual, activo) VALUES (@nombre, @descripcion, @costo_mensual, 0)";
                cmd.Parameters.Clear();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            {
                bool van = validador.validar(Controls);
                if (!van) { return;}
                Servicios serv = new Servicios();
                serv.Nombre_servicio = txtNombre.Text;
                serv.Descripcion_servivio = txtDescrip.Text;
                serv.Costo_mensual_servicio = Int32.Parse(txtcosto.Text);

                bool resultado = AgregarServcioABD(serv);
                if (resultado)
                {
                    MessageBox.Show("Persona Agregada con exito....");

                }
                else
                {
                    MessageBox.Show("Error al agregar la persona...");
                }

                this.Close();

            }
        }
    }
}


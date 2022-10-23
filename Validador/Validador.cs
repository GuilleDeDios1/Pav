using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Validador
{
    internal class validador
    {   public validador(){}

        public static bool validar(Control.ControlCollection a)
        {   bool van = true;
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a));
            }
            foreach (Control item in a) {
                if (item is GroupBox) {
                    foreach (Control item1 in item.Controls) 
                    {
                        if (item1.Text.Trim().Equals(""))
                        {
                            van = false;
                        }
                    }
                    
                    
                }
            }
            if (!van)
            {
                MessageBox.Show("Hay campos incorrectos");
            }
            return van;
        }

        public static bool validar_existencia_servicio(string nombre)
        {
            bool van = true;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Servicios WHERE nombre like @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                if (tabla.Rows.Count != 0) {
                    van = false;
                }
                return van;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}



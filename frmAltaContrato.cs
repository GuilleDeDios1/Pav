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
using Proyecto_TPI.Validador;

namespace Proyecto_TPI
{
    public partial class frmAltaContrato : Form
    {
        public frmAltaContrato()
        {
            InitializeComponent();
        }

        private void frmAltaContrato_Load(object sender, EventArgs e)
        {
           //llena el datagridview
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT id,nombre_cliente,calle,nro_calle FROM Cliente";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvClientes.DataSource = tabla;

            }
            catch (Exception)
            {

                throw;
            }
            //lena el combo
            DataTable tabla2 = buscar_servicios();
            foreach(DataRow item in tabla2.Rows)
            {
                cboServ.Items.Add(item[0].ToString());
            }

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            txtNumCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
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

        //boton asignar contrato
        private void btnasignarcontrato_Click(object sender, EventArgs e)
        {

            if (txtnrotellcont.Text.Trim() == "" || cboServ.Text.Trim() == "") {
                MessageBox.Show("Se debe ingresar todos los datos requeridos");
                return;
            }
            bool van = validador.validar_existencia_telefono(Convert.ToUInt32(txtnrotellcont.Text));
            if (van)
            {
                MessageBox.Show("El telefono no existe");
                return;
            }
            //cargar combo de servicios
            DataTable tabla = buscar_servicios();
            int id_serv = 0;
            int costo = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                if (fila[0].ToString() == cboServ.Text) {
                    id_serv = Int32.Parse(fila[1].ToString());
                    costo = Int32.Parse(fila[2].ToString());
                }
            }
            //controla fecha de datapic
            if (dtpic.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser menor a la actual");
                return;
            }
            //controla si hay servicios de ese tipo activo para el numero de telefono
            bool vandera = validador.validar_numero_servicio(Int32.Parse(txtnrotellcont.Text), id_serv);
            if (vandera)
            {
                MessageBox.Show("Este numero tiene vigente un servicio de este tipo");
                return;
            }

            //controla que no ingrese dos veces el mismo dato en la gridviwv intermedia
            if ((dgvAsignar.RowCount - 1) > 0)
            {
                foreach (DataGridViewRow item in dgvAsignar.Rows)
                {
                    if (item.Cells[1].Value != null && Int32.Parse(item.Cells[1].Value.ToString()) == id_serv)
                    {

                        MessageBox.Show("Ya se agrego este servicio");
                        return;
                    }
                }
            }


            //hacer update de la tabla servicios contratados
            dgvAsignar.Rows.Add(txtnrotellcont.Text,id_serv,dtpic.Value,costo);
            txtnrotellcont.Enabled = false;
        }
        //busca los servicios y devuelve una tabla con dos columnas nombre e id de servicio
        private DataTable buscar_servicios() 
        {
            string cadenaConexion2 = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn2 = new SqlConnection(cadenaConexion2);
            try
            {
                SqlCommand cmd2 = new SqlCommand();
                string consulta = "SELECT nombre, cod_servicio,costo_mensual FROM Servicios WHERE activo = 0";
                cmd2.Parameters.Clear();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = consulta;

                cn2.Open();
                cmd2.Connection = cn2;
                cmd2.ExecuteNonQuery();

                DataTable tabla2 = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(tabla2);
                return tabla2;


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void nadaquever(int numtell, int id_servicio)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumCliente.Text.Trim() == "")
            {
                MessageBox.Show("No se selecciono cliente");
                return;
            }
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaction = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO[dbo].[Facturas]"
                                           + "([fecha]"
                                           + ",[fecha_vencimiento] "
                                            + ",[fecha_pago] "
                                            + ",[nro_cliente])"
                                    + "VALUES"
                                           + "(@fecha"
                                            + ",@fechavencimiento"
                                            + ",@fechapago"
                                            + ",@nrocliente)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechavencimiento", dtpic.Value);
                cmd.Parameters.AddWithValue("@fechapago", DateTime.Now);
                cmd.Parameters.AddWithValue("@nrocliente", Int32.Parse(txtNumCliente.Text));
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objTransaction = cn.BeginTransaction("serviciosXcontrato");
                
                cmd.Transaction = objTransaction;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                int numerofactura = validador.buscar_numfactura();
                foreach (DataGridViewRow item in dgvAsignar.Rows)
                {
                    string consultaserviciosxcliente = "INSERT INTO[dbo].[Servicios_Contratados]"
                                                       + "([nro_telefono]"
                                                     + ",[fecha_desde]"
                                                     + ",[fecha_hasta]"
                                                     + ",[id_servicio])"
                                             + "VALUES"
                                                + "(@numeroteledono"
                                               + ", @datedesde"
                                                + ", @datehasta"
                                                + ", @idservicio)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numeroteledono", int.Parse(item.Cells[0].Value.ToString()));
                    cmd.Parameters.AddWithValue("@datedesde", DateTime.Now);
                    cmd.Parameters.AddWithValue("@datehasta", item.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@idservicio", Int32.Parse(item.Cells[1].Value.ToString()));
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = consultaserviciosxcliente;
                    cmd.ExecuteNonQuery();
                    objTransaction = cn.BeginTransaction("serviciosXcontrato");

                    string consultaDetalleFactura = "INSERT INTO[dbo].[Detalle_factura_servicios]"
                                                                + "([nrofactura]"
                                                                + ",[id_servicios_contratados])"
                                                            + "VALUES"
                                                                + "(@numerofactura "
                                                                + ", @id_servicio )";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@numerofactura", numerofactura);
                    cmd.Parameters.AddWithValue("@id_servicio", Int32.Parse(item.Cells[1].Value.ToString()));
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = consultaDetalleFactura;
                    cmd.ExecuteNonQuery();
                    objTransaction.Commit();
                }



                MessageBox.Show("Se genero la la factura conn sus detalles");

            }
            catch (Exception)
            {
                objTransaction.Rollback();
                MessageBox.Show("La transaccion no se pudo completar");

                throw;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvAsignar.CurrentRow.Cells[0] != null) { 
            dgvAsignar.Rows.Remove(dgvAsignar.CurrentRow);
            }
        }
    }   
}

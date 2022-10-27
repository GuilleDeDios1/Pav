using Proyecto_TPI.BaseDeDatos;
using Proyecto_TPI.Entidades;

namespace Proyecto_TPI.Resources
{
    public partial class baja_modificacion : Form
    {

        private int accion;
        private Cliente oCliente;
        public baja_modificacion(int accion, Cliente oCliente)
        {
            InitializeComponent();
            this.accion = accion;
            this.oCliente = oCliente;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnrocliente.Text))
            {
                MessageBox.Show("Campo numero de documento es requerido", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (accion == 1)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@nombre", txtnombre.Text);
                parametros.Add("@barrio", txtbarrio.Text);
                parametros.Add("@calle", txtcalle.Text);
                parametros.Add("@nro_calle", txtnrocalle.Text);
                parametros.Add("@nro_cliente", oCliente.NumeroCliente);
                parametros.Add("@localidad", txtlocalidad.Text);
                parametros.Add("@activo", oCliente.Activo);


                string update = "UPDATE clientes SET nombre_cliente = @nombre,id_localidad = @localidad, calle = @calle, id_barrio = @barrio, nro_calle = @nro_calle WHERE nro_cliente = @nro_cliente";

                int respuesta = new Managmentdb().EjecutarSQL(update, parametros);

                if (respuesta == 1)
                {
                    MessageBox.Show("cliente actualizado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@nro_cliente", oCliente.NumeroCliente);
                string delete = "UPDATE clientes SET activo = 0 WHERE nro_cliente = @nro_cliente";

                int respuesta = new Managmentdb().EjecutarSQL(delete, parametros);


                if (respuesta == 1)
                {
                    MessageBox.Show("cliente eliminado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al borrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void baja_modificacion_Load(object sender, EventArgs e)
        {
            txtnombre.Text = oCliente.NombreCliente;
            chkactivos.Checked = oCliente.Activo;
            txtbarrio.Text = oCliente.barrio;
            txtcalle.Text = oCliente.calle;
            txtnrocalle.Text = oCliente.nroCalle.ToString();
            txtlocalidad.Text = oCliente.localidad;
            txtnrocliente.Text = oCliente.NumeroCliente;





            if (accion == 1)
            {
                txtnrocliente.Enabled = false;
                chkactivos.Enabled = false;
                this.Text = "Registrar baja de Producto";
            }
            else
            {
                txtlocalidad.Enabled = false;
                chkactivos.Enabled = false;
                txtnombre.Enabled = false;
                txtbarrio.Enabled = false;
                txtcalle.Enabled = false;
                txtnrocliente.Enabled = false;
                txtnrocalle.Enabled = false;
                this.Text = "Modificar Producto";
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

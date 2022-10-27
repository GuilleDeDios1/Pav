using Proyecto_TPI.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TPI
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtlocalidad.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner la localidad", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNrocliente.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el numero de cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCalle.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner la calle en donde vive", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNrocalle.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el numero de calle", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtbarrio.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el codigo barrio", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int activo;

            if (chkactivo.Checked)
            {
                activo = 0;
            }
            else
            {
                activo = 1;
            }


            Dictionary<string, object> parametros = new Dictionary<string, object>(); ;
            parametros.Add("@nombre", txtNombre.Text);
            parametros.Add("@localidad", txtlocalidad.Text);
            parametros.Add("@nro_calle", txtNrocalle.Text);
            parametros.Add("@barrio", txtbarrio.Text);
            parametros.Add("@nro_cliente", txtNrocliente.Text);
            parametros.Add("@calle", txtCalle.Text);
            parametros.Add("@activo", activo.ToString());


            string insert = "INSERT INTO Cliente (nro_cliente, nombre_cliente,calle,nro_calle,id_barrio,id_localidad,activo) VALUES(@nro_cliente, @nombre, @calle,@nro_calle, @barrio,@localidad, @activo)";
            int respuesta = new Managmentdb().EjecutarSQL(insert, parametros);

            if (respuesta == 1)
            {
                MessageBox.Show("nuevo cliente agregado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al agregar un cliente nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

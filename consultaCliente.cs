using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_TPI.BaseDeDatos;
using Proyecto_TPI.Entidades;
using Proyecto_TPI.Resources;

namespace Proyecto_TPI.Properties
{
    public partial class consultaCliente : Form
    {
        public consultaCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Cliente WHERE 1=1 ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                strSql += "AND (nombre_cliente=@cliente) ";
                parametros.Add("@cliente", txtNombre.Text);
            }

            if (chkactivo.Checked)
            {
                strSql += " AND activo = '1'";
            }
            else
            {
                strSql += " AND activo = '0'";
            }

            dgvClientes.DataSource = new Managmentdb().ConsultaSQL(strSql, parametros);

            if (dgvClientes.Rows.Count > 0 && chkactivo.Checked)
            {
                habilitarControles(true);
            }
            else
            {
                habilitarControles(false);
            }
        }

        private void habilitarControles(bool v)
        {
            btnmodificar.Enabled = v;
            btneliminar.Enabled = v;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            if (fila != null)
            {
                new baja_modificacion(1, mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private Cliente mapper(DataGridViewRow fila)
        {
            Cliente oSeleted = new Cliente();
            oSeleted.NombreCliente = fila.Cells["Nombre"].Value.ToString();
            oSeleted.NumeroCliente = (fila.Cells["Nrocliente"].Value.ToString());
            oSeleted.Activo = (bool)fila.Cells["activo"].Value;
            oSeleted.barrio = (fila.Cells["barrio"].Value.ToString());
            oSeleted.nroCalle =(fila.Cells["nrocalle"].Value.ToString());
            oSeleted.calle = fila.Cells["calle"].Value.ToString();
            oSeleted.localidad = (fila.Cells["localidad"].Value.ToString());


            return oSeleted;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            if (fila != null)
            {
                new baja_modificacion(2, mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private void consultaCliente_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
        }
    }
}

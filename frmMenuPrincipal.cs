using Proyecto_TPI.Properties;

namespace Proyecto_TPI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La mejor version de ti");
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServicio ventana = new frmConsultaServicio();
            ventana.Show();
        }

        private void darAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaServicios ventana = new FrmAltaServicios();
            ventana.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new consultaCliente().ShowDialog();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaCliente().ShowDialog();

        }
    }
}

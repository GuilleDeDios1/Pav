namespace Proyecto_TPI.Properties
{
    partial class consultaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb1 = new System.Windows.Forms.GroupBox();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.Nrocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nrocalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb1
            // 
            this.Gb1.Controls.Add(this.chkactivo);
            this.Gb1.Controls.Add(this.btnConsultar);
            this.Gb1.Controls.Add(this.txtNombre);
            this.Gb1.Controls.Add(this.lblNombre);
            this.Gb1.Controls.Add(this.dgvClientes);
            this.Gb1.Location = new System.Drawing.Point(25, 38);
            this.Gb1.Name = "Gb1";
            this.Gb1.Size = new System.Drawing.Size(870, 488);
            this.Gb1.TabIndex = 0;
            this.Gb1.TabStop = false;
            this.Gb1.Text = "filtros";
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Location = new System.Drawing.Point(140, 109);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(85, 29);
            this.chkactivo.TabIndex = 3;
            this.chkactivo.Text = "activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(597, 51);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 34);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(430, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(50, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "nombre:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nrocliente,
            this.Nombre,
            this.calle,
            this.localidad,
            this.barrio,
            this.activo,
            this.nrocalle,
            this.id});
            this.dgvClientes.Location = new System.Drawing.Point(32, 168);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 33;
            this.dgvClientes.Size = new System.Drawing.Size(838, 314);
            this.dgvClientes.TabIndex = 4;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(208, 567);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 34);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(580, 567);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(112, 34);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // Nrocliente
            // 
            this.Nrocliente.DataPropertyName = "nro_cliente";
            this.Nrocliente.HeaderText = "numero cliente";
            this.Nrocliente.MinimumWidth = 8;
            this.Nrocliente.Name = "Nrocliente";
            this.Nrocliente.ReadOnly = true;
            this.Nrocliente.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_cliente";
            this.Nombre.HeaderText = "nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "calle";
            this.calle.MinimumWidth = 8;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Visible = false;
            this.calle.Width = 150;
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "id_localidad";
            this.localidad.HeaderText = "localidad";
            this.localidad.MinimumWidth = 8;
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            this.localidad.Width = 150;
            // 
            // barrio
            // 
            this.barrio.DataPropertyName = "id_barrio";
            this.barrio.HeaderText = "barrio";
            this.barrio.MinimumWidth = 8;
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            this.barrio.Width = 150;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.MinimumWidth = 8;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 150;
            // 
            // nrocalle
            // 
            this.nrocalle.DataPropertyName = "nro_calle";
            this.nrocalle.HeaderText = "nrocalle";
            this.nrocalle.MinimumWidth = 8;
            this.nrocalle.Name = "nrocalle";
            this.nrocalle.ReadOnly = true;
            this.nrocalle.Visible = false;
            this.nrocalle.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 640);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.Gb1);
            this.Name = "consultaCliente";
            this.Text = "consultaCliente";
            this.Load += new System.EventHandler(this.consultaCliente_Load);
            this.Gb1.ResumeLayout(false);
            this.Gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Gb1;
        private CheckBox chkactivo;
        private Button btnConsultar;
        private TextBox txtNombre;
        private Label lblNombre;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Nrocliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn calle;
        private DataGridViewTextBoxColumn localidad;
        private DataGridViewTextBoxColumn barrio;
        private DataGridViewCheckBoxColumn activo;
        private DataGridViewTextBoxColumn nrocalle;
        private DataGridViewTextBoxColumn id;
        private Button btneliminar;
        private Button btnmodificar;
    }
}
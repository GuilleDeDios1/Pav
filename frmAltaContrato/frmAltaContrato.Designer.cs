namespace Proyecto_TPI
{
    partial class frmAltaContrato
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
            this.grbAsignarContrat = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dtpic = new System.Windows.Forms.DateTimePicker();
            this.txtnrotellcont = new System.Windows.Forms.TextBox();
            this.btnasignarcontrato = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboServ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvAsignar = new System.Windows.Forms.DataGridView();
            this.nroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_servi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.grbSelectTelefono = new System.Windows.Forms.GroupBox();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grbAsignarContrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignar)).BeginInit();
            this.grbSelectTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAsignarContrat
            // 
            this.grbAsignarContrat.Controls.Add(this.btnBorrar);
            this.grbAsignarContrat.Controls.Add(this.dtpic);
            this.grbAsignarContrat.Controls.Add(this.txtnrotellcont);
            this.grbAsignarContrat.Controls.Add(this.btnasignarcontrato);
            this.grbAsignarContrat.Controls.Add(this.label5);
            this.grbAsignarContrat.Controls.Add(this.label4);
            this.grbAsignarContrat.Controls.Add(this.cboServ);
            this.grbAsignarContrat.Controls.Add(this.label3);
            this.grbAsignarContrat.Location = new System.Drawing.Point(22, 311);
            this.grbAsignarContrat.Name = "grbAsignarContrat";
            this.grbAsignarContrat.Size = new System.Drawing.Size(256, 179);
            this.grbAsignarContrat.TabIndex = 1;
            this.grbAsignarContrat.TabStop = false;
            this.grbAsignarContrat.Text = "AsingnarContrato";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(24, 147);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dtpic
            // 
            this.dtpic.Location = new System.Drawing.Point(97, 97);
            this.dtpic.Name = "dtpic";
            this.dtpic.Size = new System.Drawing.Size(121, 23);
            this.dtpic.TabIndex = 9;
            // 
            // txtnrotellcont
            // 
            this.txtnrotellcont.Location = new System.Drawing.Point(97, 56);
            this.txtnrotellcont.Name = "txtnrotellcont";
            this.txtnrotellcont.Size = new System.Drawing.Size(121, 23);
            this.txtnrotellcont.TabIndex = 7;
            // 
            // btnasignarcontrato
            // 
            this.btnasignarcontrato.Location = new System.Drawing.Point(147, 147);
            this.btnasignarcontrato.Name = "btnasignarcontrato";
            this.btnasignarcontrato.Size = new System.Drawing.Size(75, 23);
            this.btnasignarcontrato.TabIndex = 6;
            this.btnasignarcontrato.Text = "Asignar";
            this.btnasignarcontrato.UseVisualStyleBackColor = true;
            this.btnasignarcontrato.Click += new System.EventHandler(this.btnasignarcontrato_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "FechaHasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NroTelefono";
            // 
            // cboServ
            // 
            this.cboServ.FormattingEnabled = true;
            this.cboServ.Location = new System.Drawing.Point(97, 22);
            this.cboServ.Name = "cboServ";
            this.cboServ.Size = new System.Drawing.Size(121, 23);
            this.cboServ.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servicios";
            // 
            // dgvAsignar
            // 
            this.dgvAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroTelefono,
            this.cod_servi,
            this.fechaHasta,
            this.costo_mensual});
            this.dgvAsignar.Location = new System.Drawing.Point(346, 279);
            this.dgvAsignar.Name = "dgvAsignar";
            this.dgvAsignar.RowTemplate.Height = 25;
            this.dgvAsignar.Size = new System.Drawing.Size(445, 265);
            this.dgvAsignar.TabIndex = 3;
            // 
            // nroTelefono
            // 
            this.nroTelefono.HeaderText = "Telefono";
            this.nroTelefono.Name = "nroTelefono";
            // 
            // cod_servi
            // 
            this.cod_servi.HeaderText = "nro_servicio";
            this.cod_servi.Name = "cod_servi";
            // 
            // fechaHasta
            // 
            this.fechaHasta.HeaderText = "fechaHasta";
            this.fechaHasta.Name = "fechaHasta";
            // 
            // costo_mensual
            // 
            this.costo_mensual.HeaderText = "Costo Mensual";
            this.costo_mensual.Name = "costo_mensual";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(257, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero De Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num_Telefono";
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(120, 71);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(102, 23);
            this.txtNumTelefono.TabIndex = 3;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(147, 110);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // grbSelectTelefono
            // 
            this.grbSelectTelefono.Controls.Add(this.txtNumCliente);
            this.grbSelectTelefono.Controls.Add(this.btnAsignar);
            this.grbSelectTelefono.Controls.Add(this.txtNumTelefono);
            this.grbSelectTelefono.Controls.Add(this.label2);
            this.grbSelectTelefono.Controls.Add(this.label1);
            this.grbSelectTelefono.Location = new System.Drawing.Point(31, 60);
            this.grbSelectTelefono.Name = "grbSelectTelefono";
            this.grbSelectTelefono.Size = new System.Drawing.Size(256, 136);
            this.grbSelectTelefono.TabIndex = 0;
            this.grbSelectTelefono.TabStop = false;
            this.grbSelectTelefono.Text = "AsignarTelefono";
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Enabled = false;
            this.txtNumCliente.Location = new System.Drawing.Point(120, 33);
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.Size = new System.Drawing.Size(102, 23);
            this.txtNumCliente.TabIndex = 5;
            // 
            // nro_calle
            // 
            this.nro_calle.DataPropertyName = "nro_calle";
            this.nro_calle.HeaderText = "Nro Calle";
            this.nro_calle.Name = "nro_calle";
            // 
            // calle_cliente
            // 
            this.calle_cliente.DataPropertyName = "calle";
            this.calle_cliente.HeaderText = "Calle";
            this.calle_cliente.Name = "calle_cliente";
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.DataPropertyName = "nombre_cliente";
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.Name = "nombre_cliente";
            // 
            // id_ser
            // 
            this.id_ser.DataPropertyName = "id";
            this.id_ser.HeaderText = "ID cliente";
            this.id_ser.Name = "id_ser";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ser,
            this.nombre_cliente,
            this.calle_cliente,
            this.nro_calle});
            this.dgvClientes.Location = new System.Drawing.Point(346, 13);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(445, 223);
            this.dgvClientes.TabIndex = 2;
            // 
            // frmAltaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 556);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAsignar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grbAsignarContrat);
            this.Controls.Add(this.grbSelectTelefono);
            this.Name = "frmAltaContrato";
            this.Text = "frmAltaContrato";
            this.Load += new System.EventHandler(this.frmAltaContrato_Load);
            this.grbAsignarContrat.ResumeLayout(false);
            this.grbAsignarContrat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignar)).EndInit();
            this.grbSelectTelefono.ResumeLayout(false);
            this.grbSelectTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grbAsignarContrat;
        private TextBox txtnrotellcont;
        private Button btnasignarcontrato;
        private Label label5;
        private Label label4;
        private ComboBox cboServ;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dtpic;
        private DataGridView dgvAsignar;
        private DataGridViewTextBoxColumn nroTelefono;
        private DataGridViewTextBoxColumn cod_servi;
        private DataGridViewTextBoxColumn fechaHasta;
        private DataGridViewTextBoxColumn costo_mensual;
        private Button btnGuardar;
        private Button btnBorrar;
        private Label label1;
        private Label label2;
        private TextBox txtNumTelefono;
        private Button btnAsignar;
        private GroupBox grbSelectTelefono;
        private TextBox txtNumCliente;
        private DataGridViewTextBoxColumn nro_calle;
        private DataGridViewTextBoxColumn calle_cliente;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn id_ser;
        private DataGridView dgvClientes;
    }
}
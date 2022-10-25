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
            this.grbSelectTelefono = new System.Windows.Forms.GroupBox();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAsignarContrat = new System.Windows.Forms.GroupBox();
            this.dtpic = new System.Windows.Forms.DateTimePicker();
            this.txtnrotellcont = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboServ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnasignarcontrato = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.id_ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSelectTelefono.SuspendLayout();
            this.grbAsignarContrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSelectTelefono
            // 
            this.grbSelectTelefono.Controls.Add(this.txtNumCliente);
            this.grbSelectTelefono.Controls.Add(this.btnAsignar);
            this.grbSelectTelefono.Controls.Add(this.txtNumTelefono);
            this.grbSelectTelefono.Controls.Add(this.label2);
            this.grbSelectTelefono.Controls.Add(this.label1);
            this.grbSelectTelefono.Location = new System.Drawing.Point(12, 12);
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
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(147, 110);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(120, 71);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(102, 23);
            this.txtNumTelefono.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero De Cliente";
            // 
            // grbAsignarContrat
            // 
            this.grbAsignarContrat.Controls.Add(this.dtpic);
            this.grbAsignarContrat.Controls.Add(this.txtnrotellcont);
            this.grbAsignarContrat.Controls.Add(this.btnasignarcontrato);
            this.grbAsignarContrat.Controls.Add(this.label5);
            this.grbAsignarContrat.Controls.Add(this.label4);
            this.grbAsignarContrat.Controls.Add(this.cboServ);
            this.grbAsignarContrat.Controls.Add(this.label3);
            this.grbAsignarContrat.Location = new System.Drawing.Point(12, 154);
            this.grbAsignarContrat.Name = "grbAsignarContrat";
            this.grbAsignarContrat.Size = new System.Drawing.Size(256, 179);
            this.grbAsignarContrat.TabIndex = 1;
            this.grbAsignarContrat.TabStop = false;
            this.grbAsignarContrat.Text = "AsingnarContrato";
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
            this.dgvClientes.Size = new System.Drawing.Size(445, 311);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // id_ser
            // 
            this.id_ser.DataPropertyName = "id";
            this.id_ser.HeaderText = "ID cliente";
            this.id_ser.Name = "id_ser";
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.DataPropertyName = "nombre_cliente";
            this.nombre_cliente.HeaderText = "Nombre";
            this.nombre_cliente.Name = "nombre_cliente";
            // 
            // calle_cliente
            // 
            this.calle_cliente.DataPropertyName = "calle";
            this.calle_cliente.HeaderText = "Calle";
            this.calle_cliente.Name = "calle_cliente";
            // 
            // nro_calle
            // 
            this.nro_calle.DataPropertyName = "nro_calle";
            this.nro_calle.HeaderText = "Nro Calle";
            this.nro_calle.Name = "nro_calle";
            // 
            // frmAltaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 345);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grbAsignarContrat);
            this.Controls.Add(this.grbSelectTelefono);
            this.Name = "frmAltaContrato";
            this.Text = "frmAltaContrato";
            this.Load += new System.EventHandler(this.frmAltaContrato_Load);
            this.grbSelectTelefono.ResumeLayout(false);
            this.grbSelectTelefono.PerformLayout();
            this.grbAsignarContrat.ResumeLayout(false);
            this.grbAsignarContrat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbSelectTelefono;
        private Button btnAsignar;
        private TextBox txtNumTelefono;
        private Label label2;
        private Label label1;
        private GroupBox grbAsignarContrat;
        private TextBox txtnrotellcont;
        private Button btnasignarcontrato;
        private Label label5;
        private Label label4;
        private ComboBox cboServ;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvClientes;
        private TextBox txtNumCliente;
        private DataGridViewTextBoxColumn id_ser;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn calle_cliente;
        private DataGridViewTextBoxColumn nro_calle;
        private DateTimePicker dtpic;
    }
}
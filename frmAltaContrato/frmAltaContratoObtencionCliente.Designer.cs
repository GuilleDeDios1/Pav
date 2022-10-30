namespace Proyecto_TPI
{
    partial class frmAltaContratoObtencionCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.id_ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSelectTelefono = new System.Windows.Forms.GroupBox();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbSelectTelefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ser,
            this.nombre_cliente,
            this.calle_cliente,
            this.nro_calle});
            this.dgvClientes.Location = new System.Drawing.Point(343, 46);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(445, 223);
            this.dgvClientes.TabIndex = 3;
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
            // grbSelectTelefono
            // 
            this.grbSelectTelefono.Controls.Add(this.txtNumCliente);
            this.grbSelectTelefono.Controls.Add(this.btnAsignar);
            this.grbSelectTelefono.Controls.Add(this.txtNumTelefono);
            this.grbSelectTelefono.Controls.Add(this.label2);
            this.grbSelectTelefono.Controls.Add(this.label1);
            this.grbSelectTelefono.Location = new System.Drawing.Point(12, 46);
            this.grbSelectTelefono.Name = "grbSelectTelefono";
            this.grbSelectTelefono.Size = new System.Drawing.Size(256, 136);
            this.grbSelectTelefono.TabIndex = 4;
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
            // frmAltaContratoObtencionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSelectTelefono);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmAltaContratoObtencionCliente";
            this.Text = "altaContratoObtencionCliente";
            this.Load += new System.EventHandler(this.altaContratoObtencionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbSelectTelefono.ResumeLayout(false);
            this.grbSelectTelefono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn id_ser;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn calle_cliente;
        private DataGridViewTextBoxColumn nro_calle;
        private GroupBox grbSelectTelefono;
        private TextBox txtNumCliente;
        private Button btnAsignar;
        private TextBox txtNumTelefono;
        private Label label2;
        private Label label1;
    }
}
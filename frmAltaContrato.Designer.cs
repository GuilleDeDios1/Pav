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
            this.grbAsignarContrat = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSelectTelefono.SuspendLayout();
            this.grbAsignarContrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSelectTelefono
            // 
            this.grbSelectTelefono.Controls.Add(this.btnAsignar);
            this.grbSelectTelefono.Controls.Add(this.textBox1);
            this.grbSelectTelefono.Controls.Add(this.label2);
            this.grbSelectTelefono.Controls.Add(this.label1);
            this.grbSelectTelefono.Controls.Add(this.comboBox1);
            this.grbSelectTelefono.Location = new System.Drawing.Point(12, 12);
            this.grbSelectTelefono.Name = "grbSelectTelefono";
            this.grbSelectTelefono.Size = new System.Drawing.Size(254, 153);
            this.grbSelectTelefono.TabIndex = 0;
            this.grbSelectTelefono.TabStop = false;
            this.grbSelectTelefono.Text = "AsignarTelefono";
            // 
            // grbAsignarContrat
            // 
            this.grbAsignarContrat.Controls.Add(this.textBox3);
            this.grbAsignarContrat.Controls.Add(this.button1);
            this.grbAsignarContrat.Controls.Add(this.label5);
            this.grbAsignarContrat.Controls.Add(this.textBox2);
            this.grbAsignarContrat.Controls.Add(this.label4);
            this.grbAsignarContrat.Controls.Add(this.comboBox2);
            this.grbAsignarContrat.Controls.Add(this.label3);
            this.grbAsignarContrat.Location = new System.Drawing.Point(337, 12);
            this.grbAsignarContrat.Name = "grbAsignarContrat";
            this.grbAsignarContrat.Size = new System.Drawing.Size(249, 153);
            this.grbAsignarContrat.TabIndex = 1;
            this.grbAsignarContrat.TabStop = false;
            this.grbAsignarContrat.Text = "AsingnarContrato";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "NombreCliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "NumeroCliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(173, 124);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NroCliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "FechaHasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Contrato,
            this.nro_telefono,
            this.fecha_desde,
            this.fecha_hasta,
            this.id_servicio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(574, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // id_Contrato
            // 
            this.id_Contrato.DataPropertyName = "id_servicios_contratados";
            this.id_Contrato.HeaderText = "id_Contrato";
            this.id_Contrato.Name = "id_Contrato";
            // 
            // nro_telefono
            // 
            this.nro_telefono.DataPropertyName = "nro_telefono";
            this.nro_telefono.HeaderText = "nro_telefono";
            this.nro_telefono.Name = "nro_telefono";
            // 
            // fecha_desde
            // 
            this.fecha_desde.DataPropertyName = "fecha_desde";
            this.fecha_desde.HeaderText = "fecha_desde";
            this.fecha_desde.Name = "fecha_desde";
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.DataPropertyName = "fecha_hasta";
            this.fecha_hasta.HeaderText = "fecha_hasta";
            this.fecha_hasta.Name = "fecha_hasta";
            // 
            // id_servicio
            // 
            this.id_servicio.DataPropertyName = "id_servicio";
            this.id_servicio.HeaderText = "id_servicio";
            this.id_servicio.Name = "id_servicio";
            // 
            // frmAltaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbAsignarContrat);
            this.Controls.Add(this.grbSelectTelefono);
            this.Name = "frmAltaContrato";
            this.Text = "frmAltaContrato";
            this.grbSelectTelefono.ResumeLayout(false);
            this.grbSelectTelefono.PerformLayout();
            this.grbAsignarContrat.ResumeLayout(false);
            this.grbAsignarContrat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbSelectTelefono;
        private Button btnAsignar;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox grbAsignarContrat;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_Contrato;
        private DataGridViewTextBoxColumn nro_telefono;
        private DataGridViewTextBoxColumn fecha_desde;
        private DataGridViewTextBoxColumn fecha_hasta;
        private DataGridViewTextBoxColumn id_servicio;
    }
}
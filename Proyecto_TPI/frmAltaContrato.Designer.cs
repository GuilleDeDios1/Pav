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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbAsignarContrat = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.grbSelectTelefono.Location = new System.Drawing.Point(17, 20);
            this.grbSelectTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbSelectTelefono.Name = "grbSelectTelefono";
            this.grbSelectTelefono.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbSelectTelefono.Size = new System.Drawing.Size(363, 255);
            this.grbSelectTelefono.TabIndex = 0;
            this.grbSelectTelefono.TabStop = false;
            this.grbSelectTelefono.Text = "AsignarTelefono";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(247, 207);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(107, 38);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NumeroCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "NombreCliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 33);
            this.comboBox1.TabIndex = 0;
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
            this.grbAsignarContrat.Location = new System.Drawing.Point(481, 20);
            this.grbAsignarContrat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAsignarContrat.Name = "grbAsignarContrat";
            this.grbAsignarContrat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAsignarContrat.Size = new System.Drawing.Size(356, 255);
            this.grbAsignarContrat.TabIndex = 1;
            this.grbAsignarContrat.TabStop = false;
            this.grbAsignarContrat.Text = "AsingnarContrato";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 85);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 31);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "FechaHasta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 133);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 31);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "NroCliente";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(139, 37);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 33);
            this.comboBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servicios";
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
            this.dataGridView1.Location = new System.Drawing.Point(17, 330);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(820, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // id_Contrato
            // 
            this.id_Contrato.DataPropertyName = "id_servicios_contratados";
            this.id_Contrato.HeaderText = "id_Contrato";
            this.id_Contrato.MinimumWidth = 8;
            this.id_Contrato.Name = "id_Contrato";
            this.id_Contrato.Width = 150;
            // 
            // nro_telefono
            // 
            this.nro_telefono.DataPropertyName = "nro_telefono";
            this.nro_telefono.HeaderText = "nro_telefono";
            this.nro_telefono.MinimumWidth = 8;
            this.nro_telefono.Name = "nro_telefono";
            this.nro_telefono.Width = 150;
            // 
            // fecha_desde
            // 
            this.fecha_desde.DataPropertyName = "fecha_desde";
            this.fecha_desde.HeaderText = "fecha_desde";
            this.fecha_desde.MinimumWidth = 8;
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Width = 150;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.DataPropertyName = "fecha_hasta";
            this.fecha_hasta.HeaderText = "fecha_hasta";
            this.fecha_hasta.MinimumWidth = 8;
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Width = 150;
            // 
            // id_servicio
            // 
            this.id_servicio.DataPropertyName = "id_servicio";
            this.id_servicio.HeaderText = "id_servicio";
            this.id_servicio.MinimumWidth = 8;
            this.id_servicio.Name = "id_servicio";
            this.id_servicio.Width = 150;
            // 
            // frmAltaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbAsignarContrat);
            this.Controls.Add(this.grbSelectTelefono);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
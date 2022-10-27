namespace Proyecto_TPI
{
    partial class AltaCliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.barriolbl = new System.Windows.Forms.Label();
            this.txtNrocalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNrocliente = new System.Windows.Forms.MaskedTextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(69, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 41);
            this.label4.TabIndex = 27;
            this.label4.Text = "Alta de nuevo cliente";
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Location = new System.Drawing.Point(184, 408);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(85, 29);
            this.chkactivo.TabIndex = 42;
            this.chkactivo.Text = "activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // txtbarrio
            // 
            this.txtbarrio.Location = new System.Drawing.Point(184, 302);
            this.txtbarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(271, 31);
            this.txtbarrio.TabIndex = 41;
            // 
            // barriolbl
            // 
            this.barriolbl.AutoSize = true;
            this.barriolbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barriolbl.Location = new System.Drawing.Point(96, 303);
            this.barriolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barriolbl.Name = "barriolbl";
            this.barriolbl.Size = new System.Drawing.Size(82, 30);
            this.barriolbl.TabIndex = 40;
            this.barriolbl.Text = "Barrio:";
            // 
            // txtNrocalle
            // 
            this.txtNrocalle.Location = new System.Drawing.Point(184, 250);
            this.txtNrocalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrocalle.Name = "txtNrocalle";
            this.txtNrocalle.Size = new System.Drawing.Size(271, 31);
            this.txtNrocalle.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nro. de calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(184, 199);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(271, 31);
            this.txtCalle.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "Calle:";
            // 
            // txtNrocliente
            // 
            this.txtNrocliente.Location = new System.Drawing.Point(184, 147);
            this.txtNrocliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrocliente.Mask = "99999999";
            this.txtNrocliente.Name = "txtNrocliente";
            this.txtNrocliente.Size = new System.Drawing.Size(271, 31);
            this.txtNrocliente.TabIndex = 35;
            this.txtNrocliente.ValidatingType = typeof(int);
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroDoc.Location = new System.Drawing.Point(8, 150);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(174, 30);
            this.lblNroDoc.TabIndex = 34;
            this.lblNroDoc.Text = "numero cliente:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(74, 148);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 30);
            this.lblApellido.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 31);
            this.txtNombre.TabIndex = 31;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(74, 100);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 30);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(184, 354);
            this.txtlocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(271, 31);
            this.txtlocalidad.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "localidad:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(122, 465);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(112, 80);
            this.btncancelar.TabIndex = 45;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(375, 465);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(112, 80);
            this.btnguardar.TabIndex = 46;
            this.btnguardar.Text = "guardar persona";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 569);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkactivo);
            this.Controls.Add(this.txtbarrio);
            this.Controls.Add(this.barriolbl);
            this.Controls.Add(this.txtNrocalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNrocliente);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private CheckBox chkactivo;
        private TextBox txtbarrio;
        private Label barriolbl;
        private TextBox txtNrocalle;
        private Label label2;
        private TextBox txtCalle;
        private Label label3;
        private MaskedTextBox txtNrocliente;
        private Label lblNroDoc;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtlocalidad;
        private Label label1;
        private Button btncancelar;
        private Button btnguardar;
    }
}
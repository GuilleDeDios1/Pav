namespace Proyecto_TPI
{
    partial class frmConsultaServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaServicio));
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.Codigo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Mensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldescr_serv = new System.Windows.Forms.Label();
            this.lblcost_mens = new System.Windows.Forms.Label();
            this.lbldesde = new System.Windows.Forms.Label();
            this.lblhasta = new System.Windows.Forms.Label();
            this.grbconsulserv = new System.Windows.Forms.GroupBox();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btm_limpiarDatos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.MaskedTextBox();
            this.txtdesc = new System.Windows.Forms.MaskedTextBox();
            this.txtdesde = new System.Windows.Forms.MaskedTextBox();
            this.txthasta = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
            this.grbconsulserv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Servicio,
            this.Nombre,
            this.Descripcion,
            this.Costo_Mensual});
            this.dgv_servicios.Location = new System.Drawing.Point(12, 1);
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.RowTemplate.Height = 25;
            this.dgv_servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servicios.Size = new System.Drawing.Size(446, 171);
            this.dgv_servicios.TabIndex = 0;
            // 
            // Codigo_Servicio
            // 
            this.Codigo_Servicio.DataPropertyName = "cod_servicio";
            this.Codigo_Servicio.HeaderText = "Codigo_Servicio";
            this.Codigo_Servicio.Name = "Codigo_Servicio";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Costo_Mensual
            // 
            this.Costo_Mensual.DataPropertyName = "costo_mensual";
            this.Costo_Mensual.HeaderText = "Costo_Mensual";
            this.Costo_Mensual.Name = "Costo_Mensual";
            // 
            // lbldescr_serv
            // 
            this.lbldescr_serv.AutoSize = true;
            this.lbldescr_serv.Location = new System.Drawing.Point(6, 60);
            this.lbldescr_serv.Name = "lbldescr_serv";
            this.lbldescr_serv.Size = new System.Drawing.Size(68, 15);
            this.lbldescr_serv.TabIndex = 2;
            this.lbldescr_serv.Text = "Descipcion:";
            // 
            // lblcost_mens
            // 
            this.lblcost_mens.AutoSize = true;
            this.lblcost_mens.Location = new System.Drawing.Point(0, 104);
            this.lblcost_mens.Name = "lblcost_mens";
            this.lblcost_mens.Size = new System.Drawing.Size(86, 15);
            this.lblcost_mens.TabIndex = 3;
            this.lblcost_mens.Text = "Costo mensual";
            // 
            // lbldesde
            // 
            this.lbldesde.AutoSize = true;
            this.lbldesde.Location = new System.Drawing.Point(104, 83);
            this.lbldesde.Name = "lbldesde";
            this.lbldesde.Size = new System.Drawing.Size(39, 15);
            this.lbldesde.TabIndex = 8;
            this.lbldesde.Text = "Desde";
            // 
            // lblhasta
            // 
            this.lblhasta.AutoSize = true;
            this.lblhasta.Location = new System.Drawing.Point(154, 83);
            this.lblhasta.Name = "lblhasta";
            this.lblhasta.Size = new System.Drawing.Size(37, 15);
            this.lblhasta.TabIndex = 9;
            this.lblhasta.Text = "Hasta";
            // 
            // grbconsulserv
            // 
            this.grbconsulserv.Controls.Add(this.txthasta);
            this.grbconsulserv.Controls.Add(this.txtdesde);
            this.grbconsulserv.Controls.Add(this.txtdesc);
            this.grbconsulserv.Controls.Add(this.txtnombre);
            this.grbconsulserv.Controls.Add(this.checkActivo);
            this.grbconsulserv.Controls.Add(this.label1);
            this.grbconsulserv.Controls.Add(this.lblhasta);
            this.grbconsulserv.Controls.Add(this.lbldescr_serv);
            this.grbconsulserv.Controls.Add(this.lbldesde);
            this.grbconsulserv.Controls.Add(this.lblcost_mens);
            this.grbconsulserv.Location = new System.Drawing.Point(26, 178);
            this.grbconsulserv.Name = "grbconsulserv";
            this.grbconsulserv.Size = new System.Drawing.Size(409, 149);
            this.grbconsulserv.TabIndex = 10;
            this.grbconsulserv.TabStop = false;
            this.grbconsulserv.Text = "datos servicios";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Checked = true;
            this.checkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivo.Location = new System.Drawing.Point(317, 22);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(60, 19);
            this.checkActivo.TabIndex = 12;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(131, 333);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 40);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btm_limpiarDatos
            // 
            this.btm_limpiarDatos.Location = new System.Drawing.Point(32, 333);
            this.btm_limpiarDatos.Name = "btm_limpiarDatos";
            this.btm_limpiarDatos.Size = new System.Drawing.Size(79, 40);
            this.btm_limpiarDatos.TabIndex = 12;
            this.btm_limpiarDatos.Text = "Limpiar Datos";
            this.btm_limpiarDatos.UseVisualStyleBackColor = true;
            this.btm_limpiarDatos.Click += new System.EventHandler(this.btm_limpiarDatos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(229, 335);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 36);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(328, 335);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 34);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(93, 26);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 13;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(93, 55);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(280, 23);
            this.txtdesc.TabIndex = 14;
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(105, 101);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(29, 23);
            this.txtdesde.TabIndex = 15;
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(154, 101);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(33, 23);
            this.txthasta.TabIndex = 16;
            // 
            // frmConsultaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 406);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btm_limpiarDatos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grbconsulserv);
            this.Controls.Add(this.dgv_servicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaServicio";
            this.Load += new System.EventHandler(this.frmAltaServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.grbconsulserv.ResumeLayout(false);
            this.grbconsulserv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_servicios;
        private Label lbldescr_serv;
        private Label lblcost_mens;
        private Label lbldesde;
        private Label lblhasta;
        private GroupBox grbconsulserv;
        private Button btnActualizar;
        private Button btm_limpiarDatos;
        private Button btnEditar;
        private Label label1;
        private DataGridViewTextBoxColumn Codigo_Servicio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Costo_Mensual;
        private Button btnBorrar;
        private CheckBox checkActivo;
        private MaskedTextBox txthasta;
        private MaskedTextBox txtdesde;
        private MaskedTextBox txtdesc;
        private MaskedTextBox txtnombre;
    }
}
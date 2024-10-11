namespace ProyectoENE
{
    partial class ListarTrabajadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_trabajador = new System.Windows.Forms.ComboBox();
            this.dgv_trabajador = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajador";
            // 
            // cmb_trabajador
            // 
            this.cmb_trabajador.FormattingEnabled = true;
            this.cmb_trabajador.Location = new System.Drawing.Point(306, 73);
            this.cmb_trabajador.Name = "cmb_trabajador";
            this.cmb_trabajador.Size = new System.Drawing.Size(198, 21);
            this.cmb_trabajador.TabIndex = 1;
            this.cmb_trabajador.SelectedIndexChanged += new System.EventHandler(this.cmb_trabajador_SelectedIndexChanged);
            // 
            // dgv_trabajador
            // 
            this.dgv_trabajador.AllowUserToAddRows = false;
            this.dgv_trabajador.AllowUserToDeleteRows = false;
            this.dgv_trabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.Rut,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.SueldoLiquido});
            this.dgv_trabajador.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_trabajador.Location = new System.Drawing.Point(12, 115);
            this.dgv_trabajador.Name = "dgv_trabajador";
            this.dgv_trabajador.Size = new System.Drawing.Size(681, 223);
            this.dgv_trabajador.TabIndex = 2;
            this.dgv_trabajador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trabajador_CellContentClick);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(541, 372);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(135, 50);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(191, 372);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 50);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_volver.Location = new System.Drawing.Point(12, 372);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(135, 50);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Cerrar";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "ID";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Visible = false;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.MaxInputLength = 12;
            this.Rut.Name = "Rut";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 100;
            this.Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MaxInputLength = 200;
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // SueldoLiquido
            // 
            this.SueldoLiquido.HeaderText = "Sueldo Liquido";
            this.SueldoLiquido.MaxInputLength = 18;
            this.SueldoLiquido.Name = "SueldoLiquido";
            this.SueldoLiquido.ReadOnly = true;
            // 
            // ListarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 465);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_trabajador);
            this.Controls.Add(this.cmb_trabajador);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListarTrabajadores";
            this.Text = "Listar Trabajadores";
            this.Load += new System.EventHandler(this.ListarTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trabajador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_trabajador;
        private System.Windows.Forms.DataGridView dgv_trabajador;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoLiquido;
    }
}
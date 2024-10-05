namespace InterfazGrafica
{
    partial class Acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.lbl_errores = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lnk_revisar = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcion4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(95, 58);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(189, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "ACCESO CRM AIEP";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(63, 132);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(49, 14);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.Location = new System.Drawing.Point(75, 195);
            this.lbl_clave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(37, 14);
            this.lbl_clave.TabIndex = 2;
            this.lbl_clave.Text = "Clave";
            // 
            // lbl_errores
            // 
            this.lbl_errores.AutoSize = true;
            this.lbl_errores.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errores.Location = new System.Drawing.Point(96, 321);
            this.lbl_errores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_errores.Name = "lbl_errores";
            this.lbl_errores.Size = new System.Drawing.Size(16, 14);
            this.lbl_errores.TabIndex = 3;
            this.lbl_errores.Text = "...";
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(131, 132);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(154, 22);
            this.txb_usuario.TabIndex = 1;
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(131, 192);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.Size = new System.Drawing.Size(154, 22);
            this.txb_clave.TabIndex = 2;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(210, 262);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // lnk_revisar
            // 
            this.lnk_revisar.AutoSize = true;
            this.lnk_revisar.Location = new System.Drawing.Point(265, 500);
            this.lnk_revisar.Name = "lnk_revisar";
            this.lnk_revisar.Size = new System.Drawing.Size(87, 14);
            this.lnk_revisar.TabIndex = 4;
            this.lnk_revisar.TabStop = true;
            this.lnk_revisar.Text = "Revisar acceso";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.opcion2ToolStripMenuItem,
            this.opcion3ToolStripMenuItem,
            this.opcion4ToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.menu1ToolStripMenuItem.Text = "Menu1";
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu1ToolStripMenuItem,
            this.submenu2ToolStripMenuItem});
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion1ToolStripMenuItem.Text = "Opcion 1";
            // 
            // opcion2ToolStripMenuItem
            // 
            this.opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            this.opcion2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion2ToolStripMenuItem.Text = "Opcion 2";
            // 
            // opcion3ToolStripMenuItem
            // 
            this.opcion3ToolStripMenuItem.Name = "opcion3ToolStripMenuItem";
            this.opcion3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion3ToolStripMenuItem.Text = "Opcion 3";
            // 
            // opcion4ToolStripMenuItem
            // 
            this.opcion4ToolStripMenuItem.Name = "opcion4ToolStripMenuItem";
            this.opcion4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcion4ToolStripMenuItem.Text = "Opcion 4";
            // 
            // submenu1ToolStripMenuItem
            // 
            this.submenu1ToolStripMenuItem.Name = "submenu1ToolStripMenuItem";
            this.submenu1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.submenu1ToolStripMenuItem.Text = "Submenu1";
            // 
            // submenu2ToolStripMenuItem
            // 
            this.submenu2ToolStripMenuItem.Name = "submenu2ToolStripMenuItem";
            this.submenu2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.submenu2ToolStripMenuItem.Text = "Submenu2";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.lnk_revisar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.lbl_errores);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Acceso";
            this.Text = "Acceso";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Label lbl_errores;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.LinkLabel lnk_revisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcion4ToolStripMenuItem;
    }
}


namespace Primos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.rb_6 = new System.Windows.Forms.RadioButton();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_principal
            // 
            this.dgv_principal.AllowUserToAddRows = false;
            this.dgv_principal.AllowUserToDeleteRows = false;
            this.dgv_principal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_principal.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_principal.Location = new System.Drawing.Point(13, 317);
            this.dgv_principal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.Size = new System.Drawing.Size(794, 236);
            this.dgv_principal.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(31, 27);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(346, 33);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Análisis Números Primos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la opción del rango para comenzar el proceso:";
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(37, 99);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(59, 18);
            this.rb_1.TabIndex = 3;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "1 a 99";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(37, 123);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(80, 18);
            this.rb_2.TabIndex = 4;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "100 a 999";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(37, 147);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(94, 18);
            this.rb_3.TabIndex = 5;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "1000 a 9999";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(37, 171);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(108, 18);
            this.rb_4.TabIndex = 6;
            this.rb_4.TabStop = true;
            this.rb_4.Text = "10000 a 99999";
            this.rb_4.UseVisualStyleBackColor = true;
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(37, 195);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(129, 18);
            this.rb_5.TabIndex = 7;
            this.rb_5.TabStop = true;
            this.rb_5.Text = "1000000 a 999999";
            this.rb_5.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(37, 264);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(135, 23);
            this.btn_iniciar.TabIndex = 9;
            this.btn_iniciar.Text = "Iniciar proceso";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // rb_6
            // 
            this.rb_6.AutoSize = true;
            this.rb_6.Location = new System.Drawing.Point(37, 219);
            this.rb_6.Name = "rb_6";
            this.rb_6.Size = new System.Drawing.Size(143, 18);
            this.rb_6.TabIndex = 8;
            this.rb_6.TabStop = true;
            this.rb_6.Text = "10000000 a 1999999";
            this.rb_6.UseVisualStyleBackColor = true;
            // 
            // picBox1
            // 
            this.picBox1.Image = global::Primos.Properties.Resources.loading_waiting;
            this.picBox1.Location = new System.Drawing.Point(367, 147);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(100, 100);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 10;
            this.picBox1.TabStop = false;
            this.picBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primos.Properties.Resources.Z5cP;
            this.pictureBox1.Location = new System.Drawing.Point(727, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.rb_6);
            this.Controls.Add(this.rb_5);
            this.Controls.Add(this.rb_4);
            this.Controls.Add(this.rb_3);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgv_principal);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "AIEP";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.RadioButton rb_6;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


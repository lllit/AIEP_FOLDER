namespace parPerfectoPrimo
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
            this.lbl_ejercicio = new System.Windows.Forms.Label();
            this.lbl_ingrese_num = new System.Windows.Forms.Label();
            this.tbx_numero = new System.Windows.Forms.TextBox();
            this.btn_evaluar = new System.Windows.Forms.Button();
            this.lbl_errores = new System.Windows.Forms.Label();
            this.lbl_par = new System.Windows.Forms.Label();
            this.lbl_perfecto = new System.Windows.Forms.Label();
            this.lbl_primo = new System.Windows.Forms.Label();
            this.lbl_res_par = new System.Windows.Forms.Label();
            this.lbl_res_perfecto = new System.Windows.Forms.Label();
            this.lbl_res_primo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ejercicio
            // 
            this.lbl_ejercicio.AutoSize = true;
            this.lbl_ejercicio.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ejercicio.Location = new System.Drawing.Point(91, 66);
            this.lbl_ejercicio.Name = "lbl_ejercicio";
            this.lbl_ejercicio.Size = new System.Drawing.Size(219, 38);
            this.lbl_ejercicio.TabIndex = 0;
            this.lbl_ejercicio.Text = "EJERCICIOS 1";
            // 
            // lbl_ingrese_num
            // 
            this.lbl_ingrese_num.AutoSize = true;
            this.lbl_ingrese_num.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingrese_num.Location = new System.Drawing.Point(95, 149);
            this.lbl_ingrese_num.Name = "lbl_ingrese_num";
            this.lbl_ingrese_num.Size = new System.Drawing.Size(225, 18);
            this.lbl_ingrese_num.TabIndex = 1;
            this.lbl_ingrese_num.Text = "INGRESE UN NÚMERO ENTERO:";
            // 
            // tbx_numero
            // 
            this.tbx_numero.Location = new System.Drawing.Point(346, 146);
            this.tbx_numero.Name = "tbx_numero";
            this.tbx_numero.Size = new System.Drawing.Size(177, 21);
            this.tbx_numero.TabIndex = 2;
            // 
            // btn_evaluar
            // 
            this.btn_evaluar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_evaluar.Location = new System.Drawing.Point(561, 144);
            this.btn_evaluar.Name = "btn_evaluar";
            this.btn_evaluar.Size = new System.Drawing.Size(75, 23);
            this.btn_evaluar.TabIndex = 3;
            this.btn_evaluar.Text = "Evaluar";
            this.btn_evaluar.UseVisualStyleBackColor = true;
            this.btn_evaluar.Click += new System.EventHandler(this.btn_evaluar_Click);
            // 
            // lbl_errores
            // 
            this.lbl_errores.AutoSize = true;
            this.lbl_errores.Location = new System.Drawing.Point(668, 153);
            this.lbl_errores.Name = "lbl_errores";
            this.lbl_errores.Size = new System.Drawing.Size(16, 13);
            this.lbl_errores.TabIndex = 4;
            this.lbl_errores.Text = "...";
            // 
            // lbl_par
            // 
            this.lbl_par.AutoSize = true;
            this.lbl_par.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_par.Location = new System.Drawing.Point(274, 221);
            this.lbl_par.Name = "lbl_par";
            this.lbl_par.Size = new System.Drawing.Size(36, 15);
            this.lbl_par.TabIndex = 5;
            this.lbl_par.Text = "PAR?";
            // 
            // lbl_perfecto
            // 
            this.lbl_perfecto.AutoSize = true;
            this.lbl_perfecto.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfecto.Location = new System.Drawing.Point(235, 249);
            this.lbl_perfecto.Name = "lbl_perfecto";
            this.lbl_perfecto.Size = new System.Drawing.Size(75, 15);
            this.lbl_perfecto.TabIndex = 6;
            this.lbl_perfecto.Text = "PERFECTO?";
            // 
            // lbl_primo
            // 
            this.lbl_primo.AutoSize = true;
            this.lbl_primo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primo.Location = new System.Drawing.Point(257, 286);
            this.lbl_primo.Name = "lbl_primo";
            this.lbl_primo.Size = new System.Drawing.Size(53, 15);
            this.lbl_primo.TabIndex = 7;
            this.lbl_primo.Text = "PRIMO?";
            // 
            // lbl_res_par
            // 
            this.lbl_res_par.AutoSize = true;
            this.lbl_res_par.Location = new System.Drawing.Point(343, 223);
            this.lbl_res_par.Name = "lbl_res_par";
            this.lbl_res_par.Size = new System.Drawing.Size(16, 13);
            this.lbl_res_par.TabIndex = 8;
            this.lbl_res_par.Text = "...";
            // 
            // lbl_res_perfecto
            // 
            this.lbl_res_perfecto.AutoSize = true;
            this.lbl_res_perfecto.Location = new System.Drawing.Point(343, 251);
            this.lbl_res_perfecto.Name = "lbl_res_perfecto";
            this.lbl_res_perfecto.Size = new System.Drawing.Size(16, 13);
            this.lbl_res_perfecto.TabIndex = 9;
            this.lbl_res_perfecto.Text = "...";
            // 
            // lbl_res_primo
            // 
            this.lbl_res_primo.AutoSize = true;
            this.lbl_res_primo.Location = new System.Drawing.Point(343, 288);
            this.lbl_res_primo.Name = "lbl_res_primo";
            this.lbl_res_primo.Size = new System.Drawing.Size(16, 13);
            this.lbl_res_primo.TabIndex = 10;
            this.lbl_res_primo.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(818, 419);
            this.Controls.Add(this.lbl_res_primo);
            this.Controls.Add(this.lbl_res_perfecto);
            this.Controls.Add(this.lbl_res_par);
            this.Controls.Add(this.lbl_primo);
            this.Controls.Add(this.lbl_perfecto);
            this.Controls.Add(this.lbl_par);
            this.Controls.Add(this.lbl_errores);
            this.Controls.Add(this.btn_evaluar);
            this.Controls.Add(this.tbx_numero);
            this.Controls.Add(this.lbl_ingrese_num);
            this.Controls.Add(this.lbl_ejercicio);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AIEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ejercicio;
        private System.Windows.Forms.Label lbl_ingrese_num;
        private System.Windows.Forms.TextBox tbx_numero;
        private System.Windows.Forms.Button btn_evaluar;
        private System.Windows.Forms.Label lbl_errores;
        private System.Windows.Forms.Label lbl_par;
        private System.Windows.Forms.Label lbl_perfecto;
        private System.Windows.Forms.Label lbl_primo;
        private System.Windows.Forms.Label lbl_res_par;
        private System.Windows.Forms.Label lbl_res_perfecto;
        private System.Windows.Forms.Label lbl_res_primo;
    }
}


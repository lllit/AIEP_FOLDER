namespace InterfazGrafica
{
    partial class validarErrorProvider
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_valor = new System.Windows.Forms.TextBox();
            this.btn_validar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese valor";
            // 
            // tbox_valor
            // 
            this.tbox_valor.Location = new System.Drawing.Point(160, 76);
            this.tbox_valor.Name = "tbox_valor";
            this.tbox_valor.Size = new System.Drawing.Size(100, 20);
            this.tbox_valor.TabIndex = 1;
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(293, 73);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 23);
            this.btn_validar.TabIndex = 2;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = true;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // validarErrorProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 225);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.tbox_valor);
            this.Controls.Add(this.label1);
            this.Name = "validarErrorProvider";
            this.Text = "validarErrorProvider";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_valor;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
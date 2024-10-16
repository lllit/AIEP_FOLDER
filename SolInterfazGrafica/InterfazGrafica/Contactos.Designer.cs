﻿namespace InterfazGrafica
{
    partial class Contactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contactos));
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.cmb_ciudad = new System.Windows.Forms.ComboBox();
            this.cmb_comuna = new System.Windows.Forms.ComboBox();
            this.cmb_personalidad = new System.Windows.Forms.ComboBox();
            this.rbtn_viudo = new System.Windows.Forms.RadioButton();
            this.rbtn_casado = new System.Windows.Forms.RadioButton();
            this.rbtn_soltero = new System.Windows.Forms.RadioButton();
            this.tbox_ciudad = new System.Windows.Forms.TextBox();
            this.tbox_telefono = new System.Windows.Forms.TextBox();
            this.tbox_correo = new System.Windows.Forms.TextBox();
            this.tbox_apellidos = new System.Windows.Forms.TextBox();
            this.tbox_nombres = new System.Windows.Forms.TextBox();
            this.tbox_descripcion = new System.Windows.Forms.TextBox();
            this.tbox_rut = new System.Windows.Forms.TextBox();
            this.lbl_comuna = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_estadocivil = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_apelldos = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.lbl_personalidad = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(332, 490);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(93, 35);
            this.btn_ingresar.TabIndex = 15;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(186, 490);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(93, 35);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(448, 67);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 16;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // cmb_ciudad
            // 
            this.cmb_ciudad.FormattingEnabled = true;
            this.cmb_ciudad.Location = new System.Drawing.Point(186, 421);
            this.cmb_ciudad.Name = "cmb_ciudad";
            this.cmb_ciudad.Size = new System.Drawing.Size(171, 21);
            this.cmb_ciudad.TabIndex = 13;
            // 
            // cmb_comuna
            // 
            this.cmb_comuna.FormattingEnabled = true;
            this.cmb_comuna.Location = new System.Drawing.Point(186, 390);
            this.cmb_comuna.Name = "cmb_comuna";
            this.cmb_comuna.Size = new System.Drawing.Size(171, 21);
            this.cmb_comuna.TabIndex = 12;
            // 
            // cmb_personalidad
            // 
            this.cmb_personalidad.FormattingEnabled = true;
            this.cmb_personalidad.Location = new System.Drawing.Point(186, 153);
            this.cmb_personalidad.Name = "cmb_personalidad";
            this.cmb_personalidad.Size = new System.Drawing.Size(171, 21);
            this.cmb_personalidad.TabIndex = 2;
            // 
            // rbtn_viudo
            // 
            this.rbtn_viudo.AutoSize = true;
            this.rbtn_viudo.Location = new System.Drawing.Point(375, 330);
            this.rbtn_viudo.Name = "rbtn_viudo";
            this.rbtn_viudo.Size = new System.Drawing.Size(67, 17);
            this.rbtn_viudo.TabIndex = 10;
            this.rbtn_viudo.TabStop = true;
            this.rbtn_viudo.Text = "Viudo(a)";
            this.rbtn_viudo.UseVisualStyleBackColor = true;
            // 
            // rbtn_casado
            // 
            this.rbtn_casado.AutoSize = true;
            this.rbtn_casado.Location = new System.Drawing.Point(280, 330);
            this.rbtn_casado.Name = "rbtn_casado";
            this.rbtn_casado.Size = new System.Drawing.Size(76, 17);
            this.rbtn_casado.TabIndex = 9;
            this.rbtn_casado.TabStop = true;
            this.rbtn_casado.Text = "Casado(a)";
            this.rbtn_casado.UseVisualStyleBackColor = true;
            // 
            // rbtn_soltero
            // 
            this.rbtn_soltero.AutoSize = true;
            this.rbtn_soltero.Location = new System.Drawing.Point(186, 330);
            this.rbtn_soltero.Name = "rbtn_soltero";
            this.rbtn_soltero.Size = new System.Drawing.Size(75, 17);
            this.rbtn_soltero.TabIndex = 8;
            this.rbtn_soltero.TabStop = true;
            this.rbtn_soltero.Text = "Soltero(a)";
            this.rbtn_soltero.UseVisualStyleBackColor = true;
            // 
            // tbox_ciudad
            // 
            this.tbox_ciudad.Location = new System.Drawing.Point(186, 359);
            this.tbox_ciudad.Name = "tbox_ciudad";
            this.tbox_ciudad.Size = new System.Drawing.Size(239, 21);
            this.tbox_ciudad.TabIndex = 11;
            // 
            // tbox_telefono
            // 
            this.tbox_telefono.Location = new System.Drawing.Point(186, 298);
            this.tbox_telefono.Name = "tbox_telefono";
            this.tbox_telefono.Size = new System.Drawing.Size(133, 21);
            this.tbox_telefono.TabIndex = 7;
            // 
            // tbox_correo
            // 
            this.tbox_correo.Location = new System.Drawing.Point(186, 269);
            this.tbox_correo.Name = "tbox_correo";
            this.tbox_correo.Size = new System.Drawing.Size(239, 21);
            this.tbox_correo.TabIndex = 6;
            // 
            // tbox_apellidos
            // 
            this.tbox_apellidos.Location = new System.Drawing.Point(186, 240);
            this.tbox_apellidos.Name = "tbox_apellidos";
            this.tbox_apellidos.Size = new System.Drawing.Size(239, 21);
            this.tbox_apellidos.TabIndex = 5;
            // 
            // tbox_nombres
            // 
            this.tbox_nombres.Location = new System.Drawing.Point(186, 211);
            this.tbox_nombres.Name = "tbox_nombres";
            this.tbox_nombres.Size = new System.Drawing.Size(239, 21);
            this.tbox_nombres.TabIndex = 4;
            // 
            // tbox_descripcion
            // 
            this.tbox_descripcion.Location = new System.Drawing.Point(186, 182);
            this.tbox_descripcion.Name = "tbox_descripcion";
            this.tbox_descripcion.Size = new System.Drawing.Size(239, 21);
            this.tbox_descripcion.TabIndex = 3;
            // 
            // tbox_rut
            // 
            this.tbox_rut.Location = new System.Drawing.Point(186, 124);
            this.tbox_rut.Name = "tbox_rut";
            this.tbox_rut.Size = new System.Drawing.Size(133, 21);
            this.tbox_rut.TabIndex = 1;
            // 
            // lbl_comuna
            // 
            this.lbl_comuna.AutoSize = true;
            this.lbl_comuna.Location = new System.Drawing.Point(116, 393);
            this.lbl_comuna.Name = "lbl_comuna";
            this.lbl_comuna.Size = new System.Drawing.Size(48, 13);
            this.lbl_comuna.TabIndex = 38;
            this.lbl_comuna.Text = "Comuna";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(123, 424);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(41, 13);
            this.lbl_ciudad.TabIndex = 37;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(110, 362);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(54, 13);
            this.lbl_domicilio.TabIndex = 36;
            this.lbl_domicilio.Text = "Domicilio";
            // 
            // lbl_estadocivil
            // 
            this.lbl_estadocivil.AutoSize = true;
            this.lbl_estadocivil.Location = new System.Drawing.Point(99, 332);
            this.lbl_estadocivil.Name = "lbl_estadocivil";
            this.lbl_estadocivil.Size = new System.Drawing.Size(65, 13);
            this.lbl_estadocivil.TabIndex = 35;
            this.lbl_estadocivil.Text = "Estado Civil";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(114, 301);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(50, 13);
            this.lbl_telefono.TabIndex = 34;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(124, 272);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(40, 13);
            this.lbl_correo.TabIndex = 33;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_apelldos
            // 
            this.lbl_apelldos.AutoSize = true;
            this.lbl_apelldos.Location = new System.Drawing.Point(111, 243);
            this.lbl_apelldos.Name = "lbl_apelldos";
            this.lbl_apelldos.Size = new System.Drawing.Size(53, 13);
            this.lbl_apelldos.TabIndex = 32;
            this.lbl_apelldos.Text = "Apellidos";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(111, 214);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(53, 13);
            this.lbl_nombres.TabIndex = 31;
            this.lbl_nombres.Text = "Nombres";
            // 
            // lbl_personalidad
            // 
            this.lbl_personalidad.AutoSize = true;
            this.lbl_personalidad.Location = new System.Drawing.Point(92, 156);
            this.lbl_personalidad.Name = "lbl_personalidad";
            this.lbl_personalidad.Size = new System.Drawing.Size(72, 13);
            this.lbl_personalidad.TabIndex = 30;
            this.lbl_personalidad.Text = "Personalidad";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(98, 185);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 29;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(140, 127);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(24, 13);
            this.lbl_rut.TabIndex = 28;
            this.lbl_rut.Text = "Rut";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(98, 67);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(90, 19);
            this.lbl_titulo.TabIndex = 27;
            this.lbl_titulo.Text = "Contactos";
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.cmb_ciudad);
            this.Controls.Add(this.cmb_comuna);
            this.Controls.Add(this.cmb_personalidad);
            this.Controls.Add(this.rbtn_viudo);
            this.Controls.Add(this.rbtn_casado);
            this.Controls.Add(this.rbtn_soltero);
            this.Controls.Add(this.tbox_ciudad);
            this.Controls.Add(this.tbox_telefono);
            this.Controls.Add(this.tbox_correo);
            this.Controls.Add(this.tbox_apellidos);
            this.Controls.Add(this.tbox_nombres);
            this.Controls.Add(this.tbox_descripcion);
            this.Controls.Add(this.tbox_rut);
            this.Controls.Add(this.lbl_comuna);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.lbl_domicilio);
            this.Controls.Add(this.lbl_estadocivil);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_apelldos);
            this.Controls.Add(this.lbl_nombres);
            this.Controls.Add(this.lbl_personalidad);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_rut);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contactos";
            this.Text = "Contactos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ComboBox cmb_ciudad;
        private System.Windows.Forms.ComboBox cmb_comuna;
        private System.Windows.Forms.ComboBox cmb_personalidad;
        private System.Windows.Forms.RadioButton rbtn_viudo;
        private System.Windows.Forms.RadioButton rbtn_casado;
        private System.Windows.Forms.RadioButton rbtn_soltero;
        private System.Windows.Forms.TextBox tbox_ciudad;
        private System.Windows.Forms.TextBox tbox_telefono;
        private System.Windows.Forms.TextBox tbox_correo;
        private System.Windows.Forms.TextBox tbox_apellidos;
        private System.Windows.Forms.TextBox tbox_nombres;
        private System.Windows.Forms.TextBox tbox_descripcion;
        private System.Windows.Forms.TextBox tbox_rut;
        private System.Windows.Forms.Label lbl_comuna;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_estadocivil;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_apelldos;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.Label lbl_personalidad;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_rut;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
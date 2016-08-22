namespace appSueldoEmpleado
{
    partial class frmSueldo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.gbpResultados = new System.Windows.Forms.GroupBox();
            this.lblTotalExtra = new System.Windows.Forms.Label();
            this.lblPagaExtra = new System.Windows.Forms.Label();
            this.lblNormalNeto = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblPagaExtraBruta = new System.Windows.Forms.Label();
            this.lblMesNormalBruto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorDelEuro = new System.Windows.Forms.TextBox();
            this.gbpResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(233, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular sueldo de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(65, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(65, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtNombre.Location = new System.Drawing.Point(486, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 25);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPrimerApellido.Location = new System.Drawing.Point(486, 123);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(147, 25);
            this.txtPrimerApellido.TabIndex = 5;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSegundoApellido.Location = new System.Drawing.Point(486, 162);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(147, 25);
            this.txtSegundoApellido.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnLimpiar.Location = new System.Drawing.Point(68, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnProcesar.Location = new System.Drawing.Point(529, 344);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(100, 33);
            this.btnProcesar.TabIndex = 8;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // gbpResultados
            // 
            this.gbpResultados.Controls.Add(this.lblTotalExtra);
            this.gbpResultados.Controls.Add(this.lblPagaExtra);
            this.gbpResultados.Controls.Add(this.lblNormalNeto);
            this.gbpResultados.Controls.Add(this.lblTotalBruto);
            this.gbpResultados.Controls.Add(this.lblPagaExtraBruta);
            this.gbpResultados.Controls.Add(this.lblMesNormalBruto);
            this.gbpResultados.Controls.Add(this.label10);
            this.gbpResultados.Controls.Add(this.label9);
            this.gbpResultados.Controls.Add(this.label8);
            this.gbpResultados.Controls.Add(this.label7);
            this.gbpResultados.Controls.Add(this.label6);
            this.gbpResultados.Controls.Add(this.lblEmpleado);
            this.gbpResultados.Controls.Add(this.label5);
            this.gbpResultados.Font = new System.Drawing.Font("Verdana", 9F);
            this.gbpResultados.Location = new System.Drawing.Point(68, 397);
            this.gbpResultados.Name = "gbpResultados";
            this.gbpResultados.Size = new System.Drawing.Size(561, 247);
            this.gbpResultados.TabIndex = 9;
            this.gbpResultados.TabStop = false;
            this.gbpResultados.Text = "Resultados:";
            // 
            // lblTotalExtra
            // 
            this.lblTotalExtra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTotalExtra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalExtra.Location = new System.Drawing.Point(391, 183);
            this.lblTotalExtra.Name = "lblTotalExtra";
            this.lblTotalExtra.Size = new System.Drawing.Size(128, 25);
            this.lblTotalExtra.TabIndex = 12;
            // 
            // lblPagaExtra
            // 
            this.lblPagaExtra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPagaExtra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPagaExtra.Location = new System.Drawing.Point(391, 134);
            this.lblPagaExtra.Name = "lblPagaExtra";
            this.lblPagaExtra.Size = new System.Drawing.Size(128, 26);
            this.lblPagaExtra.TabIndex = 11;
            // 
            // lblNormalNeto
            // 
            this.lblNormalNeto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNormalNeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNormalNeto.Location = new System.Drawing.Point(391, 88);
            this.lblNormalNeto.Name = "lblNormalNeto";
            this.lblNormalNeto.Size = new System.Drawing.Size(128, 26);
            this.lblNormalNeto.TabIndex = 10;
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBruto.Location = new System.Drawing.Point(171, 183);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(139, 25);
            this.lblTotalBruto.TabIndex = 9;
            // 
            // lblPagaExtraBruta
            // 
            this.lblPagaExtraBruta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPagaExtraBruta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPagaExtraBruta.Location = new System.Drawing.Point(171, 135);
            this.lblPagaExtraBruta.Name = "lblPagaExtraBruta";
            this.lblPagaExtraBruta.Size = new System.Drawing.Size(139, 27);
            this.lblPagaExtraBruta.TabIndex = 8;
            // 
            // lblMesNormalBruto
            // 
            this.lblMesNormalBruto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblMesNormalBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMesNormalBruto.Location = new System.Drawing.Point(171, 89);
            this.lblMesNormalBruto.Name = "lblMesNormalBruto";
            this.lblMesNormalBruto.Size = new System.Drawing.Size(139, 26);
            this.lblMesNormalBruto.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 14);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sueldo neto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sueldo bruto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Totales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Paga extra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mes normal:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpleado.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblEmpleado.Location = new System.Drawing.Point(168, 18);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(351, 27);
            this.lblEmpleado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F);
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empleado:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnSalir.Location = new System.Drawing.Point(516, 660);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 11F);
            this.label11.Location = new System.Drawing.Point(68, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sueldo base:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 11F);
            this.label12.Location = new System.Drawing.Point(68, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Experiencia:";
            // 
            // txtSueldoBase
            // 
            this.txtSueldoBase.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSueldoBase.Location = new System.Drawing.Point(486, 209);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(147, 25);
            this.txtSueldoBase.TabIndex = 13;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtExperiencia.Location = new System.Drawing.Point(486, 257);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(147, 25);
            this.txtExperiencia.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 11F);
            this.label13.Location = new System.Drawing.Point(68, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Precio del Euro";
            // 
            // txtValorDelEuro
            // 
            this.txtValorDelEuro.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtValorDelEuro.Location = new System.Drawing.Point(486, 305);
            this.txtValorDelEuro.Name = "txtValorDelEuro";
            this.txtValorDelEuro.Size = new System.Drawing.Size(147, 25);
            this.txtValorDelEuro.TabIndex = 16;
            // 
            // frmSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 710);
            this.ControlBox = false;
            this.Controls.Add(this.txtValorDelEuro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtExperiencia);
            this.Controls.Add(this.txtSueldoBase);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpResultados);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmSueldo";
            this.Text = "Sueldo empleado";
            this.Load += new System.EventHandler(this.frmSueldo_Load);
            this.gbpResultados.ResumeLayout(false);
            this.gbpResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox gbpResultados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalExtra;
        private System.Windows.Forms.Label lblPagaExtra;
        private System.Windows.Forms.Label lblNormalNeto;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblPagaExtraBruta;
        private System.Windows.Forms.Label lblMesNormalBruto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSueldoBase;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorDelEuro;
    }
}


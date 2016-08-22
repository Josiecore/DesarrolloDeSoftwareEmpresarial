namespace appSueldoEmpleado
{
    partial class frmSueldoDiario
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
            this.txtHorasDiurnas = new System.Windows.Forms.TextBox();
            this.txtHorasNocturnas = new System.Windows.Forms.TextBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbpSalario = new System.Windows.Forms.GroupBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraNormal = new System.Windows.Forms.TextBox();
            this.gbpSalario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el día:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de horas diurnas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de horas nocturnas:";
            // 
            // txtHorasDiurnas
            // 
            this.txtHorasDiurnas.Location = new System.Drawing.Point(252, 148);
            this.txtHorasDiurnas.Name = "txtHorasDiurnas";
            this.txtHorasDiurnas.Size = new System.Drawing.Size(134, 21);
            this.txtHorasDiurnas.TabIndex = 5;
            // 
            // txtHorasNocturnas
            // 
            this.txtHorasNocturnas.Location = new System.Drawing.Point(252, 205);
            this.txtHorasNocturnas.Name = "txtHorasNocturnas";
            this.txtHorasNocturnas.Size = new System.Drawing.Size(134, 21);
            this.txtHorasNocturnas.TabIndex = 6;
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(252, 86);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(134, 21);
            this.cmbDias.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLimpiar.Location = new System.Drawing.Point(40, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalcular.Location = new System.Drawing.Point(286, 292);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbpSalario
            // 
            this.gbpSalario.Controls.Add(this.lblSueldo);
            this.gbpSalario.Controls.Add(this.label5);
            this.gbpSalario.Location = new System.Drawing.Point(40, 338);
            this.gbpSalario.Name = "gbpSalario";
            this.gbpSalario.Size = new System.Drawing.Size(346, 100);
            this.gbpSalario.TabIndex = 10;
            this.gbpSalario.TabStop = false;
            this.gbpSalario.Text = "Salario:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSueldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSueldo.Location = new System.Drawing.Point(110, 58);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(143, 24);
            this.lblSueldo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "El salario para el día es:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(286, 459);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor hora normal:";
            // 
            // txtHoraNormal
            // 
            this.txtHoraNormal.Location = new System.Drawing.Point(252, 258);
            this.txtHoraNormal.Name = "txtHoraNormal";
            this.txtHoraNormal.Size = new System.Drawing.Size(134, 21);
            this.txtHoraNormal.TabIndex = 13;
            // 
            // frmSueldoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(423, 498);
            this.ControlBox = false;
            this.Controls.Add(this.txtHoraNormal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpSalario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.txtHorasNocturnas);
            this.Controls.Add(this.txtHorasDiurnas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "frmSueldoDiario";
            this.Text = "Sueldo diario empleado";
            this.Load += new System.EventHandler(this.frmSueldoDiario_Load);
            this.gbpSalario.ResumeLayout(false);
            this.gbpSalario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHorasDiurnas;
        private System.Windows.Forms.TextBox txtHorasNocturnas;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbpSalario;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoraNormal;
    }
}


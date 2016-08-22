namespace appEcuacionCuadratica
{
    partial class frmEcuacionCuadratica
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbpSoluciones = new System.Windows.Forms.GroupBox();
            this.lblSolucion2 = new System.Windows.Forms.Label();
            this.lblSolucion1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbpSoluciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ecuación cuadrática de la forma ax^2 + bx + c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(65, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(196, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(328, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtA.Location = new System.Drawing.Point(27, 164);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 25);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtB.Location = new System.Drawing.Point(158, 164);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 25);
            this.txtB.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtC.Location = new System.Drawing.Point(283, 164);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 25);
            this.txtC.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnLimpiar.Location = new System.Drawing.Point(27, 258);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCalcular.Location = new System.Drawing.Point(283, 257);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbpSoluciones
            // 
            this.gbpSoluciones.Controls.Add(this.lblSolucion2);
            this.gbpSoluciones.Controls.Add(this.lblSolucion1);
            this.gbpSoluciones.Controls.Add(this.label6);
            this.gbpSoluciones.Controls.Add(this.label5);
            this.gbpSoluciones.Location = new System.Drawing.Point(27, 337);
            this.gbpSoluciones.Name = "gbpSoluciones";
            this.gbpSoluciones.Size = new System.Drawing.Size(356, 135);
            this.gbpSoluciones.TabIndex = 9;
            this.gbpSoluciones.TabStop = false;
            this.gbpSoluciones.Text = "Soluciones";
            // 
            // lblSolucion2
            // 
            this.lblSolucion2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSolucion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSolucion2.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblSolucion2.Location = new System.Drawing.Point(256, 91);
            this.lblSolucion2.Name = "lblSolucion2";
            this.lblSolucion2.Size = new System.Drawing.Size(94, 25);
            this.lblSolucion2.TabIndex = 3;
            // 
            // lblSolucion1
            // 
            this.lblSolucion1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSolucion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSolucion1.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblSolucion1.Location = new System.Drawing.Point(256, 38);
            this.lblSolucion1.Name = "lblSolucion1";
            this.lblSolucion1.Size = new System.Drawing.Size(94, 24);
            this.lblSolucion1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Solución 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Solución 1:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnSalir.Location = new System.Drawing.Point(283, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEcuacionCuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpSoluciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEcuacionCuadratica";
            this.Text = "Ecuación cuadrática";
            this.Load += new System.EventHandler(this.frmEcuacionCuadratica_Load);
            this.gbpSoluciones.ResumeLayout(false);
            this.gbpSoluciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbpSoluciones;
        private System.Windows.Forms.Label lblSolucion2;
        private System.Windows.Forms.Label lblSolucion1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
    }
}


namespace AppFabricaDeZapatos
{
    partial class frmFabricaDeZapatos
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
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtCantidadDePares = new System.Windows.Forms.TextBox();
            this.txtCostoDeZapato = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbpResultados = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVentaDelZapato = new System.Windows.Forms.Label();
            this.lblTotalCajas = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorEuro = new System.Windows.Forms.TextBox();
            this.gbpResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(202, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fábrica de zapatos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Superficie de las cajas (cm^2):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de pares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(40, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo de zapato:";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(373, 114);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(100, 20);
            this.txtSuperficie.TabIndex = 4;
            // 
            // txtCantidadDePares
            // 
            this.txtCantidadDePares.Location = new System.Drawing.Point(373, 158);
            this.txtCantidadDePares.Name = "txtCantidadDePares";
            this.txtCantidadDePares.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDePares.TabIndex = 5;
            // 
            // txtCostoDeZapato
            // 
            this.txtCostoDeZapato.Location = new System.Drawing.Point(373, 201);
            this.txtCostoDeZapato.Name = "txtCostoDeZapato";
            this.txtCostoDeZapato.Size = new System.Drawing.Size(100, 20);
            this.txtCostoDeZapato.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnLimpiar.Location = new System.Drawing.Point(43, 284);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 29);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCalcular.Location = new System.Drawing.Point(373, 284);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 29);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbpResultados
            // 
            this.gbpResultados.Controls.Add(this.lblTotalCajas);
            this.gbpResultados.Controls.Add(this.lblVentaDelZapato);
            this.gbpResultados.Controls.Add(this.label6);
            this.gbpResultados.Controls.Add(this.label5);
            this.gbpResultados.Font = new System.Drawing.Font("Verdana", 11F);
            this.gbpResultados.Location = new System.Drawing.Point(43, 328);
            this.gbpResultados.Name = "gbpResultados";
            this.gbpResultados.Size = new System.Drawing.Size(430, 122);
            this.gbpResultados.TabIndex = 9;
            this.gbpResultados.TabStop = false;
            this.gbpResultados.Text = "Resultados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio de venta de los zapatos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio total  de las cajas:";
            // 
            // lblVentaDelZapato
            // 
            this.lblVentaDelZapato.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblVentaDelZapato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentaDelZapato.Location = new System.Drawing.Point(285, 21);
            this.lblVentaDelZapato.Name = "lblVentaDelZapato";
            this.lblVentaDelZapato.Size = new System.Drawing.Size(125, 31);
            this.lblVentaDelZapato.TabIndex = 2;
            // 
            // lblTotalCajas
            // 
            this.lblTotalCajas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotalCajas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCajas.Location = new System.Drawing.Point(285, 70);
            this.lblTotalCajas.Name = "lblTotalCajas";
            this.lblTotalCajas.Size = new System.Drawing.Size(125, 31);
            this.lblTotalCajas.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(328, 466);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 32);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11F);
            this.label7.Location = new System.Drawing.Point(40, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor del Euro:";
            // 
            // txtValorEuro
            // 
            this.txtValorEuro.Location = new System.Drawing.Point(373, 243);
            this.txtValorEuro.Name = "txtValorEuro";
            this.txtValorEuro.Size = new System.Drawing.Size(100, 20);
            this.txtValorEuro.TabIndex = 12;
            // 
            // frmFabricaDeZapatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 510);
            this.ControlBox = false;
            this.Controls.Add(this.txtValorEuro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCostoDeZapato);
            this.Controls.Add(this.txtCantidadDePares);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFabricaDeZapatos";
            this.Text = "Fábrica de zapatos";
            this.Load += new System.EventHandler(this.frmFabricaDeZapatos_Load);
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
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtCantidadDePares;
        private System.Windows.Forms.TextBox txtCostoDeZapato;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbpResultados;
        private System.Windows.Forms.Label lblTotalCajas;
        private System.Windows.Forms.Label lblVentaDelZapato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorEuro;
    }
}


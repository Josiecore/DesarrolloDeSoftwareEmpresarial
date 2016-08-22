namespace appMasaNeumatico
{
    partial class frmMasaDeAire
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
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbpMasaDeAire = new System.Windows.Forms.GroupBox();
            this.lblMasa = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbpMasaDeAire.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular masa de aire de un neumático";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura (°C) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(29, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(29, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volumen:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtTemperatura.Location = new System.Drawing.Point(202, 111);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(123, 25);
            this.txtTemperatura.TabIndex = 4;
            // 
            // txtPresion
            // 
            this.txtPresion.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPresion.Location = new System.Drawing.Point(202, 172);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(123, 25);
            this.txtPresion.TabIndex = 5;
            // 
            // txtVolumen
            // 
            this.txtVolumen.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtVolumen.Location = new System.Drawing.Point(202, 236);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(123, 25);
            this.txtVolumen.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnLimpiar.Location = new System.Drawing.Point(32, 308);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnCalcular.Location = new System.Drawing.Point(202, 308);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 33);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbpMasaDeAire
            // 
            this.gbpMasaDeAire.Controls.Add(this.lblMasa);
            this.gbpMasaDeAire.Font = new System.Drawing.Font("Verdana", 11F);
            this.gbpMasaDeAire.Location = new System.Drawing.Point(32, 377);
            this.gbpMasaDeAire.Name = "gbpMasaDeAire";
            this.gbpMasaDeAire.Size = new System.Drawing.Size(293, 100);
            this.gbpMasaDeAire.TabIndex = 9;
            this.gbpMasaDeAire.TabStop = false;
            this.gbpMasaDeAire.Text = "Masa de aire:";
            // 
            // lblMasa
            // 
            this.lblMasa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblMasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMasa.Location = new System.Drawing.Point(80, 41);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(143, 27);
            this.lblMasa.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 11F);
            this.button2.Location = new System.Drawing.Point(202, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMasaDeAire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 531);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbpMasaDeAire);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.txtPresion);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMasaDeAire";
            this.Text = "Masa de aire";
            this.Load += new System.EventHandler(this.frmMasaDeAire_Load);
            this.gbpMasaDeAire.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbpMasaDeAire;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Button button2;
    }
}


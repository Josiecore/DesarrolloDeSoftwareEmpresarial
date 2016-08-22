namespace appConversorDeTemperaturas
{
    partial class frmConversorDeTemperaturas
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
            this.cmbGradosDeEntrada = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadDeGradosDeEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGradosDeSalida = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.gbpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.gbpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de temperaturas";
            // 
            // cmbGradosDeEntrada
            // 
            this.cmbGradosDeEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradosDeEntrada.FormattingEnabled = true;
            this.cmbGradosDeEntrada.Location = new System.Drawing.Point(92, 124);
            this.cmbGradosDeEntrada.Name = "cmbGradosDeEntrada";
            this.cmbGradosDeEntrada.Size = new System.Drawing.Size(121, 21);
            this.cmbGradosDeEntrada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el tipo de grados de entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite los grados de entrada";
            // 
            // txtCantidadDeGradosDeEntrada
            // 
            this.txtCantidadDeGradosDeEntrada.Location = new System.Drawing.Point(102, 207);
            this.txtCantidadDeGradosDeEntrada.Name = "txtCantidadDeGradosDeEntrada";
            this.txtCantidadDeGradosDeEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDeGradosDeEntrada.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione el tipo de grados a convertir";
            // 
            // cmbGradosDeSalida
            // 
            this.cmbGradosDeSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradosDeSalida.FormattingEnabled = true;
            this.cmbGradosDeSalida.Location = new System.Drawing.Point(92, 299);
            this.cmbGradosDeSalida.Name = "cmbGradosDeSalida";
            this.cmbGradosDeSalida.Size = new System.Drawing.Size(121, 21);
            this.cmbGradosDeSalida.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(27, 348);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.AutoSize = true;
            this.btnConvertir.BackColor = System.Drawing.Color.LightGreen;
            this.btnConvertir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(217, 348);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(79, 24);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // gbpResultado
            // 
            this.gbpResultado.Controls.Add(this.lblResultado);
            this.gbpResultado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpResultado.Location = new System.Drawing.Point(63, 417);
            this.gbpResultado.Name = "gbpResultado";
            this.gbpResultado.Size = new System.Drawing.Size(200, 100);
            this.gbpResultado.TabIndex = 9;
            this.gbpResultado.TabStop = false;
            this.gbpResultado.Text = "Resultado";
            this.gbpResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblResultado.Location = new System.Drawing.Point(29, 47);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(139, 28);
            this.lblResultado.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Salmon;
            this.Salir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(221, 533);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // frmConversorDeTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(331, 568);
            this.ControlBox = false;
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.gbpResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbGradosDeSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadDeGradosDeEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGradosDeEntrada);
            this.Controls.Add(this.label1);
            this.Name = "frmConversorDeTemperaturas";
            this.Text = "Conversor de temperaturas";
            this.Load += new System.EventHandler(this.frmConversorDeTemperaturas_Load);
            this.gbpResultado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGradosDeEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadDeGradosDeEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGradosDeSalida;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.GroupBox gbpResultado;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label lblResultado;
    }
}


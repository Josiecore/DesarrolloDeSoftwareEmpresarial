namespace WindowsFormsApplication1
{
    partial class frmAumentoEmpleado
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
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtTiempoTrabajado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbpAumento = new System.Windows.Forms.GroupBox();
            this.lblPorcentajeDelAumento = new System.Windows.Forms.Label();
            this.lblValorAumento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbpAumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(139, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aumento del empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo actual del empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(43, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Años trabajados en la empresa:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtSueldo.Location = new System.Drawing.Point(348, 122);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 24);
            this.txtSueldo.TabIndex = 3;
            // 
            // txtTiempoTrabajado
            // 
            this.txtTiempoTrabajado.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtTiempoTrabajado.Location = new System.Drawing.Point(348, 184);
            this.txtTiempoTrabajado.Name = "txtTiempoTrabajado";
            this.txtTiempoTrabajado.Size = new System.Drawing.Size(100, 24);
            this.txtTiempoTrabajado.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(348, 259);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 27);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCalcular.Location = new System.Drawing.Point(46, 259);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 27);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular aumento";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbpAumento
            // 
            this.gbpAumento.Controls.Add(this.lblPorcentajeDelAumento);
            this.gbpAumento.Controls.Add(this.lblValorAumento);
            this.gbpAumento.Controls.Add(this.label5);
            this.gbpAumento.Controls.Add(this.label4);
            this.gbpAumento.Font = new System.Drawing.Font("Verdana", 10F);
            this.gbpAumento.Location = new System.Drawing.Point(46, 344);
            this.gbpAumento.Name = "gbpAumento";
            this.gbpAumento.Size = new System.Drawing.Size(414, 121);
            this.gbpAumento.TabIndex = 7;
            this.gbpAumento.TabStop = false;
            this.gbpAumento.Text = "Aumento:";
            // 
            // lblPorcentajeDelAumento
            // 
            this.lblPorcentajeDelAumento.BackColor = System.Drawing.Color.Cyan;
            this.lblPorcentajeDelAumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPorcentajeDelAumento.Location = new System.Drawing.Point(299, 34);
            this.lblPorcentajeDelAumento.Name = "lblPorcentajeDelAumento";
            this.lblPorcentajeDelAumento.Size = new System.Drawing.Size(103, 17);
            this.lblPorcentajeDelAumento.TabIndex = 2;
            // 
            // lblValorAumento
            // 
            this.lblValorAumento.BackColor = System.Drawing.Color.Cyan;
            this.lblValorAumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorAumento.Location = new System.Drawing.Point(299, 94);
            this.lblValorAumento.Name = "lblValorAumento";
            this.lblValorAumento.Size = new System.Drawing.Size(103, 17);
            this.lblValorAumento.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor del aumento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Porcentaje de aumento:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnSalir.Location = new System.Drawing.Point(348, 485);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAumentoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(504, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpAumento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTiempoTrabajado);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAumentoEmpleado";
            this.Text = "Aumento de empleado";
            this.Load += new System.EventHandler(this.frmAumentoEmpleado_Load);
            this.gbpAumento.ResumeLayout(false);
            this.gbpAumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtTiempoTrabajado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbpAumento;
        private System.Windows.Forms.Label lblPorcentajeDelAumento;
        private System.Windows.Forms.Label lblValorAumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}


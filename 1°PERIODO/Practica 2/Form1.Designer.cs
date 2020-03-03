namespace Practica_2
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
            this.btnConver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRomano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConver
            // 
            this.btnConver.Location = new System.Drawing.Point(189, 34);
            this.btnConver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(81, 19);
            this.btnConver.TabIndex = 0;
            this.btnConver.Text = "CONVERTIR";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(189, 87);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(85, 33);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(91, 20);
            this.txtNum.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 36);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "NUMERO";
            // 
            // lblRomano
            // 
            this.lblRomano.AutoSize = true;
            this.lblRomano.Location = new System.Drawing.Point(26, 106);
            this.lblRomano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRomano.Name = "lblRomano";
            this.lblRomano.Size = new System.Drawing.Size(0, 13);
            this.lblRomano.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 130);
            this.Controls.Add(this.lblRomano);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRomano;
    }
}


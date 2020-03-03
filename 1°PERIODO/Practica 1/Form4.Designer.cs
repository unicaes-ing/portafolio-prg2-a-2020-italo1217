namespace Practica_1
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textcantidad = new System.Windows.Forms.TextBox();
            this.textsubt = new System.Windows.Forms.TextBox();
            this.textimpuesto = new System.Windows.Forms.TextBox();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.cbotitulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo del libro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Impuesto (13%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total a pagar";
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(116, 66);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(100, 20);
            this.textprecio.TabIndex = 7;
            // 
            // textcantidad
            // 
            this.textcantidad.Location = new System.Drawing.Point(116, 108);
            this.textcantidad.Name = "textcantidad";
            this.textcantidad.Size = new System.Drawing.Size(100, 20);
            this.textcantidad.TabIndex = 8;
            // 
            // textsubt
            // 
            this.textsubt.Location = new System.Drawing.Point(160, 176);
            this.textsubt.Name = "textsubt";
            this.textsubt.Size = new System.Drawing.Size(100, 20);
            this.textsubt.TabIndex = 9;
            // 
            // textimpuesto
            // 
            this.textimpuesto.Location = new System.Drawing.Point(160, 213);
            this.textimpuesto.Name = "textimpuesto";
            this.textimpuesto.Size = new System.Drawing.Size(100, 20);
            this.textimpuesto.TabIndex = 10;
            // 
            // texttotal
            // 
            this.texttotal.Location = new System.Drawing.Point(160, 252);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(100, 20);
            this.texttotal.TabIndex = 11;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(36, 319);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(141, 319);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(260, 319);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // cbotitulo
            // 
            this.cbotitulo.FormattingEnabled = true;
            this.cbotitulo.Items.AddRange(new object[] {
            "EL DADOR DE RECUERDOS",
            "LA COMEDIA HUMANA",
            "100 AÑOS DE SOLEDAD",
            "EL PRINCIPITO",
            "NARRACIONES EXTRAORDINARIAS"});
            this.cbotitulo.Location = new System.Drawing.Point(116, 23);
            this.cbotitulo.Name = "cbotitulo";
            this.cbotitulo.Size = new System.Drawing.Size(219, 21);
            this.cbotitulo.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 382);
            this.Controls.Add(this.cbotitulo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.textimpuesto);
            this.Controls.Add(this.textsubt);
            this.Controls.Add(this.textcantidad);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textcantidad;
        private System.Windows.Forms.TextBox textsubt;
        private System.Windows.Forms.TextBox textimpuesto;
        private System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cbotitulo;
    }
}
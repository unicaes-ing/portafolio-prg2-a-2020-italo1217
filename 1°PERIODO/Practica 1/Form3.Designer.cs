namespace Practica_1
{
    partial class Form3
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
            this.textinver1 = new System.Windows.Forms.TextBox();
            this.textinver2 = new System.Windows.Forms.TextBox();
            this.textporc1 = new System.Windows.Forms.TextBox();
            this.textporc2 = new System.Windows.Forms.TextBox();
            this.textporc3 = new System.Windows.Forms.TextBox();
            this.textinver3 = new System.Windows.Forms.TextBox();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "porcentaje";
            // 
            // textinver1
            // 
            this.textinver1.Location = new System.Drawing.Point(53, 79);
            this.textinver1.Name = "textinver1";
            this.textinver1.Size = new System.Drawing.Size(100, 20);
            this.textinver1.TabIndex = 2;
            // 
            // textinver2
            // 
            this.textinver2.Location = new System.Drawing.Point(53, 119);
            this.textinver2.Name = "textinver2";
            this.textinver2.Size = new System.Drawing.Size(100, 20);
            this.textinver2.TabIndex = 3;
            // 
            // textporc1
            // 
            this.textporc1.Location = new System.Drawing.Point(193, 79);
            this.textporc1.Name = "textporc1";
            this.textporc1.Size = new System.Drawing.Size(100, 20);
            this.textporc1.TabIndex = 4;
            // 
            // textporc2
            // 
            this.textporc2.Location = new System.Drawing.Point(193, 119);
            this.textporc2.Name = "textporc2";
            this.textporc2.Size = new System.Drawing.Size(100, 20);
            this.textporc2.TabIndex = 5;
            // 
            // textporc3
            // 
            this.textporc3.Location = new System.Drawing.Point(193, 166);
            this.textporc3.Name = "textporc3";
            this.textporc3.Size = new System.Drawing.Size(100, 20);
            this.textporc3.TabIndex = 6;
            // 
            // textinver3
            // 
            this.textinver3.Location = new System.Drawing.Point(53, 166);
            this.textinver3.Name = "textinver3";
            this.textinver3.Size = new System.Drawing.Size(100, 20);
            this.textinver3.TabIndex = 7;
            // 
            // texttotal
            // 
            this.texttotal.Location = new System.Drawing.Point(53, 256);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(100, 20);
            this.texttotal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "3.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total inversion";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(29, 302);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(127, 302);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(222, 302);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 357);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.textinver3);
            this.Controls.Add(this.textporc3);
            this.Controls.Add(this.textporc2);
            this.Controls.Add(this.textporc1);
            this.Controls.Add(this.textinver2);
            this.Controls.Add(this.textinver1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textinver1;
        private System.Windows.Forms.TextBox textinver2;
        private System.Windows.Forms.TextBox textporc1;
        private System.Windows.Forms.TextBox textporc2;
        private System.Windows.Forms.TextBox textporc3;
        private System.Windows.Forms.TextBox textinver3;
        private System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}
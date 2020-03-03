namespace Practica_2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoop5 = new System.Windows.Forms.RadioButton();
            this.rdoop2 = new System.Windows.Forms.RadioButton();
            this.rdoop4 = new System.Windows.Forms.RadioButton();
            this.rdoop3 = new System.Windows.Forms.RadioButton();
            this.rdoop1 = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoop5);
            this.groupBox1.Controls.Add(this.rdoop2);
            this.groupBox1.Controls.Add(this.rdoop4);
            this.groupBox1.Controls.Add(this.rdoop3);
            this.groupBox1.Controls.Add(this.rdoop1);
            this.groupBox1.Location = new System.Drawing.Point(181, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(70, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento";
            // 
            // rdoop5
            // 
            this.rdoop5.AutoSize = true;
            this.rdoop5.Location = new System.Drawing.Point(4, 106);
            this.rdoop5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoop5.Name = "rdoop5";
            this.rdoop5.Size = new System.Drawing.Size(45, 17);
            this.rdoop5.TabIndex = 4;
            this.rdoop5.TabStop = true;
            this.rdoop5.Text = "20%";
            this.rdoop5.UseVisualStyleBackColor = true;
            // 
            // rdoop2
            // 
            this.rdoop2.AutoSize = true;
            this.rdoop2.Location = new System.Drawing.Point(4, 40);
            this.rdoop2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoop2.Name = "rdoop2";
            this.rdoop2.Size = new System.Drawing.Size(39, 17);
            this.rdoop2.TabIndex = 3;
            this.rdoop2.TabStop = true;
            this.rdoop2.Text = "5%";
            this.rdoop2.UseVisualStyleBackColor = true;
            // 
            // rdoop4
            // 
            this.rdoop4.AutoSize = true;
            this.rdoop4.Location = new System.Drawing.Point(4, 84);
            this.rdoop4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoop4.Name = "rdoop4";
            this.rdoop4.Size = new System.Drawing.Size(45, 17);
            this.rdoop4.TabIndex = 2;
            this.rdoop4.TabStop = true;
            this.rdoop4.Text = "15%";
            this.rdoop4.UseVisualStyleBackColor = true;
            // 
            // rdoop3
            // 
            this.rdoop3.AutoSize = true;
            this.rdoop3.Location = new System.Drawing.Point(4, 62);
            this.rdoop3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoop3.Name = "rdoop3";
            this.rdoop3.Size = new System.Drawing.Size(45, 17);
            this.rdoop3.TabIndex = 1;
            this.rdoop3.TabStop = true;
            this.rdoop3.Text = "10%";
            this.rdoop3.UseVisualStyleBackColor = true;
            // 
            // rdoop1
            // 
            this.rdoop1.AutoSize = true;
            this.rdoop1.Location = new System.Drawing.Point(4, 18);
            this.rdoop1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoop1.Name = "rdoop1";
            this.rdoop1.Size = new System.Drawing.Size(39, 17);
            this.rdoop1.TabIndex = 0;
            this.rdoop1.TabStop = true;
            this.rdoop1.Text = "0%";
            this.rdoop1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(57, 194);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(166, 193);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(78, 81);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(56, 19);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(71, 20);
            this.txtCant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(76, 20);
            this.txtCant.TabIndex = 9;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(71, 117);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(76, 20);
            this.txtDesc.TabIndex = 10;
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(71, 162);
            this.txtTot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(76, 20);
            this.txtTot.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(71, 51);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 234);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoop5;
        private System.Windows.Forms.RadioButton rdoop2;
        private System.Windows.Forms.RadioButton rdoop4;
        private System.Windows.Forms.RadioButton rdoop3;
        private System.Windows.Forms.RadioButton rdoop1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}
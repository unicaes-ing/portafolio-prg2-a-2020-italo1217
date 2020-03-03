namespace Practica_2
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
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsta = new System.Windows.Forms.ListBox();
            this.txtLongconvert = new System.Windows.Forms.TextBox();
            this.lstde = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca la longitud a convertir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud convertida";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(172, 25);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(76, 20);
            this.txtLong.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(55, 200);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(66, 19);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(146, 200);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsta);
            this.groupBox2.Location = new System.Drawing.Point(134, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(116, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "a";
            // 
            // lsta
            // 
            this.lsta.FormattingEnabled = true;
            this.lsta.Items.AddRange(new object[] {
            "Pulgadas\t",
            "Pies",
            "Yardas"});
            this.lsta.Location = new System.Drawing.Point(7, 17);
            this.lsta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsta.Name = "lsta";
            this.lsta.Size = new System.Drawing.Size(96, 69);
            this.lsta.TabIndex = 0;
            // 
            // txtLongconvert
            // 
            this.txtLongconvert.Location = new System.Drawing.Point(116, 170);
            this.txtLongconvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLongconvert.Name = "txtLongconvert";
            this.txtLongconvert.Size = new System.Drawing.Size(76, 20);
            this.txtLongconvert.TabIndex = 12;
            // 
            // lstde
            // 
            this.lstde.FormattingEnabled = true;
            this.lstde.Items.AddRange(new object[] {
            "Pulgadas\t",
            "Pies",
            "Yardas"});
            this.lstde.Location = new System.Drawing.Point(7, 17);
            this.lstde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstde.Name = "lstde";
            this.lstde.Size = new System.Drawing.Size(96, 69);
            this.lstde.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstde);
            this.groupBox1.Location = new System.Drawing.Point(14, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(116, 99);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 228);
            this.Controls.Add(this.txtLongconvert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsta;
        private System.Windows.Forms.TextBox txtLongconvert;
        private System.Windows.Forms.ListBox lstde;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
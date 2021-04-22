namespace ConvertorLeiEuro
{
    partial class Form1
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
            this.lblLei = new System.Windows.Forms.Label();
            this.txtLei = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLei
            // 
            this.lblLei.AutoSize = true;
            this.lblLei.Location = new System.Drawing.Point(89, 81);
            this.lblLei.Name = "lblLei";
            this.lblLei.Size = new System.Drawing.Size(51, 13);
            this.lblLei.TabIndex = 0;
            this.lblLei.Text = "Suma Lei";
            this.lblLei.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLei
            // 
            this.txtLei.Location = new System.Drawing.Point(92, 97);
            this.txtLei.Name = "txtLei";
            this.txtLei.Size = new System.Drawing.Size(100, 20);
            this.txtLei.TabIndex = 1;
            this.txtLei.TextChanged += new System.EventHandler(this.txtLei_TextChanged);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(92, 151);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(89, 135);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(59, 13);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "Suma Euro";
            this.lblEuro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 248);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtLei);
            this.Controls.Add(this.lblLei);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLei;
        private System.Windows.Forms.TextBox txtLei;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label lblEuro;
    }
}


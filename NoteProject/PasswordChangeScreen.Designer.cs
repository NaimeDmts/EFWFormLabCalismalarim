namespace NoteProject
{
    partial class PasswordChangeScreen
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
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifreDegis = new System.Windows.Forms.Button();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(382, 225);
            this.txtYeniSifreTekrar.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(174, 23);
            this.txtYeniSifreTekrar.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Yeni Şifre Tekrar :";
            // 
            // btnSifreDegis
            // 
            this.btnSifreDegis.Location = new System.Drawing.Point(244, 274);
            this.btnSifreDegis.Margin = new System.Windows.Forms.Padding(2);
            this.btnSifreDegis.Name = "btnSifreDegis";
            this.btnSifreDegis.Size = new System.Drawing.Size(312, 32);
            this.btnSifreDegis.TabIndex = 34;
            this.btnSifreDegis.Text = "Şifre Değiştir";
            this.btnSifreDegis.UseVisualStyleBackColor = true;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(382, 186);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(174, 23);
            this.txtYeniSifre.TabIndex = 32;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(382, 144);
            this.txtEskiSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(174, 23);
            this.txtEskiSifre.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Yeni Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Eski Şifre :";
            // 
            // PasswordChangeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSifreDegis);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordChangeScreen";
            this.Text = "PasswordChangeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYeniSifreTekrar;
        private Label label3;
        private Button btnSifreDegis;
        private TextBox txtYeniSifre;
        private TextBox txtEskiSifre;
        private Label label2;
        private Label label1;
    }
}
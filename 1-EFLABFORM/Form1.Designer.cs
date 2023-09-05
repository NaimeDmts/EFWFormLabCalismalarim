namespace _1_EFLABFORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalisanGetir = new System.Windows.Forms.Button();
            this.lblCalisan = new System.Windows.Forms.ListBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalisanGetir
            // 
            this.btnCalisanGetir.Location = new System.Drawing.Point(96, 12);
            this.btnCalisanGetir.Name = "btnCalisanGetir";
            this.btnCalisanGetir.Size = new System.Drawing.Size(245, 43);
            this.btnCalisanGetir.TabIndex = 0;
            this.btnCalisanGetir.Text = "Calisan Getir";
            this.btnCalisanGetir.UseVisualStyleBackColor = true;
            this.btnCalisanGetir.Click += new System.EventHandler(this.btnCalisanGetir_Click);
            // 
            // lblCalisan
            // 
            this.lblCalisan.FormattingEnabled = true;
            this.lblCalisan.ItemHeight = 15;
            this.lblCalisan.Location = new System.Drawing.Point(96, 61);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(245, 289);
            this.lblCalisan.TabIndex = 1;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(406, 119);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(91, 43);
            this.btnCalisanEkle.TabIndex = 2;
            this.btnCalisanEkle.Text = "Calisan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(388, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 23);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(389, 62);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(124, 23);
            this.txtSoyad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.lblCalisan);
            this.Controls.Add(this.btnCalisanGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalisanGetir;
        private ListBox lblCalisan;
        private Button btnCalisanEkle;
        private TextBox txtAd;
        private TextBox txtSoyad;
    }
}
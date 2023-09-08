namespace NoteProject
{
    partial class UserScreen
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
            this.linkSifreDegis = new System.Windows.Forms.LinkLabel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnNotSil = new System.Windows.Forms.Button();
            this.btnYeniNot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lboxNotlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // linkSifreDegis
            // 
            this.linkSifreDegis.AutoSize = true;
            this.linkSifreDegis.Location = new System.Drawing.Point(156, 356);
            this.linkSifreDegis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkSifreDegis.Name = "linkSifreDegis";
            this.linkSifreDegis.Size = new System.Drawing.Size(73, 15);
            this.linkSifreDegis.TabIndex = 35;
            this.linkSifreDegis.TabStop = true;
            this.linkSifreDegis.Text = "Şifre Değiştir";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(556, 348);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 26);
            this.btnKaydet.TabIndex = 34;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnNotSil
            // 
            this.btnNotSil.Location = new System.Drawing.Point(440, 348);
            this.btnNotSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotSil.Name = "btnNotSil";
            this.btnNotSil.Size = new System.Drawing.Size(86, 26);
            this.btnNotSil.TabIndex = 33;
            this.btnNotSil.Text = "Not Sil";
            this.btnNotSil.UseVisualStyleBackColor = true;
            // 
            // btnYeniNot
            // 
            this.btnYeniNot.Location = new System.Drawing.Point(326, 348);
            this.btnYeniNot.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniNot.Name = "btnYeniNot";
            this.btnYeniNot.Size = new System.Drawing.Size(86, 26);
            this.btnYeniNot.TabIndex = 29;
            this.btnYeniNot.Text = "Yeni Not";
            this.btnYeniNot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "İçerik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Notlarım";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Başlık";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(326, 151);
            this.txtIcerik.Margin = new System.Windows.Forms.Padding(2);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(318, 191);
            this.txtIcerik.TabIndex = 28;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(326, 98);
            this.txtBaslik.Margin = new System.Windows.Forms.Padding(2);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(318, 23);
            this.txtBaslik.TabIndex = 27;
            // 
            // lboxNotlar
            // 
            this.lboxNotlar.FormattingEnabled = true;
            this.lboxNotlar.ItemHeight = 15;
            this.lboxNotlar.Location = new System.Drawing.Point(156, 98);
            this.lboxNotlar.Margin = new System.Windows.Forms.Padding(2);
            this.lboxNotlar.Name = "lboxNotlar";
            this.lboxNotlar.Size = new System.Drawing.Size(145, 244);
            this.lboxNotlar.TabIndex = 36;
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkSifreDegis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnNotSil);
            this.Controls.Add(this.btnYeniNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lboxNotlar);
            this.Name = "UserScreen";
            this.Text = "UserScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkSifreDegis;
        private Button btnKaydet;
        private Button btnNotSil;
        private Button btnYeniNot;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtIcerik;
        private TextBox txtBaslik;
        private ListBox lboxNotlar;
    }
}
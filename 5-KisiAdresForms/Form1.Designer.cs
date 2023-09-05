namespace _5_KisiAdresForms
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
            components = new System.ComponentModel.Container();
            lvKisiler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            adresToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            mtxtTelefon = new MaskedTextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkYoneticiEkrani = new LinkLabel();
            txtKisiAra = new TextBox();
            label4 = new Label();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvKisiler
            // 
            lvKisiler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvKisiler.ContextMenuStrip = contextMenuStrip1;
            lvKisiler.FullRowSelect = true;
            lvKisiler.GridLines = true;
            lvKisiler.Location = new Point(170, 265);
            lvKisiler.Margin = new Padding(2);
            lvKisiler.Name = "lvKisiler";
            lvKisiler.Size = new Size(460, 138);
            lvKisiler.TabIndex = 13;
            lvKisiler.UseCompatibleStateImageBehavior = false;
            lvKisiler.View = View.Details;
            lvKisiler.SelectedIndexChanged += lvKisiler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "AD";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SOYAD";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TELEFON";
            columnHeader4.Width = 300;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, adresToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(105, 48);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(104, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // adresToolStripMenuItem
            // 
            adresToolStripMenuItem.Name = "adresToolStripMenuItem";
            adresToolStripMenuItem.Size = new Size(104, 22);
            adresToolStripMenuItem.Text = "Adres";
            adresToolStripMenuItem.Click += adresToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(mtxtTelefon);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(170, 48);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(298, 205);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Ekleme Ekranı";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(162, 151);
            btnGuncelle.Margin = new Padding(2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(96, 32);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(23, 151);
            btnKaydet.Margin = new Padding(2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(96, 32);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(114, 110);
            mtxtTelefon.Margin = new Padding(2);
            mtxtTelefon.Mask = "(999) 000-00-00";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(145, 23);
            mtxtTelefon.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(114, 71);
            txtSoyad.Margin = new Padding(2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(145, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(114, 34);
            txtAd.Margin = new Padding(2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(145, 23);
            txtAd.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 109);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // linkYoneticiEkrani
            // 
            linkYoneticiEkrani.AutoSize = true;
            linkYoneticiEkrani.Location = new Point(508, 86);
            linkYoneticiEkrani.Margin = new Padding(2, 0, 2, 0);
            linkYoneticiEkrani.Name = "linkYoneticiEkrani";
            linkYoneticiEkrani.Size = new Size(84, 15);
            linkYoneticiEkrani.TabIndex = 11;
            linkYoneticiEkrani.TabStop = true;
            linkYoneticiEkrani.Text = "Yönetici Ekranı";
            linkYoneticiEkrani.LinkClicked += linkYoneticiEkrani_LinkClicked;
            // 
            // txtKisiAra
            // 
            txtKisiAra.Location = new Point(484, 206);
            txtKisiAra.Margin = new Padding(2);
            txtKisiAra.Name = "txtKisiAra";
            txtKisiAra.Size = new Size(145, 23);
            txtKisiAra.TabIndex = 10;
            txtKisiAra.TextChanged += txtKisiAra_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 12;
            label4.Text = "Kişi Ara";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvKisiler);
            Controls.Add(groupBox1);
            Controls.Add(linkYoneticiEkrani);
            Controls.Add(txtKisiAra);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvKisiler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private Button btnGuncelle;
        private Button btnKaydet;
        private MaskedTextBox mtxtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkYoneticiEkrani;
        private TextBox txtKisiAra;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem adresToolStripMenuItem;
    }
}
namespace _5_KisiAdresForms
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
            lvAdresler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            txtAdresDetay = new TextBox();
            txtIlce = new TextBox();
            txtSehir = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvAdresler
            // 
            lvAdresler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvAdresler.FullRowSelect = true;
            lvAdresler.GridLines = true;
            lvAdresler.Location = new Point(166, 244);
            lvAdresler.Margin = new Padding(2);
            lvAdresler.Name = "lvAdresler";
            lvAdresler.Size = new Size(469, 142);
            lvAdresler.TabIndex = 5;
            lvAdresler.UseCompatibleStateImageBehavior = false;
            lvAdresler.View = View.Details;
            lvAdresler.SelectedIndexChanged += lvAdresler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Şehir";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "İlçe";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Adres Detay";
            columnHeader4.Width = 430;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtAdresDetay);
            groupBox1.Controls.Add(txtIlce);
            groupBox1.Controls.Add(txtSehir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(166, 64);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(468, 171);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adres Ekleme Ekranı";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(302, 98);
            btnSil.Margin = new Padding(2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 28);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(302, 64);
            btnGuncelle.Margin = new Padding(2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 28);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(302, 30);
            btnKaydet.Margin = new Padding(2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(140, 28);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdresDetay
            // 
            txtAdresDetay.Location = new Point(112, 100);
            txtAdresDetay.Margin = new Padding(2);
            txtAdresDetay.Multiline = true;
            txtAdresDetay.Name = "txtAdresDetay";
            txtAdresDetay.Size = new Size(149, 62);
            txtAdresDetay.TabIndex = 2;
            // 
            // txtIlce
            // 
            txtIlce.Location = new Point(112, 64);
            txtIlce.Margin = new Padding(2);
            txtIlce.Name = "txtIlce";
            txtIlce.Size = new Size(149, 23);
            txtIlce.TabIndex = 1;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(112, 30);
            txtSehir.Margin = new Padding(2);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(149, 23);
            txtSehir.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 0;
            label3.Text = "Adres Detay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 0;
            label2.Text = "İlçe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Şehir";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvAdresler);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvAdresler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private TextBox txtAdresDetay;
        private TextBox txtIlce;
        private TextBox txtSehir;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
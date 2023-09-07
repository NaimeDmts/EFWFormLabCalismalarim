namespace KisiNot.UI
{
    partial class Form5
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
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSifre = new System.Windows.Forms.Button();
            this.lvNotlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not İçeriği";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(142, 22);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(230, 23);
            this.txtBaslik.TabIndex = 2;
            this.txtBaslik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(142, 59);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(230, 129);
            this.txtIcerik.TabIndex = 3;
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(142, 203);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(75, 24);
            this.btnNotEkle.TabIndex = 4;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(223, 204);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(73, 23);
            this.btnGuncel.TabIndex = 5;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(302, 204);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yeni Şifre";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 23);
            this.textBox3.TabIndex = 9;
            // 
            // btnSifre
            // 
            this.btnSifre.Location = new System.Drawing.Point(182, 318);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(103, 23);
            this.btnSifre.TabIndex = 10;
            this.btnSifre.Text = "Sifre Güncelle";
            this.btnSifre.UseVisualStyleBackColor = true;
            // 
            // lvNotlar
            // 
            this.lvNotlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNotlar.FullRowSelect = true;
            this.lvNotlar.GridLines = true;
            this.lvNotlar.Location = new System.Drawing.Point(414, 18);
            this.lvNotlar.Name = "lvNotlar";
            this.lvNotlar.Size = new System.Drawing.Size(305, 346);
            this.lvNotlar.TabIndex = 11;
            this.lvNotlar.UseCompatibleStateImageBehavior = false;
            this.lvNotlar.View = System.Windows.Forms.View.Details;
            this.lvNotlar.SelectedIndexChanged += new System.EventHandler(this.lvNotlar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Baslik";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Not İçeriği";
            this.columnHeader2.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifreniz";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(139, 240);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(173, 23);
            this.txtEskiSifre.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvNotlar);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBaslik;
        private TextBox txtIcerik;
        private Button btnNotEkle;
        private Button btnGuncel;
        private Button btnSil;
        private Label label4;
        private TextBox textBox3;
        private Button btnSifre;
        private ListView lvNotlar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label3;
        private TextBox txtEskiSifre;
    }
}
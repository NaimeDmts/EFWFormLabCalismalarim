namespace KisiNot.UI
{
    partial class Form4
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
            this.lvKisiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvNotlar = new System.Windows.Forms.ListView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvKisiler
            // 
            this.lvKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvKisiler.FullRowSelect = true;
            this.lvKisiler.GridLines = true;
            this.lvKisiler.Location = new System.Drawing.Point(3, 174);
            this.lvKisiler.Name = "lvKisiler";
            this.lvKisiler.Size = new System.Drawing.Size(240, 264);
            this.lvKisiler.TabIndex = 0;
            this.lvKisiler.UseCompatibleStateImageBehavior = false;
            this.lvKisiler.View = System.Windows.Forms.View.Details;
            this.lvKisiler.SelectedIndexChanged += new System.EventHandler(this.lvKisiler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Statu";
            this.columnHeader2.Width = 80;
            // 
            // lvNotlar
            // 
            this.lvNotlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvNotlar.GridLines = true;
            this.lvNotlar.Location = new System.Drawing.Point(258, 174);
            this.lvNotlar.Name = "lvNotlar";
            this.lvNotlar.Size = new System.Drawing.Size(530, 264);
            this.lvNotlar.TabIndex = 1;
            this.lvNotlar.UseCompatibleStateImageBehavior = false;
            this.lvNotlar.View = System.Windows.Forms.View.Details;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(372, 63);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(192, 54);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(92, 15);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Kullanıcı Durum";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NotBaşlığı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NotIceriği";
            this.columnHeader4.Width = 400;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kullanıcı";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lvNotlar);
            this.Controls.Add(this.lvKisiler);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvKisiler;
        private ListView lvNotlar;
        private Button btnGuncelle;
        private Label lblDurum;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
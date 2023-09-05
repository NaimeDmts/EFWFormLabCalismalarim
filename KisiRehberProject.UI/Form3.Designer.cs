namespace KisiRehberProject.UI
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lvAdresler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lboxKisiler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(340, 89);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(140, 23);
            this.txtAra.TabIndex = 15;
            // 
            // lvAdresler
            // 
            this.lvAdresler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAdresler.FullRowSelect = true;
            this.lvAdresler.GridLines = true;
            this.lvAdresler.Location = new System.Drawing.Point(289, 117);
            this.lvAdresler.Margin = new System.Windows.Forms.Padding(2);
            this.lvAdresler.Name = "lvAdresler";
            this.lvAdresler.Size = new System.Drawing.Size(426, 244);
            this.lvAdresler.TabIndex = 17;
            this.lvAdresler.UseCompatibleStateImageBehavior = false;
            this.lvAdresler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Şehir";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlçe";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres Detay";
            this.columnHeader3.Width = 400;
            // 
            // lboxKisiler
            // 
            this.lboxKisiler.FormattingEnabled = true;
            this.lboxKisiler.ItemHeight = 15;
            this.lboxKisiler.Location = new System.Drawing.Point(85, 117);
            this.lboxKisiler.Margin = new System.Windows.Forms.Padding(2);
            this.lboxKisiler.Name = "lboxKisiler";
            this.lboxKisiler.Size = new System.Drawing.Size(178, 244);
            this.lboxKisiler.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ara : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yönetici Ekranı";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lvAdresler);
            this.Controls.Add(this.lboxKisiler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAra;
        private ListView lvAdresler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListBox lboxKisiler;
        private Label label2;
        private Label label1;
    }
}
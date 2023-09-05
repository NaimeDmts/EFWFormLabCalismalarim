namespace _5_KisiAdresForms
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
            txtAra = new TextBox();
            lvAdresler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lboxKisiler = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Location = new Point(340, 89);
            txtAra.Margin = new Padding(2);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(140, 23);
            txtAra.TabIndex = 10;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // lvAdresler
            // 
            lvAdresler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvAdresler.FullRowSelect = true;
            lvAdresler.GridLines = true;
            lvAdresler.Location = new Point(289, 117);
            lvAdresler.Margin = new Padding(2);
            lvAdresler.Name = "lvAdresler";
            lvAdresler.Size = new Size(426, 244);
            lvAdresler.TabIndex = 12;
            lvAdresler.UseCompatibleStateImageBehavior = false;
            lvAdresler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Şehir";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İlçe";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adres Detay";
            columnHeader3.Width = 400;
            // 
            // lboxKisiler
            // 
            lboxKisiler.FormattingEnabled = true;
            lboxKisiler.ItemHeight = 15;
            lboxKisiler.Location = new Point(85, 117);
            lboxKisiler.Margin = new Padding(2);
            lboxKisiler.Name = "lboxKisiler";
            lboxKisiler.Size = new Size(178, 244);
            lboxKisiler.TabIndex = 11;
            lboxKisiler.SelectedIndexChanged += lboxKisiler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 14;
            label2.Text = "Ara : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 13;
            label1.Text = "Yönetici Ekranı";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAra);
            Controls.Add(lvAdresler);
            Controls.Add(lboxKisiler);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
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
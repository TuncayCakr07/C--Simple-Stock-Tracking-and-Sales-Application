namespace Satis_Takip
{
    partial class frmÜrünListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜrünListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGUNCELLE = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Satıştxt = new System.Windows.Forms.TextBox();
            this.Alıştxt = new System.Windows.Forms.TextBox();
            this.Miktartxt = new System.Windows.Forms.TextBox();
            this.Ürünadtxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.Barkodtxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txtBarkodnoAra = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarkaDüzenle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGUNCELLE
            // 
            this.btnGUNCELLE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGUNCELLE.BackgroundImage")));
            this.btnGUNCELLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGUNCELLE.FlatAppearance.BorderSize = 0;
            this.btnGUNCELLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUNCELLE.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGUNCELLE.Location = new System.Drawing.Point(108, 382);
            this.btnGUNCELLE.Name = "btnGUNCELLE";
            this.btnGUNCELLE.Size = new System.Drawing.Size(57, 49);
            this.btnGUNCELLE.TabIndex = 36;
            this.btnGUNCELLE.UseVisualStyleBackColor = true;
            this.btnGUNCELLE.Click += new System.EventHandler(this.btnGUNCELLE_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Satış Fiyatı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(2, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Alış Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(23, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Miktarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(14, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Ürün Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(23, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "Marka:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(14, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 38;
            this.label13.Text = "Kategori:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(2, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 18);
            this.label14.TabIndex = 37;
            this.label14.Text = "Barkod No:";
            // 
            // Satıştxt
            // 
            this.Satıştxt.Location = new System.Drawing.Point(99, 341);
            this.Satıştxt.Name = "Satıştxt";
            this.Satıştxt.Size = new System.Drawing.Size(163, 23);
            this.Satıştxt.TabIndex = 35;
            // 
            // Alıştxt
            // 
            this.Alıştxt.Location = new System.Drawing.Point(99, 300);
            this.Alıştxt.Name = "Alıştxt";
            this.Alıştxt.Size = new System.Drawing.Size(163, 23);
            this.Alıştxt.TabIndex = 34;
            // 
            // Miktartxt
            // 
            this.Miktartxt.Location = new System.Drawing.Point(99, 255);
            this.Miktartxt.Name = "Miktartxt";
            this.Miktartxt.Size = new System.Drawing.Size(163, 23);
            this.Miktartxt.TabIndex = 33;
            // 
            // Ürünadtxt
            // 
            this.Ürünadtxt.Location = new System.Drawing.Point(99, 212);
            this.Ürünadtxt.Name = "Ürünadtxt";
            this.Ürünadtxt.Size = new System.Drawing.Size(163, 23);
            this.Ürünadtxt.TabIndex = 32;
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(99, 169);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(163, 23);
            this.Markatxt.TabIndex = 31;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(99, 130);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(163, 23);
            this.Kategoritxt.TabIndex = 30;
            // 
            // Barkodtxt
            // 
            this.Barkodtxt.Location = new System.Drawing.Point(99, 92);
            this.Barkodtxt.Name = "Barkodtxt";
            this.Barkodtxt.Size = new System.Drawing.Size(163, 23);
            this.Barkodtxt.TabIndex = 29;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(719, 473);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(53, 52);
            this.btnSil.TabIndex = 44;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(552, 47);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(220, 23);
            this.txtbarkodno.TabIndex = 45;
            this.txtbarkodno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBarkodnoAra
            // 
            this.txtBarkodnoAra.AutoSize = true;
            this.txtBarkodnoAra.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodnoAra.Location = new System.Drawing.Point(315, 48);
            this.txtBarkodnoAra.Name = "txtBarkodnoAra";
            this.txtBarkodnoAra.Size = new System.Drawing.Size(231, 18);
            this.txtBarkodnoAra.TabIndex = 46;
            this.txtBarkodnoAra.Text = "Barkod Numarasına Göre Ara:";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(415, 472);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(163, 24);
            this.comboKategori.TabIndex = 47;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(415, 507);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(163, 24);
            this.comboMarka.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(349, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(339, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Kategori:";
            // 
            // btnMarkaDüzenle
            // 
            this.btnMarkaDüzenle.FlatAppearance.BorderSize = 0;
            this.btnMarkaDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaDüzenle.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkaDüzenle.Image")));
            this.btnMarkaDüzenle.Location = new System.Drawing.Point(609, 467);
            this.btnMarkaDüzenle.Name = "btnMarkaDüzenle";
            this.btnMarkaDüzenle.Size = new System.Drawing.Size(70, 58);
            this.btnMarkaDüzenle.TabIndex = 51;
            this.btnMarkaDüzenle.UseVisualStyleBackColor = true;
            this.btnMarkaDüzenle.Click += new System.EventHandler(this.btnMarkaDüzenle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "GÜNCELLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(607, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "DÜZENLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(731, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "SİL";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(778, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 48);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmÜrünListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMarkaDüzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.txtBarkodnoAra);
            this.Controls.Add(this.txtbarkodno);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGUNCELLE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Satıştxt);
            this.Controls.Add(this.Alıştxt);
            this.Controls.Add(this.Miktartxt);
            this.Controls.Add(this.Ürünadtxt);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.Barkodtxt);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmÜrünListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.frmÜrünListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGUNCELLE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Satıştxt;
        private System.Windows.Forms.TextBox Alıştxt;
        private System.Windows.Forms.TextBox Miktartxt;
        private System.Windows.Forms.TextBox Ürünadtxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Barkodtxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Label txtBarkodnoAra;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarkaDüzenle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
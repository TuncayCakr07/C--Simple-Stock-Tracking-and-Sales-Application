namespace Satis_Takip
{
    partial class Satis_Takip
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis_Takip));
            this.dataGridViewsatis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunMktar = new System.Windows.Forms.TextBox();
            this.txtUrunad = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.btnSatışyap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGeneltoplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnSatışlarıListele = new System.Windows.Forms.Button();
            this.btnÜrünListesi = new System.Windows.Forms.Button();
            this.btnÜrünekle = new System.Windows.Forms.Button();
            this.btnMüşteriListesi = new System.Windows.Forms.Button();
            this.btnMüşteriEkle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewsatis
            // 
            this.dataGridViewsatis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewsatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsatis.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewsatis.Location = new System.Drawing.Point(314, 141);
            this.dataGridViewsatis.Name = "dataGridViewsatis";
            this.dataGridViewsatis.ReadOnly = true;
            this.dataGridViewsatis.RowHeadersWidth = 51;
            this.dataGridViewsatis.RowTemplate.Height = 24;
            this.dataGridViewsatis.Size = new System.Drawing.Size(954, 391);
            this.dataGridViewsatis.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdsoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(46, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC NO";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(106, 113);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 26);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdsoyad.Location = new System.Drawing.Point(106, 72);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(100, 26);
            this.txtAdsoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(106, 31);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 30);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSatisFiyat);
            this.groupBox2.Controls.Add(this.txtUrunMktar);
            this.groupBox2.Controls.Add(this.txtUrunad);
            this.groupBox2.Controls.Add(this.txtBarkod);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(46, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Toplam Fiyat";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(106, 170);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 28);
            this.txtToplamFiyat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ürün Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barkod No";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(106, 136);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 28);
            this.txtSatisFiyat.TabIndex = 6;
            this.txtSatisFiyat.TextChanged += new System.EventHandler(this.txtSatisFiyat_TextChanged);
            // 
            // txtUrunMktar
            // 
            this.txtUrunMktar.Location = new System.Drawing.Point(106, 102);
            this.txtUrunMktar.Name = "txtUrunMktar";
            this.txtUrunMktar.Size = new System.Drawing.Size(100, 28);
            this.txtUrunMktar.TabIndex = 5;
            this.txtUrunMktar.Text = "1";
            this.txtUrunMktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUrunMktar.TextChanged += new System.EventHandler(this.txtUrunMktar_TextChanged);
            // 
            // txtUrunad
            // 
            this.txtUrunad.Location = new System.Drawing.Point(106, 68);
            this.txtUrunad.Name = "txtUrunad";
            this.txtUrunad.Size = new System.Drawing.Size(100, 28);
            this.txtUrunad.TabIndex = 4;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(106, 33);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 28);
            this.txtBarkod.TabIndex = 3;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(160, 556);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(73, 56);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(1286, 141);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 53);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.FlatAppearance.BorderSize = 0;
            this.btnSatışİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışİptal.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışİptal.ForeColor = System.Drawing.Color.Black;
            this.btnSatışİptal.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışİptal.Image")));
            this.btnSatışİptal.Location = new System.Drawing.Point(1286, 267);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(64, 62);
            this.btnSatışİptal.TabIndex = 5;
            this.btnSatışİptal.UseVisualStyleBackColor = true;
            this.btnSatışİptal.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // btnSatışyap
            // 
            this.btnSatışyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSatışyap.BackgroundImage")));
            this.btnSatışyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSatışyap.FlatAppearance.BorderSize = 0;
            this.btnSatışyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışyap.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışyap.ForeColor = System.Drawing.Color.Black;
            this.btnSatışyap.Location = new System.Drawing.Point(1047, 545);
            this.btnSatışyap.Name = "btnSatışyap";
            this.btnSatışyap.Size = new System.Drawing.Size(61, 67);
            this.btnSatışyap.TabIndex = 6;
            this.btnSatışyap.UseVisualStyleBackColor = true;
            this.btnSatışyap.Click += new System.EventHandler(this.btnSatışyap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(749, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "GENEL TOPLAM:";
            // 
            // lblGeneltoplam
            // 
            this.lblGeneltoplam.AutoSize = true;
            this.lblGeneltoplam.BackColor = System.Drawing.Color.White;
            this.lblGeneltoplam.ForeColor = System.Drawing.Color.Black;
            this.lblGeneltoplam.Location = new System.Drawing.Point(896, 561);
            this.lblGeneltoplam.Name = "lblGeneltoplam";
            this.lblGeneltoplam.Size = new System.Drawing.Size(0, 16);
            this.lblGeneltoplam.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnSatışlarıListele);
            this.panel1.Controls.Add(this.btnÜrünListesi);
            this.panel1.Controls.Add(this.btnÜrünekle);
            this.panel1.Controls.Add(this.btnMüşteriListesi);
            this.panel1.Controls.Add(this.btnMüşteriEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 65);
            this.panel1.TabIndex = 10;
            // 
            // btnKategori
            // 
            this.btnKategori.FlatAppearance.BorderSize = 0;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKategori.Image = ((System.Drawing.Image)(resources.GetObject("btnKategori.Image")));
            this.btnKategori.Location = new System.Drawing.Point(1050, 4);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(71, 59);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.FlatAppearance.BorderSize = 0;
            this.btnMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarka.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMarka.Image = ((System.Drawing.Image)(resources.GetObject("btnMarka.Image")));
            this.btnMarka.Location = new System.Drawing.Point(914, 1);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(71, 58);
            this.btnMarka.TabIndex = 5;
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatışlarıListele
            // 
            this.btnSatışlarıListele.FlatAppearance.BorderSize = 0;
            this.btnSatışlarıListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışlarıListele.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışlarıListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSatışlarıListele.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışlarıListele.Image")));
            this.btnSatışlarıListele.Location = new System.Drawing.Point(735, 4);
            this.btnSatışlarıListele.Name = "btnSatışlarıListele";
            this.btnSatışlarıListele.Size = new System.Drawing.Size(71, 52);
            this.btnSatışlarıListele.TabIndex = 4;
            this.btnSatışlarıListele.UseVisualStyleBackColor = true;
            this.btnSatışlarıListele.Click += new System.EventHandler(this.btnSatışlarıListele_Click);
            // 
            // btnÜrünListesi
            // 
            this.btnÜrünListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnÜrünListesi.BackgroundImage")));
            this.btnÜrünListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnÜrünListesi.FlatAppearance.BorderSize = 0;
            this.btnÜrünListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünListesi.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜrünListesi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnÜrünListesi.Location = new System.Drawing.Point(610, 4);
            this.btnÜrünListesi.Name = "btnÜrünListesi";
            this.btnÜrünListesi.Size = new System.Drawing.Size(59, 55);
            this.btnÜrünListesi.TabIndex = 3;
            this.btnÜrünListesi.UseVisualStyleBackColor = true;
            this.btnÜrünListesi.Click += new System.EventHandler(this.btnÜrünListesi_Click);
            // 
            // btnÜrünekle
            // 
            this.btnÜrünekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnÜrünekle.FlatAppearance.BorderSize = 0;
            this.btnÜrünekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünekle.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜrünekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnÜrünekle.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrünekle.Image")));
            this.btnÜrünekle.Location = new System.Drawing.Point(479, 5);
            this.btnÜrünekle.Name = "btnÜrünekle";
            this.btnÜrünekle.Size = new System.Drawing.Size(71, 56);
            this.btnÜrünekle.TabIndex = 2;
            this.btnÜrünekle.UseVisualStyleBackColor = true;
            this.btnÜrünekle.Click += new System.EventHandler(this.btnÜrünekle_Click);
            // 
            // btnMüşteriListesi
            // 
            this.btnMüşteriListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMüşteriListesi.BackgroundImage")));
            this.btnMüşteriListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMüşteriListesi.FlatAppearance.BorderSize = 0;
            this.btnMüşteriListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüşteriListesi.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriListesi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMüşteriListesi.Location = new System.Drawing.Point(345, 5);
            this.btnMüşteriListesi.Name = "btnMüşteriListesi";
            this.btnMüşteriListesi.Size = new System.Drawing.Size(71, 56);
            this.btnMüşteriListesi.TabIndex = 1;
            this.btnMüşteriListesi.UseVisualStyleBackColor = true;
            this.btnMüşteriListesi.Click += new System.EventHandler(this.btnMüşteriListesi_Click);
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMüşteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüşteriEkle.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMüşteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMüşteriEkle.Image")));
            this.btnMüşteriEkle.Location = new System.Drawing.Point(224, 3);
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(71, 59);
            this.btnMüşteriEkle.TabIndex = 0;
            this.btnMüşteriEkle.UseVisualStyleBackColor = true;
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(192, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "MÜŞTERİ EKLE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(326, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "MÜŞTERİ LİSTESİ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(476, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "ÜRÜN EKLE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(596, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "ÜRÜN LİSTESİ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(732, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "SATIŞ LİSTESİ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(911, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 15;
            this.label15.Text = "MARKA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(1044, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 16;
            this.label16.Text = "KATEGORİ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(172, 615);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "EKLE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(1044, 615);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 18);
            this.label18.TabIndex = 18;
            this.label18.Text = "SATIŞ YAP";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(1297, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 18);
            this.label19.TabIndex = 19;
            this.label19.Text = "SİL";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(1283, 332);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 18);
            this.label20.TabIndex = 20;
            this.label20.Text = "SATIŞ İPTAL";
            // 
            // Satis_Takip
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1435, 653);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGeneltoplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSatışyap);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewsatis);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satis_Takip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Takip";
            this.Load += new System.EventHandler(this.Satis_Takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtUrunMktar;
        private System.Windows.Forms.TextBox txtUrunad;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Button btnSatışyap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGeneltoplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatışlarıListele;
        private System.Windows.Forms.Button btnÜrünListesi;
        private System.Windows.Forms.Button btnÜrünekle;
        private System.Windows.Forms.Button btnMüşteriListesi;
        private System.Windows.Forms.Button btnMüşteriEkle;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}


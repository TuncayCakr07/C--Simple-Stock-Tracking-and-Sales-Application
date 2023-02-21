using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Satis_Takip
{
    public partial class frmÜrünekle : Form
    {
        public frmÜrünekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=SatisTakip;Integrated Security=True");
        private bool Durum;
        private void barkodkontrol()
        {
            Durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (Barkodtxt.Text == read["barkodno"].ToString() || Barkodtxt.Text=="")
                {
                    Durum = false;
                }
            }
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmÜrünekle_Load(object sender, EventArgs e)
        {
               kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+comboKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {

            
          
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktar,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAd.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlış.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatış.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
           
            comboMarka.Items.Clear();
            foreach  (Control item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)    
                {
                    item.Text = "";
                }
                if (item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void Barkodtxt_TextChanged(object sender, EventArgs e)
        {
            if (Barkodtxt.Text=="")
            {
                lblmiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '"+Barkodtxt.Text+"'",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                Ürünadtxt.Text = read["urunadi"].ToString();
                lblmiktar.Text = read["miktar"].ToString();
                 Alıştxt.Text = read["alisfiyati"].ToString();
                Satıştxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnGUNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktar=miktar+'" + int.Parse(Miktartxt.Text) + "'where barkodno='" + Barkodtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

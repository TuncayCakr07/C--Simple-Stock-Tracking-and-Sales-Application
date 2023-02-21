using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis_Takip
{
    public partial class Satis_Takip : Form
    {
        public Satis_Takip()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=SatisTakip;Integrated Security=True");
        DataSet Daset=new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from sepet",baglanti);
            adptr.Fill(Daset,"sepet");
            dataGridViewsatis.DataSource = Daset.Tables["sepet"];
            baglanti.Close();
        }


        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            frmMüşteriEkleme ekle= new frmMüşteriEkleme();
            ekle.ShowDialog();
        }

        private void btnMüşteriListesi_Click(object sender, EventArgs e)
        {
            frmMüşteriListesi liste= new frmMüşteriListesi();
            liste.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGeneltoplam.Text=komut.ExecuteScalar()+"TL";
                baglanti.Close();
            
            }
            catch (Exception)
            {

                ;
            }
        }
        private void Satis_Takip_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }
        bool durum;
        private void barkodkontrol()
        {
            durum= true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkod.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyati,@toplamfiyati,@tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunad.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtUrunMktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati",double.Parse(txtSatisFiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyati",double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktar=miktar+'"+int.Parse(txtUrunMktar.Text)+ "' where barkodno='"+txtBarkod.Text+"'", baglanti);
                 komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=miktar*satisfiyati where barkodno='"+txtBarkod.Text+"'",baglanti);   
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            txtUrunMktar.Text = "1";
            Daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtUrunMktar)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void btnÜrünekle_Click(object sender, EventArgs e)
        {
            frmÜrünekle ekle=new frmÜrünekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmkategori kategori= new frmkategori();
             kategori.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka=new frmMarka();
            marka.ShowDialog();
        }

        private void btnÜrünListesi_Click(object sender, EventArgs e)
        {
            frmÜrünListesi liste=new frmÜrünListesi();
            liste.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text=="")
            {
                txtAdsoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select * from Müşteri where tc like '"+txtTc.Text+"'",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                txtAdsoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + txtBarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunad.Text = read["urunadi"].ToString();
                txtSatisFiyat.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtUrunMktar)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void txtUrunMktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtUrunMktar.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatisFiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtUrunMktar.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridViewsatis.CurrentRow.Cells["barkodno"].Value.ToString() +"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
          
            MessageBox.Show("Satış İptal Edilsin mi?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void btnSatışlarıListele_Click(object sender, EventArgs e)
        {
            frmSatisListesi satislistesi= new frmSatisListesi();
            satislistesi.ShowDialog();
        }

        private void btnSatışyap_Click(object sender, EventArgs e)
        {
            for (int i= 0; i < dataGridViewsatis.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyati,@toplamfiyati,@tarih) ", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridViewsatis.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridViewsatis.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktar", int.Parse(dataGridViewsatis.Rows[i].Cells["miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridViewsatis.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridViewsatis.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktar=miktar-'" + int.Parse(dataGridViewsatis.Rows[i].Cells["miktar"].Value.ToString()) + "'where barkodno='" + dataGridViewsatis.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                
                
               
            }
            baglanti.Open();
            SqlCommand komut3= new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Tamamlansın Mı?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from kullanici where id", baglanti);
        }
    }
}

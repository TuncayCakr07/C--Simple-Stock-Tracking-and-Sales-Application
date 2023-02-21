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

namespace Satis_Takip
{
    public partial class frmÜrünListesi : Form
    {
        public frmÜrünListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=SatisTakip;Integrated Security=True");
        DataSet Daset=new DataSet();
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
        private void frmÜrünListesi_Load(object sender, EventArgs e)
        {
            Ürünlistele();
            kategorigetir();
        }

        private void Ürünlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(Daset, "urun");
            dataGridView1.DataSource = Daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Barkodtxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            Ürünadtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktartxt.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            Alıştxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            Satıştxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGUNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktar=@miktar,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@barkodno",Barkodtxt.Text);
            komut.Parameters.AddWithValue("@urunadi", Ürünadtxt.Text);
            komut.Parameters.AddWithValue("@miktar",int.Parse(Miktartxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati",double.Parse(Alıştxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(Satıştxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            Daset.Tables["urun"].Clear();
            Ürünlistele();
            MessageBox.Show("Ürün Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaDüzenle_Click(object sender, EventArgs e)
        {
            if (Barkodtxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", Barkodtxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori ve Marka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Daset.Tables["urun"].Clear();
                Ürünlistele();
            }
            else
            {
                MessageBox.Show("Ürün Bulunmaktadır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Daset.Tables["urun"].Clear();
            Ürünlistele();
            MessageBox.Show("Kayıt Silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtbarkodno.Text + "%'", baglanti);
            adptr.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
            baglanti.Close();
        }
    }
}

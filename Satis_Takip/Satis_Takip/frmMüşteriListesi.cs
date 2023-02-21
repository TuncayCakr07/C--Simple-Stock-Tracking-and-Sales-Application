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
    public partial class frmMüşteriListesi : Form
    {
        public frmMüşteriListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=SatisTakip;Integrated Security=True");
        DataSet satisdata= new DataSet();
        private void frmMüşteriListesi_Load(object sender, EventArgs e)
        {
             Kayit_listele();

        }

        private void Kayit_listele()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from müşteri", baglanti);
            adptr.Fill(satisdata, "müşteri");
            dataGridView1.DataSource = satisdata.Tables["müşteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtAdsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            satisdata.Tables["müşteri"].Clear();
            Kayit_listele();
            MessageBox.Show("Müşteri Kaydı Güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() +"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            satisdata.Tables["müşteri"].Clear();
            Kayit_listele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable Tablo=new DataTable();
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from müşteri where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adptr.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
            baglanti.Close();
        }
    }
}

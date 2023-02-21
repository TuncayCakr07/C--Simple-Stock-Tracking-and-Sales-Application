using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Satis_Takip
{
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=SatisTakip;Integrated Security=True");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() || textBox1.Text=="")
                {   
                    durum= false;
                }
            }
            baglanti.Close();
        }
        private void frmkategori_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + textBox1.Text + "') ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
               
                MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mevcut Olan Kategori Eklenemez","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            textBox1.Text = "";

        }
    }
}

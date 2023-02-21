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
    public partial class frmSatisListesi : Form
    {
        public frmSatisListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=SatisTakip;Integrated Security=True");
        DataSet Daset = new DataSet();
       
        private void Satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from satis", baglanti);
            adptr.Fill(Daset, "satis");
            dataGridViewsatislistesi.DataSource = Daset.Tables["satis"];
            baglanti.Close();
        }
        private void frmSatisListesi_Load(object sender, EventArgs e)
        {
           Satislistele();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace Emlak_Kayıt_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan=new SqlConnection("Data Source=ATES\\SQLEXPRESS;Initial Catalog=SİTELER;Integrated Security=True");

        private void cmbSıte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSıte.Text == "ELİTKENT")
            {
                btnElit.BackColor = Color.Blue;
                btnKardelen.BackColor = Color.Yellow;
                btnNatura.BackColor = Color.Yellow;
                btnDoga.BackColor = Color.Yellow;
            }
            if (cmbSıte.Text == "KARDELEN")
            {
                btnElit.BackColor = Color.Yellow;
                btnKardelen.BackColor = Color.Blue;
                btnNatura.BackColor = Color.Yellow;
                btnDoga.BackColor = Color.Yellow;
            }
            if (cmbSıte.Text == "DOĞAŞEHİR")
            {
                btnElit.BackColor = Color.Yellow;
                btnKardelen.BackColor = Color.Yellow;
                btnNatura.BackColor = Color.Yellow;
                btnDoga.BackColor = Color.Blue;
            }
            if (cmbSıte.Text == "NATURA")
            {
                btnElit.BackColor = Color.Yellow;
                btnKardelen.BackColor = Color.Yellow;
                btnNatura.BackColor = Color.Blue;
                btnDoga.BackColor = Color.Yellow;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from Site", baglan);
            SqlDataAdapter da= new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Site(SITE,SAT_KIRA,METREKARE,ODA_SAYISI,FIYAT,BLOK,NO,AD_SOYAD,TELEFON,NOT) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglan);
            komut.Parameters.AddWithValue("@p1", cmbSıte.Text);
            komut.Parameters.AddWithValue("@p2", cmbSat.Text);
            komut.Parameters.AddWithValue("@p3", txtMetre.Text);
            komut.Parameters.AddWithValue("@p4", cmbOda.Text);
            komut.Parameters.AddWithValue("@p5", txtFıyat.Text);
            komut.Parameters.AddWithValue("@p6", cmbBlok.Text);
            komut.Parameters.AddWithValue("@p7", txtNo.Text);
            komut.Parameters.AddWithValue("@p8", txtAd.Text);
            komut.Parameters.AddWithValue("@p9", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p10", txtNot.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kaydetme işlemi tamamlandı");
        }
    }
}

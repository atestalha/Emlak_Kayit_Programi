using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Emlak_Kayıt_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "admin" && txtSıfre.Text == "1234")
            {
                Form2 emlak = new Form2();
                emlak.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA SIFRENIZ HATALI LÜTFEN TEKRAR DENEYİNİZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

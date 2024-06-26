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

namespace KutuphaneOtomasyonWinForm
{
    public partial class Form1 : Form
    {
        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            var personel = db.Personeller.Where(x=>x.personel_ad.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();
            
            if(personel == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }

            else
            {
                MessageBox.Show("Giriş Başarılı");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
            
            
        }
    }
}

using KutuphaneOtomasyonWinForm.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible=false;
            güncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                güncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
               
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                güncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;

            }
           
            
            KullaniciListeForm kListeForm = new KullaniciListeForm();
            kListeForm.MdiParent = this;
            kListeForm.Show();
            
            
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleFormu ekleFormu = new KullaniciEkleFormu();
            ekleFormu.MdiParent = this;
            ekleFormu.Show();
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kSil = new KullaniciSilForm();
            kSil.MdiParent = this;
            kSil.Show();
        }
    }
}

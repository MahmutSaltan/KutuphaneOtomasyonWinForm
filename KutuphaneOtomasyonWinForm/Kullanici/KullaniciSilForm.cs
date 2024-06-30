using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kullanici
{
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }
        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();
        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            var kullanici = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanici.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seçilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x=>x.kullanici_id==seçilenId).FirstOrDefault(); 
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            dataGridView1.DataSource = db.Kullanicilar.ToList();
        }
    }
}

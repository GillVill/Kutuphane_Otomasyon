using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KutuphaneOtomasyon
{
    public partial class YazarEkle : DevExpress.XtraEditors.XtraForm
    {
        public YazarEkle()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yeniYazar = new Yazar();
            yeniYazar.Ad = txtYazarAdi.Text;
            yeniYazar.Soyad = txtYazarSoyadi.Text;

            ef.Yazars.Add(yeniYazar);
            ef.SaveChanges();

            MessageBox.Show(txtYazarAdi.Text + " " + txtYazarSoyadi.Text + " yazar listesine eklendi", "Yeni Yazar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AlanlariTemizle();
        }

        private void AlanlariTemizle()
        {
            txtYazarAdi.ResetText();
            txtYazarSoyadi.ResetText();
        }
    }
}
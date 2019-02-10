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
    public partial class KategoriEkle : DevExpress.XtraEditors.XtraForm
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Kategori yeniKategori = new Kategori();
            yeniKategori.KategoriAdi = txtKategoriAdi.Text;

            ef.Kategoris.Add(yeniKategori);
            ef.SaveChanges();

            MessageBox.Show(yeniKategori.KategoriAdi + " kategorisi eklendi", "Yeni Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AlanlariTemizle();
        }

        private void AlanlariTemizle()
        {
            txtKategoriAdi.ResetText();
        }
    }
}
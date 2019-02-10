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
    public partial class KitapAramaSonuc : DevExpress.XtraEditors.XtraForm
    {
        public KitapAramaSonuc()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        List<Kitap> kitapSonucListesi;
        private void KitapAramaSonuc_Load(object sender, EventArgs e)
        {
            GridDoldur();
            AltBilgiGetir();
        }
        private void GridDoldur()
        {
            foreach (Kitap kitap in kitapSonucListesi)
                dgvKitapSonucListesi.Rows.Add(kitap.KitapAdi, kitap.ISBNNo, kitap.Yazar.Ad + " " + kitap.Yazar.Soyad, 
                    kitap.Kategori.KategoriAdi, kitap.SayfaSayisi, kitap.Durum, kitap.RafNo);

            for (int i = 0; i < dgvKitapSonucListesi.ColumnCount; i++)
                dgvKitapSonucListesi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvKitapSonucListesi.Columns[dgvKitapSonucListesi.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
        }
        public void KitapSonuclariGetir(List<Kitap> sonucListesi)
        {
            this.kitapSonucListesi = sonucListesi;
        }
        private void AltBilgiGetir()
        {
            lblToplamKitapSayisi.Text = kitapSonucListesi.Count.ToString();
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void dgvKitapSonucListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string seciliISBN = dgvKitapSonucListesi.CurrentRow.Cells[1].Value.ToString();
            Kitap secilenKitap = ef.Kitaps.Where(k => k.ISBNNo == seciliISBN).FirstOrDefault();

            KitapDetay kitapDetayEkrani = new KitapDetay();
            kitapDetayEkrani.SeciliKitap(secilenKitap);
            kitapDetayEkrani.ShowDialog();
        }
    }
}
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
    public partial class YazarListesi : DevExpress.XtraEditors.XtraForm
    {
        public YazarListesi()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void YazarListesiGetir()
        {
            var yazarListesi = ef.Yazars.Select(y => new
            {
                y.Id,
                y.Ad,
                y.Soyad,
                KitapSayisi = ef.Kitaps.Where(k => k.YazarNo == y.Id).Count()
            }).Where(y => (y.Ad + " " + y.Soyad).Contains(txtYazarAra.Text)).ToList();

            dgvYazarlar.DataSource = yazarListesi;
            dgvYazarlar.Invalidate();

            for (int i = 0; i < dgvYazarlar.ColumnCount - 1; i++)
                dgvYazarlar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvYazarlar.Columns[dgvYazarlar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //foreach (var yazarlar in ef.Yazars.ToList())
            //{
            //    int kitapSayisi = ef.Kitaps.Where(k => k.YazarNo == yazarlar.Id).Count();
            //    dgvYazarlar.Rows.Add(yazarlar.Id, yazarlar.Ad, yazarlar.Soyad, kitapSayisi);
            //}
            ////dgvYazarlar.DataSource = ef.Yazars.ToList();
            ////dgvYazarlar.Columns["Kitaps"].Visible = false;

            //for (int i = 0; i < dgvYazarlar.ColumnCount-1; i++)
            //    dgvYazarlar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvYazarlar.Columns[dgvYazarlar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void YazarListesi_Load(object sender, EventArgs e)
        {
            YazarListesiGetir();
            lblYazarSayisi.Text = ef.Yazars.Count().ToString();
        }

        private void dgvYazarlar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            YazarDetayGetir(Convert.ToInt32(dgvYazarlar.CurrentRow.Cells[0].Value));
        }

        private void YazarDetayGetir(int id)
        {
            AlanlariTemizle();

            Yazar seciliYazar = ef.Yazars.Where(y => y.Id == id).FirstOrDefault();
            var kitapListesi = ef.Kitaps.Where(k => k.YazarNo == id).ToList();

            txtYazarAdi.Text = seciliYazar.Ad;
            txtYazarSoyadi.Text = seciliYazar.Soyad;

            foreach (var kitap in kitapListesi)
                lstKitapListesi.Items.Add(kitap.KitapAdi);

            lblToplamKitap.Text = ef.Kitaps.Where(k => k.YazarNo == id).Count().ToString();
        }

        private void AlanlariTemizle()
        {
            txtYazarAdi.ResetText();
            txtYazarSoyadi.ResetText();
            lstKitapListesi.Items.Clear();
        }

        private void txtYazarAra_TextChanged(object sender, EventArgs e)
        {
            var yazarListesi = ef.Yazars.Select(y => new
            {
                y.Id,
                y.Ad,
                y.Soyad,
                KitapSayisi = ef.Kitaps.Where(k => k.YazarNo == y.Id).Count()
            }).Where(y => (y.Ad + " " + y.Soyad).Contains(txtYazarAra.Text)).ToList();

            dgvYazarlar.DataSource = yazarListesi;
            dgvYazarlar.Invalidate();

            for (int i = 0; i < dgvYazarlar.ColumnCount - 1; i++)
                dgvYazarlar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvYazarlar.Columns[dgvYazarlar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void lstKitapListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitap seciliKitap = ef.Kitaps.Where(k => k.KitapAdi == lstKitapListesi.SelectedItem.ToString()).FirstOrDefault();

            KitapDetay kitapDetay = new KitapDetay();
            kitapDetay.SeciliKitap(seciliKitap);
            kitapDetay.ShowDialog();
        }
    }
}
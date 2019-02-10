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
    public partial class KitapListesi : DevExpress.XtraEditors.XtraForm
    {
        public KitapListesi()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void KitapListesi_Load(object sender, EventArgs e)
        {
            KategoriGetir();
            KitapListesiGetir();
        }
        private void KitapListesiGetir()
        {
            var kitapListesi = ef.Kitaps.Select(k => new
            {
                k.KitapId,
                k.ISBNNo,
                k.KitapAdi,
                Yazar = k.Yazar.Ad + " " + k.Yazar.Soyad,
                Kategori = k.Kategori.KategoriAdi,
                k.SayfaSayisi,
                k.Aciklama
            }).ToList();

            dgvKitaplar.DataSource = kitapListesi;
            dgvKitaplar.Invalidate();

            //DataGridViewe eklenecek elemanları düzgün bir şekilde eklemek ve datagridview'un kaymasını engellemek için kullanılan trick.
            for (int i = 0; i < dgvKitaplar.ColumnCount - 1; i++)
                dgvKitaplar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKitaplar.Columns[dgvKitaplar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void KategoriGetir()
        {
            cbKategori.DataSource = ef.Kategoris.Select(c=>c.KategoriAdi).ToList();
            cbKategori.Invalidate();
        }
        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kitapListesi = ef.Kitaps.Select(k => new
            {
                k.KitapId,
                k.ISBNNo,
                k.KitapAdi,
                Yazar = k.Yazar.Ad + " " + k.Yazar.Soyad,
                Kategori = k.Kategori.KategoriAdi,
                k.SayfaSayisi,
                k.Aciklama
            }).Where(k => k.Kategori == cbKategori.Text).ToList();

            dgvKitaplar.DataSource = kitapListesi;
            dgvKitaplar.Invalidate();

            //DataGridViewe eklenecek elemanları düzgün bir şekilde eklemek ve datagridview'un kaymasını engellemek için kullanılan trick.
            for (int i = 0; i < dgvKitaplar.ColumnCount - 1; i++)
                dgvKitaplar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKitaplar.Columns[dgvKitaplar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnKitapAdiAra_Click(object sender, EventArgs e)
        {
            var kitapListesi = ef.Kitaps.Select(k => new
            {
                k.KitapId,
                k.ISBNNo,
                k.KitapAdi,
                Yazar = k.Yazar.Ad + " " + k.Yazar.Soyad,
                Kategori = k.Kategori.KategoriAdi,
                k.SayfaSayisi,
                k.Aciklama
            }).Where(k => k.KitapAdi.Contains(txtKitapAdi.Text)).ToList();

            dgvKitaplar.DataSource = kitapListesi;
            dgvKitaplar.Invalidate();

            //DataGridViewe eklenecek elemanları düzgün bir şekilde eklemek ve datagridview'un kaymasını engellemek için kullanılan trick.
            for (int i = 0; i < dgvKitaplar.ColumnCount - 1; i++)
                dgvKitaplar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKitaplar.Columns[dgvKitaplar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnYazarAra_Click(object sender, EventArgs e)
        {
            var kitapListesi = ef.Kitaps.Select(k => new
            {
                k.KitapId,
                k.ISBNNo,
                k.KitapAdi,
                Yazar = k.Yazar.Ad + " " + k.Yazar.Soyad,
                Kategori = k.Kategori.KategoriAdi,
                k.SayfaSayisi,
                k.Aciklama
            }).Where(k => k.Yazar.Contains(txtYazarAdi.Text)).ToList();

            dgvKitaplar.DataSource = kitapListesi;
            dgvKitaplar.Invalidate();

            //DataGridViewe eklenecek elemanları düzgün bir şekilde eklemek ve datagridview'un kaymasını engellemek için kullanılan trick.
            for (int i = 0; i < dgvKitaplar.ColumnCount - 1; i++)
                dgvKitaplar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKitaplar.Columns[dgvKitaplar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtEtiket_TextChanged(object sender, EventArgs e)
        {
            var kitapListesi = ef.Kitaps.Select(k => new
            {
                k.KitapId,
                k.ISBNNo,
                k.KitapAdi,
                Yazar = k.Yazar.Ad + " " + k.Yazar.Soyad,
                Kategori = k.Kategori.KategoriAdi,
                k.SayfaSayisi,
                k.Aciklama
            }).Where(k => k.Aciklama.Contains(txtEtiket.Text)).ToList();

            dgvKitaplar.DataSource = kitapListesi;
            dgvKitaplar.Invalidate();

            //DataGridViewe eklenecek elemanları düzgün bir şekilde eklemek ve datagridview'un kaymasını engellemek için kullanılan trick.
            for (int i = 0; i < dgvKitaplar.ColumnCount - 1; i++)
                dgvKitaplar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKitaplar.Columns[dgvKitaplar.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvKitaplar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int seciliKitapId = (int)dgvKitaplar.CurrentRow.Cells[0].Value;
            Kitap seciliKitap = ef.Kitaps.Where(k => k.KitapId == seciliKitapId).FirstOrDefault();

            KitapDetay kitapDetayEkrani = new KitapDetay();
            kitapDetayEkrani.SeciliKitap(seciliKitap);
            kitapDetayEkrani.ShowDialog();
        }
    }
}
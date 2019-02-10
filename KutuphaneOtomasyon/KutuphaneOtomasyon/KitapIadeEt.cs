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
    public partial class KitapIadeEt : DevExpress.XtraEditors.XtraForm
    {
        public KitapIadeEt()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        int ogrenciNo;
        int islemId;
        private void KitapIadeEt_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            GridDoldur();
        }

        private void OgrenciListesi()
        {
            cbOgrenciNo.DataSource = ef.Ogrencis.Select(o=>o.OgrenciNo).ToList();
            cbOgrenciNo.Invalidate();
        }

        private void GridDoldur()
        {
            dgvIslemGecmisi.DataSource = null;

            var islemListesi = ef.Islems.Select(i => new
            {
                i.IslemNo,
                Ogrenci = i.Ogrenci.OgrenciAd + " " + i.Ogrenci.OgrenciSoyad,
                i.Kitap.KitapAdi,
                YazarAdı = i.Kitap.Yazar.Ad + " " + i.Kitap.Yazar.Soyad,
                OATarih = i.AlisTarihi,
                TEGTarih = i.VerisTarihi
            }).ToList();

            dgvIslemGecmisi.DataSource = islemListesi;
            dgvIslemGecmisi.Invalidate();

            for (int i = 0; i < dgvIslemGecmisi.ColumnCount - 1; i++)
                dgvIslemGecmisi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIslemGecmisi.Columns[dgvIslemGecmisi.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void cbOgrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvIslemGecmisi.DataSource = null;

            ogrenciNo = Convert.ToInt32(cbOgrenciNo.Text);

            Ogrenci seciliOgrenci = ef.Ogrencis.Where(o => o.OgrenciNo == ogrenciNo).FirstOrDefault();
            txtOgrenciAdi.Text = seciliOgrenci.OgrenciAd;
            txtOgrenciSoyadi.Text = seciliOgrenci.OgrenciSoyad;

            var islemListesiOgrenciNo = ef.Islems.Select(i => new
            {
                i.IslemNo,
                OgrenciNo = i.OgrenciNo,
                Ogrenci = i.Ogrenci.OgrenciAd + " " + i.Ogrenci.OgrenciSoyad,
                i.Kitap.KitapAdi,
                YazarAdı = i.Kitap.Yazar.Ad + " " + i.Kitap.Yazar.Soyad,
                OATarih = i.AlisTarihi,
                TEGTarih = i.VerisTarihi
            }).Where(i => i.OgrenciNo == ogrenciNo).ToList();

            dgvIslemGecmisi.DataSource = islemListesiOgrenciNo;
            dgvIslemGecmisi.Invalidate();
            dgvIslemGecmisi.Columns["IslemNo"].Visible = false;

            for (int i = 0; i < dgvIslemGecmisi.ColumnCount - 1; i++)
                dgvIslemGecmisi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIslemGecmisi.Columns[dgvIslemGecmisi.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            Islem secilenIslem = ef.Islems.Where(i => i.IslemNo == islemId).FirstOrDefault();
            Kitap seciliKitap = ef.Kitaps.Where(k => k.KitapId == secilenIslem.KitapNo).FirstOrDefault();

            DialogResult result = MessageBox.Show(secilenIslem.Ogrenci.OgrenciAd + " " + secilenIslem.Ogrenci.OgrenciSoyad + " adlı öğrenciye ait "
                + secilenIslem.Kitap.KitapAdi + " adlı kitap teslim alınacak? Bu işlemi onaylıyor musunuz?",
                "Teslim Alma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                IslemGecmisi islemGecmis = new IslemGecmisi();
                islemGecmis.OgrenciNo = secilenIslem.OgrenciNo;
                islemGecmis.KitapNo = secilenIslem.KitapNo;
                islemGecmis.AlisTarihi = secilenIslem.AlisTarihi;
                islemGecmis.TeslimTarihi = DateTime.Today;

                seciliKitap.Durum = "Kullanılabilir";

                ef.IslemGecmisis.Add(islemGecmis);
                ef.Islems.Remove(secilenIslem);
                ef.SaveChanges();

                MessageBox.Show("Kitap başarıyla iade edildi", "Kitap Teslim Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
                AlanlariTemizle();
            }
            else
            {
                this.Show();
                AlanlariTemizle();
                GridDoldur();
            }
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            Islem secilenIslem = ef.Islems.Where(i => i.IslemNo == islemId).FirstOrDefault();

            DialogResult result = MessageBox.Show(secilenIslem.Ogrenci.OgrenciAd + " " + secilenIslem.Ogrenci.OgrenciSoyad + " adlı öğrenciye ait "
                + secilenIslem.Kitap.KitapAdi + " adlı kitabın iade süresi 15 gün uzatılacak? Bu işlemi onaylıyor musunuz?",
                "İade Tarihi Uzatma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                secilenIslem.VerisTarihi = DateTime.Today.AddDays(15);
                ef.SaveChanges();

                MessageBox.Show("İade süresi uzatıldı", "İade Tarihi Uzatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
                AlanlariTemizle();
            }
            else
            {
                this.Show();
                GridDoldur();
                AlanlariTemizle();
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            dgvIslemGecmisi.DataSource = null;

            var islemListesiTarih = ef.Islems.Select(i => new
            {
                i.IslemNo,
                Ogrenci = i.Ogrenci.OgrenciAd + " " + i.Ogrenci.OgrenciSoyad,
                i.Kitap.KitapAdi,
                YazarAdı = i.Kitap.Yazar.Ad + " " + i.Kitap.Yazar.Soyad,
                OATarih = i.AlisTarihi,
                TEGTarih = i.VerisTarihi
            }).OrderByDescending(i => i.TEGTarih).ToList();

            dgvIslemGecmisi.DataSource = islemListesiTarih;
            dgvIslemGecmisi.Invalidate();

            for (int i = 0; i < dgvIslemGecmisi.ColumnCount - 1; i++)
                dgvIslemGecmisi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIslemGecmisi.Columns[dgvIslemGecmisi.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvIslemGecmisi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            islemId = Convert.ToInt32(dgvIslemGecmisi.CurrentRow.Cells[0].Value);
            //Islem seciliIslem = ef.Islems.Where(i => i.IslemNo == islemId).FirstOrDefault();

            //KitapIadeDetay kitapIadeDetay = new KitapIadeDetay();
            //kitapIadeDetay.IslemGetir(seciliIslem);
            //kitapIadeDetay.ShowDialog();

            //GridDoldur();
        }

        private void AlanlariTemizle()
        {
            txtOgrenciAdi.Text = "";
            txtOgrenciSoyadi.Text = "";
            cbOgrenciNo.SelectedIndex = 0;
        }
    }
}
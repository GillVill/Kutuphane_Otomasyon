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
    public partial class KitapOduncAl : DevExpress.XtraEditors.XtraForm
    {
        public KitapOduncAl()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        List<KitapOduncAlma> oduncAlinanKitaplarListesi = new List<KitapOduncAlma>();

        int ogrenciNo;
        private void IslemYap_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            KitapListesi();
            GridDoldur();
        }
        private void OgrenciListesi()
        {
            cbOgrenciNo.DataSource = ef.Ogrencis.Select(o => o.OgrenciNo).ToList();
            cbOgrenciNo.Invalidate();
        }
        private void KitapListesi()
        {
            cbKitapAdi.DataSource = ef.Kitaps.Select(k => k.KitapAdi).ToList();
            cbKitapAdi.Invalidate();
        }
        private void GridDoldur()
        {
            var islemListesi = ef.Islems.Select(i => new
            {
                Ogrenci = i.Ogrenci.OgrenciAd + " " + i.Ogrenci.OgrenciSoyad,
                i.Kitap.KitapAdi,
                YazarAdı = i.Kitap.Yazar.Ad + " " + i.Kitap.Yazar.Soyad,
                OATarih = i.AlisTarihi,
                TEGTarih = i.VerisTarihi
            }).OrderByDescending(i => i.TEGTarih).ToList();

            dgvIslemGecmisi.DataSource = islemListesi;
            dgvIslemGecmisi.Invalidate();

            for (int i = 0; i < dgvIslemGecmisi.ColumnCount; i++)
                dgvIslemGecmisi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIslemGecmisi.Columns[dgvIslemGecmisi.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void cbOgrenciNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogrenciNo = Convert.ToInt32(cbOgrenciNo.Text);
            Ogrenci secilenOgrenci = ef.Ogrencis.Where(o => o.OgrenciNo == ogrenciNo).FirstOrDefault();

            txtOgrenciAdi.Text = secilenOgrenci.OgrenciAd;
            txtOgrenciSoyadi.Text = secilenOgrenci.OgrenciSoyad;
            txtOgrenciSinif.Text = secilenOgrenci.Sinif;
        }
        private void cbKitapAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitap secilenKitap = ef.Kitaps.Where(k => k.KitapAdi == cbKitapAdi.Text).FirstOrDefault();
            Yazar secilenYazar = ef.Yazars.Where(y => y.Id == secilenKitap.YazarNo).FirstOrDefault();
            txtYazarAdi.Text = secilenYazar.Ad + " " + secilenYazar.Soyad;
        }
        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            Islem oduncAlma = new Islem();
            Kitap secilenKitap = ef.Kitaps.Where(k => k.KitapAdi == cbKitapAdi.Text).FirstOrDefault();

            if(secilenKitap.Durum.Equals("Kullanılabilir", StringComparison.InvariantCultureIgnoreCase))
            {
                if (ef.Islems.Where(i => i.OgrenciNo == ogrenciNo).Count() < 3)
                {
                    oduncAlma.OgrenciNo = Convert.ToInt32(cbOgrenciNo.Text);
                    oduncAlma.KitapNo = secilenKitap.KitapId;
                    oduncAlma.AlisTarihi = (DateTime)dtAlisTarihi.EditValue;
                    oduncAlma.VerisTarihi = (DateTime)dtTeslimTarihi.EditValue;

                    secilenKitap.Durum = "Ödünç Verildi";

                    ef.Islems.Add(oduncAlma);
                    ef.SaveChanges();

                    MessageBox.Show(cbKitapAdi.Text + " " + txtOgrenciAdi.Text + " " + txtOgrenciSoyadi.Text + " adlı öğrenciye ödünç verildi", "Ödünç Verme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    GridDoldur();
                    AlanlariTemizle();
                }
                else
                {
                    MessageBox.Show("Bir öğrenci 15 gün içerisinde maksimum 3 kitap alabilir", "Limit aşıldı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();

                    AlanlariTemizle();
                    GridDoldur();
                }
            }
            else
            {
                MessageBox.Show("Seçilen kitap şu anda başka birine ödünç verilmiş durumda", "Kitap Ödünç Verilmiş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();

                GridDoldur();
                AlanlariTemizle();
            }
        }
        private void dtAlisTarihi_EditValueChanged(object sender, EventArgs e)
        {
            DateTime teslimTarihi = ((DateTime)dtAlisTarihi.EditValue).AddDays(15);

            //teslimTarihi = teslimTarihi.AddDays(15);
            dtTeslimTarihi.EditValue = teslimTarihi;
            dtTeslimTarihi.Enabled = false;
        }
        private void AlanlariTemizle()
        {
            cbKitapAdi.SelectedIndex = 0;
            cbOgrenciNo.SelectedIndex = 0;

            txtOgrenciAdi.Clear();
            txtOgrenciSoyadi.Clear();
            txtOgrenciSinif.Clear();
            txtYazarAdi.Clear();

            dtAlisTarihi.EditValue = DateTime.Today;
            dtTeslimTarihi.EditValue = DateTime.Today.AddDays(15);
        }
    }
}
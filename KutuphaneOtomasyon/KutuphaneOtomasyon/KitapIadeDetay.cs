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
    public partial class KitapIadeDetay : DevExpress.XtraEditors.XtraForm
    {
        public KitapIadeDetay()
        {
            InitializeComponent();
        }

        Islem seciliIslem;
        EFKutuphaneEntities ef = new EFKutuphaneEntities();

        private void KitapIadeDetay_Load(object sender, EventArgs e)
        {
            OduncBilgileri();
        }
        public void IslemGetir(Islem seciliIslem)
        {
            this.seciliIslem = seciliIslem;
        }
        private void OduncBilgileri()
        {
            txtOgrenciNo.Text = seciliIslem.OgrenciNo.ToString();
            txtOgrenciAdi.Text = seciliIslem.Ogrenci.OgrenciAd;
            txtOgrenciSoyad.Text = seciliIslem.Ogrenci.OgrenciSoyad;

            txtKitapAdi.Text = seciliIslem.Kitap.KitapAdi;
            txtTeslimTarihi.Text = seciliIslem.VerisTarihi.Value.ToLongDateString();
        }

        private void btnKitapTeslimAl_Click(object sender, EventArgs e)
        {
            Kitap teslimEdilecekKitap = ef.Kitaps.Where(k => k.KitapId == seciliIslem.KitapNo).FirstOrDefault();

            DialogResult result = MessageBox.Show(seciliIslem.Ogrenci.OgrenciAd + " " + seciliIslem.Ogrenci.OgrenciSoyad + " adlı öğrenciye ait "
                + seciliIslem.Kitap.KitapAdi + " adlı kitap teslim alınacak? Bu işlemi onaylıyor musunuz?",
                "Teslim Alma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                IslemGecmisi islemGecmis = new IslemGecmisi();
                islemGecmis.OgrenciNo = seciliIslem.OgrenciNo;
                islemGecmis.KitapNo = seciliIslem.KitapNo;
                islemGecmis.AlisTarihi = seciliIslem.AlisTarihi;
                islemGecmis.TeslimTarihi = DateTime.Today;

                teslimEdilecekKitap.Durum = "Kullanılabilir";

                ef.IslemGecmisis.Add(islemGecmis);
                ef.Islems.Remove(seciliIslem);
                ef.SaveChanges();

                MessageBox.Show("Kitap başarıyla teslim edildi", "Kitap Teslim Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlanlariTemizle();
                this.Close();
            }
            else
                this.Show();
        }

        private void btnKitapSureUzat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(seciliIslem.Ogrenci.OgrenciAd + " " + seciliIslem.Ogrenci.OgrenciSoyad + " adlı öğrenciye ait "
               + seciliIslem.Kitap.KitapAdi + " adlı kitabın iade süresi 15 gün uzatılacak? Bu işlemi onaylıyor musunuz?",
               "İade Tarihi Uzatma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                seciliIslem.VerisTarihi = DateTime.Today.AddDays(15);
                ef.SaveChanges();

                MessageBox.Show("İade süresi uzatıldı", "İade Tarihi Uzatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OduncBilgileri();
            }
            else
                this.Show();
        }

        private void AlanlariTemizle()
        {
            txtOgrenciNo.Text = "";
            txtOgrenciAdi.Text = "";
            txtOgrenciSoyad.Text = "";

            txtKitapAdi.Text = "";
            txtTeslimTarihi.Text = "";
        }

    }
}
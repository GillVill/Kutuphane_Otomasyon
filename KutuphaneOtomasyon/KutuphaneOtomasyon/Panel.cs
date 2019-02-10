using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Panel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Panel()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        Kullanici kullanici;
        private void Panel_Load(object sender, EventArgs e)
        {
            GenelBilgiGetir();
            barKullanici.Caption += kullanici.KullaniciAdi;
        }
        private void btnOgrenciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OgrenciEkle ogrenciEklemeEkrani = new OgrenciEkle();
            ogrenciEklemeEkrani.ShowDialog();
        }
        private void btnOgrenciListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OgrenciListesi ogrenciListesiEkrani = new OgrenciListesi();
            ogrenciListesiEkrani.ShowDialog();
        }
        private void btnKitapEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KitapEkle kitapEklemeEkrani = new KitapEkle();
            kitapEklemeEkrani.ShowDialog();
        }
        private void btnYazarEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YazarEkle yazarEklemeEkrani = new YazarEkle();
            yazarEklemeEkrani.ShowDialog();
        }
        private void btnKategoriEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KategoriEkle kategoriEklemeEkrani = new KategoriEkle();
            kategoriEklemeEkrani.ShowDialog();
        }
        private void btnYazarListesi__ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YazarListesi yazarListesiEkrani = new YazarListesi();
            yazarListesiEkrani.ShowDialog();
        }
        private void btnKitapListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KitapListesi kitapListesiEkrani = new KitapListesi();
            kitapListesiEkrani.ShowDialog();
        }
        private void btnYayineviEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YayineviEkle yayineviEkle = new YayineviEkle();
            yayineviEkle.ShowDialog();
        }
        private void btnYayineviListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YayineviListesi yayineviListesi = new YayineviListesi();
            yayineviListesi.ShowDialog();
        }
        private void btnKitapAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KitapOduncAl kitapAlma = new KitapOduncAl();
            kitapAlma.ShowDialog();
        }
        private void btnIslemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KitapIadeEt kitapIadeEt = new KitapIadeEt();
            kitapIadeEt.ShowDialog();
        }
        private void btnKullaniciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kullanici.Yetki == 1)
            {
                KullaniciEkle yeniKullaniciEkle = new KullaniciEkle();
                yeniKullaniciEkle.ShowDialog();
            }
            else
                MessageBox.Show("Bu işlemi gerçekleştirecek yetkiye sahip değilsiniz.", "Yetersiz Yetki", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnKullaniciDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullaniciDuzenle kullaniciDuzenle = new KullaniciDuzenle();
            kullaniciDuzenle.KullaniciBilgisi(kullanici);
            kullaniciDuzenle.ShowDialog();
        }
        private void btnKullaniciDegistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show(kullanici.KullaniciAdi + " adlı kullanıcının oturumunu kapatıp sisteme başka bir kullanıcı ile girmek istediğinizden emin misiniz?", 
                "Kullanıcı Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                this.Close();
            else
                this.Show();
        }
        private void btnHizliKitapAra_Click(object sender, EventArgs e)
        {
            var kitapListesi = ef.Kitaps.Where(k => k.KitapAdi.Contains(txtKitapArama.Text) || k.ISBNNo.Contains(txtKitapArama.Text)).ToList();

            if (kitapListesi.Count > 0)
            {
                AlanlariTemizle();

                KitapAramaSonuc aramaSonuclari = new KitapAramaSonuc();
                aramaSonuclari.KitapSonuclariGetir(kitapListesi);
                aramaSonuclari.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Aradağınız kriterlere uygun bir kitap bulunmamaktadır.", "Kitap Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if(result == DialogResult.OK)
                {
                    this.Show();
                    AlanlariTemizle();
                }
            }
        }
        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                this.Show();
        }
        private void Panel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                    Application.Exit();
                else
                    this.Show();
            }
        }
        public void KullaniciBilgileriAl(Kullanici seciliKullanici)
        {
            kullanici = seciliKullanici;
        }
        private void GenelBilgiGetir()
        {
            lblKitapSayisi.Text = ef.Kitaps.Count().ToString();
            lblYazarSayisi.Text = ef.Yazars.Count().ToString();
            lblOgrenciSayisi.Text = ef.Ogrencis.Count().ToString();
        }
        private void AlanlariTemizle()
        {
            txtKitapArama.Text = "";
        }
    } 
}

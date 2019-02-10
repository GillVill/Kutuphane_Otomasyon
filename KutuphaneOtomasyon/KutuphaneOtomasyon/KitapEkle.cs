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
using System.IO;

namespace KutuphaneOtomasyon
{
    public partial class KitapEkle : DevExpress.XtraEditors.XtraForm
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void YazarGetir()
        {
            cbYazarListesi.DataSource = ef.Yazars.Select(y => new { Adsoyad = y.Ad + " " + y.Soyad }).ToList();
            cbYazarListesi.DisplayMember = "Adsoyad";
            cbYazarListesi.Invalidate();
        }
        private void KategoriGetir()
        {
            cbKategoriListesi.DataSource = ef.Kategoris.Select(x => x.KategoriAdi).ToList();
            cbKategoriListesi.Invalidate();
        }
        private void YayineviGetir()
        {
            cbYayinevi.DataSource = ef.Yayinevis.ToList();
            cbYayinevi.DisplayMember = "Ad";
            cbYayinevi.ValueMember = "Id";
        }
        private void XtraKitapEkle_Load(object sender, EventArgs e)
        {
            YazarGetir();
            KategoriGetir();
            YayineviGetir();
            //KitapListesi();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Yazar secilenYazar = ef.Yazars.Where(x => x.Id == cbYazarListesi.SelectedIndex + 1).FirstOrDefault();
            Kategori secilenKategori = ef.Kategoris.Where(x => x.KategoriId == cbKategoriListesi.SelectedIndex + 1).FirstOrDefault();
            Yayinevi seciliYayinEvi = ef.Yayinevis.Where(x => x.Id == (int)cbYayinevi.SelectedValue).FirstOrDefault();

            Kitap yeniKitap = new Kitap();
            YayineviKitap yayineviKitap = new YayineviKitap();

            yeniKitap.ISBNNo = txtISBN.Text;
            yeniKitap.KitapAdi = txtKitapAdi.Text;
            yeniKitap.YazarNo = secilenYazar.Id;
            yeniKitap.KategoriNo = secilenKategori.KategoriId;
            yeniKitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
            yeniKitap.Aciklama = rtxtAciklama.Text;
            yeniKitap.RafNo = txtRafNo.Text;
            yeniKitap.Durum = "Kullanılabilir";

            try
            {
                byte[] img = null;

                FileStream fileStream = new FileStream(pbKitapFoto.GetLoadedImageLocation(), FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);

                img = binaryReader.ReadBytes((int)fileStream.Length);
                yeniKitap.Resim = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf veritabanına eklenirken bir hata meydana geldi..."+ex.Message);
            }

            yayineviKitap.KitapId = yeniKitap.KitapId;
            yayineviKitap.YayineviId = seciliYayinEvi.Id;

            ef.Kitaps.Add(yeniKitap);
            ef.YayineviKitaps.Add(yayineviKitap);
            ef.SaveChanges();

            MessageBox.Show(cbYazarListesi.Text + " adlı yazara ait, " + txtKitapAdi.Text + " adlı kitap kütüphaneye başarıyla eklendi...", "Kitap Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            KitapEkleAlanlariniTemizle();
        }
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yeniYazar = new Yazar();

            yeniYazar.Ad = txtYazarAdi.Text;
            yeniYazar.Soyad = txtYazarSoyadi.Text.ToUpper();

            ef.Yazars.Add(yeniYazar);
            ef.SaveChanges();

            MessageBox.Show(txtYazarAdi.Text + " " + txtYazarSoyadi.Text + " adlı yazar sisteme başarıyla eklendi", "Yazar Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            YazarEkleAlanlariniTemizle();
            YazarGetir();
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Kategori yeniKategori = new Kategori();

            yeniKategori.KategoriAdi = txtKategoriAdi.Text;

            ef.Kategoris.Add(yeniKategori);
            ef.SaveChanges();

            MessageBox.Show(txtKategoriAdi.Text + " adlı kategori sisteme başarıyla eklendi", "Kategori Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            KategoriEkleAlanlariniTemizle();
            KategoriGetir();
        }
        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            Yayinevi yeniYayinevi = new Yayinevi();

            yeniYayinevi.Ad = txtYayinEviAdi.Text;

            ef.Yayinevis.Add(yeniYayinevi);
            ef.SaveChanges();

            MessageBox.Show(yeniYayinevi.Ad + " adlı yayınevi sisteme başarıyla kaydedildi", "Yeni Yayınevi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YayineviAlanlariniTemizle();
            YayineviGetir();
        }
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Yüklenecek kitap için bir fotoğraf seçin...";
                fileDialog.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                pbKitapFoto.LoadImage();
                //if (fileDialog.ShowDialog() == DialogResult.OK)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf yüklenirken bir hata meydana geldi: " + ex.Message);
            }
        }
        private void KitapEkleAlanlariniTemizle()
        {
            txtISBN.Text = "";
            txtKitapAdi.Text = "";
            txtSayfaSayisi.Text = "";
            rtxtAciklama.Text = "";

            cbYazarListesi.SelectedIndex = 0;
            cbKategoriListesi.SelectedIndex = 0;
            cbYayinevi.SelectedIndex = 0;

            pbKitapFoto.Image = null;
        }
        private void YazarEkleAlanlariniTemizle()
        {
            txtYazarAdi.Text = "";
            txtYazarSoyadi.Text = "";
        }
        private void KategoriEkleAlanlariniTemizle()
        {
            txtKategoriAdi.Text = "";
        }
        private void YayineviAlanlariniTemizle()
        {
            txtYayinEviAdi.Text = "";
        }
    }
}
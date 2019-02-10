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
    public partial class KitapDetay : DevExpress.XtraEditors.XtraForm
    {
        public KitapDetay()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        Kitap kitap;
        
        private void KitapDetay_Load(object sender, EventArgs e)
        {
            KitapDetayGetir();
        }

        public void SeciliKitap(Kitap seciliKitap)
        {
            kitap = seciliKitap;
        }

        private void KitapDetayGetir()
        {
            this.Text = kitap.KitapAdi + " kitabına ait detaylı bilgi";
            try
            {
                byte[] img = kitap.Resim;
                if (img != null)
                {
                    MemoryStream memoryStream = new MemoryStream(img);
                    pbKitapFoto.Image = Image.FromStream(memoryStream);
                }
                else
                    pbKitapFoto.Properties.NullText = "Resim yüklenemedi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçili kitabın resmi yüklenirken bir hata meydana geldi: " + ex.Message);
            }
            txtIsbnNo.Text = kitap.ISBNNo;
            txtKitapAdi.Text = kitap.KitapAdi;
            txtYazarAdi.Text = kitap.Yazar.Ad + " " + kitap.Yazar.Soyad;
            txtKategori.Text = kitap.Kategori.KategoriAdi;
            txtSayfaSayisi.Text = kitap.SayfaSayisi.ToString();
            txtRafNo.Text = kitap.RafNo;
            txtKitapDurum.Text = kitap.Durum;

            YayineviKitap yayineviKitap = ef.YayineviKitaps.Where(yk => yk.KitapId == kitap.KitapId).FirstOrDefault();
            Yayinevi seciliYayinevi = ef.Yayinevis.Where(y => y.Id == yayineviKitap.YayineviId).FirstOrDefault();

            txtYayinevi.Text = seciliYayinevi.Ad;
            rtxtAciklama.Text = kitap.Aciklama;
        }
    }
}
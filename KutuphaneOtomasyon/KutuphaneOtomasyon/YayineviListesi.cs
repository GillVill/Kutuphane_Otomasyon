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
    public partial class YayineviListesi : DevExpress.XtraEditors.XtraForm
    {
        public YayineviListesi()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();

        private void YayineviListesi_Load(object sender, EventArgs e)
        {
            YayineviListesiGetir();
            lblYayineviSayisi.Text = ef.Yayinevis.Count().ToString();
        }

        private void YayineviListesiGetir()
        {
            cbYayineviListesi.DataSource = ef.Yayinevis.Select(y=>y.Ad).ToList();
            cbYayineviListesi.Invalidate();
            //cbYayineviListesi.DisplayMember = "Ad";
            //cbYayineviListesi.ValueMember = "Id";
        }

        private void cbYayineviListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yayinevi seciliYayinevi = ef.Yayinevis.Where(y => y.Id == (cbYayineviListesi.SelectedIndex + 1)).FirstOrDefault();

            txtYayinEviAdi.Text = seciliYayinevi.Ad;
            rtxtYayineviBilgi.Text = seciliYayinevi.Aciklama;

            try
            {
                byte[] img = seciliYayinevi.Resim;
                if (img != null)
                {
                    MemoryStream memoryStream = new MemoryStream(img);
                    pbYayineviLogo.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    pbYayineviLogo.Image = null;
                    pbYayineviLogo.Properties.NullText = "Yayinevine ait logo bulunamadı...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf yüklenirken bir hata meydana geldi: " + ex.Message);
            }

            var kitapListesi = ef.YayineviKitaps.Where(yk => yk.YayineviId == seciliYayinevi.Id).Select(yk => yk.KitapId).ToList();

            lstKitaplar.Items.Clear();
            foreach (var kitap in kitapListesi)
            {
                Kitap yeniKitap = ef.Kitaps.Where(k => k.KitapId == kitap).FirstOrDefault();
                lstKitaplar.Items.Add(yeniKitap.KitapAdi);
            }

            lblSeciliYayineviKitapSayisi.Text = kitapListesi.Count.ToString();
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitap seciliKitap = ef.Kitaps.Where(k => k.KitapAdi == lstKitaplar.SelectedItem.ToString()).FirstOrDefault();

            KitapDetay kitapDetay = new KitapDetay();
            kitapDetay.SeciliKitap(seciliKitap);
            kitapDetay.ShowDialog();
        }
    }
}
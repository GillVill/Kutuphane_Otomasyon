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
    public partial class YayineviEkle : DevExpress.XtraEditors.XtraForm
    {
        public YayineviEkle()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();

        private void btnYayineviLogoYukle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Yayınevi logosu yükleyin";
                fileDialog.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|All Files (*.*)|*.*";

                pbYayineviLogo.LoadImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yayınevi logosu yüklenirken bir hata meydana geldi: " + ex.Message);
            }
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            Yayinevi yeniYayinevi = new Yayinevi();

            yeniYayinevi.Ad = txtYayinEviAdi.Text;
            yeniYayinevi.Aciklama = rtxtYayineviBilgi.Text;

            try
            {
                byte[] img = null;

                FileStream fileStream = new FileStream(pbYayineviLogo.GetLoadedImageLocation(), FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fileStream);

                img = reader.ReadBytes((int)fileStream.Length);
                yeniYayinevi.Resim = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yayınevi logosu veritabanına kaydedilemedi: " + ex.Message);
            }

            ef.Yayinevis.Add(yeniYayinevi);
            ef.SaveChanges();

            MessageBox.Show(yeniYayinevi.Ad + " adlı yayınevi sisteme başarıyla kaydedildi", "Yeni Yayınevi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AlanlariTemizle();
        }

        private void AlanlariTemizle()
        {
            txtYayinEviAdi.Text = "";
            rtxtYayineviBilgi.Text = "";
            pbYayineviLogo.Image = null;
        }
    }
}
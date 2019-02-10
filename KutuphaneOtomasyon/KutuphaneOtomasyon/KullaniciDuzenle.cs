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
    public partial class KullaniciDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciDuzenle()
        {
            InitializeComponent();
        }

        Kullanici kullanici;
        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = kullanici.KullaniciAdi;
        }
        public void KullaniciBilgisi(Kullanici kullanici)
        {
            this.kullanici = kullanici;
        }
        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (kullanici.Parola == txtEskiParola.Text)
            {
                if (txtYeniParola.Text == txtYeniParolaTekrar.Text)
                {
                    Kullanici guncellenecekKullanici = ef.Kullanicis.Where(k => k.KullaniciAdi == kullanici.KullaniciAdi).FirstOrDefault();
                    guncellenecekKullanici.Parola = txtYeniParola.Text;

                    ef.SaveChanges();
                    MessageBox.Show(lblKullaniciAdi.Text + " adlı kullanıcının parolası değiştirildi.", "Parola Değiştirildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                }
                else
                    MessageBox.Show("Girilen yeni parola değerleri birbiriyle aynı değil. Lütfen doğru girdiğinizden emin olunuz",
                        "Parolalar birbirinden farklı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Girilen parola şu anki kullanıcıya ait. Eski parolanızı doğru girdiğinizden emin olun", "Eski Parola Yanlış", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void AlanlariTemizle()
        {
            txtEskiParola.Text = "";
            txtYeniParola.Text = "";
            txtYeniParolaTekrar.Text = "";
        }
    }
}
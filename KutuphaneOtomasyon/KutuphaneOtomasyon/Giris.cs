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
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        public Giris()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();

        private void Giris_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void KullaniciGetir()
        {
            cBox_KullaniciAdi.Properties.DataSource = ef.Kullanicis.Select(k => k.KullaniciAdi).ToList();
            cBox_KullaniciAdi.Invalidate();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici seciliKullanici = ef.Kullanicis.Where(k => k.KullaniciAdi == cBox_KullaniciAdi.Text).FirstOrDefault();

            if (seciliKullanici.Parola == txtParola.Text)
            {
                AlanlariTemizle();

                Panel panel = new Panel();
                panel.KullaniciBilgileriAl(seciliKullanici);
                panel.ShowDialog();
            }
            else
                lblHata.Text = "Yanlış parola!!!";
        }

        private void AlanlariTemizle()
        {
            cBox_KullaniciAdi.ResetText();
            txtParola.Text = "";
            lblHata.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (result == DialogResult.Yes)
                Application.Exit();
            else
                this.Show();
        }
        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                    Application.Exit();
                else
                    this.Show();
            }
        }

        private void cBox_KullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                    Application.Exit();
                else
                    this.Show();
            }
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (result == DialogResult.Yes)
                    Application.Exit();
                else
                    this.Show();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Kullanici seciliKullanici = ef.Kullanicis.Where(k => k.KullaniciAdi == cBox_KullaniciAdi.Text).FirstOrDefault();

                if (seciliKullanici.Parola == txtParola.Text)
                {
                    AlanlariTemizle();

                    Panel panel = new Panel();
                    panel.KullaniciBilgileriAl(seciliKullanici);
                    panel.ShowDialog();
                }
                else
                    lblHata.Text = "Yanlış parola!!!";
            }
        }
    }
}
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
    public partial class KullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            YetkiListesi();
        }
        private void YetkiListesi()
        {
            cbYetki.DataSource = ef.Yetkis.Select(y => y.YetkiAdi).ToList();
            cbYetki.Invalidate();
        }
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciParola.Text.Equals(txtKullaniciParolaTekrar.Text))
            {
                Kullanici yeniKullanici = new Kullanici();

                yeniKullanici.KullaniciAdi = txtKullaniciAdi.Text;
                yeniKullanici.Parola = txtKullaniciParola.Text;
                yeniKullanici.Yetki = cbYetki.SelectedIndex + 1;

                ef.Kullanicis.Add(yeniKullanici);
                ef.SaveChanges();

                MessageBox.Show(txtKullaniciAdi.Text + " adlı kullanıcı sisteme başarıyla eklendi", "Yeni Kullanıcı Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AlanlariTemizle();
            }
            else
            {
                MessageBox.Show("Girilen parolalar birbiriyle eşleşmiyor. Parola alanlarını doğru girdiğinizden emin olunuz.", "Parolalar Eşleşmiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Show();
            }
        }
        private void AlanlariTemizle()
        {
            txtKullaniciAdi.Text = "";
            txtKullaniciParola.Text = "";
            txtKullaniciParolaTekrar.Text = "";

            cbYetki.ResetText();
        }
    }
}
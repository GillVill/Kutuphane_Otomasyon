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
    public partial class OgrenciEkle : DevExpress.XtraEditors.XtraForm
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci yeniOgrenci = new Ogrenci();

            yeniOgrenci.OgrenciAd = txtOgrenciAdi.Text;
            yeniOgrenci.OgrenciSoyad = txtOgrenciSoyadi.Text;
            yeniOgrenci.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
            yeniOgrenci.DTarihi = (DateTime)dtDogumTarihi.EditValue;
            yeniOgrenci.Sinif = txtSinif.Text;
            yeniOgrenci.Cinsiyet = chkErkek.Checked == true ? "E" : "K";
            yeniOgrenci.EPosta = txtEPosta.Text;

            ef.Ogrencis.Add(yeniOgrenci);
            ef.SaveChanges();

            MessageBox.Show(yeniOgrenci.OgrenciAd + " " + yeniOgrenci.OgrenciSoyad + " adlı öğrenci listeye başarıyla eklendi", "Öğrenci Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
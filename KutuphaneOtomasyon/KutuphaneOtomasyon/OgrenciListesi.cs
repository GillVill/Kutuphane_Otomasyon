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
    public partial class OgrenciListesi : DevExpress.XtraEditors.XtraForm
    {
        public OgrenciListesi()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities kutuphaneEntities;
        
        private void XtraOgrenciListesi_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            kutuphaneEntities = new EFKutuphaneEntities();
            dgvOgrenciListesi.DataSource = kutuphaneEntities.Ogrencis.ToList();
            dgvOgrenciListesi.Columns["Islems"].Visible = false;
            dgvOgrenciListesi.Columns["IslemGecmisis"].Visible = false;

            for (int i = 0; i < dgvOgrenciListesi.Columns.Count - 3; i++)
                dgvOgrenciListesi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvOgrenciListesi.Columns[dgvOgrenciListesi.ColumnCount - 3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            //for (int i = 0; i <= dgvOgrenciListesi.Columns.Count - 1; i++)
            //{
            //    //store autosized widths
            //    int colw = dgvOgrenciListesi.Columns[i].Width;
            //    //remove autosizing
            //    dgvOgrenciListesi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    //set width to calculated by autosize
            //    dgvOgrenciListesi.Columns[i].Width = colw;
            //}
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci yeniOgrenci = new Ogrenci();

            yeniOgrenci.OgrenciAd = txtOgrenciAdi.Text;
            yeniOgrenci.OgrenciSoyad = txtOgrenciSoyadi.Text.ToUpper();
            yeniOgrenci.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
            yeniOgrenci.DTarihi = (DateTime)dtDogumTarihi.EditValue;
            yeniOgrenci.Cinsiyet = chkErkek.Checked ? "E" : "K";
            yeniOgrenci.Sinif = txtSinif.Text;
            yeniOgrenci.EPosta = txtEPosta.Text;

            kutuphaneEntities.Ogrencis.Add(yeniOgrenci);
            kutuphaneEntities.SaveChanges();

            AlanlariTemizle();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekNo = Convert.ToInt32(txtOgrenciNo.Text);

            Ogrenci guncellenecekOgrenci = kutuphaneEntities.Ogrencis.Where(x => x.OgrenciNo == guncellenecekNo).FirstOrDefault();

            guncellenecekOgrenci.OgrenciAd = txtOgrenciAdi.Text;
            guncellenecekOgrenci.OgrenciSoyad = txtOgrenciSoyadi.Text;
            guncellenecekOgrenci.DTarihi = (DateTime)dtDogumTarihi.EditValue;
            guncellenecekOgrenci.Cinsiyet = chkErkek.Checked == true ? "E" : "K";
            guncellenecekOgrenci.Sinif = txtSinif.Text;
            guncellenecekOgrenci.EPosta = txtEPosta.Text;

            kutuphaneEntities.SaveChanges();

            AlanlariTemizle();
            Doldur();
        }

        private void dgvOgrenciListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOgrenciNo.Text = dgvOgrenciListesi.CurrentRow.Cells[0].Value.ToString();
            txtOgrenciAdi.Text = dgvOgrenciListesi.CurrentRow.Cells[1].Value.ToString();
            txtOgrenciSoyadi.Text = dgvOgrenciListesi.CurrentRow.Cells[2].Value.ToString();

            if (dgvOgrenciListesi.CurrentRow.Cells[3].Value.ToString().Equals("E"))
            {
                chkErkek.Checked = true;
                chkKadin.Checked = false;
            }  
            else if (dgvOgrenciListesi.CurrentRow.Cells[3].Value.ToString().Equals("K"))
            {
                chkKadin.Checked = true;
                chkErkek.Checked = false;
            }
               

            dtDogumTarihi.EditValue = (DateTime)dgvOgrenciListesi.CurrentRow.Cells[4].Value;
            txtSinif.Text = dgvOgrenciListesi.CurrentRow.Cells[5].Value.ToString();
            if (dgvOgrenciListesi.CurrentRow.Cells[6].Value==null)
                txtEPosta.Text = "";
            else
                txtEPosta.Text = dgvOgrenciListesi.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekNo = Convert.ToInt32(txtOgrenciNo.Text);

            Ogrenci silinecekOgrenci = kutuphaneEntities.Ogrencis.Where(x => x.OgrenciNo == silinecekNo).FirstOrDefault();

            kutuphaneEntities.Ogrencis.Remove(silinecekOgrenci);
            kutuphaneEntities.SaveChanges();

            AlanlariTemizle();
            Doldur();
        }

        private void AlanlariTemizle()
        {
            txtOgrenciAdi.Text = "";
            txtOgrenciSoyadi.ResetText();
            txtOgrenciNo.ResetText();
            dtDogumTarihi.EditValue = DateTime.Now;
            chkErkek.Checked = false;
            chkErkek.Checked = false;
            txtSinif.ResetText();
            txtEPosta.ResetText();
        }

    }
}
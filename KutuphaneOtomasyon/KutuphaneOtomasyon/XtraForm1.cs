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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        EFKutuphaneEntities ef = new EFKutuphaneEntities();
        private void btnRsmYukle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();

                fileDialog.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                fileDialog.Title = "Kitap için bir foto seçiniz...";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.ImageLocation = fileDialog.FileName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf seçilirken bir hata meydana geldi: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           Yayinevi yayinevi = ef.Yayinevis.Where(y => y.Id == 8).FirstOrDefault();

            try
            {
                byte[] img = null;

                FileStream fileStream = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fileStream);

                img = reader.ReadBytes((int)fileStream.Length);

                yayinevi.Resim = img;
                ef.SaveChanges();

                MessageBox.Show("Fotoğraf veritabanına kaydedildi.");
                pictureBox1.ImageLocation = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf veritabanına eklenirken bir hata meydana geldi: " + ex.Message);
            }
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
namespace KutuphaneOtomasyon
{
    partial class OgrenciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciEkle));
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grpOgrenciBilgileri = new DevExpress.XtraEditors.GroupControl();
            this.chkKadin = new DevExpress.XtraEditors.CheckEdit();
            this.chkErkek = new DevExpress.XtraEditors.CheckEdit();
            this.dtDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtSinif = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrenciNo = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrenciSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrenciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEPosta = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgileri)).BeginInit();
            this.grpOgrenciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKadin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkErkek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEPosta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(217, 395);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(187, 45);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpOgrenciBilgileri
            // 
            this.grpOgrenciBilgileri.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpOgrenciBilgileri.CaptionImageOptions.Image")));
            this.grpOgrenciBilgileri.Controls.Add(this.chkKadin);
            this.grpOgrenciBilgileri.Controls.Add(this.chkErkek);
            this.grpOgrenciBilgileri.Controls.Add(this.dtDogumTarihi);
            this.grpOgrenciBilgileri.Controls.Add(this.txtEPosta);
            this.grpOgrenciBilgileri.Controls.Add(this.txtSinif);
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciNo);
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciSoyadi);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl7);
            this.grpOgrenciBilgileri.Controls.Add(this.txtOgrenciAdi);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl6);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl4);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl3);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl2);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl5);
            this.grpOgrenciBilgileri.Controls.Add(this.labelControl1);
            this.grpOgrenciBilgileri.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpOgrenciBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            this.grpOgrenciBilgileri.Size = new System.Drawing.Size(392, 365);
            this.grpOgrenciBilgileri.TabIndex = 1;
            this.grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // chkKadin
            // 
            this.chkKadin.Location = new System.Drawing.Point(259, 230);
            this.chkKadin.Name = "chkKadin";
            this.chkKadin.Properties.Caption = "Kadın";
            this.chkKadin.Size = new System.Drawing.Size(112, 25);
            this.chkKadin.TabIndex = 7;
            // 
            // chkErkek
            // 
            this.chkErkek.Location = new System.Drawing.Point(155, 230);
            this.chkErkek.Name = "chkErkek";
            this.chkErkek.Properties.Caption = "Erkek";
            this.chkErkek.Size = new System.Drawing.Size(112, 25);
            this.chkErkek.TabIndex = 6;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.EditValue = null;
            this.dtDogumTarihi.Location = new System.Drawing.Point(155, 183);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.dtDogumTarihi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dtDogumTarihi.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dtDogumTarihi.Properties.Appearance.Options.UseBackColor = true;
            this.dtDogumTarihi.Properties.Appearance.Options.UseFont = true;
            this.dtDogumTarihi.Properties.Appearance.Options.UseForeColor = true;
            this.dtDogumTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDogumTarihi.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtDogumTarihi.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtDogumTarihi.Size = new System.Drawing.Size(211, 28);
            this.dtDogumTarihi.TabIndex = 5;
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(155, 270);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSinif.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtSinif.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSinif.Properties.Appearance.Options.UseBackColor = true;
            this.txtSinif.Properties.Appearance.Options.UseFont = true;
            this.txtSinif.Properties.Appearance.Options.UseForeColor = true;
            this.txtSinif.Size = new System.Drawing.Size(211, 28);
            this.txtSinif.TabIndex = 8;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(155, 140);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciNo.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtOgrenciNo.Properties.Appearance.Options.UseFont = true;
            this.txtOgrenciNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtOgrenciNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOgrenciNo.Size = new System.Drawing.Size(211, 28);
            this.txtOgrenciNo.TabIndex = 4;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(155, 101);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciSoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciSoyadi.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciSoyadi.Properties.Appearance.Options.UseBackColor = true;
            this.txtOgrenciSoyadi.Properties.Appearance.Options.UseFont = true;
            this.txtOgrenciSoyadi.Properties.Appearance.Options.UseForeColor = true;
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(211, 28);
            this.txtOgrenciSoyadi.TabIndex = 3;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(155, 63);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciAdi.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtOgrenciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtOgrenciAdi.Properties.Appearance.Options.UseForeColor = true;
            this.txtOgrenciAdi.Size = new System.Drawing.Size(211, 28);
            this.txtOgrenciAdi.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 275);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Sınıfı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 188);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(116, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Doğum Tarihi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Öğrenci No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Öğrenci Soyadı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 231);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Cinsiyet";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Öğrenci Adı:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 318);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 19);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "E Posta:";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(155, 313);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEPosta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtEPosta.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEPosta.Properties.Appearance.Options.UseBackColor = true;
            this.txtEPosta.Properties.Appearance.Options.UseFont = true;
            this.txtEPosta.Properties.Appearance.Options.UseForeColor = true;
            this.txtEPosta.Size = new System.Drawing.Size(211, 28);
            this.txtEPosta.TabIndex = 9;
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 454);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpOgrenciBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrenciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgileri)).EndInit();
            this.grpOgrenciBilgileri.ResumeLayout(false);
            this.grpOgrenciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKadin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkErkek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEPosta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.GroupControl grpOgrenciBilgileri;
        private DevExpress.XtraEditors.CheckEdit chkKadin;
        private DevExpress.XtraEditors.CheckEdit chkErkek;
        private DevExpress.XtraEditors.DateEdit dtDogumTarihi;
        private DevExpress.XtraEditors.TextEdit txtSinif;
        private DevExpress.XtraEditors.TextEdit txtOgrenciNo;
        private DevExpress.XtraEditors.TextEdit txtOgrenciSoyadi;
        private DevExpress.XtraEditors.TextEdit txtOgrenciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEPosta;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
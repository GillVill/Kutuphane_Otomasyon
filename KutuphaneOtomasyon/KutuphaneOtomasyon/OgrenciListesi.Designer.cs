namespace KutuphaneOtomasyon
{
    partial class OgrenciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListesi));
            this.dgvOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chkKadin = new DevExpress.XtraEditors.CheckEdit();
            this.chkErkek = new DevExpress.XtraEditors.CheckEdit();
            this.dtDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtSinif = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrenciNo = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrenciSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtOgrenciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEPosta = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKadin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkErkek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEPosta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciListesi
            // 
            this.dgvOgrenciListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOgrenciListesi.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOgrenciListesi.Location = new System.Drawing.Point(2, 1);
            this.dgvOgrenciListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOgrenciListesi.Name = "dgvOgrenciListesi";
            this.dgvOgrenciListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvOgrenciListesi.Size = new System.Drawing.Size(895, 393);
            this.dgvOgrenciListesi.TabIndex = 14;
            this.dgvOgrenciListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOgrenciListesi_CellMouseClick);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl2.Controls.Add(this.dgvOgrenciListesi);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(411, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(899, 436);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Öğrenci Listesi";
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
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(140, 415);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(140, 44);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(14, 414);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 45);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 275);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 21);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Sınıfı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 188);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Doğum Tarihi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Öğrenci No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Öğrenci Soyadı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 231);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 21);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Cinsiyeti:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Öğrenci Adı:";
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(286, 415);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 45);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.chkKadin);
            this.groupControl1.Controls.Add(this.chkErkek);
            this.groupControl1.Controls.Add(this.dtDogumTarihi);
            this.groupControl1.Controls.Add(this.txtEPosta);
            this.groupControl1.Controls.Add(this.txtSinif);
            this.groupControl1.Controls.Add(this.txtOgrenciNo);
            this.groupControl1.Controls.Add(this.txtOgrenciSoyadi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtOgrenciAdi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(392, 372);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Öğrenci Bilgileri";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 321);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 21);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "E Posta: ";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(155, 316);
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
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1322, 478);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "OgrenciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.XtraOgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkKadin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkErkek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDogumTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrenciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEPosta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciListesi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit chkKadin;
        private DevExpress.XtraEditors.CheckEdit chkErkek;
        private DevExpress.XtraEditors.DateEdit dtDogumTarihi;
        private DevExpress.XtraEditors.TextEdit txtSinif;
        private DevExpress.XtraEditors.TextEdit txtOgrenciNo;
        private DevExpress.XtraEditors.TextEdit txtOgrenciSoyadi;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtOgrenciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtEPosta;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
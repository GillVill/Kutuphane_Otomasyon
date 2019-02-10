namespace KutuphaneOtomasyon
{
    partial class KitapAramaSonuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapAramaSonuc));
            this.grpKitapAramaSonuc = new DevExpress.XtraEditors.GroupControl();
            this.dgvKitapSonucListesi = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamKitapSayisi = new DevExpress.XtraEditors.LabelControl();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SayfaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RafNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpKitapAramaSonuc)).BeginInit();
            this.grpKitapAramaSonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapSonucListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKitapAramaSonuc
            // 
            this.grpKitapAramaSonuc.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpKitapAramaSonuc.CaptionImageOptions.Image")));
            this.grpKitapAramaSonuc.Controls.Add(this.dgvKitapSonucListesi);
            this.grpKitapAramaSonuc.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpKitapAramaSonuc.Location = new System.Drawing.Point(12, 12);
            this.grpKitapAramaSonuc.Name = "grpKitapAramaSonuc";
            this.grpKitapAramaSonuc.Size = new System.Drawing.Size(1103, 330);
            this.grpKitapAramaSonuc.TabIndex = 1;
            this.grpKitapAramaSonuc.Text = "Sonuç Listesi";
            // 
            // dgvKitapSonucListesi
            // 
            this.dgvKitapSonucListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvKitapSonucListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapSonucListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapAdi,
            this.ISBNNO,
            this.YazarAdı,
            this.Kategori,
            this.SayfaSayisi,
            this.Durum,
            this.RafNo});
            this.dgvKitapSonucListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKitapSonucListesi.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvKitapSonucListesi.Location = new System.Drawing.Point(2, 41);
            this.dgvKitapSonucListesi.Name = "dgvKitapSonucListesi";
            this.dgvKitapSonucListesi.ReadOnly = true;
            this.dgvKitapSonucListesi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvKitapSonucListesi.RowTemplate.Height = 28;
            this.dgvKitapSonucListesi.Size = new System.Drawing.Size(1099, 287);
            this.dgvKitapSonucListesi.TabIndex = 2;
            this.dgvKitapSonucListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKitapSonucListesi_CellMouseClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 360);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(180, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Bulunan Kitap Sayısı:";
            // 
            // lblToplamKitapSayisi
            // 
            this.lblToplamKitapSayisi.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKitapSayisi.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lblToplamKitapSayisi.Appearance.Options.UseFont = true;
            this.lblToplamKitapSayisi.Appearance.Options.UseForeColor = true;
            this.lblToplamKitapSayisi.Location = new System.Drawing.Point(200, 361);
            this.lblToplamKitapSayisi.Name = "lblToplamKitapSayisi";
            this.lblToplamKitapSayisi.Size = new System.Drawing.Size(6, 21);
            this.lblToplamKitapSayisi.TabIndex = 3;
            this.lblToplamKitapSayisi.Text = "-";
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Appearance.Options.UseForeColor = true;
            this.lblTarih.Location = new System.Drawing.Point(957, 358);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(6, 21);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "-";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(899, 360);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tarih:";
            // 
            // KitapAdi
            // 
            this.KitapAdi.HeaderText = "Kitap";
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.ReadOnly = true;
            this.KitapAdi.Width = 80;
            // 
            // ISBNNO
            // 
            this.ISBNNO.HeaderText = "ISBN";
            this.ISBNNO.Name = "ISBNNO";
            this.ISBNNO.ReadOnly = true;
            this.ISBNNO.Width = 80;
            // 
            // YazarAdı
            // 
            this.YazarAdı.HeaderText = "Yazar";
            this.YazarAdı.Name = "YazarAdı";
            this.YazarAdı.ReadOnly = true;
            this.YazarAdı.Width = 80;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            this.Kategori.Width = 80;
            // 
            // SayfaSayisi
            // 
            this.SayfaSayisi.HeaderText = "Sayfa";
            this.SayfaSayisi.Name = "SayfaSayisi";
            this.SayfaSayisi.ReadOnly = true;
            this.SayfaSayisi.Width = 50;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Width = 80;
            // 
            // RafNo
            // 
            this.RafNo.HeaderText = "Raf";
            this.RafNo.Name = "RafNo";
            this.RafNo.ReadOnly = true;
            this.RafNo.Width = 80;
            // 
            // KitapAramaSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1127, 411);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblToplamKitapSayisi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grpKitapAramaSonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "KitapAramaSonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama Sonuçları";
            this.Load += new System.EventHandler(this.KitapAramaSonuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKitapAramaSonuc)).EndInit();
            this.grpKitapAramaSonuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapSonucListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpKitapAramaSonuc;
        private System.Windows.Forms.DataGridView dgvKitapSonucListesi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblToplamKitapSayisi;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn SayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RafNo;
    }
}
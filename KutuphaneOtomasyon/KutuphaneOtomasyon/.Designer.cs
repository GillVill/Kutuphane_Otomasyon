namespace KutuphaneOtomasyon
{
    partial class KitapOduncAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapOduncAl));
            this.dgvIslemGecmisi = new System.Windows.Forms.DataGridView();
            this.grpIslemGecmisi = new DevExpress.XtraEditors.GroupControl();
            this.btnKitapAl = new DevExpress.XtraEditors.SimpleButton();
            this.dtTeslimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dtAlisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKitapAdi = new System.Windows.Forms.ComboBox();
            this.txtOgrenciSinif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grpOgrenciSec = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemGecmisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpIslemGecmisi)).BeginInit();
            this.grpIslemGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeslimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeslimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciSec)).BeginInit();
            this.grpOgrenciSec.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIslemGecmisi
            // 
            this.dgvIslemGecmisi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvIslemGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIslemGecmisi.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvIslemGecmisi.Location = new System.Drawing.Point(2, 41);
            this.dgvIslemGecmisi.Name = "dgvIslemGecmisi";
            this.dgvIslemGecmisi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvIslemGecmisi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvIslemGecmisi.RowTemplate.Height = 28;
            this.dgvIslemGecmisi.Size = new System.Drawing.Size(906, 250);
            this.dgvIslemGecmisi.TabIndex = 13;
            // 
            // grpIslemGecmisi
            // 
            this.grpIslemGecmisi.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpIslemGecmisi.CaptionImageOptions.Image")));
            this.grpIslemGecmisi.Controls.Add(this.dgvIslemGecmisi);
            this.grpIslemGecmisi.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpIslemGecmisi.Location = new System.Drawing.Point(12, 329);
            this.grpIslemGecmisi.Name = "grpIslemGecmisi";
            this.grpIslemGecmisi.Size = new System.Drawing.Size(910, 293);
            this.grpIslemGecmisi.TabIndex = 15;
            this.grpIslemGecmisi.Text = "Ödünç Alınan Kitaplar";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Appearance.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAl.Appearance.Options.UseFont = true;
            this.btnKitapAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapAl.ImageOptions.Image")));
            this.btnKitapAl.Location = new System.Drawing.Point(300, 234);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(173, 53);
            this.btnKitapAl.TabIndex = 11;
            this.btnKitapAl.Text = "ÖDÜNÇ VER";
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // dtTeslimTarihi
            // 
            this.dtTeslimTarihi.EditValue = null;
            this.dtTeslimTarihi.Location = new System.Drawing.Point(222, 190);
            this.dtTeslimTarihi.Name = "dtTeslimTarihi";
            this.dtTeslimTarihi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.dtTeslimTarihi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dtTeslimTarihi.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dtTeslimTarihi.Properties.Appearance.Options.UseBackColor = true;
            this.dtTeslimTarihi.Properties.Appearance.Options.UseFont = true;
            this.dtTeslimTarihi.Properties.Appearance.Options.UseForeColor = true;
            this.dtTeslimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTeslimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTeslimTarihi.Size = new System.Drawing.Size(251, 28);
            this.dtTeslimTarihi.TabIndex = 10;
            // 
            // dtAlisTarihi
            // 
            this.dtAlisTarihi.EditValue = null;
            this.dtAlisTarihi.Location = new System.Drawing.Point(222, 147);
            this.dtAlisTarihi.Name = "dtAlisTarihi";
            this.dtAlisTarihi.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.dtAlisTarihi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dtAlisTarihi.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dtAlisTarihi.Properties.Appearance.Options.UseBackColor = true;
            this.dtAlisTarihi.Properties.Appearance.Options.UseFont = true;
            this.dtAlisTarihi.Properties.Appearance.Options.UseForeColor = true;
            this.dtAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAlisTarihi.Size = new System.Drawing.Size(251, 28);
            this.dtAlisTarihi.TabIndex = 9;
            this.dtAlisTarihi.EditValueChanged += new System.EventHandler(this.dtAlisTarihi_EditValueChanged);
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarAdi.Enabled = false;
            this.txtYazarAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtYazarAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarAdi.Location = new System.Drawing.Point(222, 103);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(251, 27);
            this.txtYazarAdi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No:";
            // 
            // cbOgrenciNo
            // 
            this.cbOgrenciNo.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbOgrenciNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cbOgrenciNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbOgrenciNo.FormattingEnabled = true;
            this.cbOgrenciNo.Location = new System.Drawing.Point(144, 55);
            this.cbOgrenciNo.Name = "cbOgrenciNo";
            this.cbOgrenciNo.Size = new System.Drawing.Size(221, 27);
            this.cbOgrenciNo.TabIndex = 2;
            this.cbOgrenciNo.SelectedIndexChanged += new System.EventHandler(this.cbOgrenciNo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Teslim Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Alış Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yazar Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kitap Adı:";
            // 
            // cbKitapAdi
            // 
            this.cbKitapAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbKitapAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cbKitapAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbKitapAdi.FormattingEnabled = true;
            this.cbKitapAdi.Location = new System.Drawing.Point(118, 55);
            this.cbKitapAdi.Name = "cbKitapAdi";
            this.cbKitapAdi.Size = new System.Drawing.Size(355, 27);
            this.cbKitapAdi.TabIndex = 7;
            this.cbKitapAdi.SelectedIndexChanged += new System.EventHandler(this.cbKitapAdi_SelectedIndexChanged);
            // 
            // txtOgrenciSinif
            // 
            this.txtOgrenciSinif.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciSinif.Enabled = false;
            this.txtOgrenciSinif.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciSinif.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciSinif.Location = new System.Drawing.Point(144, 181);
            this.txtOgrenciSinif.Name = "txtOgrenciSinif";
            this.txtOgrenciSinif.Size = new System.Drawing.Size(221, 27);
            this.txtOgrenciSinif.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sınıfı:";
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciSoyadi.Enabled = false;
            this.txtOgrenciSoyadi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciSoyadi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(144, 139);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(221, 27);
            this.txtOgrenciSoyadi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı:";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciAdi.Enabled = false;
            this.txtOgrenciAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciAdi.Location = new System.Drawing.Point(144, 97);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(221, 27);
            this.txtOgrenciAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı:";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.btnKitapAl);
            this.groupControl2.Controls.Add(this.dtTeslimTarihi);
            this.groupControl2.Controls.Add(this.dtAlisTarihi);
            this.groupControl2.Controls.Add(this.txtYazarAdi);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.cbKitapAdi);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(424, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(498, 301);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Kitap Seç";
            // 
            // grpOgrenciSec
            // 
            this.grpOgrenciSec.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpOgrenciSec.CaptionImageOptions.Image")));
            this.grpOgrenciSec.Controls.Add(this.txtOgrenciSinif);
            this.grpOgrenciSec.Controls.Add(this.label4);
            this.grpOgrenciSec.Controls.Add(this.txtOgrenciSoyadi);
            this.grpOgrenciSec.Controls.Add(this.label3);
            this.grpOgrenciSec.Controls.Add(this.txtOgrenciAdi);
            this.grpOgrenciSec.Controls.Add(this.label2);
            this.grpOgrenciSec.Controls.Add(this.label1);
            this.grpOgrenciSec.Controls.Add(this.cbOgrenciNo);
            this.grpOgrenciSec.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpOgrenciSec.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenciSec.Name = "grpOgrenciSec";
            this.grpOgrenciSec.Size = new System.Drawing.Size(396, 241);
            this.grpOgrenciSec.TabIndex = 13;
            this.grpOgrenciSec.Text = "Öğrenci Seç";
            // 
            // KitapOduncAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 641);
            this.Controls.Add(this.grpIslemGecmisi);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grpOgrenciSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "KitapOduncAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ödünç Alma";
            this.Load += new System.EventHandler(this.IslemYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemGecmisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpIslemGecmisi)).EndInit();
            this.grpIslemGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTeslimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeslimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciSec)).EndInit();
            this.grpOgrenciSec.ResumeLayout(false);
            this.grpOgrenciSec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvIslemGecmisi;
        private DevExpress.XtraEditors.GroupControl grpIslemGecmisi;
        private DevExpress.XtraEditors.SimpleButton btnKitapAl;
        private DevExpress.XtraEditors.DateEdit dtTeslimTarihi;
        private DevExpress.XtraEditors.DateEdit dtAlisTarihi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOgrenciNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKitapAdi;
        private System.Windows.Forms.TextBox txtOgrenciSinif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl grpOgrenciSec;
    }
}
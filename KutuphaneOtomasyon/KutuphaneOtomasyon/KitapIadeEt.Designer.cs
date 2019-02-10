namespace KutuphaneOtomasyon
{
    partial class KitapIadeEt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIadeEt));
            this.grpOgrenciSec = new DevExpress.XtraEditors.GroupControl();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.btnTeslimAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnSureUzat = new DevExpress.XtraEditors.SimpleButton();
            this.btnMailGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnSirala = new DevExpress.XtraEditors.SimpleButton();
            this.grpIslemGecmisi = new DevExpress.XtraEditors.GroupControl();
            this.dgvIslemGecmisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciSec)).BeginInit();
            this.grpOgrenciSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpIslemGecmisi)).BeginInit();
            this.grpIslemGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOgrenciSec
            // 
            this.grpOgrenciSec.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpOgrenciSec.CaptionImageOptions.Image")));
            this.grpOgrenciSec.Controls.Add(this.txtOgrenciSoyadi);
            this.grpOgrenciSec.Controls.Add(this.label3);
            this.grpOgrenciSec.Controls.Add(this.txtOgrenciAdi);
            this.grpOgrenciSec.Controls.Add(this.label2);
            this.grpOgrenciSec.Controls.Add(this.label1);
            this.grpOgrenciSec.Controls.Add(this.cbOgrenciNo);
            this.grpOgrenciSec.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpOgrenciSec.Location = new System.Drawing.Point(12, 23);
            this.grpOgrenciSec.Name = "grpOgrenciSec";
            this.grpOgrenciSec.Size = new System.Drawing.Size(436, 208);
            this.grpOgrenciSec.TabIndex = 1;
            this.grpOgrenciSec.Text = "Öğrenci Seçimi";
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtOgrenciSoyadi.Enabled = false;
            this.txtOgrenciSoyadi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtOgrenciSoyadi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(144, 139);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(277, 27);
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
            this.txtOgrenciAdi.Size = new System.Drawing.Size(277, 27);
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
            this.cbOgrenciNo.Size = new System.Drawing.Size(277, 27);
            this.cbOgrenciNo.TabIndex = 2;
            this.cbOgrenciNo.SelectedIndexChanged += new System.EventHandler(this.cbOgrenciNo_SelectedIndexChanged);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnTeslimAl.Appearance.Options.UseFont = true;
            this.btnTeslimAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimAl.ImageOptions.Image")));
            this.btnTeslimAl.Location = new System.Drawing.Point(466, 61);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(193, 59);
            this.btnTeslimAl.TabIndex = 5;
            this.btnTeslimAl.Text = "TESLİM AL";
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnSureUzat.Appearance.Options.UseFont = true;
            this.btnSureUzat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSureUzat.ImageOptions.Image")));
            this.btnSureUzat.Location = new System.Drawing.Point(466, 162);
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.Size = new System.Drawing.Size(193, 59);
            this.btnSureUzat.TabIndex = 6;
            this.btnSureUzat.Text = "SÜRE UZAT";
            this.btnSureUzat.Click += new System.EventHandler(this.btnSureUzat_Click);
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnMailGonder.Appearance.Options.UseFont = true;
            this.btnMailGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMailGonder.ImageOptions.Image")));
            this.btnMailGonder.Location = new System.Drawing.Point(701, 61);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(193, 59);
            this.btnMailGonder.TabIndex = 7;
            this.btnMailGonder.Text = "MAİL GÖNDER";
            // 
            // btnSirala
            // 
            this.btnSirala.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnSirala.Appearance.Options.UseFont = true;
            this.btnSirala.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSirala.ImageOptions.Image")));
            this.btnSirala.Location = new System.Drawing.Point(701, 162);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(193, 59);
            this.btnSirala.TabIndex = 8;
            this.btnSirala.Text = "SIRALA";
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // grpIslemGecmisi
            // 
            this.grpIslemGecmisi.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpIslemGecmisi.CaptionImageOptions.Image")));
            this.grpIslemGecmisi.Controls.Add(this.dgvIslemGecmisi);
            this.grpIslemGecmisi.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpIslemGecmisi.Location = new System.Drawing.Point(12, 254);
            this.grpIslemGecmisi.Name = "grpIslemGecmisi";
            this.grpIslemGecmisi.Size = new System.Drawing.Size(910, 293);
            this.grpIslemGecmisi.TabIndex = 9;
            this.grpIslemGecmisi.Text = "Teslim Alınacak Kitaplar";
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
            this.dgvIslemGecmisi.TabIndex = 10;
            this.dgvIslemGecmisi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIslemGecmisi_CellMouseClick);
            // 
            // KitapIadeEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(941, 575);
            this.Controls.Add(this.grpIslemGecmisi);
            this.Controls.Add(this.btnMailGonder);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnSureUzat);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.grpOgrenciSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "KitapIadeEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim Alma";
            this.Load += new System.EventHandler(this.KitapIadeEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciSec)).EndInit();
            this.grpOgrenciSec.ResumeLayout(false);
            this.grpOgrenciSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpIslemGecmisi)).EndInit();
            this.grpIslemGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemGecmisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpOgrenciSec;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOgrenciNo;
        private DevExpress.XtraEditors.SimpleButton btnTeslimAl;
        private DevExpress.XtraEditors.SimpleButton btnSureUzat;
        private DevExpress.XtraEditors.SimpleButton btnMailGonder;
        private DevExpress.XtraEditors.SimpleButton btnSirala;
        private DevExpress.XtraEditors.GroupControl grpIslemGecmisi;
        private System.Windows.Forms.DataGridView dgvIslemGecmisi;
    }
}
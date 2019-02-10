namespace KutuphaneOtomasyon
{
    partial class KitapListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapListesi));
            this.grpKitaplar = new DevExpress.XtraEditors.GroupControl();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.grpKitapFiltre = new DevExpress.XtraEditors.GroupControl();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.btnYazarAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnKitapAdiAra = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtiket = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpKitaplar)).BeginInit();
            this.grpKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKitapFiltre)).BeginInit();
            this.grpKitapFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKitaplar
            // 
            this.grpKitaplar.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpKitaplar.CaptionImageOptions.Image")));
            this.grpKitaplar.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.grpKitaplar.Controls.Add(this.dgvKitaplar);
            this.grpKitaplar.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpKitaplar.Location = new System.Drawing.Point(12, 187);
            this.grpKitaplar.Name = "grpKitaplar";
            this.grpKitaplar.Size = new System.Drawing.Size(1150, 353);
            this.grpKitaplar.TabIndex = 8;
            this.grpKitaplar.Text = "Kitap Listesi";
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKitaplar.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvKitaplar.Location = new System.Drawing.Point(2, 41);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvKitaplar.RowTemplate.Height = 28;
            this.dgvKitaplar.Size = new System.Drawing.Size(1146, 310);
            this.dgvKitaplar.TabIndex = 9;
            this.dgvKitaplar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKitaplar_CellMouseClick);
            // 
            // grpKitapFiltre
            // 
            this.grpKitapFiltre.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpKitapFiltre.CaptionImageOptions.Image")));
            this.grpKitapFiltre.Controls.Add(this.cbKategori);
            this.grpKitapFiltre.Controls.Add(this.btnYazarAra);
            this.grpKitapFiltre.Controls.Add(this.btnKitapAdiAra);
            this.grpKitapFiltre.Controls.Add(this.label3);
            this.grpKitapFiltre.Controls.Add(this.txtEtiket);
            this.grpKitapFiltre.Controls.Add(this.txtYazarAdi);
            this.grpKitapFiltre.Controls.Add(this.label4);
            this.grpKitapFiltre.Controls.Add(this.label2);
            this.grpKitapFiltre.Controls.Add(this.txtKitapAdi);
            this.grpKitapFiltre.Controls.Add(this.label1);
            this.grpKitapFiltre.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpKitapFiltre.Location = new System.Drawing.Point(12, 13);
            this.grpKitapFiltre.Name = "grpKitapFiltre";
            this.grpKitapFiltre.Size = new System.Drawing.Size(1150, 168);
            this.grpKitapFiltre.TabIndex = 1;
            this.grpKitapFiltre.Text = "Kitap Arama";
            // 
            // cbKategori
            // 
            this.cbKategori.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbKategori.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cbKategori.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(811, 54);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(311, 27);
            this.cbKategori.TabIndex = 6;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // btnYazarAra
            // 
            this.btnYazarAra.Appearance.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarAra.Appearance.Options.UseFont = true;
            this.btnYazarAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazarAra.ImageOptions.Image")));
            this.btnYazarAra.Location = new System.Drawing.Point(382, 102);
            this.btnYazarAra.Name = "btnYazarAra";
            this.btnYazarAra.Size = new System.Drawing.Size(158, 44);
            this.btnYazarAra.TabIndex = 5;
            this.btnYazarAra.Text = "ARA";
            this.btnYazarAra.Click += new System.EventHandler(this.btnYazarAra_Click);
            // 
            // btnKitapAdiAra
            // 
            this.btnKitapAdiAra.Appearance.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAdiAra.Appearance.Options.UseFont = true;
            this.btnKitapAdiAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapAdiAra.ImageOptions.Image")));
            this.btnKitapAdiAra.Location = new System.Drawing.Point(382, 45);
            this.btnKitapAdiAra.Name = "btnKitapAdiAra";
            this.btnKitapAdiAra.Size = new System.Drawing.Size(158, 44);
            this.btnKitapAdiAra.TabIndex = 3;
            this.btnKitapAdiAra.Text = "ARA";
            this.btnKitapAdiAra.Click += new System.EventHandler(this.btnKitapAdiAra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(718, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori:";
            // 
            // txtEtiket
            // 
            this.txtEtiket.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEtiket.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtEtiket.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEtiket.Location = new System.Drawing.Point(811, 111);
            this.txtEtiket.Name = "txtEtiket";
            this.txtEtiket.Size = new System.Drawing.Size(311, 27);
            this.txtEtiket.TabIndex = 7;
            this.txtEtiket.TextChanged += new System.EventHandler(this.txtEtiket_TextChanged);
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtYazarAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarAdi.Location = new System.Drawing.Point(128, 111);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(232, 27);
            this.txtYazarAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(739, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Etiket:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Adı:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKitapAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtKitapAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtKitapAdi.Location = new System.Drawing.Point(128, 54);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(232, 27);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // KitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1188, 552);
            this.Controls.Add(this.grpKitapFiltre);
            this.Controls.Add(this.grpKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "KitapListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.KitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKitaplar)).EndInit();
            this.grpKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKitapFiltre)).EndInit();
            this.grpKitapFiltre.ResumeLayout(false);
            this.grpKitapFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpKitaplar;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private DevExpress.XtraEditors.GroupControl grpKitapFiltre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnYazarAra;
        private DevExpress.XtraEditors.SimpleButton btnKitapAdiAra;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox txtEtiket;
        private System.Windows.Forms.Label label4;
    }
}
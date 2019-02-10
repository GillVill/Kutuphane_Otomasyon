namespace KutuphaneOtomasyon
{
    partial class YazarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarListesi));
            this.grpYazarlar = new DevExpress.XtraEditors.GroupControl();
            this.lblYazarSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYazarlar = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblToplamKitap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstKitapListesi = new System.Windows.Forms.ListBox();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpYazarlar)).BeginInit();
            this.grpYazarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYazarlar
            // 
            this.grpYazarlar.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpYazarlar.CaptionImageOptions.Image")));
            this.grpYazarlar.Controls.Add(this.lblYazarSayisi);
            this.grpYazarlar.Controls.Add(this.label2);
            this.grpYazarlar.Controls.Add(this.txtYazarAra);
            this.grpYazarlar.Controls.Add(this.label1);
            this.grpYazarlar.Controls.Add(this.dgvYazarlar);
            this.grpYazarlar.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpYazarlar.Location = new System.Drawing.Point(13, 13);
            this.grpYazarlar.Name = "grpYazarlar";
            this.grpYazarlar.Size = new System.Drawing.Size(522, 410);
            this.grpYazarlar.TabIndex = 1;
            this.grpYazarlar.Text = "Yazarlar";
            // 
            // lblYazarSayisi
            // 
            this.lblYazarSayisi.AutoSize = true;
            this.lblYazarSayisi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarSayisi.ForeColor = System.Drawing.Color.Yellow;
            this.lblYazarSayisi.Location = new System.Drawing.Point(141, 374);
            this.lblYazarSayisi.Name = "lblYazarSayisi";
            this.lblYazarSayisi.Size = new System.Drawing.Size(0, 19);
            this.lblYazarSayisi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Yazar:";
            // 
            // txtYazarAra
            // 
            this.txtYazarAra.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarAra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarAra.Location = new System.Drawing.Point(137, 52);
            this.txtYazarAra.Name = "txtYazarAra";
            this.txtYazarAra.Size = new System.Drawing.Size(218, 27);
            this.txtYazarAra.TabIndex = 2;
            this.txtYazarAra.TextChanged += new System.EventHandler(this.txtYazarAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar Ara:";
            // 
            // dgvYazarlar
            // 
            this.dgvYazarlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYazarlar.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvYazarlar.Location = new System.Drawing.Point(9, 89);
            this.dgvYazarlar.Name = "dgvYazarlar";
            this.dgvYazarlar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dgvYazarlar.RowTemplate.Height = 28;
            this.dgvYazarlar.Size = new System.Drawing.Size(499, 272);
            this.dgvYazarlar.TabIndex = 3;
            this.dgvYazarlar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvYazarlar_CellMouseClick);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.lblToplamKitap);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.lstKitapListesi);
            this.groupControl1.Controls.Add(this.txtYazarSoyadi);
            this.groupControl1.Controls.Add(this.txtYazarAdi);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(542, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(436, 410);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Detaylı Bilgi";
            // 
            // lblToplamKitap
            // 
            this.lblToplamKitap.AutoSize = true;
            this.lblToplamKitap.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKitap.ForeColor = System.Drawing.Color.Yellow;
            this.lblToplamKitap.Location = new System.Drawing.Point(164, 374);
            this.lblToplamKitap.Name = "lblToplamKitap";
            this.lblToplamKitap.Size = new System.Drawing.Size(0, 19);
            this.lblToplamKitap.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Toplam Kitap:";
            // 
            // lstKitapListesi
            // 
            this.lstKitapListesi.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstKitapListesi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKitapListesi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstKitapListesi.FormattingEnabled = true;
            this.lstKitapListesi.ItemHeight = 22;
            this.lstKitapListesi.Location = new System.Drawing.Point(34, 203);
            this.lstKitapListesi.Name = "lstKitapListesi";
            this.lstKitapListesi.Size = new System.Drawing.Size(384, 158);
            this.lstKitapListesi.TabIndex = 7;
            this.lstKitapListesi.SelectedIndexChanged += new System.EventHandler(this.lstKitapListesi_SelectedIndexChanged);
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarSoyadi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarSoyadi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarSoyadi.Location = new System.Drawing.Point(158, 118);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(260, 29);
            this.txtYazarSoyadi.TabIndex = 6;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarAdi.Location = new System.Drawing.Point(158, 68);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(260, 29);
            this.txtYazarAdi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kitap Listesi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yazar Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yazar Adı:";
            // 
            // YazarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(990, 435);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpYazarlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "YazarListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Listesi";
            this.Load += new System.EventHandler(this.YazarListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpYazarlar)).EndInit();
            this.grpYazarlar.ResumeLayout(false);
            this.grpYazarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYazarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpYazarlar;
        private System.Windows.Forms.TextBox txtYazarAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYazarlar;
        private System.Windows.Forms.Label lblYazarSayisi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListBox lstKitapListesi;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamKitap;
        private System.Windows.Forms.Label label6;
    }
}
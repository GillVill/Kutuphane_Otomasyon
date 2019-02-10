namespace KutuphaneOtomasyon
{
    partial class KullaniciDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciDuzenle));
            this.grpYeniKullanici = new DevExpress.XtraEditors.GroupControl();
            this.btnKullaniciGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtYeniParola = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEskiParola = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYeniParolaTekrar = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpYeniKullanici)).BeginInit();
            this.grpYeniKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYeniKullanici
            // 
            this.grpYeniKullanici.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpYeniKullanici.CaptionImageOptions.Image")));
            this.grpYeniKullanici.Controls.Add(this.lblKullaniciAdi);
            this.grpYeniKullanici.Controls.Add(this.labelControl4);
            this.grpYeniKullanici.Controls.Add(this.btnKullaniciGuncelle);
            this.grpYeniKullanici.Controls.Add(this.txtYeniParolaTekrar);
            this.grpYeniKullanici.Controls.Add(this.labelControl1);
            this.grpYeniKullanici.Controls.Add(this.txtYeniParola);
            this.grpYeniKullanici.Controls.Add(this.labelControl3);
            this.grpYeniKullanici.Controls.Add(this.txtEskiParola);
            this.grpYeniKullanici.Controls.Add(this.labelControl2);
            this.grpYeniKullanici.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpYeniKullanici.Location = new System.Drawing.Point(12, 12);
            this.grpYeniKullanici.Name = "grpYeniKullanici";
            this.grpYeniKullanici.Size = new System.Drawing.Size(433, 334);
            this.grpYeniKullanici.TabIndex = 1;
            this.grpYeniKullanici.Text = "Kullanıcı Düzenle";
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciGuncelle.Appearance.Options.UseFont = true;
            this.btnKullaniciGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.ImageOptions.Image")));
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(249, 249);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(166, 57);
            this.btnKullaniciGuncelle.TabIndex = 5;
            this.btnKullaniciGuncelle.Text = "GÜNCELLE";
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // txtYeniParola
            // 
            this.txtYeniParola.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYeniParola.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniParola.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYeniParola.Location = new System.Drawing.Point(152, 162);
            this.txtYeniParola.Name = "txtYeniParola";
            this.txtYeniParola.PasswordChar = '*';
            this.txtYeniParola.Size = new System.Drawing.Size(263, 29);
            this.txtYeniParola.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(32, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Yeni Şifre:";
            // 
            // txtEskiParola
            // 
            this.txtEskiParola.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEskiParola.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiParola.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEskiParola.Location = new System.Drawing.Point(152, 118);
            this.txtEskiParola.Name = "txtEskiParola";
            this.txtEskiParola.PasswordChar = '*';
            this.txtEskiParola.Size = new System.Drawing.Size(263, 29);
            this.txtEskiParola.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Eski Şifre:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 208);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Şifre Tekrar:";
            // 
            // txtYeniParolaTekrar
            // 
            this.txtYeniParolaTekrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYeniParolaTekrar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniParolaTekrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYeniParolaTekrar.Location = new System.Drawing.Point(152, 206);
            this.txtYeniParolaTekrar.Name = "txtYeniParolaTekrar";
            this.txtYeniParolaTekrar.PasswordChar = '*';
            this.txtYeniParolaTekrar.Size = new System.Drawing.Size(263, 29);
            this.txtYeniParolaTekrar.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(32, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 21);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Kullanıcı Adı:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.Appearance.Options.UseForeColor = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(166, 55);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(6, 21);
            this.lblKullaniciAdi.TabIndex = 6;
            this.lblKullaniciAdi.Text = "-";
            // 
            // KullaniciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.grpYeniKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Değiştir";
            this.Load += new System.EventHandler(this.KullaniciDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpYeniKullanici)).EndInit();
            this.grpYeniKullanici.ResumeLayout(false);
            this.grpYeniKullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpYeniKullanici;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciGuncelle;
        private System.Windows.Forms.TextBox txtYeniParola;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtEskiParola;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtYeniParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
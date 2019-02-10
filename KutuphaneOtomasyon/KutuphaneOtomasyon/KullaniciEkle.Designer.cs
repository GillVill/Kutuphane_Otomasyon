namespace KutuphaneOtomasyon
{
    partial class KullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkle));
            this.grpYeniKullanici = new DevExpress.XtraEditors.GroupControl();
            this.btnKullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cbYetki = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciParolaTekrar = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpYeniKullanici)).BeginInit();
            this.grpYeniKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYeniKullanici
            // 
            this.grpYeniKullanici.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpYeniKullanici.CaptionImageOptions.Image")));
            this.grpYeniKullanici.Controls.Add(this.btnKullaniciEkle);
            this.grpYeniKullanici.Controls.Add(this.cbYetki);
            this.grpYeniKullanici.Controls.Add(this.labelControl4);
            this.grpYeniKullanici.Controls.Add(this.txtKullaniciParolaTekrar);
            this.grpYeniKullanici.Controls.Add(this.labelControl3);
            this.grpYeniKullanici.Controls.Add(this.txtKullaniciParola);
            this.grpYeniKullanici.Controls.Add(this.labelControl2);
            this.grpYeniKullanici.Controls.Add(this.txtKullaniciAdi);
            this.grpYeniKullanici.Controls.Add(this.labelControl1);
            this.grpYeniKullanici.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.grpYeniKullanici.Location = new System.Drawing.Point(12, 21);
            this.grpYeniKullanici.Name = "grpYeniKullanici";
            this.grpYeniKullanici.Size = new System.Drawing.Size(433, 327);
            this.grpYeniKullanici.TabIndex = 1;
            this.grpYeniKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciEkle.Appearance.Options.UseFont = true;
            this.btnKullaniciEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.ImageOptions.Image")));
            this.btnKullaniciEkle.Location = new System.Drawing.Point(244, 248);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(166, 57);
            this.btnKullaniciEkle.TabIndex = 6;
            this.btnKullaniciEkle.Text = "EKLE";
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // cbYetki
            // 
            this.cbYetki.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbYetki.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYetki.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbYetki.FormattingEnabled = true;
            this.cbYetki.Location = new System.Drawing.Point(147, 196);
            this.cbYetki.Name = "cbYetki";
            this.cbYetki.Size = new System.Drawing.Size(263, 29);
            this.cbYetki.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Yetki:";
            // 
            // txtKullaniciParolaTekrar
            // 
            this.txtKullaniciParolaTekrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKullaniciParolaTekrar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciParolaTekrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtKullaniciParolaTekrar.Location = new System.Drawing.Point(147, 151);
            this.txtKullaniciParolaTekrar.Name = "txtKullaniciParolaTekrar";
            this.txtKullaniciParolaTekrar.PasswordChar = '*';
            this.txtKullaniciParolaTekrar.Size = new System.Drawing.Size(263, 29);
            this.txtKullaniciParolaTekrar.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 21);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Şifre Tekrar:";
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKullaniciParola.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciParola.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtKullaniciParola.Location = new System.Drawing.Point(147, 107);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.PasswordChar = '*';
            this.txtKullaniciParola.Size = new System.Drawing.Size(263, 29);
            this.txtKullaniciParola.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(147, 61);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(263, 29);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 360);
            this.Controls.Add(this.grpYeniKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpYeniKullanici)).EndInit();
            this.grpYeniKullanici.ResumeLayout(false);
            this.grpYeniKullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpYeniKullanici;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciEkle;
        private System.Windows.Forms.ComboBox cbYetki;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtKullaniciParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
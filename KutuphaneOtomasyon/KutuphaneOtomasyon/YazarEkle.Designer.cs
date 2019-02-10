namespace KutuphaneOtomasyon
{
    partial class YazarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarEkle));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnYazarEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.btnYazarEkle);
            this.groupControl2.Controls.Add(this.txtYazarSoyadi);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.txtYazarAdi);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(415, 212);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Yazar Ekle";
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnYazarEkle.Appearance.Options.UseFont = true;
            this.btnYazarEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazarEkle.ImageOptions.Image")));
            this.btnYazarEkle.Location = new System.Drawing.Point(284, 150);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(110, 50);
            this.btnYazarEkle.TabIndex = 11;
            this.btnYazarEkle.Text = "EKLE";
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarSoyadi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtYazarSoyadi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarSoyadi.Location = new System.Drawing.Point(149, 105);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(245, 27);
            this.txtYazarSoyadi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yazar Soyadı:";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtYazarAdi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtYazarAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtYazarAdi.Location = new System.Drawing.Point(149, 62);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(247, 27);
            this.txtYazarAdi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yazar Adı:";
            // 
            // YazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 246);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "YazarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazarEkle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnYazarEkle;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label6;
    }
}
namespace Pansiyon_otomasyonu
{
    partial class FrmAdminGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.lbl_KullaniciAd = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txtbox_kullanıcıAd = new System.Windows.Forms.TextBox();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_KullaniciAd
            // 
            this.lbl_KullaniciAd.AutoSize = true;
            this.lbl_KullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAd.ForeColor = System.Drawing.Color.White;
            this.lbl_KullaniciAd.Location = new System.Drawing.Point(7, 70);
            this.lbl_KullaniciAd.Name = "lbl_KullaniciAd";
            this.lbl_KullaniciAd.Size = new System.Drawing.Size(139, 25);
            this.lbl_KullaniciAd.TabIndex = 0;
            this.lbl_KullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_Sifre.Location = new System.Drawing.Point(82, 123);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(64, 25);
            this.lbl_Sifre.TabIndex = 0;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // txtbox_kullanıcıAd
            // 
            this.txtbox_kullanıcıAd.Location = new System.Drawing.Point(169, 70);
            this.txtbox_kullanıcıAd.Multiline = true;
            this.txtbox_kullanıcıAd.Name = "txtbox_kullanıcıAd";
            this.txtbox_kullanıcıAd.Size = new System.Drawing.Size(241, 26);
            this.txtbox_kullanıcıAd.TabIndex = 0;
            this.txtbox_kullanıcıAd.TextChanged += new System.EventHandler(this.txtbox_kullanıcıAd_TextChanged);
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Location = new System.Drawing.Point(169, 127);
            this.txtbox_sifre.Multiline = true;
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(241, 26);
            this.txtbox_sifre.TabIndex = 1;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(84, 251);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(121, 38);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(224, 251);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(121, 38);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(446, 32);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Ayı Boğan Tesislerine Hoşgeldiniz";
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 357);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.txtbox_kullanıcıAd);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAd);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullaniciAd;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txtbox_kullanıcıAd;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl1;
    }
}


namespace Pansiyon_otomasyonu
{
    partial class FrmMusteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ucret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GirisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CikisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_verileriGoster = new System.Windows.Forms.Button();
            this.dateTime_cikis = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Giris = new System.Windows.Forms.DateTimePicker();
            this.maskedBox_telno = new System.Windows.Forms.MaskedTextBox();
            this.txt_ucret = new System.Windows.Forms.TextBox();
            this.txtbox_oda = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txtbox_soyad = new System.Windows.Forms.TextBox();
            this.txtBox_ad = new System.Windows.Forms.TextBox();
            this.lbl_ucret = new System.Windows.Forms.Label();
            this.lbl_CıkısTarih = new System.Windows.Forms.Label();
            this.lbl_odasayisi = new System.Windows.Forms.Label();
            this.lbl_GirisTarih = new System.Windows.Forms.Label();
            this.lbl_kimlikNo = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.txtbox_ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Adı,
            this.Soyadı,
            this.Telno,
            this.Tc,
            this.Oda,
            this.Ucret,
            this.GirisTarih,
            this.CikisTarih});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 331);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(990, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // No
            // 
            this.No.Text = "No";
            // 
            // Adı
            // 
            this.Adı.Text = "Adı";
            this.Adı.Width = 91;
            // 
            // Soyadı
            // 
            this.Soyadı.Text = "Soyadı";
            this.Soyadı.Width = 113;
            // 
            // Telno
            // 
            this.Telno.Text = "Telno";
            this.Telno.Width = 97;
            // 
            // Tc
            // 
            this.Tc.Text = "Tc";
            this.Tc.Width = 99;
            // 
            // Oda
            // 
            this.Oda.Text = "Oda";
            this.Oda.Width = 97;
            // 
            // Ucret
            // 
            this.Ucret.Text = "Ücret";
            this.Ucret.Width = 106;
            // 
            // GirisTarih
            // 
            this.GirisTarih.Text = "GirişTarih";
            this.GirisTarih.Width = 142;
            // 
            // CikisTarih
            // 
            this.CikisTarih.Text = "CıkışTarih";
            this.CikisTarih.Width = 175;
            // 
            // btn_verileriGoster
            // 
            this.btn_verileriGoster.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_verileriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_verileriGoster.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verileriGoster.Location = new System.Drawing.Point(791, 2);
            this.btn_verileriGoster.Name = "btn_verileriGoster";
            this.btn_verileriGoster.Size = new System.Drawing.Size(197, 47);
            this.btn_verileriGoster.TabIndex = 1;
            this.btn_verileriGoster.Text = "Verileri göster";
            this.btn_verileriGoster.UseVisualStyleBackColor = false;
            this.btn_verileriGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTime_cikis
            // 
            this.dateTime_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_cikis.Location = new System.Drawing.Point(183, 287);
            this.dateTime_cikis.Name = "dateTime_cikis";
            this.dateTime_cikis.Size = new System.Drawing.Size(200, 27);
            this.dateTime_cikis.TabIndex = 22;
            // 
            // dateTime_Giris
            // 
            this.dateTime_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_Giris.Location = new System.Drawing.Point(183, 251);
            this.dateTime_Giris.Name = "dateTime_Giris";
            this.dateTime_Giris.Size = new System.Drawing.Size(200, 27);
            this.dateTime_Giris.TabIndex = 18;
            // 
            // maskedBox_telno
            // 
            this.maskedBox_telno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedBox_telno.Location = new System.Drawing.Point(183, 92);
            this.maskedBox_telno.Mask = "(999) 000-0000";
            this.maskedBox_telno.Name = "maskedBox_telno";
            this.maskedBox_telno.Size = new System.Drawing.Size(200, 27);
            this.maskedBox_telno.TabIndex = 12;
            // 
            // txt_ucret
            // 
            this.txt_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ucret.Location = new System.Drawing.Point(183, 208);
            this.txt_ucret.Name = "txt_ucret";
            this.txt_ucret.Size = new System.Drawing.Size(200, 27);
            this.txt_ucret.TabIndex = 16;
            // 
            // txtbox_oda
            // 
            this.txtbox_oda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_oda.Location = new System.Drawing.Point(183, 166);
            this.txtbox_oda.Name = "txtbox_oda";
            this.txtbox_oda.Size = new System.Drawing.Size(200, 27);
            this.txtbox_oda.TabIndex = 14;
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(183, 132);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(200, 27);
            this.txt_tc.TabIndex = 13;
            // 
            // txtbox_soyad
            // 
            this.txtbox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_soyad.Location = new System.Drawing.Point(183, 51);
            this.txtbox_soyad.Name = "txtbox_soyad";
            this.txtbox_soyad.Size = new System.Drawing.Size(200, 27);
            this.txtbox_soyad.TabIndex = 11;
            // 
            // txtBox_ad
            // 
            this.txtBox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ad.Location = new System.Drawing.Point(183, 12);
            this.txtBox_ad.Name = "txtBox_ad";
            this.txtBox_ad.Size = new System.Drawing.Size(200, 27);
            this.txtBox_ad.TabIndex = 10;
            // 
            // lbl_ucret
            // 
            this.lbl_ucret.AutoSize = true;
            this.lbl_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ucret.Location = new System.Drawing.Point(113, 207);
            this.lbl_ucret.Name = "lbl_ucret";
            this.lbl_ucret.Size = new System.Drawing.Size(64, 25);
            this.lbl_ucret.TabIndex = 19;
            this.lbl_ucret.Text = "Ücret:";
            // 
            // lbl_CıkısTarih
            // 
            this.lbl_CıkısTarih.AutoSize = true;
            this.lbl_CıkısTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CıkısTarih.Location = new System.Drawing.Point(62, 287);
            this.lbl_CıkısTarih.Name = "lbl_CıkısTarih";
            this.lbl_CıkısTarih.Size = new System.Drawing.Size(115, 25);
            this.lbl_CıkısTarih.TabIndex = 15;
            this.lbl_CıkısTarih.Text = "Cıkış Tarihi:";
            // 
            // lbl_odasayisi
            // 
            this.lbl_odasayisi.AutoSize = true;
            this.lbl_odasayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_odasayisi.Location = new System.Drawing.Point(39, 168);
            this.lbl_odasayisi.Name = "lbl_odasayisi";
            this.lbl_odasayisi.Size = new System.Drawing.Size(144, 25);
            this.lbl_odasayisi.TabIndex = 20;
            this.lbl_odasayisi.Text = "Oda Numarası:";
            // 
            // lbl_GirisTarih
            // 
            this.lbl_GirisTarih.AutoSize = true;
            this.lbl_GirisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GirisTarih.Location = new System.Drawing.Point(66, 248);
            this.lbl_GirisTarih.Name = "lbl_GirisTarih";
            this.lbl_GirisTarih.Size = new System.Drawing.Size(111, 25);
            this.lbl_GirisTarih.TabIndex = 17;
            this.lbl_GirisTarih.Text = "Giriş Tarihi:";
            // 
            // lbl_kimlikNo
            // 
            this.lbl_kimlikNo.AutoSize = true;
            this.lbl_kimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kimlikNo.Location = new System.Drawing.Point(39, 132);
            this.lbl_kimlikNo.Name = "lbl_kimlikNo";
            this.lbl_kimlikNo.Size = new System.Drawing.Size(138, 25);
            this.lbl_kimlikNo.TabIndex = 21;
            this.lbl_kimlikNo.Text = "T.C Kimlik No:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel.Location = new System.Drawing.Point(8, 91);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(169, 25);
            this.lbl_tel.TabIndex = 23;
            this.lbl_tel.Text = "Telefon numarası:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(98, 48);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(79, 25);
            this.lbl_Soyad.TabIndex = 24;
            this.lbl_Soyad.Text = "Soyadı:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adi.Location = new System.Drawing.Point(130, 14);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(47, 25);
            this.lbl_Adi.TabIndex = 25;
            this.lbl_Adi.Text = "Adı:";
            // 
            // txtbox_ara
            // 
            this.txtbox_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_ara.Location = new System.Drawing.Point(773, 289);
            this.txtbox_ara.Name = "txtbox_ara";
            this.txtbox_ara.Size = new System.Drawing.Size(215, 27);
            this.txtbox_ara.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(714, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "İsim:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_guncelle.Location = new System.Drawing.Point(791, 55);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(197, 47);
            this.btn_guncelle.TabIndex = 27;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Magenta;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sil.Location = new System.Drawing.Point(791, 108);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(197, 47);
            this.btn_sil.TabIndex = 27;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.Teal;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ara.Location = new System.Drawing.Point(791, 226);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(197, 47);
            this.btn_ara.TabIndex = 27;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_temizle.Location = new System.Drawing.Point(791, 168);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(197, 47);
            this.btn_temizle.TabIndex = 28;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(989, 526);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_cikis);
            this.Controls.Add(this.dateTime_Giris);
            this.Controls.Add(this.maskedBox_telno);
            this.Controls.Add(this.txtbox_ara);
            this.Controls.Add(this.txt_ucret);
            this.Controls.Add(this.txtbox_oda);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txtbox_soyad);
            this.Controls.Add(this.txtBox_ad);
            this.Controls.Add(this.lbl_ucret);
            this.Controls.Add(this.lbl_CıkısTarih);
            this.Controls.Add(this.lbl_odasayisi);
            this.Controls.Add(this.lbl_GirisTarih);
            this.Controls.Add(this.lbl_kimlikNo);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Adi);
            this.Controls.Add(this.btn_verileriGoster);
            this.Controls.Add(this.listView1);
            this.Name = "FrmMusteriler";
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader Soyadı;
        private System.Windows.Forms.ColumnHeader Telno;
        private System.Windows.Forms.ColumnHeader Tc;
        private System.Windows.Forms.ColumnHeader Oda;
        private System.Windows.Forms.ColumnHeader Ucret;
        private System.Windows.Forms.ColumnHeader GirisTarih;
        private System.Windows.Forms.ColumnHeader CikisTarih;
        private System.Windows.Forms.Button btn_verileriGoster;
        private System.Windows.Forms.DateTimePicker dateTime_cikis;
        private System.Windows.Forms.DateTimePicker dateTime_Giris;
        private System.Windows.Forms.MaskedTextBox maskedBox_telno;
        private System.Windows.Forms.TextBox txt_ucret;
        private System.Windows.Forms.TextBox txtbox_oda;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txtbox_soyad;
        private System.Windows.Forms.TextBox txtBox_ad;
        private System.Windows.Forms.Label lbl_ucret;
        private System.Windows.Forms.Label lbl_CıkısTarih;
        private System.Windows.Forms.Label lbl_odasayisi;
        private System.Windows.Forms.Label lbl_GirisTarih;
        private System.Windows.Forms.Label lbl_kimlikNo;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Adi;
        private System.Windows.Forms.TextBox txtbox_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_temizle;
    }
}
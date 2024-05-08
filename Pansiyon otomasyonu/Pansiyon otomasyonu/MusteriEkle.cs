using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_otomasyonu
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        

        SqlConnection baglanti= new SqlConnection("Data Source=DESKTOP-54I5E04\\SQLEXPRESS01;Initial Catalog=Pansiyon;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA104(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "101";
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into ODA101(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);  
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA102(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA103(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA105(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA106(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_108_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA108(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ODA109(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_107_Click(object sender, EventArgs e)
        {
            txtbox_oda.Text = "107";
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into ODA107(Adi,Soyadi) values ('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btn_dolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Odalar Doludur:)","BİLGİ",MessageBoxButtons.OK);
        }

        private void btn_bos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Odalar Boştur:)","BİLGİ",MessageBoxButtons.OK);
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTime_cıkıs_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dateTime_Giris.Text);
            DateTime buyukTarih = Convert.ToDateTime(dateTime_cıkıs.Text);

            TimeSpan sunuc = buyukTarih - kucukTarih;

            label1.Text = sunuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label1.Text) * 50;
            txt_ucret.Text = ucret.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERİ (Adi,Soyadi,TELNO,TC,ODA,UCRET,GİRİSTARİH,CİKİSTARİH) VALUES('" + txtBox_ad.Text + "','" + txtbox_soyad.Text + "','" + maskedBox_telno.Text + "','" + textBox3.Text + "','" + txtbox_oda.Text + "','" + txt_ucret.Text + "','" + dateTime_Giris.Value.ToString("yyyy-MM-dd") + "','" + dateTime_cıkıs.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt Başarılı","Başarılı", MessageBoxButtons.OK);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from ODA101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;

                btn101.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from ODA102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from ODA103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
                btn103.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from ODA104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
                btn104.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from ODA105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
                btn105.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from ODA106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
                btn106.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from ODA107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
                btn107.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from ODA108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
                btn108.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from ODA109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
                btn109.Enabled = false;
            }
        }
    }
}

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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=DESKTOP-54I5E04\\SQLEXPRESS01;Initial Catalog=Pansiyon;Integrated Security=True");
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMUSTERİ",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MUSTERIID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["TELNO"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["ODA"].ToString());
                ekle.SubItems.Add(oku["UCRET"].ToString());
                ekle.SubItems.Add(oku["GİRİSTARİH"].ToString());
                ekle.SubItems.Add(oku["CİKİSTARİH"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
            
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtBox_ad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtbox_soyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            maskedBox_telno.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txt_tc.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtbox_oda.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txt_ucret.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTime_Giris.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTime_cikis.Text = listView1.SelectedItems[0].SubItems[8].Text;

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txtbox_oda.Text == "101")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA101", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "102")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA102", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "103")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA103", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "104")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA104", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "105")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA105", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "106")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA106", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "107")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA107", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "108")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA108", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
            if (txtbox_oda.Text == "109")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);
                SqlCommand cmd1 = new SqlCommand("Delete from ODA109", baglanti);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtBox_ad.Clear();
            txtbox_soyad.Clear();
            maskedBox_telno.Clear();
            txt_tc.Clear();
            txtbox_oda.Clear();
            txt_ucret.Clear();
            dateTime_Giris.Text = "";
            dateTime_cikis.Text = "";


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLMUSTERİ set Adi='" + txtBox_ad.Text + "',Soyadi='" + txtbox_soyad.Text + "',TELNO='" + maskedBox_telno.Text + "',TC='" + txt_tc.Text + "',ODA='" + txtbox_oda.Text + "',UCRET='" + txt_ucret.Text + "' where MUSTERIID='" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme başarılı", "Bilgi", MessageBoxButtons.OK);
            baglanti.Close() ;
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMUSTERİ where Adi like '%"+ txtbox_ara.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MUSTERIID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["TELNO"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["ODA"].ToString());
                ekle.SubItems.Add(oku["UCRET"].ToString());
                ekle.SubItems.Add(oku["GİRİSTARİH"].ToString());
                ekle.SubItems.Add(oku["CİKİSTARİH"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        //Data Source = DESKTOP - 54I5E04\\SQLEXPRESS01;Initial Catalog = Pansiyon; Integrated Security = True
    }
}//            SqlCommand cmd = new SqlCommand("Delete from TBLMUSTERİ where MUSTERIID=(" + id + ")", baglanti);



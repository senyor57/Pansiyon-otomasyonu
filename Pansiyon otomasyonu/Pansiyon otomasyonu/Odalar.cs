﻿using System;
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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-54I5E04\\SQLEXPRESS01;Initial Catalog=Pansiyon;Integrated Security=True");
        private void Odalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from ODA101", baglanti);
            SqlDataReader oku1=komut1.ExecuteReader();

            while(oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString()+ " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
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
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_otomasyonu
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void btn_AdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm= new FrmAdminGiris();
            frm.Show();
            this.Hide();
        }

        private void btn_YeniMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkle frm= new MusteriEkle();
            frm.Show();
            this.Hide();
        }

        private void btn_odalar_Click(object sender, EventArgs e)
        {
            Odalar frm= new Odalar();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm= new FrmMusteriler();
            frm.Show();
            this.Hide();
        }

        private void btn_hakkımda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayı Boğan Tesisleri pansiyon uygulaması/ 2024-Sinop ","BİLGİ",MessageBoxButtons.OK);
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}

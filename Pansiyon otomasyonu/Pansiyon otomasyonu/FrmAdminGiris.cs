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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void txtbox_kullanıcıAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txtbox_kullanıcıAd.Text=="admin" && txtbox_sifre.Text =="123")
            {
                FrmAnasayfa fr = new FrmAnasayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre hatalı"," Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

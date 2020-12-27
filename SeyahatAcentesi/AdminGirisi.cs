using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace SeyahatAcentesi
{
    public partial class AdminGirisi : Form
    {
        public AdminGirisi()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7BLQFJ04;Initial Catalog=SeyahatAcentesiDbase;Integrated Security=True");
        SqlDataReader dr;
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            this.komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tblAdmin where adminKullaniciAdi='" + tbKullaniciAdi.Text + "' AND adminSifre='" + tbAdminSifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AdminPaneli panel = new AdminPaneli();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz.");
            }

            baglanti.Close();



        }
    }
}

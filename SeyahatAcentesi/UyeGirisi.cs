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
namespace SeyahatAcentesi
{
    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7BLQFJ04;Initial Catalog=SeyahatAcentesiDbase;Integrated Security=True");
        SqlDataReader dr;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            this.komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Uyeler where UyeMail='" + tbxEposta.Text + "' AND UyeParola='" + tbxSifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                UyeFormu frm=new UyeFormu();
                frm.Show();
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

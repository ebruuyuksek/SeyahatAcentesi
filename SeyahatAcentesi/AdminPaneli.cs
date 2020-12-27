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
    public partial class AdminPaneli : Form
    {
        SQLclass islemler=new SQLclass();
        public AdminPaneli()
        {
            InitializeComponent();
        }
       


        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Width = 100; 
        }

        private void AdminPaneli_MouseHover(object sender, EventArgs e)
        {
            panel1.Width = 100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=LAPTOP-7BLQFJ04;Initial Catalog=SeyahatAcentesiDbase;Integrated Security=True");

        private void verilerigoruntule()
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("Select *From Uyeler",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle=new ListViewItem();
                ekle.Text = oku["Uyeid"].ToString();
                ekle.SubItems.Add(oku["UyeAdi"].ToString());
                ekle.SubItems.Add(oku["UyeSoyadi"].ToString());
                ekle.SubItems.Add(oku["UyeMail"].ToString());
                ekle.SubItems.Add(oku["UyeTelefon"].ToString());
                listView1.Items.Add(ekle); 
            }
            baglanti.Close();
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigoruntule();

        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            
            
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            
        }
    }
}

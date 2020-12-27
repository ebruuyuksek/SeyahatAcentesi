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
using System.Net.Mail;

namespace SeyahatAcentesi
{
    public partial class KayitOl : Form
    {
        /// <summary>
        /// //////
        /// </summary>
        SQLclass islemler = new SQLclass();


        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7BLQFJ04;Initial Catalog=SeyahatAcentesiDbase;Integrated Security=True");

        private void btnUyeOl_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeOl_Click_1(object sender, EventArgs e)
        {

            bool deger = Email_Format_Kontrol(tbEposta.Text);

 /*
            if (tbAd.Text.Trim() == "")
                errorProvider1.SetError(tbAd, "Bu alan boş bırakılamaz.");
            if (tbSoyad.Text.Trim() == "")
                errorProvider1.SetError(tbSoyad, "Bu alan boş bırakılamaz.");
            if (masktbNo.Text.Trim() == "")
                errorProvider1.SetError(masktbNo, "Bu alan boş bırakılamaz.");
            if (deger == false)
                errorProvider1.SetError(tbEposta, "Lütfen geçerli bir e-posta giriniz..");
            if (tbTC.Text.Trim() == "")
                errorProvider1.SetError(tbTC, "Bu alan boş bırakılamaz.");
            if (tbSifre.Text.Trim() == "")
                errorProvider1.SetError(tbSifre, "Bu alan boş bırakılamaz.");
           
              else
              {
                  errorProvider1.SetError(tbAd, "");
                  baglanti.Open();
                  SqlCommand komut =
                      new SqlCommand(
                          "insert into Uyeler (UyeAdi,UyeSoyadi,UyeTelefon,UyeMail,Uyetckimlik,UyeParola) values ('" + tbAd.Text + "' , '" + tbSoyad.Text +
                          "','" + masktbNo.Text + "', '" + tbEposta.Text + "','" + tbTC.Text + "','" + tbSifre.Text + "') ", baglanti);
                  komut.ExecuteNonQuery();
                  baglanti.Close();
                  MessageBox.Show("Kaydınız tamamlanmıştır.");

              }
           */
            
                Uye yeni = new Uye();
                yeni.Ad = tbAd.Text;
                yeni.Soyad = tbSoyad.Text;
                yeni.Mail = tbEposta.Text;
                yeni.Telefon = masktbNo.Text;
                yeni.Tcno = tbTC.Text;
                yeni.Parola = tbSifre.Text;
                islemler.Ekle(yeni);
                MessageBox.Show("Kaydınız tamamlanmıştır.");

            





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeGirisi grs = new UyeGirisi();
            grs.Show();
            this.Hide();
        }

        private void tbAd_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}


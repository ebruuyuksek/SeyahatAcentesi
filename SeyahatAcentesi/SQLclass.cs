using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Data;
using System.Data.Sql;

namespace SeyahatAcentesi
{

    class SQLclass
    {
        SqlConnection con;


        public SQLclass()
        {
            Connect();
        }

        public void Connect()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-7BLQFJ04;Initial Catalog=SeyahatAcentesiDbase;Integrated Security=True");
        }

        public List<Uye> Listele()
        {
            SqlCommand cmd=new SqlCommand("Select *From Uyeler");

            //try
            //{
                List<Uye> UyelerListesi = new List<Uye>();
            // cmd.CommandText = "Select *From Uyeler";
            //cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Uye kayit = new Uye();
                    kayit.Ad = reader[1].ToString();
                    kayit.Soyad = reader[2].ToString();
                   // kayit.Telefon = reader[3].ToString();
                    kayit.Mail = reader[4].ToString();
                    //kayit.Tcno = reader[5].ToString();
                    //kayit.Parola = reader[8].ToString();
                    UyelerListesi.Add(kayit);
                }
                con.Close();
                return UyelerListesi;
          //  }
          //  catch
          //  {
          //      throw;
           // }
           // finally
           // {
           //     if (con != null)
           //     {
                 //   con.Close();
          //      }
          //  }
        }

        public void Ekle(Uye k)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Uyeler (UyeAdi,UyeSoyadi,UyeTelefon,UyeMail,Uyetckimlik,UyeParola) values ('" + k.Ad + "' , '" + k.Soyad +
                   "','" + k.Telefon + "', '" + k.Mail + "','" + k.Tcno + "','" + k.Parola + "') ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Guncelle(Uye eskiUye, Uye yeniUye)
        {
            try
            {
                SqlCommand cmd=new SqlCommand("Update Uyeler SET UyeAdi='" + yeniUye.Ad + "',UyeSoyadi='" + yeniUye.Soyad + "',UyeTelefon='" + yeniUye.Telefon + "',UyeMail='" + yeniUye.Mail + "',Uyetckimlik='" + yeniUye.Tcno + "' Where Uyeid=" + eskiUye.Id + "");
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }

        public void Sil(Uye k)
        {
            try
            {
                SqlCommand cmd=new SqlCommand( "Delete From Uyeler Where Uyeid=" + k.Id + "");
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}

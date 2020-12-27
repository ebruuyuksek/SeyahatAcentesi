using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi
{
    class Uye
    {
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _adi;
        public string Ad
        {
            get { return _adi; }
            set { _adi = value; }
        }


        string _soyadi;
        public string Soyad
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }


        string _telefonu;
        public string Telefon
        {
            get { return _telefonu; }
            set { _telefonu = value; }
        }

        string p_mail;
        public string Mail
        {
            get { return p_mail; }
            set { p_mail = value; }
        }
        string tc_no;
        public string Tcno
        {
            get { return tc_no; }
            set { tc_no = value; }
        }

        string p_parola;
        public string Parola
        {
            get { return p_parola; }
            set { p_parola = value; }
        }


    }
}

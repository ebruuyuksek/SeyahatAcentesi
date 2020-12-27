using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatAcentesi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //pictureBox1.Load("C:\\Users\\Ebru\\Desktop\\Seyahat Acentesi\\projede_kullandığım_resimler\\galeri1.jpg");

        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            KayitOl  kayit=new KayitOl();
            kayit.Show();
            this.Hide();

            
        }

        private void btn_UyeGirisi_Click(object sender, EventArgs e)
        {
            UyeGirisi uye = new UyeGirisi();
            uye.Show();
            this.Hide();
        }

        private void btn_AdminGirisi_Click(object sender, EventArgs e)
        {
            AdminGirisi admin=new AdminGirisi();
            admin.Show();
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.galeri1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.galeri2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuizGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=localhost;Initial Catalog=Quiz;Integrated Security=True");//Veri tabanı bağlanma yeridir.

        int sayac = 0;
        int puan = 0;
        int zaman = 101;

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 101;

            if(sayac==11)
            {
                this.Close();
            }


            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;

            BtnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            BtnBasla.Text = "Sonraki Soru";
            sayac += 1;
            lblsoru.Text = sayac.ToString();//Kaçıncı soruda olduğunu belirtmektedir.

            if (sayac == 1 || sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(@"Select * from soru1 order by NEWID()", baglan);//soru1 tablosundan rastgele soru getirmesi için kullanılabilir.
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["secenek1"].ToString());
                    button2.Text = (oku["secenek2"].ToString());
                    button3.Text = (oku["secenek3"].ToString());
                    button4.Text = (oku["secenek4"].ToString());//Veri tabanından seçenekleri okuma işlemidir.
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru_cevap"].ToString());

                }
                baglan.Close();
            }
            else if (sayac == 2 || sayac == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(@"Select * from soru2 order by NEWID()", baglan);//soru1 tablosundan rastgele soru getirmesi için kullanılabilir.
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["secenek1"].ToString());
                    button2.Text = (oku["secenek2"].ToString());
                    button3.Text = (oku["secenek3"].ToString());
                    button4.Text = (oku["secenek4"].ToString());//Veri tabanından seçenekleri okuma işlemidir.
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru_cevap"].ToString());

                }
                baglan.Close();
            }
            else if (sayac == 3 || sayac == 8)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(@"Select * from soru3 order by NEWID()", baglan);//soru1 tablosundan rastgele soru getirmesi için kullanılabilir.
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["secenek1"].ToString());
                    button2.Text = (oku["secenek2"].ToString());
                    button3.Text = (oku["secenek3"].ToString());
                    button4.Text = (oku["secenek4"].ToString());//Veri tabanından seçenekleri okuma işlemidir.
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru_cevap"].ToString());

                }
                baglan.Close();
            }
            else if (sayac == 4  || sayac == 9)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(@"Select * from soru4 order by NEWID()", baglan);//soru1 tablosundan rastgele soru getirmesi için kullanılabilir.
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["secenek1"].ToString());
                    button2.Text = (oku["secenek2"].ToString());
                    button3.Text = (oku["secenek3"].ToString());
                    button4.Text = (oku["secenek4"].ToString());//Veri tabanından seçenekleri okuma işlemidir.
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru_cevap"].ToString());

                }
                baglan.Close();
            }
            else if (sayac == 5 || sayac==10 )
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(@"Select * from soru5 order by NEWID()", baglan);//soru1 tablosundan rastgele soru getirmesi için kullanılabilir.
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["secenek1"].ToString());
                    button2.Text = (oku["secenek2"].ToString());
                    button3.Text = (oku["secenek3"].ToString());
                    button4.Text = (oku["secenek4"].ToString());//Veri tabanından seçenekleri okuma işlemidir.
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru_cevap"].ToString());

                }
                baglan.Close();
            }
            else
            {
                    timer1.Enabled = false;
                    BtnBasla.Text = "Cikis";
                    BtnBasla.Enabled =true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    label4.Text = "OYUN BİTTİ";
               // UPDATE dbo.Users SET users.Score = 20 where users.id = 1
            }
           


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblsoru.Text = sayac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( button1.Text == lbldogru.Text )
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }

            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button2.Text == lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puan += 10;
                lblpuan.Text = puan.ToString();
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman-1;
            lblzaman.Text = zaman.ToString();

            if (zaman == 0)
            {
                timer1.Enabled = false;
                BtnBasla.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void lbldogru_Click(object sender, EventArgs e)
        {

        }
    }
}

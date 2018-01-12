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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=localhost;Initial Catalog=Quiz;Integrated Security=True");//Veri tabanı bağlanma yeridir.

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void result_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand(@"Select u.* from dbo.Users u where u.id=1", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            kllnc1.Text = (oku["id"].ToString());

            baglan.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

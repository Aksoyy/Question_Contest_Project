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
    public partial class PuanTablosu : Form
    {
        public PuanTablosu()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void griddoldur()
        {
            con = new SqlConnection("server=localhost; Initial Catalog=Quiz;Integrated Security=True");
            da = new SqlDataAdapter("Select Name,point From Users ORDER BY point DESC", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Users");
            dataGridView1.DataSource = ds.Tables["Users"];
            con.Close();
        }

        private void PuanTablosu_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

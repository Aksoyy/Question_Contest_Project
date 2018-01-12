using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public User user;
        public UserProvider islem;
        private void button2_Click_1(object sender, EventArgs e)
        {
            islem = new UserProvider();
            user = islem.getUser(txtName.Text, txtPass.Text);
            if (user != null)
            {
                FrmQuizGame f2 = new FrmQuizGame();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da şifre Yanlış!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            islem = new UserProvider();
            user = new User();
            user.Name = txtName.Text;
            user.Password = txtPass.Text;
            if (islem.InsertUser(user))
            {
                MessageBox.Show("Kullanıcı Eklendi");
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı adı var!");
            }

        }
    }
}
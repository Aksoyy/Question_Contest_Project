using System;
using System.Windows.Forms;
using GPNetworkServer;
using GPNetworkMessage;
using GPNetworkClient;

namespace QuizGame
{
    public partial class FrmQuizGame : Form
    {
        private string ipAddressString = "127.0.0.1";
        private int portNumber = 127;
        private TCPServer server;

        public FrmQuizGame()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmPlay newFormPlay = new FrmPlay();
            newFormPlay.Show();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmInfo newFormInfo = new FrmInfo();
            newFormInfo.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            server = new TCPServer(ipAddressString, portNumber);
            server.Start();
            Form2 newForm2 = new Form2();
            newForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PuanTablosu newForm3 = new PuanTablosu();
            newForm3.Show();
        }
    }
}

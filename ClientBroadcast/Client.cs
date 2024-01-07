using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ClientBroadcast
{
    public partial class Client : MetroFramework.Forms.MetroForm
    {
        string ServerIPAddress;
        SoundPlayer soundPlayer;
        string SelectedFolder;

        TcpClient tcpClient;

        public Client()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer();
            this.Load += new System.EventHandler(this.Client_Load);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string ServerIPAddress = TextBox1.Text;

            Properties.Settings.Default.IPAddress = ServerIPAddress;
            Properties.Settings.Default.Save();

            MessageBox.Show("IP가 업데이트 되었습니다.");

            // ClientProgram.cs 폼을 열고 현재 폼을 닫음
            ClientBroadcast.ClientProgram clientProgramForm = new ClientBroadcast.ClientProgram(ServerIPAddress);
            clientProgramForm.Show();
            this.Close();
        }


        private void Client_Load(object sender, EventArgs e)
        {
            // 이전에 저장한 IP를 가져와서 textBox1에 설정합니다.
            TextBox1.Text = Properties.Settings.Default.IPAddress;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

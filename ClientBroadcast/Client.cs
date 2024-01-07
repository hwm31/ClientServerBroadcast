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
        }
        private void Client_Load(object sender, EventArgs e)
        {
            // 이전에 저장한 IP를 가져와서 textBox1에 설정합니다.
            TextBox1.Text = Properties.Settings.Default.IPAddress;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFolderBrowserDialog));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            try
            {
                tcpClient = new TcpClient(ServerIPAddress, 12345);
                NetworkStream networkStream = tcpClient.GetStream();

                // 클라이언트 측에서 파일 이름을 받아옴
                byte[] fileNameBuffer = new byte[1024];
                int totalBytesRead = 0;
                int bytesRead;

                try
                {
                    while (totalBytesRead < fileNameBuffer.Length)
                    {
                        bytesRead = networkStream.Read(fileNameBuffer, totalBytesRead, 1);

                        if (bytesRead == 0)
                        {
                            Console.WriteLine("서버에서 읽을 데이터가 없습니다.");
                            break;
                        }

                        if (fileNameBuffer[totalBytesRead] == 0) // 널 문자를 만나면 중지
                        {
                            break;
                        }

                        totalBytesRead += bytesRead;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"파일 이름을 받아오는 도중 예외 발생: {ex.Message}");
                    return;
                }

                if (totalBytesRead == 0)
                {
                    Console.WriteLine("파일 이름을 받아오는 중에 문제가 발생했습니다.");
                    return;
                }

                string fileName = Encoding.UTF8.GetString(fileNameBuffer, 0, totalBytesRead);
                string fullPath = $"{SelectedFolder}{fileName}";

                using (Stream stream = tcpClient.GetStream())
                {
                    using (FileStream fileStream = File.Create(fullPath))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead2;

                        while ((bytesRead2 = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead2);
                        }
                    }
                }

                try
                {
                    Process.Start(fullPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"MP3 파일을 실행하는 도중 오류 발생: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류: {ex.Message}");
            }
            finally
            {
                tcpClient?.Close();
            }
        }



        private void ShowFolderBrowserDialog()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "폴더 선택";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedFolder = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}

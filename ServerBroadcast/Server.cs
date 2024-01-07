using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebSockets;
using System;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using MetroFramework.Controls;
using System.Drawing;
using System.Data;
using System.Collections.Generic;

namespace ServerBroadcast
{
    public partial class Server : MetroFramework.Forms.MetroForm
    {
        private TcpListener tcpListener;
        private Thread listenerThread;

        DataTable GridData;

        string ServerIPAddress = "192.168.219.109";
        string MP3FilePath = "";

        public Server()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Invoke(new Action(() =>
            {
                this.tcpListener = new TcpListener(IPAddress.Parse(ServerIPAddress), 12345);
                this.listenerThread = new Thread(new ThreadStart(ListenForClients));
                this.listenerThread.Start();
            }));

            DataTable dt = GetData();

            grdMain.DataSource = dt;
        }

        private void ListenForClients()
        {
            this.tcpListener.Start();

            while (true)
            {
                TcpClient client = this.tcpListener.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object clientObj)
        {
            if(string.IsNullOrEmpty(MP3FilePath))
            {
                MessageBox.Show("선택한 파일이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TcpClient tcpClient = (TcpClient)clientObj;
            NetworkStream clientStream = tcpClient.GetStream();

            // 서버 측에서 파일 이름을 먼저 전송
            string fileName = Path.GetFileName(MP3FilePath);
            byte[] fileNameBuffer = Encoding.UTF8.GetBytes(fileName + '\0');
            clientStream.Write(fileNameBuffer, 0, fileNameBuffer.Length);

            using (FileStream fileStream = File.OpenRead(MP3FilePath))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    clientStream.Write(buffer, 0, bytesRead);
                }
            }

            tcpClient.Close();
        }

        private void btnFileFind_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFolderBrowserDialog));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void ShowFolderBrowserDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP3 파일 (*.mp3)|*.mp3|모든 파일 (*.*)|*.*";
                openFileDialog.Title = "파일 열기";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MP3FilePath = openFileDialog.FileName;
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ServerBroadcast.ServerSetting serverSettingForm = new ServerBroadcast.ServerSetting();
            serverSettingForm.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            ServerBroadcast.ServerSetting serverSettingInstance = new ServerBroadcast.ServerSetting();
            ServerBroadcast.ServerClientAdd serverClientAddForm = new ServerBroadcast.ServerClientAdd(serverSettingInstance);
            serverClientAddForm.Show();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            List<string> deletedItems = new List<string>();

            for (int i = grdMain.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = grdMain.Rows[i];
                if (row.Cells["colCHK"].Value != null && (bool)row.Cells["colCHK"].Value)
                {
                    // 첫 번째 열의 값을 저장합니다. 필요에 따라 다른 열을 선택할 수 있습니다.
                    deletedItems.Add(row.Cells[1].Value.ToString());
                    grdMain.Rows.RemoveAt(i);
                }
            }

            // 삭제된 항목들을 메시지 박스로 표시합니다.
            if (deletedItems.Count > 0)
            {
                string message = "삭제된 클라이언트:\n" + string.Join("\n", deletedItems);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("삭제된 항목이 없습니다.");
            }
        }

        DataTable GetData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CHK");
            dt.Columns.Add("IP");
            dt.Columns.Add("LOC");
            dt.Columns.Add("TEMP");
            dt.Columns.Add("STATUS");

            DataRow row = dt.NewRow();
            row["IP"] = "192.168.10.100";
            row["LOC"] = "본관 건물 2층";
            row["TEMP"] = "일반 알림";

            dt.Rows.Add(row.ItemArray);

            row["IP"] = "192.168.10.102";
            row["LOC"] = "본관 건물 32층";
            row["TEMP"] = "주주 총회";

            dt.Rows.Add(row.ItemArray);

            return dt;
        }
    }
}

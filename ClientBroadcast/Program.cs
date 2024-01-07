using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBroadcast
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 이전에 저장된 IP 주소 확인
            string savedIP = Properties.Settings.Default.IPAddress;

            if (string.IsNullOrEmpty(savedIP))
            {
                // IP 주소가 없으면 Client.cs 폼을 띄움
                Application.Run(new Client());
            }
            else
            {
                // 저장된 IP 주소가 있으면 ClientProgram.cs 폼을 띄움
                ClientBroadcast.ClientProgram clientProgramForm = new ClientBroadcast.ClientProgram(savedIP);
                clientProgramForm.Show();
                Application.Run();
            }
        }

    }
}

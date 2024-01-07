using ClientBroadcast;
using ServerBroadcast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerBroadcast
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
            //Application.Run(new Server());
            //Application.Run(new Client());

            try
            {
                // 서버 인스턴스를 생성하고 각각의 서버는 별도의 스레드에서 실행
                Thread serverThread1 = new Thread(() => Application.Run(new Server()));
                Thread serverThread2 = new Thread(() => Application.Run(new Client()));

                // 각 스레드 시작
                serverThread1.Start();
                serverThread2.Start();

                // 각 스레드가 종료되길 기다림
                serverThread1.Join();
                serverThread2.Join();
            }
            catch (Exception ex)
            {
                Console.WriteLine("메인 스레드에서 오류 발생: " + ex.Message);
            }
        }
    }
}


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
    public partial class ClientSetting : MetroFramework.Forms.MetroForm
    {
        public ClientSetting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClientSetting
            // 
            this.ClientSize = new System.Drawing.Size(397, 314);
            this.Name = "ClientSetting";
            this.Text = "클라이언트 설정";
            this.ResumeLayout(false);

        }
    }
}

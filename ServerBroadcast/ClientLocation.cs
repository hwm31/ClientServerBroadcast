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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServerBroadcast
{
    public partial class ClientLocation : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;

        private ServerSetting serverSettingForm;

        public ClientLocation(ServerSetting serverSetting)
        {
            InitializeComponent();
            serverSettingForm = serverSetting;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (serverSettingForm == null)
            {
                MessageBox.Show("ServerSetting 폼의 인스턴스가 없습니다.");
                return;
            }

            string locValue = metroTextBox1.Text;
            serverSettingForm.AddLocToDataGridView(locValue);
            MessageBox.Show(locValue + " (이/가) 저장되었습니다.");
        }

        public ClientLocation() // 기본 생성자를 추가
        {
            InitializeComponent(); // 폼의 디자인을 초기화
        }

        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "위치 ";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(73, 82);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(119, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(215, 82);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "저장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(117, 144);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "닫기";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ClientLocation
            // 
            this.ClientSize = new System.Drawing.Size(317, 190);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientLocation";
            this.Text = "클라이언트 위치 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
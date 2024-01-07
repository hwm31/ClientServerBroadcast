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
using System.Data;
using MetroFramework.Controls;

namespace ServerBroadcast
{
    public partial class ClientTemp2 : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox ExplainBox;
        private ServerSetting serverSettingForm;
        public ClientTemp2(ServerSetting serverSetting)
        {
            InitializeComponent();
            serverSettingForm = serverSetting;
        }

        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.ExplainBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "시작 시간";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "반복";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "실행 파일";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "설명";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(119, 257);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "저장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(265, 257);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "닫기";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ExplainBox
            // 
            this.ExplainBox.Location = new System.Drawing.Point(104, 189);
            this.ExplainBox.Name = "ExplainBox";
            this.ExplainBox.Size = new System.Drawing.Size(236, 23);
            this.ExplainBox.TabIndex = 6;
            this.ExplainBox.Text = "metroTextBox1";
            // 
            // ClientTemp2
            // 
            this.ClientSize = new System.Drawing.Size(441, 323);
            this.Controls.Add(this.ExplainBox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientTemp2";
            this.Text = "템플릿 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

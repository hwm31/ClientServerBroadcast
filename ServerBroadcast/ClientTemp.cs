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

namespace ServerBroadcast
{
    public partial class ClientTemp : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private ServerSetting serverSettingForm;
        public ClientTemp(ServerSetting serverSetting)
        {
            InitializeComponent();
            serverSettingForm = serverSetting;
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
            this.metroLabel1.Location = new System.Drawing.Point(24, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "템플릿";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(84, 74);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(118, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(225, 74);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "저장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(127, 137);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "닫기";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ClientTemp
            // 
            this.ClientSize = new System.Drawing.Size(324, 183);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientTemp";
            this.Text = "템플릿 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (serverSettingForm == null)
            {
                MessageBox.Show("ServerSetting 폼의 인스턴스가 없습니다.");
                return;
            }

            string tempValue = metroTextBox1.Text;
            serverSettingForm.AddTempToDataGridView(tempValue);
            MessageBox.Show(tempValue + " (이/가) 저장되었습니다.");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

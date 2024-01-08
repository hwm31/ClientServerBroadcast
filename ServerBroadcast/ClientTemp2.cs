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
        private MetroTextBox metroTextBox1;
        private MetroTextBox metroTextBox2;
        private MetroTextBox metroTextBox3;
        private MetroLabel metroLabel5;
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
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
            this.metroButton1.Location = new System.Drawing.Point(65, 257);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "저장";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(203, 257);
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
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(104, 73);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(90, 23);
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(104, 109);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(46, 23);
            this.metroTextBox2.TabIndex = 8;
            this.metroTextBox2.Text = "metroTextBox2";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(104, 147);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox3.TabIndex = 9;
            this.metroTextBox3.Text = "metroTextBox3";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(201, 73);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(147, 20);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "(10:30 형식으로 입력)";
            // 
            // ClientTemp2
            // 
            this.ClientSize = new System.Drawing.Size(357, 311);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
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
            if (serverSettingForm == null)
            {
                MessageBox.Show("ServerSetting 폼의 인스턴스가 없습니다.");
                return;
            }

            string startValue = metroTextBox1.Text;
            string repValue = metroTextBox2.Text;
            string fileValue = metroTextBox3.Text;
            string rmkValue = ExplainBox.Text;
            serverSettingForm.AddStartToDataGridView(startValue, repValue, fileValue, rmkValue);
            MessageBox.Show(startValue + " 일정이 저장되었습니다.");
        }
    }
}

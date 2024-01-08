using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ClientBroadcast
{
    public partial class ClientStart : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton metroButton2;

        public ClientStart()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "시작 시간";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "반복";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "실행 파일";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 200);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "설명";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(104, 77);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(91, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(110, 255);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(69, 30);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "저장";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(208, 255);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(66, 30);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "닫기";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(104, 115);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(52, 23);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.Text = "metroTextBox2";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(104, 196);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(170, 23);
            this.metroTextBox3.TabIndex = 8;
            this.metroTextBox3.Text = "metroTextBox3";
            // 
            // ClientStart
            // 
            this.ClientSize = new System.Drawing.Size(395, 308);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientStart";
            this.Text = "클라이언트 작업 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

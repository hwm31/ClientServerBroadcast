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
using System.Collections.Generic;
using System.Data.SQLite;

namespace ServerBroadcast
{
    public partial class ServerClientAdd : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;

        private ServerSetting serverSetting;
        public ServerClientAdd(ServerSetting serverSetting) // 기본 생성자를 추가
        {
            InitializeComponent(); // 폼의 디자인을 초기화
            this.serverSetting = serverSetting;
            LoadComboBoxItems(metroComboBox1, "M001");
            LoadComboBoxItems(metroComboBox2, "M002");
        }

        private void LoadComboBoxItems(MetroFramework.Controls.MetroComboBox comboBox, string mainCod)
        {
            string connectionString = "Data Source=ClientServerdb.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = $"SELECT CODNME FROM comcod WHERE MAINCOD = '{mainCod}'";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader["CODNME"].ToString());
                        }
                    }
                }
            }
        }


        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "클라이언트 IP";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "클라이언트 위치";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "실행 템플릿";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(168, 83);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(146, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "19.023.242.12";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(168, 128);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(146, 30);
            this.metroComboBox1.TabIndex = 4;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Location = new System.Drawing.Point(168, 177);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(146, 30);
            this.metroComboBox2.TabIndex = 5;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 267);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 37);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "클라이언트 추가";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(207, 267);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(107, 37);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "취소";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ServerClientAdd
            // 
            this.ClientSize = new System.Drawing.Size(359, 327);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ServerClientAdd";
            this.Text = "클라이언트 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
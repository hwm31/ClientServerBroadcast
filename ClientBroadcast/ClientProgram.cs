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
    public partial class ClientProgram : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private DataGridViewCheckBoxColumn ColSele;
        private DataGridViewTextBoxColumn ColStart;
        private DataGridViewTextBoxColumn ColRep;
        private DataGridViewTextBoxColumn ColFile;
        private DataGridViewTextBoxColumn ColExp;
        private string ip;

        public ClientProgram(string ip)
        {
            InitializeComponent();
            this.ip = ip; // 멤버 변수에 값을 할당
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            metroTextBox1.Text = this.ip;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColSele = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "서버";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(88, 83);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(139, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(524, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(67, 32);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "설정";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(284, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "현재 클라이언트에서 대기 중인 작업 현황";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(16, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "⦁";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(16, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "⦁";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSele,
            this.ColStart,
            this.ColRep,
            this.ColFile,
            this.ColExp});
            this.dataGridView1.Location = new System.Drawing.Point(41, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(550, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColSele
            // 
            this.ColSele.HeaderText = "선택";
            this.ColSele.MinimumWidth = 6;
            this.ColSele.Name = "ColSele";
            this.ColSele.Width = 50;
            // 
            // ColStart
            // 
            this.ColStart.HeaderText = "시작 시간";
            this.ColStart.MinimumWidth = 6;
            this.ColStart.Name = "ColStart";
            this.ColStart.Width = 125;
            // 
            // ColRep
            // 
            this.ColRep.HeaderText = "반복";
            this.ColRep.MinimumWidth = 6;
            this.ColRep.Name = "ColRep";
            this.ColRep.Width = 65;
            // 
            // ColFile
            // 
            this.ColFile.HeaderText = "실행 파일";
            this.ColFile.MinimumWidth = 6;
            this.ColFile.Name = "ColFile";
            this.ColFile.Width = 125;
            // 
            // ColExp
            // 
            this.ColExp.HeaderText = "설명";
            this.ColExp.MinimumWidth = 6;
            this.ColExp.Name = "ColExp";
            this.ColExp.Width = 135;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(41, 345);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(95, 31);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "서버 동기화";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(365, 345);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(61, 31);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "추가";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(530, 345);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(61, 31);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "저장";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(448, 345);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(61, 31);
            this.metroButton5.TabIndex = 10;
            this.metroButton5.Text = "삭제";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(293, 83);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 23);
            this.metroButton6.TabIndex = 11;
            this.metroButton6.Text = "접속 갱신";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // ClientProgram
            // 
            this.ClientSize = new System.Drawing.Size(637, 412);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientProgram";
            this.Text = "클라이언트 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ClientBroadcast.ClientSetting clientSettingForm = new ClientBroadcast.ClientSetting();
            clientSettingForm.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ClientBroadcast.ClientStart clientStartForm = new ClientBroadcast.ClientStart();
            clientStartForm.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            List<string> deletedItems = new List<string>();

            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells["ColSele"].Value != null && (bool)row.Cells["ColSele"].Value)
                {
                    deletedItems.Add(row.Cells[1].Value.ToString());
                    dataGridView1.Rows.RemoveAt(i);
                }
            }

            if (deletedItems.Count > 0)
            {
                string message = "삭제된 항목:\n" + string.Join("\n", deletedItems);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("삭제된 항목이 없습니다.");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ip = metroTextBox1.Text;

            // 새 IP 주소를 설정에 저장
            Properties.Settings.Default.IPAddress = ip;
            Properties.Settings.Default.Save();

            // 사용자에게 IP 주소가 업데이트되었음을 알림
            MessageBox.Show("IP 주소가 업데이트되었습니다: " + ip);
        }
    }
}

using System;
using System.Collections.Generic;
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn COLSele;
        private DataGridViewTextBoxColumn COLTemp;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn COLStart;
        private DataGridViewTextBoxColumn COLRepe;
        private DataGridViewTextBoxColumn COLFile;
        private DataGridViewTextBoxColumn COLExp;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroLabel metroLabel1;

        public ClientSetting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COLSele = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.COLStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLRepe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(16, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "⦁";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(179, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "서버 상태 확인 갱신 주기 ";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(218, 72);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(56, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(274, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(24, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "초";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(16, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "⦁";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(39, 113);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(152, 20);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "클라이언트 위치 관리";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(198, 108);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox1.TabIndex = 6;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 161);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(16, 20);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "⦁";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(39, 160);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "템플릿 관리";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLSele,
            this.COLTemp});
            this.dataGridView1.Location = new System.Drawing.Point(39, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(229, 126);
            this.dataGridView1.TabIndex = 9;
            // 
            // COLSele
            // 
            this.COLSele.HeaderText = "";
            this.COLSele.MinimumWidth = 6;
            this.COLSele.Name = "COLSele";
            this.COLSele.Width = 50;
            // 
            // COLTemp
            // 
            this.COLTemp.HeaderText = "템플릿";
            this.COLTemp.MinimumWidth = 6;
            this.COLTemp.Name = "COLTemp";
            this.COLTemp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COLTemp.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLStart,
            this.COLRepe,
            this.COLFile,
            this.COLExp});
            this.dataGridView2.Location = new System.Drawing.Point(300, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(479, 126);
            this.dataGridView2.TabIndex = 10;
            // 
            // COLStart
            // 
            this.COLStart.HeaderText = "시작 시간";
            this.COLStart.MinimumWidth = 6;
            this.COLStart.Name = "COLStart";
            // 
            // COLRepe
            // 
            this.COLRepe.HeaderText = "반복";
            this.COLRepe.MinimumWidth = 6;
            this.COLRepe.Name = "COLRepe";
            this.COLRepe.Width = 65;
            // 
            // COLFile
            // 
            this.COLFile.HeaderText = "실행 파일";
            this.COLFile.MinimumWidth = 6;
            this.COLFile.Name = "COLFile";
            this.COLFile.Width = 125;
            // 
            // COLExp
            // 
            this.COLExp.HeaderText = "설명";
            this.COLExp.MinimumWidth = 6;
            this.COLExp.Name = "COLExp";
            this.COLExp.Width = 135;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(347, 335);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "서버 템플릿 받기";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(511, 335);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "추가";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(608, 335);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "삭제";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(704, 335);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 14;
            this.metroButton4.Text = "저장";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(278, 403);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(95, 32);
            this.metroButton5.TabIndex = 15;
            this.metroButton5.Text = "서버 전송";
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(440, 403);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(85, 32);
            this.metroButton6.TabIndex = 16;
            this.metroButton6.Text = "닫기";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // ClientSetting
            // 
            this.ClientSize = new System.Drawing.Size(811, 458);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClientSetting";
            this.Text = "클라이언트 설정";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            List<string> deletedItems = new List<string>();

            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells["COLSele"].Value != null && (bool)row.Cells["COLSele"].Value)
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
    }
}

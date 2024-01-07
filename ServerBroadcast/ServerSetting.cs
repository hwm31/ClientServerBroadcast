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
using System.Collections.Generic;
using System.Data.SQLite;

namespace ServerBroadcast
{
    public partial class ServerSetting : MetroFramework.Forms.MetroForm
    {
        public ServerSetting() // 기본 생성자를 추가
        {
            InitializeComponent(); // 폼의 디자인을 초기화
        }

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public DataGridView dataGridView1;
        public MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroButton SaveButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton11;
        private DataGridViewCheckBoxColumn colSele;
        private DataGridViewTextBoxColumn colLoc;
        private DataGridViewCheckBoxColumn ColCHEK;
        private DataGridViewTextBoxColumn colTEMP;
        private DataGridViewCheckBoxColumn ColCheck;
        private DataGridViewTextBoxColumn colStart;
        private DataGridViewTextBoxColumn colRepet;
        private DataGridViewTextBoxColumn colFile;
        private DataGridViewTextBoxColumn colExpl;
        private MetroFramework.Controls.MetroLabel metroLabel1;

        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSele = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SaveButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColCHEK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(220, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "클라이언트 상태 확인 갱신 주기";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(263, 83);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(42, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "120";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(312, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "초";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(16, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "⦁";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 132);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(16, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "⦁";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(152, 20);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "클라이언트 위치 관리";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSele,
            this.colLoc});
            this.dataGridView1.Location = new System.Drawing.Point(24, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(281, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colSele
            // 
            this.colSele.DataPropertyName = "loc";
            this.colSele.HeaderText = "";
            this.colSele.MinimumWidth = 6;
            this.colSele.Name = "colSele";
            this.colSele.Width = 50;
            // 
            // colLoc
            // 
            this.colLoc.DataPropertyName = "CliLoc";
            this.colLoc.HeaderText = "위치";
            this.colLoc.MinimumWidth = 6;
            this.colLoc.Name = "colLoc";
            this.colLoc.Width = 125;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 349);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "추가";
            this.addButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(128, 349);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "삭제";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Location = new System.Drawing.Point(230, 349);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(75, 23);
            this.SaveButton1.TabIndex = 9;
            this.SaveButton1.Text = "저장";
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(379, 132);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 20);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "템플릿 관리";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(363, 132);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(16, 20);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "⦁";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCHEK,
            this.colTEMP});
            this.dataGridView2.Location = new System.Drawing.Point(363, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(281, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // ColCHEK
            // 
            this.ColCHEK.HeaderText = "";
            this.ColCHEK.MinimumWidth = 6;
            this.ColCHEK.Name = "ColCHEK";
            this.ColCHEK.Width = 50;
            // 
            // colTEMP
            // 
            this.colTEMP.DataPropertyName = "CliTemp";
            this.colTEMP.HeaderText = "템플릿";
            this.colTEMP.MinimumWidth = 6;
            this.colTEMP.Name = "colTEMP";
            this.colTEMP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTEMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTEMP.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.colStart,
            this.colRepet,
            this.colFile,
            this.colExpl});
            this.dataGridView3.Location = new System.Drawing.Point(669, 172);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(536, 150);
            this.dataGridView3.TabIndex = 13;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(569, 349);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 16;
            this.metroButton4.Text = "저장";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(462, 349);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 15;
            this.metroButton5.Text = "삭제";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(363, 349);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 23);
            this.metroButton6.TabIndex = 14;
            this.metroButton6.Text = "추가";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(1130, 349);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(75, 23);
            this.metroButton7.TabIndex = 19;
            this.metroButton7.Text = "저장";
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(1027, 349);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(75, 23);
            this.metroButton8.TabIndex = 18;
            this.metroButton8.Text = "삭제";
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(926, 349);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(75, 23);
            this.metroButton9.TabIndex = 17;
            this.metroButton9.Text = "추가";
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroButton10
            // 
            this.metroButton10.Location = new System.Drawing.Point(362, 447);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(126, 34);
            this.metroButton10.TabIndex = 20;
            this.metroButton10.Text = "닫기";
            this.metroButton10.Click += new System.EventHandler(this.metroButton10_Click);
            // 
            // metroButton11
            // 
            this.metroButton11.Location = new System.Drawing.Point(544, 447);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(126, 34);
            this.metroButton11.TabIndex = 21;
            this.metroButton11.Text = "서버 설정 백업";
            // 
            // ColCheck
            // 
            this.ColCheck.HeaderText = "";
            this.ColCheck.MinimumWidth = 6;
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColCheck.Width = 50;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "시작 시간";
            this.colStart.MinimumWidth = 6;
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            // 
            // colRepet
            // 
            this.colRepet.HeaderText = "반복";
            this.colRepet.MinimumWidth = 6;
            this.colRepet.Name = "colRepet";
            this.colRepet.ReadOnly = true;
            this.colRepet.Width = 65;
            // 
            // colFile
            // 
            this.colFile.HeaderText = "실행 파일";
            this.colFile.MinimumWidth = 6;
            this.colFile.Name = "colFile";
            this.colFile.ReadOnly = true;
            this.colFile.Width = 125;
            // 
            // colExpl
            // 
            this.colExpl.HeaderText = "설명";
            this.colExpl.MinimumWidth = 6;
            this.colExpl.Name = "colExpl";
            this.colExpl.ReadOnly = true;
            this.colExpl.Width = 135;
            // 
            // ServerSetting
            // 
            this.ClientSize = new System.Drawing.Size(1228, 509);
            this.Controls.Add(this.metroButton11);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.metroButton8);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ServerSetting";
            this.Text = "서버 설정";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            List<string> deletedItems = new List<string>();

            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells["colSele"].Value != null && (bool)row.Cells["colSele"].Value)
                {
                    // 첫 번째 열의 값을 저장합니다. 필요에 따라 다른 열을 선택할 수 있습니다.
                    deletedItems.Add(row.Cells[1].Value.ToString());
                    dataGridView1.Rows.RemoveAt(i);
                }
            }

            // 삭제된 항목들을 메시지 박스로 표시합니다.
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

        private void metroButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ClientLocation clientLocationForm = new ClientLocation(this);
            clientLocationForm.Show();
        }

        public void AddLocToDataGridView(string locValue)
        {
            int rowIndex1 = dataGridView1.Rows.Add(); // 새 행을 추가하고 인덱스를 얻습니다.
            dataGridView1.Rows[rowIndex1].Cells["colLoc"].Value = locValue; // 'colLoc' 열에 값 설정
        }

        public void AddTempToDataGridView(string tempValue)
        {
            int rowIndex2 = dataGridView2.Rows.Add();
            dataGridView2.Rows[rowIndex2].Cells["colTEMP"].Value = tempValue; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ClientTemp clientTempForm = new ClientTemp(this);
            clientTempForm.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            List<string> deletedItems2 = new List<string>();

            for (int j = dataGridView2.Rows.Count - 1; j >= 0; j--)
            {
                DataGridViewRow row2 = dataGridView2.Rows[j];
                if (row2.Cells["ColCHEK"].Value != null && (bool)row2.Cells["ColCHEK"].Value)
                {
                    // 첫 번째 열의 값을 저장합니다. 필요에 따라 다른 열을 선택할 수 있습니다.
                    deletedItems2.Add(row2.Cells[1].Value.ToString());
                    dataGridView2.Rows.RemoveAt(j);
                }
            }

            // 삭제된 항목들을 메시지 박스로 표시합니다.
            if (deletedItems2.Count > 0)
            {
                string message2 = "삭제된 항목:\n" + string.Join("\n", deletedItems2);
                MessageBox.Show(message2);
            }
            else
            {
                MessageBox.Show("삭제된 항목이 없습니다.");
            }
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("선택된 데이터가 저장되었습니다.");
        }
    

        private void metroButton9_Click(object sender, EventArgs e)
        {
            ClientTemp2 clientTemp2Form = new ClientTemp2(this);
            clientTemp2Form.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            List<string> deletedItems3 = new List<string>();

            for (int k = dataGridView3.Rows.Count - 1; k >= 0; k--)
            {
                DataGridViewRow row3 = dataGridView3.Rows[k];
                if (row3.Cells["ColCheck"].Value != null && (bool)row3.Cells["ColCheck"].Value)
                {
                    // 첫 번째 열의 값을 저장합니다. 필요에 따라 다른 열을 선택할 수 있습니다.
                    deletedItems3.Add(row3.Cells[1].Value.ToString());
                    dataGridView3.Rows.RemoveAt(k);
                }
            }

            // 삭제된 항목들을 메시지 박스로 표시합니다.
            if (deletedItems3.Count > 0)
            {
                string message3 = "삭제된 항목:\n" + string.Join("\n", deletedItems3);
                MessageBox.Show(message3);
            }
            else
            {
                MessageBox.Show("삭제된 항목이 없습니다.");
            }
        }
    }
}

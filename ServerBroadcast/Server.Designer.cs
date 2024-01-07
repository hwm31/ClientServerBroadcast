namespace ServerBroadcast
{
    partial class Server
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileFind = new System.Windows.Forms.Button();
            this.SettingButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.colCHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileFind
            // 
            this.btnFileFind.Location = new System.Drawing.Point(758, 211);
            this.btnFileFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFileFind.Name = "btnFileFind";
            this.btnFileFind.Size = new System.Drawing.Size(86, 29);
            this.btnFileFind.TabIndex = 0;
            this.btnFileFind.Text = "파일 찾기";
            this.btnFileFind.UseVisualStyleBackColor = true;
            this.btnFileFind.Click += new System.EventHandler(this.btnFileFind_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(563, 32);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(80, 30);
            this.SettingButton.TabIndex = 1;
            this.SettingButton.Text = "설정";
            this.SettingButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(27, 102);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 30);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "클라이언트 추가";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.AllowDrop = true;
            this.metroButton2.Location = new System.Drawing.Point(195, 102);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 30);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "클라이언트 삭제";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // grdMain
            // 
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCHK,
            this.colIP,
            this.colLoc,
            this.colTemp,
            this.colStatus});
            this.grdMain.Location = new System.Drawing.Point(27, 154);
            this.grdMain.Name = "grdMain";
            this.grdMain.RowHeadersWidth = 51;
            this.grdMain.RowTemplate.Height = 27;
            this.grdMain.Size = new System.Drawing.Size(616, 150);
            this.grdMain.TabIndex = 4;
            // 
            // metroButton3
            // 
            this.metroButton3.AllowDrop = true;
            this.metroButton3.Location = new System.Drawing.Point(364, 102);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(140, 30);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "클라이언트 상태 확인";
            // 
            // colCHK
            // 
            this.colCHK.DataPropertyName = "CHK";
            this.colCHK.HeaderText = "선택";
            this.colCHK.MinimumWidth = 6;
            this.colCHK.Name = "colCHK";
            this.colCHK.Width = 50;
            // 
            // colIP
            // 
            this.colIP.DataPropertyName = "IP";
            this.colIP.HeaderText = "IP Address";
            this.colIP.MinimumWidth = 6;
            this.colIP.Name = "colIP";
            this.colIP.ReadOnly = true;
            this.colIP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIP.Width = 125;
            // 
            // colLoc
            // 
            this.colLoc.DataPropertyName = "LOC";
            this.colLoc.HeaderText = "위치";
            this.colLoc.MinimumWidth = 6;
            this.colLoc.Name = "colLoc";
            this.colLoc.ReadOnly = true;
            this.colLoc.Width = 125;
            // 
            // colTemp
            // 
            this.colTemp.DataPropertyName = "TEMP";
            this.colTemp.HeaderText = "실행 템플릿";
            this.colTemp.MinimumWidth = 6;
            this.colTemp.Name = "colTemp";
            this.colTemp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTemp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTemp.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "STATUS";
            this.colStatus.HeaderText = "상태";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 430);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.btnFileFind);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Server";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileFind;
        private MetroFramework.Controls.MetroButton SettingButton;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView grdMain;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewImageColumn colStatus;
    }
}


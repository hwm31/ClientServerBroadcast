namespace ClientBroadcast
{
    partial class Client
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
            this.btnReceive = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(490, 142);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(86, 29);
            this.btnReceive.TabIndex = 0;
            this.btnReceive.Text = "button1";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "IP";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(52, 75);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBox1.Size = new System.Drawing.Size(140, 25);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(207, 78);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "upload";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 435);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnReceive);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceive;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox TextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}


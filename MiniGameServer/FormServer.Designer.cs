namespace MiniGameServer
{
    partial class FormServer
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
            this.LogHistory = new Sunny.UI.UIRichTextBox();
            this.BtnServerStop = new Sunny.UI.UIButton();
            this.BtnServerStart = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // LogHistory
            // 
            this.LogHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogHistory.FillColor = System.Drawing.Color.White;
            this.LogHistory.Font = new System.Drawing.Font("나눔바른고딕", 8F);
            this.LogHistory.Location = new System.Drawing.Point(4, 40);
            this.LogHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogHistory.MinimumSize = new System.Drawing.Size(1, 1);
            this.LogHistory.Name = "LogHistory";
            this.LogHistory.Padding = new System.Windows.Forms.Padding(2);
            this.LogHistory.ReadOnly = true;
            this.LogHistory.ShowText = false;
            this.LogHistory.Size = new System.Drawing.Size(792, 309);
            this.LogHistory.TabIndex = 0;
            this.LogHistory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnServerStop
            // 
            this.BtnServerStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServerStop.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnServerStop.Location = new System.Drawing.Point(696, 357);
            this.BtnServerStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnServerStop.Name = "BtnServerStop";
            this.BtnServerStop.Size = new System.Drawing.Size(100, 35);
            this.BtnServerStop.TabIndex = 3;
            this.BtnServerStop.Text = "서버 중지";
            this.BtnServerStop.Click += new System.EventHandler(this.BtnServerStop_Click);
            // 
            // BtnServerStart
            // 
            this.BtnServerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServerStart.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnServerStart.Location = new System.Drawing.Point(4, 357);
            this.BtnServerStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnServerStart.Name = "BtnServerStart";
            this.BtnServerStart.Size = new System.Drawing.Size(100, 35);
            this.BtnServerStart.TabIndex = 4;
            this.BtnServerStart.Text = "서버 시작";
            this.BtnServerStart.Click += new System.EventHandler(this.BtnServerStart_Click);
            // 
            // FormServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnServerStop);
            this.Controls.Add(this.BtnServerStart);
            this.Controls.Add(this.LogHistory);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.Name = "FormServer";
            this.Text = "서버";
            this.TitleFont = new System.Drawing.Font("나눔바른고딕", 12F);
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox LogHistory;
        private Sunny.UI.UIButton BtnServerStop;
        private Sunny.UI.UIButton BtnServerStart;
    }
}


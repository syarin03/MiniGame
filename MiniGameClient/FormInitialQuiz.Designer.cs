namespace MiniGameClient
{
    partial class FormInitialQuiz
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
            this.InputChat = new Sunny.UI.UITextBox();
            this.LogChat = new Sunny.UI.UIRichTextBox();
            this.FlowUserList = new Sunny.UI.UIFlowLayoutPanel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // InputChat
            // 
            this.InputChat.AcceptsReturn = true;
            this.InputChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputChat.ButtonSymbol = 61912;
            this.InputChat.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.InputChat.ButtonSymbolSize = 20;
            this.InputChat.ButtonWidth = 35;
            this.InputChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputChat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.InputChat.Font = new System.Drawing.Font("나눔바른고딕", 10F);
            this.InputChat.Location = new System.Drawing.Point(280, 675);
            this.InputChat.Margin = new System.Windows.Forms.Padding(5);
            this.InputChat.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputChat.Name = "InputChat";
            this.InputChat.Padding = new System.Windows.Forms.Padding(5, 0, 35, 0);
            this.InputChat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputChat.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.InputChat.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.InputChat.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputChat.ShowButton = true;
            this.InputChat.ShowText = false;
            this.InputChat.Size = new System.Drawing.Size(790, 35);
            this.InputChat.Style = Sunny.UI.UIStyle.Custom;
            this.InputChat.StyleCustomMode = true;
            this.InputChat.TabIndex = 19;
            this.InputChat.Text = "채팅";
            this.InputChat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputChat.Watermark = "";
            // 
            // LogChat
            // 
            this.LogChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogChat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.LogChat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.LogChat.Font = new System.Drawing.Font("나눔바른고딕", 10F);
            this.LogChat.Location = new System.Drawing.Point(280, 350);
            this.LogChat.Margin = new System.Windows.Forms.Padding(5);
            this.LogChat.MinimumSize = new System.Drawing.Size(1, 1);
            this.LogChat.Name = "LogChat";
            this.LogChat.Padding = new System.Windows.Forms.Padding(5, 5, 5, 35);
            this.LogChat.ReadOnly = true;
            this.LogChat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogChat.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.LogChat.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogChat.ShowText = false;
            this.LogChat.Size = new System.Drawing.Size(790, 360);
            this.LogChat.Style = Sunny.UI.UIStyle.Custom;
            this.LogChat.StyleCustomMode = true;
            this.LogChat.TabIndex = 18;
            this.LogChat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowUserList
            // 
            this.FlowUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlowUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.FlowUserList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.FlowUserList.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.FlowUserList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FlowUserList.Location = new System.Drawing.Point(10, 350);
            this.FlowUserList.Margin = new System.Windows.Forms.Padding(5);
            this.FlowUserList.MinimumSize = new System.Drawing.Size(1, 1);
            this.FlowUserList.Name = "FlowUserList";
            this.FlowUserList.Padding = new System.Windows.Forms.Padding(2);
            this.FlowUserList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FlowUserList.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FlowUserList.ShowText = false;
            this.FlowUserList.Size = new System.Drawing.Size(260, 360);
            this.FlowUserList.Style = Sunny.UI.UIStyle.Custom;
            this.FlowUserList.StyleCustomMode = true;
            this.FlowUserList.TabIndex = 20;
            this.FlowUserList.Text = "uiFlowLayoutPanel1";
            this.FlowUserList.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(0, 275);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(1080, 35);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 24;
            this.uiLabel5.Text = "힌트3: ㅂㄷㅈㄱ";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(0, 235);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(1080, 35);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 25;
            this.uiLabel4.Text = "힌트2: ㅁㄴㅇㄹ";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(0, 195);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(1080, 35);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 26;
            this.uiLabel3.Text = "힌트1: ㅁㅇㄴㄹ";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("나눔바른고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.Location = new System.Drawing.Point(0, 120);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(1080, 70);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "ㅇㅇㅇ";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel6.Location = new System.Drawing.Point(0, 35);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(1080, 35);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.StyleCustomMode = true;
            this.uiLabel6.TabIndex = 22;
            this.uiLabel6.Text = "n / n 라운드";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.Location = new System.Drawing.Point(0, 85);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1080, 35);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 23;
            this.uiLabel1.Text = "출제자: ㅇㅇㅇ";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInitialQuiz
            // 
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.InputChat);
            this.Controls.Add(this.LogChat);
            this.Controls.Add(this.FlowUserList);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FormInitialQuiz";
            this.Text = "초성퀴즈";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox InputChat;
        private Sunny.UI.UIRichTextBox LogChat;
        private Sunny.UI.UIFlowLayoutPanel FlowUserList;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel1;
    }
}

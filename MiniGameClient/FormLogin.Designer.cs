namespace MiniGameClient
{
    partial class FormLogin
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
            this.InputLoginID = new Sunny.UI.UITextBox();
            this.InputLoginPW = new Sunny.UI.UITextBox();
            this.BtnLogin = new Sunny.UI.UIButton();
            this.BtnLoginToSignUp = new Sunny.UI.UILinkLabel();
            this.BtnLoginToFind = new Sunny.UI.UILinkLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.TitleBar = new MiniGameClient.TitleBar();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputLoginID
            // 
            this.InputLoginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputLoginID.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputLoginID.Location = new System.Drawing.Point(150, 140);
            this.InputLoginID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputLoginID.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputLoginID.Name = "InputLoginID";
            this.InputLoginID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputLoginID.ShowText = false;
            this.InputLoginID.Size = new System.Drawing.Size(300, 30);
            this.InputLoginID.Style = Sunny.UI.UIStyle.Custom;
            this.InputLoginID.TabIndex = 0;
            this.InputLoginID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputLoginID.Watermark = "아이디";
            // 
            // InputLoginPW
            // 
            this.InputLoginPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputLoginPW.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputLoginPW.Location = new System.Drawing.Point(150, 180);
            this.InputLoginPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputLoginPW.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputLoginPW.Name = "InputLoginPW";
            this.InputLoginPW.PasswordChar = '*';
            this.InputLoginPW.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputLoginPW.ShowText = false;
            this.InputLoginPW.Size = new System.Drawing.Size(300, 30);
            this.InputLoginPW.Style = Sunny.UI.UIStyle.Custom;
            this.InputLoginPW.TabIndex = 3;
            this.InputLoginPW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputLoginPW.Watermark = "비밀번호";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLogin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnLogin.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLogin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLogin.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLogin.Location = new System.Drawing.Point(150, 220);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLogin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnLogin.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLogin.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLogin.Size = new System.Drawing.Size(300, 40);
            this.BtnLogin.Style = Sunny.UI.UIStyle.Custom;
            this.BtnLogin.StyleCustomMode = true;
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.TipsFont = new System.Drawing.Font("나눔바른고딕", 9F);
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnLoginToSignUp
            // 
            this.BtnLoginToSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnLoginToSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLoginToSignUp.AutoSize = true;
            this.BtnLoginToSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginToSignUp.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(167)))));
            this.BtnLoginToSignUp.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLoginToSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.BtnLoginToSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLoginToSignUp.Location = new System.Drawing.Point(243, 0);
            this.BtnLoginToSignUp.Name = "BtnLoginToSignUp";
            this.BtnLoginToSignUp.Size = new System.Drawing.Size(65, 30);
            this.BtnLoginToSignUp.Style = Sunny.UI.UIStyle.Custom;
            this.BtnLoginToSignUp.StyleCustomMode = true;
            this.BtnLoginToSignUp.TabIndex = 5;
            this.BtnLoginToSignUp.TabStop = true;
            this.BtnLoginToSignUp.Text = "회원가입";
            this.BtnLoginToSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLoginToSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnLoginToSignUp.Click += new System.EventHandler(this.BtnLoginToSignUp_Click);
            // 
            // BtnLoginToFind
            // 
            this.BtnLoginToFind.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnLoginToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLoginToFind.AutoSize = true;
            this.BtnLoginToFind.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginToFind.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLoginToFind.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.BtnLoginToFind.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLoginToFind.Location = new System.Drawing.Point(243, 30);
            this.BtnLoginToFind.Name = "BtnLoginToFind";
            this.BtnLoginToFind.Size = new System.Drawing.Size(146, 30);
            this.BtnLoginToFind.Style = Sunny.UI.UIStyle.Custom;
            this.BtnLoginToFind.StyleCustomMode = true;
            this.BtnLoginToFind.TabIndex = 5;
            this.BtnLoginToFind.TabStop = true;
            this.BtnLoginToFind.Text = "아이디/비밀번호 찾기";
            this.BtnLoginToFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLoginToFind.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.Location = new System.Drawing.Point(69, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(168, 30);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "아직 회원이 아니신가요?";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.Location = new System.Drawing.Point(24, 30);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(213, 30);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "아이디/비밀번호를 잊으셨나요?";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(600, 35);
            this.TitleBar.TabIndex = 7;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.BtnLoginToSignUp, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.BtnLoginToFind, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(100, 280);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 2;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(400, 60);
            this.uiTableLayoutPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTableLayoutPanel1.TabIndex = 8;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // FormLogin
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.InputLoginPW);
            this.Controls.Add(this.InputLoginID);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "로그인";
            this.TitleFont = new System.Drawing.Font("나눔바른고딕", 12F);
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox InputLoginID;
        private Sunny.UI.UITextBox InputLoginPW;
        private Sunny.UI.UIButton BtnLogin;
        private Sunny.UI.UILinkLabel BtnLoginToSignUp;
        private Sunny.UI.UILinkLabel BtnLoginToFind;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private TitleBar TitleBar;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
    }
}


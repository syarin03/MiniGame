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
            this.BtnLogin = new Sunny.UI.UIButton();
            this.InputPW = new Sunny.UI.UITextBox();
            this.InputID = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.BtnLoginToSignUp = new Sunny.UI.UILinkLabel();
            this.BtnToFind = new Sunny.UI.UILinkLabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnLogin.Location = new System.Drawing.Point(150, 205);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLogin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnLogin.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLogin.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnLogin.Size = new System.Drawing.Size(300, 40);
            this.BtnLogin.Style = Sunny.UI.UIStyle.Custom;
            this.BtnLogin.StyleCustomMode = true;
            this.BtnLogin.TabIndex = 15;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.TipsFont = new System.Drawing.Font("나눔바른고딕", 9F);
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // InputPW
            // 
            this.InputPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPW.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPW.Location = new System.Drawing.Point(150, 165);
            this.InputPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPW.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputPW.Name = "InputPW";
            this.InputPW.PasswordChar = '*';
            this.InputPW.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW.ShowText = false;
            this.InputPW.Size = new System.Drawing.Size(300, 30);
            this.InputPW.Style = Sunny.UI.UIStyle.Custom;
            this.InputPW.TabIndex = 14;
            this.InputPW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPW.Watermark = "비밀번호";
            // 
            // InputID
            // 
            this.InputID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputID.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputID.Location = new System.Drawing.Point(150, 125);
            this.InputID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputID.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputID.Name = "InputID";
            this.InputID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputID.ShowText = false;
            this.InputID.Size = new System.Drawing.Size(300, 30);
            this.InputID.Style = Sunny.UI.UIStyle.Custom;
            this.InputID.TabIndex = 13;
            this.InputID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputID.Watermark = "아이디";
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
            // BtnToFind
            // 
            this.BtnToFind.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnToFind.AutoSize = true;
            this.BtnToFind.BackColor = System.Drawing.Color.Transparent;
            this.BtnToFind.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnToFind.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.BtnToFind.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnToFind.Location = new System.Drawing.Point(243, 30);
            this.BtnToFind.Name = "BtnToFind";
            this.BtnToFind.Size = new System.Drawing.Size(146, 30);
            this.BtnToFind.Style = Sunny.UI.UIStyle.Custom;
            this.BtnToFind.StyleCustomMode = true;
            this.BtnToFind.TabIndex = 5;
            this.BtnToFind.TabStop = true;
            this.BtnToFind.Text = "아이디/비밀번호 찾기";
            this.BtnToFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnToFind.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
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
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.BtnLoginToSignUp, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.BtnToFind, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(100, 265);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 2;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(400, 60);
            this.uiTableLayoutPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTableLayoutPanel1.TabIndex = 16;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.InputPW);
            this.Controls.Add(this.InputID);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "FormLogin";
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnLogin;
        private Sunny.UI.UITextBox InputPW;
        private Sunny.UI.UITextBox InputID;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILinkLabel BtnLoginToSignUp;
        private Sunny.UI.UILinkLabel BtnToFind;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
    }
}

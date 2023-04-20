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
            this.SuspendLayout();
            // 
            // InputLoginID
            // 
            this.InputLoginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputLoginID.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputLoginID.Location = new System.Drawing.Point(228, 148);
            this.InputLoginID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputLoginID.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputLoginID.Name = "InputLoginID";
            this.InputLoginID.ShowText = false;
            this.InputLoginID.Size = new System.Drawing.Size(174, 29);
            this.InputLoginID.TabIndex = 0;
            this.InputLoginID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputLoginID.Watermark = "";
            // 
            // InputLoginPW
            // 
            this.InputLoginPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputLoginPW.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputLoginPW.Location = new System.Drawing.Point(228, 187);
            this.InputLoginPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputLoginPW.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputLoginPW.Name = "InputLoginPW";
            this.InputLoginPW.ShowText = false;
            this.InputLoginPW.Size = new System.Drawing.Size(174, 29);
            this.InputLoginPW.TabIndex = 3;
            this.InputLoginPW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputLoginPW.Watermark = "";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLogin.Location = new System.Drawing.Point(410, 148);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 68);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnLoginToSignUp
            // 
            this.BtnLoginToSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.BtnLoginToSignUp.AutoSize = true;
            this.BtnLoginToSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginToSignUp.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLoginToSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.BtnLoginToSignUp.Location = new System.Drawing.Point(387, 293);
            this.BtnLoginToSignUp.Name = "BtnLoginToSignUp";
            this.BtnLoginToSignUp.Size = new System.Drawing.Size(65, 19);
            this.BtnLoginToSignUp.TabIndex = 5;
            this.BtnLoginToSignUp.TabStop = true;
            this.BtnLoginToSignUp.Text = "회원가입";
            this.BtnLoginToSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // BtnLoginToFind
            // 
            this.BtnLoginToFind.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.BtnLoginToFind.AutoSize = true;
            this.BtnLoginToFind.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginToFind.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLoginToFind.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.BtnLoginToFind.Location = new System.Drawing.Point(387, 327);
            this.BtnLoginToFind.Name = "BtnLoginToFind";
            this.BtnLoginToFind.Size = new System.Drawing.Size(146, 19);
            this.BtnLoginToFind.TabIndex = 5;
            this.BtnLoginToFind.TabStop = true;
            this.BtnLoginToFind.Text = "아이디/비밀번호 찾기";
            this.BtnLoginToFind.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.Location = new System.Drawing.Point(224, 293);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(168, 19);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "아직 회원이 아니신가요?";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.Location = new System.Drawing.Point(179, 327);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(213, 19);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "아이디/비밀번호를 잊으셨나요?";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.BtnLoginToFind);
            this.Controls.Add(this.BtnLoginToSignUp);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.InputLoginPW);
            this.Controls.Add(this.InputLoginID);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLogin";
            this.Text = "";
            this.TitleFont = new System.Drawing.Font("나눔바른고딕", 12F);
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox InputLoginID;
        private Sunny.UI.UITextBox InputLoginPW;
        private Sunny.UI.UIButton BtnLogin;
        private Sunny.UI.UILinkLabel BtnLoginToSignUp;
        private Sunny.UI.UILinkLabel BtnLoginToFind;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}


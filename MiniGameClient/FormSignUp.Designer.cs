namespace MiniGameClient
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputSignUpID = new Sunny.UI.UITextBox();
            this.InputSignUpPW2 = new Sunny.UI.UITextBox();
            this.InputSignUpPW1 = new Sunny.UI.UITextBox();
            this.InputSignUpNickName = new Sunny.UI.UITextBox();
            this.LabelSignUpID = new Sunny.UI.UILabel();
            this.LabelSignUpPW = new Sunny.UI.UILabel();
            this.LabelSignUpPhone = new Sunny.UI.UILabel();
            this.LabelSignUpNickName = new Sunny.UI.UILabel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.TitleBar = new MiniGameClient.TitleBar();
            this.InputSignUpPhone2 = new Sunny.UI.UITextBox();
            this.InputSignUpPhone3 = new Sunny.UI.UITextBox();
            this.InputSignUpPhone1 = new Sunny.UI.UITextBox();
            this.InputSignUpName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // InputSignUpID
            // 
            this.InputSignUpID.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpID.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpID.Location = new System.Drawing.Point(150, 70);
            this.InputSignUpID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpID.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpID.Name = "InputSignUpID";
            this.InputSignUpID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpID.ShowText = false;
            this.InputSignUpID.Size = new System.Drawing.Size(300, 30);
            this.InputSignUpID.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpID.TabIndex = 0;
            this.InputSignUpID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpID.Watermark = "아이디";
            this.InputSignUpID.Leave += new System.EventHandler(this.InputSignUpID_Leave);
            // 
            // InputSignUpPW2
            // 
            this.InputSignUpPW2.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpPW2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpPW2.Location = new System.Drawing.Point(150, 170);
            this.InputSignUpPW2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpPW2.MaxLength = 20;
            this.InputSignUpPW2.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpPW2.Name = "InputSignUpPW2";
            this.InputSignUpPW2.PasswordChar = '●';
            this.InputSignUpPW2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW2.ShowText = false;
            this.InputSignUpPW2.Size = new System.Drawing.Size(300, 30);
            this.InputSignUpPW2.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpPW2.TabIndex = 2;
            this.InputSignUpPW2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpPW2.Watermark = "비밀번호 확인";
            this.InputSignUpPW2.Leave += new System.EventHandler(this.InputSignUpPW2_Leave);
            this.InputSignUpPW2.Enter += new System.EventHandler(this.InputSignUpPW2_Enter);
            // 
            // InputSignUpPW1
            // 
            this.InputSignUpPW1.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpPW1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpPW1.Location = new System.Drawing.Point(150, 130);
            this.InputSignUpPW1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpPW1.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpPW1.Name = "InputSignUpPW1";
            this.InputSignUpPW1.PasswordChar = '●';
            this.InputSignUpPW1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPW1.ShowText = false;
            this.InputSignUpPW1.Size = new System.Drawing.Size(300, 30);
            this.InputSignUpPW1.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpPW1.TabIndex = 1;
            this.InputSignUpPW1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpPW1.Watermark = "비밀번호(영어/숫자 혼용 8~20자)";
            this.InputSignUpPW1.Leave += new System.EventHandler(this.InputSignUpPW1_Leave);
            // 
            // InputSignUpNickName
            // 
            this.InputSignUpNickName.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpNickName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpNickName.Location = new System.Drawing.Point(150, 330);
            this.InputSignUpNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpNickName.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpNickName.Name = "InputSignUpNickName";
            this.InputSignUpNickName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpNickName.ShowText = false;
            this.InputSignUpNickName.Size = new System.Drawing.Size(300, 30);
            this.InputSignUpNickName.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpNickName.TabIndex = 7;
            this.InputSignUpNickName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpNickName.Watermark = "닉네임";
            this.InputSignUpNickName.Leave += new System.EventHandler(this.InputSignUpNickName_Leave);
            // 
            // LabelSignUpID
            // 
            this.LabelSignUpID.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelSignUpID.Location = new System.Drawing.Point(150, 100);
            this.LabelSignUpID.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSignUpID.Name = "LabelSignUpID";
            this.LabelSignUpID.Size = new System.Drawing.Size(300, 23);
            this.LabelSignUpID.Style = Sunny.UI.UIStyle.Custom;
            this.LabelSignUpID.TabIndex = 11;
            this.LabelSignUpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSignUpPW
            // 
            this.LabelSignUpPW.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelSignUpPW.Location = new System.Drawing.Point(150, 200);
            this.LabelSignUpPW.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSignUpPW.Name = "LabelSignUpPW";
            this.LabelSignUpPW.Size = new System.Drawing.Size(300, 23);
            this.LabelSignUpPW.Style = Sunny.UI.UIStyle.Custom;
            this.LabelSignUpPW.TabIndex = 11;
            this.LabelSignUpPW.Text = "영어, 숫자 혼용 8~20자";
            this.LabelSignUpPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSignUpPhone
            // 
            this.LabelSignUpPhone.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelSignUpPhone.Location = new System.Drawing.Point(150, 300);
            this.LabelSignUpPhone.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSignUpPhone.Name = "LabelSignUpPhone";
            this.LabelSignUpPhone.Size = new System.Drawing.Size(300, 23);
            this.LabelSignUpPhone.Style = Sunny.UI.UIStyle.Custom;
            this.LabelSignUpPhone.TabIndex = 11;
            this.LabelSignUpPhone.Text = "전화번호 중복 확인";
            this.LabelSignUpPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSignUpNickName
            // 
            this.LabelSignUpNickName.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelSignUpNickName.Location = new System.Drawing.Point(150, 360);
            this.LabelSignUpNickName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSignUpNickName.Name = "LabelSignUpNickName";
            this.LabelSignUpNickName.Size = new System.Drawing.Size(300, 23);
            this.LabelSignUpNickName.Style = Sunny.UI.UIStyle.Custom;
            this.LabelSignUpNickName.TabIndex = 11;
            this.LabelSignUpNickName.Text = "닉네임 중복 확인";
            this.LabelSignUpNickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(468, 403);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(120, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.TabIndex = 8;
            this.uiSymbolButton1.Text = "가입하기";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(600, 35);
            this.TitleBar.TabIndex = 10;
            this.TitleBar.TitleName = "TitleName";
            // 
            // InputSignUpPhone2
            // 
            this.InputSignUpPhone2.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpPhone2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpPhone2.Location = new System.Drawing.Point(240, 270);
            this.InputSignUpPhone2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpPhone2.MaxLength = 4;
            this.InputSignUpPhone2.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpPhone2.Name = "InputSignUpPhone2";
            this.InputSignUpPhone2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone2.ShowText = false;
            this.InputSignUpPhone2.Size = new System.Drawing.Size(100, 30);
            this.InputSignUpPhone2.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpPhone2.TabIndex = 5;
            this.InputSignUpPhone2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpPhone2.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.InputSignUpPhone2.Watermark = "";
            // 
            // InputSignUpPhone3
            // 
            this.InputSignUpPhone3.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpPhone3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpPhone3.Location = new System.Drawing.Point(350, 270);
            this.InputSignUpPhone3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpPhone3.MaxLength = 4;
            this.InputSignUpPhone3.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpPhone3.Name = "InputSignUpPhone3";
            this.InputSignUpPhone3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone3.ShowText = false;
            this.InputSignUpPhone3.Size = new System.Drawing.Size(100, 30);
            this.InputSignUpPhone3.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpPhone3.TabIndex = 6;
            this.InputSignUpPhone3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpPhone3.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.InputSignUpPhone3.Watermark = "";
            // 
            // InputSignUpPhone1
            // 
            this.InputSignUpPhone1.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpPhone1.DoubleValue = 10D;
            this.InputSignUpPhone1.FillDisableColor = System.Drawing.Color.White;
            this.InputSignUpPhone1.FillReadOnlyColor = System.Drawing.Color.White;
            this.InputSignUpPhone1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpPhone1.IntValue = 10;
            this.InputSignUpPhone1.Location = new System.Drawing.Point(150, 270);
            this.InputSignUpPhone1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpPhone1.MaxLength = 4;
            this.InputSignUpPhone1.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpPhone1.Name = "InputSignUpPhone1";
            this.InputSignUpPhone1.ReadOnly = true;
            this.InputSignUpPhone1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpPhone1.ShowText = false;
            this.InputSignUpPhone1.Size = new System.Drawing.Size(80, 30);
            this.InputSignUpPhone1.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpPhone1.TabIndex = 5;
            this.InputSignUpPhone1.Text = "010";
            this.InputSignUpPhone1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpPhone1.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.InputSignUpPhone1.Watermark = "";
            // 
            // InputSignUpName
            // 
            this.InputSignUpName.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputSignUpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputSignUpName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputSignUpName.Location = new System.Drawing.Point(150, 230);
            this.InputSignUpName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputSignUpName.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputSignUpName.Name = "InputSignUpName";
            this.InputSignUpName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputSignUpName.ShowText = false;
            this.InputSignUpName.Size = new System.Drawing.Size(300, 30);
            this.InputSignUpName.Style = Sunny.UI.UIStyle.Custom;
            this.InputSignUpName.TabIndex = 3;
            this.InputSignUpName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputSignUpName.Watermark = "이름";
            // 
            // FormSignUp
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.InputSignUpID);
            this.Controls.Add(this.LabelSignUpNickName);
            this.Controls.Add(this.LabelSignUpPhone);
            this.Controls.Add(this.LabelSignUpPW);
            this.Controls.Add(this.LabelSignUpID);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.InputSignUpNickName);
            this.Controls.Add(this.InputSignUpPhone3);
            this.Controls.Add(this.InputSignUpPhone1);
            this.Controls.Add(this.InputSignUpPhone2);
            this.Controls.Add(this.InputSignUpName);
            this.Controls.Add(this.InputSignUpPW2);
            this.Controls.Add(this.InputSignUpPW1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.Name = "FormSignUp";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "회원가입";
            this.TitleFont = new System.Drawing.Font("나눔바른고딕", 12F);
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox InputSignUpID;
        private Sunny.UI.UITextBox InputSignUpPW2;
        private Sunny.UI.UITextBox InputSignUpPW1;
        private Sunny.UI.UITextBox InputSignUpNickName;
        private TitleBar TitleBar;
        private Sunny.UI.UILabel LabelSignUpPW;
        private Sunny.UI.UILabel LabelSignUpPhone;
        private Sunny.UI.UILabel LabelSignUpNickName;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        public Sunny.UI.UILabel LabelSignUpID;
        private Sunny.UI.UITextBox InputSignUpPhone2;
        private Sunny.UI.UITextBox InputSignUpPhone3;
        private Sunny.UI.UITextBox InputSignUpPhone1;
        private Sunny.UI.UITextBox InputSignUpName;
    }
}
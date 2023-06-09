﻿namespace MiniGameClient
{
    partial class FormSignUp
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
            this.components = new System.ComponentModel.Container();
            this.BtnInfoNickName = new Sunny.UI.UISymbolLabel();
            this.BtnInfoPW = new Sunny.UI.UISymbolLabel();
            this.BtnInfoID = new Sunny.UI.UISymbolLabel();
            this.BtnSignUp = new Sunny.UI.UISymbolButton();
            this.InputID = new Sunny.UI.UITextBox();
            this.LabelNickName = new Sunny.UI.UILabel();
            this.LabelPhone = new Sunny.UI.UILabel();
            this.LabelPW = new Sunny.UI.UILabel();
            this.LabelID = new Sunny.UI.UILabel();
            this.InputNickName = new Sunny.UI.UITextBox();
            this.InputPhone3 = new Sunny.UI.UITextBox();
            this.InputPhone1 = new Sunny.UI.UITextBox();
            this.InputPhone2 = new Sunny.UI.UITextBox();
            this.InputName = new Sunny.UI.UITextBox();
            this.InputPW2 = new Sunny.UI.UITextBox();
            this.ToolTipInfo = new Sunny.UI.UIToolTip(this.components);
            this.InputPW1 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // BtnInfoNickName
            // 
            this.BtnInfoNickName.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfoNickName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfoNickName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnInfoNickName.Location = new System.Drawing.Point(455, 330);
            this.BtnInfoNickName.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnInfoNickName.Name = "BtnInfoNickName";
            this.BtnInfoNickName.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.BtnInfoNickName.Size = new System.Drawing.Size(30, 30);
            this.BtnInfoNickName.Style = Sunny.UI.UIStyle.Custom;
            this.BtnInfoNickName.StyleCustomMode = true;
            this.BtnInfoNickName.Symbol = 62108;
            this.BtnInfoNickName.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnInfoNickName.SymbolSize = 30;
            this.BtnInfoNickName.TabIndex = 44;
            this.BtnInfoNickName.TabStop = false;
            this.BtnInfoNickName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ToolTipInfo.SetToolTip(this.BtnInfoNickName, "한글/영문/숫자 사용 2자 이상 20자 이하\r\n특수문자(공백 제외) 사용 불가");
            // 
            // BtnInfoPW
            // 
            this.BtnInfoPW.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfoPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfoPW.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnInfoPW.Location = new System.Drawing.Point(455, 130);
            this.BtnInfoPW.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnInfoPW.Name = "BtnInfoPW";
            this.BtnInfoPW.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.BtnInfoPW.Size = new System.Drawing.Size(30, 30);
            this.BtnInfoPW.Style = Sunny.UI.UIStyle.Custom;
            this.BtnInfoPW.StyleCustomMode = true;
            this.BtnInfoPW.Symbol = 62108;
            this.BtnInfoPW.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnInfoPW.SymbolSize = 30;
            this.BtnInfoPW.TabIndex = 43;
            this.BtnInfoPW.TabStop = false;
            this.BtnInfoPW.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ToolTipInfo.SetToolTip(this.BtnInfoPW, "영문 및 숫자 최소 1자 이상 포함하여 8자 이상, 20자 이하");
            // 
            // BtnInfoID
            // 
            this.BtnInfoID.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfoID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfoID.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnInfoID.Location = new System.Drawing.Point(455, 70);
            this.BtnInfoID.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnInfoID.Name = "BtnInfoID";
            this.BtnInfoID.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.BtnInfoID.Size = new System.Drawing.Size(30, 30);
            this.BtnInfoID.Style = Sunny.UI.UIStyle.Custom;
            this.BtnInfoID.StyleCustomMode = true;
            this.BtnInfoID.Symbol = 62108;
            this.BtnInfoID.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnInfoID.SymbolSize = 30;
            this.BtnInfoID.TabIndex = 42;
            this.BtnInfoID.TabStop = false;
            this.BtnInfoID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ToolTipInfo.SetToolTip(this.BtnInfoID, "영문 및 숫자를 사용하여 6자 이상, 20자 이하");
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSignUp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSignUp.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnSignUp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnSignUp.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnSignUp.Location = new System.Drawing.Point(468, 403);
            this.BtnSignUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSignUp.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.BtnSignUp.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnSignUp.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnSignUp.Size = new System.Drawing.Size(120, 35);
            this.BtnSignUp.Style = Sunny.UI.UIStyle.Custom;
            this.BtnSignUp.TabIndex = 37;
            this.BtnSignUp.Text = "가입하기";
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // InputID
            // 
            this.InputID.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputID.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputID.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputID.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputID.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputID.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputID.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InputID.Location = new System.Drawing.Point(150, 70);
            this.InputID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputID.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputID.Name = "InputID";
            this.InputID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputID.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputID.ShowText = false;
            this.InputID.Size = new System.Drawing.Size(300, 30);
            this.InputID.Style = Sunny.UI.UIStyle.Custom;
            this.InputID.TabIndex = 29;
            this.InputID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputID.Watermark = "아이디";
            // 
            // LabelNickName
            // 
            this.LabelNickName.BackColor = System.Drawing.Color.Transparent;
            this.LabelNickName.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelNickName.Location = new System.Drawing.Point(150, 360);
            this.LabelNickName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelNickName.Name = "LabelNickName";
            this.LabelNickName.Size = new System.Drawing.Size(300, 23);
            this.LabelNickName.Style = Sunny.UI.UIStyle.Custom;
            this.LabelNickName.TabIndex = 40;
            this.LabelNickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPhone
            // 
            this.LabelPhone.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhone.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelPhone.Location = new System.Drawing.Point(150, 300);
            this.LabelPhone.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(300, 23);
            this.LabelPhone.Style = Sunny.UI.UIStyle.Custom;
            this.LabelPhone.TabIndex = 39;
            this.LabelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPW
            // 
            this.LabelPW.BackColor = System.Drawing.Color.Transparent;
            this.LabelPW.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelPW.Location = new System.Drawing.Point(150, 200);
            this.LabelPW.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPW.Name = "LabelPW";
            this.LabelPW.Size = new System.Drawing.Size(300, 23);
            this.LabelPW.Style = Sunny.UI.UIStyle.Custom;
            this.LabelPW.TabIndex = 38;
            this.LabelPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelID
            // 
            this.LabelID.BackColor = System.Drawing.Color.Transparent;
            this.LabelID.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.LabelID.Location = new System.Drawing.Point(150, 100);
            this.LabelID.Margin = new System.Windows.Forms.Padding(0);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(300, 23);
            this.LabelID.Style = Sunny.UI.UIStyle.Custom;
            this.LabelID.TabIndex = 41;
            this.LabelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputNickName
            // 
            this.InputNickName.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputNickName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputNickName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputNickName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputNickName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputNickName.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputNickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputNickName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputNickName.Location = new System.Drawing.Point(150, 330);
            this.InputNickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputNickName.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputNickName.Name = "InputNickName";
            this.InputNickName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputNickName.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputNickName.ShowText = false;
            this.InputNickName.Size = new System.Drawing.Size(300, 30);
            this.InputNickName.Style = Sunny.UI.UIStyle.Custom;
            this.InputNickName.TabIndex = 36;
            this.InputNickName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputNickName.Watermark = "닉네임";
            // 
            // InputPhone3
            // 
            this.InputPhone3.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone3.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPhone3.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPhone3.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone3.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPhone3.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPhone3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPhone3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPhone3.Location = new System.Drawing.Point(350, 270);
            this.InputPhone3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPhone3.MaxLength = 4;
            this.InputPhone3.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputPhone3.Name = "InputPhone3";
            this.InputPhone3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone3.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone3.ShowText = false;
            this.InputPhone3.Size = new System.Drawing.Size(100, 30);
            this.InputPhone3.Style = Sunny.UI.UIStyle.Custom;
            this.InputPhone3.TabIndex = 35;
            this.InputPhone3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPhone3.Watermark = "";
            this.InputPhone3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPhone_KeyPress);
            this.InputPhone3.Enter += new System.EventHandler(this.InputPhone3_Enter);
            // 
            // InputPhone1
            // 
            this.InputPhone1.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone1.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPhone1.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPhone1.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone1.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPhone1.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPhone1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPhone1.DoubleValue = 10D;
            this.InputPhone1.FillDisableColor = System.Drawing.Color.White;
            this.InputPhone1.FillReadOnlyColor = System.Drawing.Color.White;
            this.InputPhone1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPhone1.IntValue = 10;
            this.InputPhone1.Location = new System.Drawing.Point(150, 270);
            this.InputPhone1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPhone1.MaxLength = 4;
            this.InputPhone1.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputPhone1.Name = "InputPhone1";
            this.InputPhone1.ReadOnly = true;
            this.InputPhone1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone1.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone1.ShowText = false;
            this.InputPhone1.Size = new System.Drawing.Size(80, 30);
            this.InputPhone1.Style = Sunny.UI.UIStyle.Custom;
            this.InputPhone1.TabIndex = 34;
            this.InputPhone1.Text = "010";
            this.InputPhone1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPhone1.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.InputPhone1.Watermark = "";
            // 
            // InputPhone2
            // 
            this.InputPhone2.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone2.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPhone2.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPhone2.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone2.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPhone2.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPhone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPhone2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPhone2.Location = new System.Drawing.Point(240, 270);
            this.InputPhone2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPhone2.MaxLength = 4;
            this.InputPhone2.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputPhone2.Name = "InputPhone2";
            this.InputPhone2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPhone2.ShowText = false;
            this.InputPhone2.Size = new System.Drawing.Size(100, 30);
            this.InputPhone2.Style = Sunny.UI.UIStyle.Custom;
            this.InputPhone2.TabIndex = 33;
            this.InputPhone2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPhone2.Watermark = "";
            this.InputPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPhone_KeyPress);
            this.InputPhone2.Enter += new System.EventHandler(this.InputPhone2_Enter);
            // 
            // InputName
            // 
            this.InputName.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputName.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputName.Location = new System.Drawing.Point(150, 230);
            this.InputName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputName.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputName.Name = "InputName";
            this.InputName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputName.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputName.ShowText = false;
            this.InputName.Size = new System.Drawing.Size(300, 30);
            this.InputName.Style = Sunny.UI.UIStyle.Custom;
            this.InputName.TabIndex = 32;
            this.InputName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputName.Watermark = "이름";
            // 
            // InputPW2
            // 
            this.InputPW2.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW2.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPW2.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPW2.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW2.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPW2.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPW2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPW2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPW2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InputPW2.Location = new System.Drawing.Point(150, 170);
            this.InputPW2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPW2.MaxLength = 20;
            this.InputPW2.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputPW2.Name = "InputPW2";
            this.InputPW2.PasswordChar = '●';
            this.InputPW2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW2.ShowText = false;
            this.InputPW2.Size = new System.Drawing.Size(300, 30);
            this.InputPW2.Style = Sunny.UI.UIStyle.Custom;
            this.InputPW2.TabIndex = 31;
            this.InputPW2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPW2.Watermark = "비밀번호 확인";
            this.InputPW2.Enter += new System.EventHandler(this.InputPW2_Enter);
            // 
            // ToolTipInfo
            // 
            this.ToolTipInfo.BackColor = System.Drawing.Color.White;
            this.ToolTipInfo.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ToolTipInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ToolTipInfo.OwnerDraw = true;
            this.ToolTipInfo.Tag = "ID";
            this.ToolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipInfo.UseAnimation = false;
            this.ToolTipInfo.UseFading = false;
            // 
            // InputPW1
            // 
            this.InputPW1.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW1.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPW1.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPW1.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW1.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.InputPW1.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InputPW1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPW1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputPW1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.InputPW1.Location = new System.Drawing.Point(150, 130);
            this.InputPW1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputPW1.MinimumSize = new System.Drawing.Size(1, 16);
            this.InputPW1.Name = "InputPW1";
            this.InputPW1.PasswordChar = '●';
            this.InputPW1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InputPW1.ShowText = false;
            this.InputPW1.Size = new System.Drawing.Size(300, 30);
            this.InputPW1.Style = Sunny.UI.UIStyle.Custom;
            this.InputPW1.TabIndex = 30;
            this.InputPW1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPW1.Watermark = "비밀번호";
            // 
            // FormSignUp
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.BtnInfoNickName);
            this.Controls.Add(this.BtnInfoPW);
            this.Controls.Add(this.BtnInfoID);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.InputID);
            this.Controls.Add(this.LabelNickName);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.LabelPW);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.InputNickName);
            this.Controls.Add(this.InputPhone3);
            this.Controls.Add(this.InputPhone1);
            this.Controls.Add(this.InputPhone2);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputPW2);
            this.Controls.Add(this.InputPW1);
            this.Name = "FormSignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel BtnInfoNickName;
        private Sunny.UI.UIToolTip ToolTipInfo;
        private Sunny.UI.UISymbolLabel BtnInfoPW;
        private Sunny.UI.UISymbolLabel BtnInfoID;
        private Sunny.UI.UISymbolButton BtnSignUp;
        private Sunny.UI.UITextBox InputID;
        public Sunny.UI.UILabel LabelNickName;
        public Sunny.UI.UILabel LabelPhone;
        public Sunny.UI.UILabel LabelPW;
        public Sunny.UI.UILabel LabelID;
        private Sunny.UI.UITextBox InputNickName;
        private Sunny.UI.UITextBox InputPhone3;
        private Sunny.UI.UITextBox InputPhone1;
        private Sunny.UI.UITextBox InputPhone2;
        private Sunny.UI.UITextBox InputName;
        private Sunny.UI.UITextBox InputPW2;
        private Sunny.UI.UITextBox InputPW1;
    }
}

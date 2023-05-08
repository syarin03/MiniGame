namespace MiniGameClient
{
    partial class TitleBar
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleName = new Sunny.UI.UILabel();
            this.BtnClose = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // TitleName
            // 
            this.TitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleName.BackColor = System.Drawing.Color.Transparent;
            this.TitleName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold);
            this.TitleName.ForeColor = System.Drawing.Color.White;
            this.TitleName.Location = new System.Drawing.Point(0, 0);
            this.TitleName.Margin = new System.Windows.Forms.Padding(0);
            this.TitleName.Name = "TitleName";
            this.TitleName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TitleName.Size = new System.Drawing.Size(600, 35);
            this.TitleName.Style = Sunny.UI.UIStyle.Custom;
            this.TitleName.StyleCustomMode = true;
            this.TitleName.TabIndex = 0;
            this.TitleName.Text = "Form";
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FillColor = System.Drawing.Color.Transparent;
            this.BtnClose.FillColor2 = System.Drawing.Color.Transparent;
            this.BtnClose.FillDisableColor = System.Drawing.Color.Transparent;
            this.BtnClose.FillHoverColor = System.Drawing.Color.Transparent;
            this.BtnClose.FillPressColor = System.Drawing.Color.Transparent;
            this.BtnClose.FillSelectedColor = System.Drawing.Color.Transparent;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnClose.Location = new System.Drawing.Point(565, 0);
            this.BtnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RectColor = System.Drawing.Color.Transparent;
            this.BtnClose.RectDisableColor = System.Drawing.Color.Transparent;
            this.BtnClose.RectHoverColor = System.Drawing.Color.Transparent;
            this.BtnClose.RectPressColor = System.Drawing.Color.Transparent;
            this.BtnClose.RectSelectedColor = System.Drawing.Color.Transparent;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.Style = Sunny.UI.UIStyle.Custom;
            this.BtnClose.StyleCustomMode = true;
            this.BtnClose.Symbol = 61453;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TitleBar
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TitleName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(600, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel TitleName;
        private Sunny.UI.UISymbolButton BtnClose;
    }
}

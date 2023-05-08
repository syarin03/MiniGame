namespace MiniGameClient
{
    partial class RoomPanel
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
            this.RoomNumber = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.RoomName = new Sunny.UI.UILabel();
            this.HostName = new Sunny.UI.UILabel();
            this.SymbolSecret = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // RoomNumber
            // 
            this.RoomNumber.Font = new System.Drawing.Font("나눔바른고딕", 20F, System.Drawing.FontStyle.Bold);
            this.RoomNumber.Location = new System.Drawing.Point(0, 0);
            this.RoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(80, 100);
            this.RoomNumber.TabIndex = 0;
            this.RoomNumber.Text = "1234";
            this.RoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLine1.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLine1.Location = new System.Drawing.Point(80, 0);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(4, 100);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 1;
            // 
            // RoomName
            // 
            this.RoomName.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.RoomName.Location = new System.Drawing.Point(100, 10);
            this.RoomName.Margin = new System.Windows.Forms.Padding(10);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(170, 23);
            this.RoomName.TabIndex = 2;
            this.RoomName.Text = "RoomName";
            this.RoomName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HostName
            // 
            this.HostName.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.HostName.Location = new System.Drawing.Point(100, 40);
            this.HostName.Margin = new System.Windows.Forms.Padding(10);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(100, 23);
            this.HostName.TabIndex = 2;
            this.HostName.Text = "HostName";
            this.HostName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SymbolSecret
            // 
            this.SymbolSecret.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SymbolSecret.Location = new System.Drawing.Point(245, 65);
            this.SymbolSecret.MinimumSize = new System.Drawing.Size(1, 1);
            this.SymbolSecret.Name = "SymbolSecret";
            this.SymbolSecret.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.SymbolSecret.Size = new System.Drawing.Size(35, 35);
            this.SymbolSecret.Style = Sunny.UI.UIStyle.Custom;
            this.SymbolSecret.StyleCustomMode = true;
            this.SymbolSecret.Symbol = 61475;
            this.SymbolSecret.SymbolOffset = new System.Drawing.Point(-2, 0);
            this.SymbolSecret.TabIndex = 3;
            // 
            // RoomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.SymbolSecret);
            this.Controls.Add(this.HostName);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.RoomNumber);
            this.Name = "RoomPanel";
            this.Size = new System.Drawing.Size(280, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel RoomNumber;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel RoomName;
        private Sunny.UI.UILabel HostName;
        private Sunny.UI.UISymbolLabel SymbolSecret;
    }
}

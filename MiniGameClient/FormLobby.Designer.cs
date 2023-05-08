namespace MiniGameClient
{
    partial class FormLobby
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
            this.FlowRoomList = new Sunny.UI.UIFlowLayoutPanel();
            this.Avatar = new Sunny.UI.UIAvatar();
            this.PanelUserInfo = new Sunny.UI.UIPanel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.LabelNickName = new Sunny.UI.UILabel();
            this.PanelRoomList = new Sunny.UI.UIPanel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.PanelUserInfo.SuspendLayout();
            this.PanelRoomList.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowRoomList
            // 
            this.FlowRoomList.FillColor = System.Drawing.Color.Transparent;
            this.FlowRoomList.FillColor2 = System.Drawing.Color.Transparent;
            this.FlowRoomList.FillDisableColor = System.Drawing.Color.Transparent;
            this.FlowRoomList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.FlowRoomList.Location = new System.Drawing.Point(0, 35);
            this.FlowRoomList.Margin = new System.Windows.Forms.Padding(0);
            this.FlowRoomList.MinimumSize = new System.Drawing.Size(1, 1);
            this.FlowRoomList.Name = "FlowRoomList";
            this.FlowRoomList.Padding = new System.Windows.Forms.Padding(2);
            this.FlowRoomList.RectColor = System.Drawing.Color.Transparent;
            this.FlowRoomList.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.FlowRoomList.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FlowRoomList.ShowText = false;
            this.FlowRoomList.Size = new System.Drawing.Size(600, 530);
            this.FlowRoomList.Style = Sunny.UI.UIStyle.Custom;
            this.FlowRoomList.StyleCustomMode = true;
            this.FlowRoomList.TabIndex = 4;
            this.FlowRoomList.Text = "uiFlowLayoutPanel1";
            this.FlowRoomList.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.Transparent;
            this.Avatar.FillColor = System.Drawing.Color.White;
            this.Avatar.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Avatar.Location = new System.Drawing.Point(5, 30);
            this.Avatar.Margin = new System.Windows.Forms.Padding(5);
            this.Avatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(80, 90);
            this.Avatar.Style = Sunny.UI.UIStyle.Custom;
            this.Avatar.StyleCustomMode = true;
            this.Avatar.TabIndex = 1;
            // 
            // PanelUserInfo
            // 
            this.PanelUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.PanelUserInfo.Controls.Add(this.uiSymbolLabel1);
            this.PanelUserInfo.Controls.Add(this.LabelNickName);
            this.PanelUserInfo.Controls.Add(this.Avatar);
            this.PanelUserInfo.FillColor = System.Drawing.Color.Transparent;
            this.PanelUserInfo.FillColor2 = System.Drawing.Color.Transparent;
            this.PanelUserInfo.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelUserInfo.Location = new System.Drawing.Point(0, 35);
            this.PanelUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelUserInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelUserInfo.Name = "PanelUserInfo";
            this.PanelUserInfo.RectColor = System.Drawing.Color.Transparent;
            this.PanelUserInfo.RectDisableColor = System.Drawing.Color.Transparent;
            this.PanelUserInfo.Size = new System.Drawing.Size(200, 200);
            this.PanelUserInfo.Style = Sunny.UI.UIStyle.Custom;
            this.PanelUserInfo.StyleCustomMode = true;
            this.PanelUserInfo.TabIndex = 6;
            this.PanelUserInfo.Text = null;
            this.PanelUserInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Font = new System.Drawing.Font("나눔바른고딕", 8F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(5, 5);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(190, 25);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.StyleCustomMode = true;
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.SymbolSize = 12;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "내 정보";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelNickName
            // 
            this.LabelNickName.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNickName.Location = new System.Drawing.Point(90, 40);
            this.LabelNickName.Name = "LabelNickName";
            this.LabelNickName.Size = new System.Drawing.Size(100, 35);
            this.LabelNickName.Style = Sunny.UI.UIStyle.Custom;
            this.LabelNickName.StyleCustomMode = true;
            this.LabelNickName.TabIndex = 2;
            this.LabelNickName.Text = "nickname";
            this.LabelNickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelRoomList
            // 
            this.PanelRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.PanelRoomList.Controls.Add(this.FlowRoomList);
            this.PanelRoomList.Controls.Add(this.uiSymbolLabel2);
            this.PanelRoomList.FillColor = System.Drawing.Color.Transparent;
            this.PanelRoomList.FillColor2 = System.Drawing.Color.Transparent;
            this.PanelRoomList.FillDisableColor = System.Drawing.Color.Transparent;
            this.PanelRoomList.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRoomList.Location = new System.Drawing.Point(200, 35);
            this.PanelRoomList.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRoomList.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelRoomList.Name = "PanelRoomList";
            this.PanelRoomList.RectColor = System.Drawing.Color.Transparent;
            this.PanelRoomList.RectDisableColor = System.Drawing.Color.Transparent;
            this.PanelRoomList.Size = new System.Drawing.Size(600, 565);
            this.PanelRoomList.Style = Sunny.UI.UIStyle.Custom;
            this.PanelRoomList.StyleCustomMode = true;
            this.PanelRoomList.TabIndex = 7;
            this.PanelRoomList.Text = null;
            this.PanelRoomList.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.Font = new System.Drawing.Font("나눔바른고딕", 8F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(5, 5);
            this.uiSymbolLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(590, 25);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.StyleCustomMode = true;
            this.uiSymbolLabel2.Symbol = 61641;
            this.uiSymbolLabel2.SymbolSize = 12;
            this.uiSymbolLabel2.TabIndex = 3;
            this.uiSymbolLabel2.Text = "방 목록";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLobby
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelUserInfo);
            this.Controls.Add(this.PanelRoomList);
            this.Name = "FormLobby";
            this.PanelUserInfo.ResumeLayout(false);
            this.PanelRoomList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIFlowLayoutPanel FlowRoomList;
        private Sunny.UI.UIAvatar Avatar;
        private Sunny.UI.UIPanel PanelUserInfo;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UILabel LabelNickName;
        private Sunny.UI.UIPanel PanelRoomList;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
    }
}

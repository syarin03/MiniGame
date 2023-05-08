using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniGameClient
{
    public partial class FormLobby : MiniGameClient.CustomForm
    {
        ClientManager clientManager;
        public Player player;

        public FormLobby(ClientManager cm)
        {
            InitializeComponent();
            clientManager = cm;
            UILocalizeHelper.SetEN();
            clientManager.FormLobby = this;
            player = clientManager.player;
            LabelNickName.Text = player.Nickname;
        }
    }
}

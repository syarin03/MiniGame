using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace MiniGameClient
{
    public partial class FormLogin : UIForm
    {
        ClientManager clientManager;
        Dictionary<string, object> sendDataDict;

        public FormLogin(ClientManager cm)
        {
            InitializeComponent();
            clientManager = cm;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (InputLoginID.Text == "" || InputLoginPW.Text == "")
            {
                UIMessageBox.ShowWarning("아이디 또는 비밀번호 입력을 확인해주세요");
            }
            else
            {
                string input_id = InputLoginID.Text;
                string input_pw = InputLoginPW.Text;

                sendDataDict = new Dictionary<string, object>
                {
                    { "method", "Login" },
                    { "sender", clientManager.client.Client.LocalEndPoint },
                    { "input_id", input_id },
                    { "input_pw", input_pw }
                };

                clientManager.SendData(sendDataDict);
            }
        }
    }
}

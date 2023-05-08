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
    public partial class FormLogin : MiniGameClient.CustomForm
    {
        ClientManager clientManager;
        Dictionary<string, object> sendDataDict;

        public FormLogin(ClientManager cm)
        {
            InitializeComponent();
            clientManager = cm;
            UILocalizeHelper.SetEN();
            clientManager.FormLogin = this;
            Console.WriteLine("asdf " + clientManager.FormLogin.ToString());
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (InputID.Text == "" || InputPW.Text == "")
            {
                UIMessageBox.ShowWarning("아이디 또는 비밀번호 입력을 확인해주세요", false);
            }
            else
            {
                string input_id = InputID.Text;
                string input_pw = InputPW.Text;

                sendDataDict = new Dictionary<string, object>
                {
                    { "method", "LogIn" },
                    { "sender", clientManager.clientIP },
                    { "input_id", input_id },
                    { "input_pw", input_pw }
                };

                clientManager.SendData(sendDataDict);
            }
        }

        private void BtnLoginToSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp(clientManager);
            clientManager.FormSignUp = formSignUp;
            formSignUp.ShowDialog();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clientManager.player == null)
            {
                Application.Exit();
            }
        }
    }
}

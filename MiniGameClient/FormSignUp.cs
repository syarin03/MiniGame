using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace MiniGameClient
{
    public partial class FormSignUp : UIForm
    {
        Dictionary<string, object> sendDataDict;
        ClientManager clientManager;
        bool isClicked = false;

        public FormSignUp(ClientManager cm)
        {
            InitializeComponent();
            TitleBar.TitleName = "회원가입";
            clientManager = cm;
            InputSignUpPhone2.Text = string.Empty;
            InputSignUpPhone3.Text = string.Empty;
        }

        private void InputSignUpID_Leave(object sender, EventArgs e)
        {
            sendDataDict = new Dictionary<string, object>()
            {
                { "method", "CheckID" },
                { "sender", clientManager.clientIP },
                { "input_id", InputSignUpID.Text }
            };
            clientManager.SendData(sendDataDict);
        }

        private void InputSignUpPW2_Enter(object sender, EventArgs e)
        {
            isClicked = true;
        }

        private void InputSignUpPW1_Leave(object sender, EventArgs e)
        {
            if (InputSignUpPW1.Text.Length < 8 || !Regex.IsMatch(InputSignUpPW1.Text, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                LabelSignUpPW.Text = "영어, 숫자 혼용 8~20자";
            }
            else if (isClicked && InputSignUpPW1.Text != InputSignUpPW2.Text)
            {
                LabelSignUpPW.Text = "비밀번호가 일치하지 않습니다";
            }
            else
            {
                LabelSignUpPW.Text = "";
            }
        }

        private void InputSignUpPW2_Leave(object sender, EventArgs e)
        {
            if (InputSignUpPW1.Text.Length < 8 || !Regex.IsMatch(InputSignUpPW1.Text, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                LabelSignUpPW.Text = "영어, 숫자 혼용 8~20자";
            }
            else if (InputSignUpPW1.Text != InputSignUpPW2.Text)
            {
                LabelSignUpPW.Text = "비밀번호                                  가 일치하지 않습니다";
            }
        }

        private void InputSignUpNickName_Leave(object sender, EventArgs e)
        {
            sendDataDict = new Dictionary<string, object>()
            {
                { "method", "CheckNickName" },
                { "sender", clientManager.clientIP },
                { "input_id", InputSignUpNickName.Text }
            };
            clientManager.SendData(sendDataDict);
        }
    }
}

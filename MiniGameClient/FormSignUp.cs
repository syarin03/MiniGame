using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameClient
{
    public partial class FormSignUp : MiniGameClient.CustomForm
    {
        Dictionary<string, object> sendDataDict;
        ClientManager clientManager;
        public bool isPW2Clicked = false;
        public bool isPhone2Clicked = false;
        public bool isPhone3Clicked = false;
        public bool isIDChecked = false;
        public bool isPWRight = false;
        public bool isPhoneChecked = false;
        public bool isNickNameChecked = false;
        public bool isNickNameLeave = false;

        public FormSignUp(ClientManager cm)
        {
            InitializeComponent();
            clientManager = cm;
            InputPhone2.Text = string.Empty;
            InputPhone3.Text = string.Empty;
        }

        private async void BtnSignUp_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            while (true)
            {
                if (InputName.Focused)
                {
                    continue;
                }

                else if (!isIDChecked || !isNickNameChecked || !isPhoneChecked)
                {
                    UIMessageBox.ShowWarning("중복 확인을 해주세요", false);
                    return;
                }
                else
                {
                    string phone = InputPhone1.Text + InputPhone2.Text + InputPhone3.Text;
                    List<string> values = new List<string>
                    {
                        InputID.Text,
                        InputPW1.Text,
                        InputName.Text,
                        phone,
                        InputNickName.Text
                    };
                    sendDataDict = new Dictionary<string, object>()
                    {
                        { "method", "SignUp" },
                        { "sender", clientManager.clientIP },
                        { "values", values }
                    };

                    clientManager.SendData(sendDataDict);
                    break;
                }
            }
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            if (sender == InputID)
            {
                InputID.Text = Regex.Replace(InputID.Text, @"[^a-zA-Z0-9]", string.Empty, RegexOptions.Singleline);
                if (InputID.TextLength < 4 || InputID.TextLength > 20)
                {
                    LabelID.Text = "아이디 규칙에 맞춰주세요";
                    return;
                }
                sendDataDict = new Dictionary<string, object>()
                {
                    { "method", "CheckID" },
                    { "sender", clientManager.clientIP },
                    { "input_id", InputID.Text }
                };

                clientManager.SendData(sendDataDict);
            }
            else if (sender == InputPW1 || sender == InputPW2)
            {
                InputPW1.Text = Regex.Replace(InputPW1.Text, @"[^a-zA-Z0-9]", string.Empty, RegexOptions.Singleline);
                InputPW2.Text = Regex.Replace(InputPW2.Text, @"[^a-zA-Z0-9]", string.Empty, RegexOptions.Singleline);

                if (!Regex.IsMatch(InputPW1.Text, @"^(?=.*?[a-zA-Z])(?=.*?[0-9]).{8,20}$"))
                {
                    LabelPW.Text = "비밀번호 규칙에 맞춰주세요";
                    isPWRight = false;
                    return;
                }
                else if (isPW2Clicked && InputPW1.Text != InputPW2.Text)
                {
                    LabelPW.Text = "비밀번호가 일치하지 않습니다";
                    isPWRight = false;
                    return;
                }
                LabelPW.Text = string.Empty;
                isPWRight = true;
            }
            else if (sender == InputNickName)
            {
                InputNickName.Text = Regex.Replace(InputNickName.Text, @"[^a-zA-Z0-9가-힣]", string.Empty, RegexOptions.Singleline);

                sendDataDict = new Dictionary<string, object>()
                {
                    { "method", "CheckNickName" },
                    { "sender", clientManager.clientIP },
                    { "input_nickname", InputNickName.Text }
                };

                clientManager.SendData(sendDataDict);

                isNickNameLeave = true;
            }
            else if (sender == InputPhone2 || sender == InputPhone3)
            {
                if (isPhone2Clicked && isPhone3Clicked && (InputPhone2.TextLength < 4 || InputPhone3.TextLength < 4))
                {
                    LabelPhone.Text = "올바른 전화번호를 입력해주세요";
                    return;
                }

                LabelPhone.Text = string.Empty;

                string phone = InputPhone1.Text + InputPhone2.Text + InputPhone3.Text;
                sendDataDict = new Dictionary<string, object>()
                {
                    { "method", "CheckPhone" },
                    { "sender", clientManager.clientIP },
                    { "input_phone", phone }
                };

                clientManager.SendData(sendDataDict);
            }
        }

        private void InputPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void InputPW2_Enter(object sender, EventArgs e)
        {
            isPW2Clicked = true;
        }

        private void InputPhone2_Enter(object sender, EventArgs e)
        {
            isPhone2Clicked = true;
        }

        private void InputPhone3_Enter(object sender, EventArgs e)
        {
            isPhone3Clicked = true;
        }
    }
}

using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace MiniGameClient
{
    public class ClientManager
    {
        public bool isConnect = false;
        public EndPoint clientIP;

        public TcpClient client;
        NetworkStream networkStream;

        public Player player;

        public FormSignUp FormSignUp { get; set; }
        public FormLogin FormLogin { get; set; }
        public FormLobby FormLobby { get; set; }


        public ClientManager()
        {
            Thread thread = new Thread(() => ThreadProc())
            {
                IsBackground = true
            };
            thread.Start();
            Thread.Sleep(100);
        }

        private void ThreadProc()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 2869);
                networkStream = client.GetStream();
                isConnect = true;

                clientIP = client.Client.LocalEndPoint;

                Console.WriteLine(clientIP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UIMessageBox.ShowError("서버와의 연결이 끊겼습니다", false);
                isConnect = false;
                return;
            }

            while (true)
            {
                ReceiveData();
            }
        }

        public void SendData(Dictionary<string, object> sendDataDict)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, sendDataDict);
            byte[] sendData = memoryStream.ToArray();

            try
            {
                networkStream.Write(sendData, 0, sendData.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReceiveData()
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
                    memoryStream.Write(buffer, 0, bytesRead);
                    memoryStream.Position = 0;

                    Dictionary<string, object> receiveDataDict =
                        (Dictionary<string, object>)binaryFormatter.Deserialize(memoryStream);

                    string method = receiveDataDict["method"].ToString();
                    Console.WriteLine(method);

                    switch (method)
                    {
                        case "LogInResult":
                            if (!(bool)receiveDataDict["result"])
                            {
                                UIMessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다", false);
                            }
                            else
                            {
                                List<object> value = (List<object>)receiveDataDict["value"];
                                player = new Player(value);
                                FormLogin.DialogResult = DialogResult.OK;
                            }
                            break;

                        case "CheckIDResult":
                            if (!(bool)receiveDataDict["result"])
                            {
                                FormSignUp.Invoke((MethodInvoker)delegate ()
                                {
                                    FormSignUp.LabelID.Text = "이미 사용 중인 아이디입니다";
                                });
                                FormSignUp.isIDChecked = false;
                            }
                            else
                            {
                                FormSignUp.Invoke((MethodInvoker)delegate ()
                                {
                                    FormSignUp.LabelID.Text = "사용 가능한 아이디입니다";
                                });
                                FormSignUp.isIDChecked = true;
                            }
                            break;

                        case "CheckPhoneResult":
                            if (!(bool)receiveDataDict["result"])
                            {
                                FormSignUp.Invoke((MethodInvoker)delegate ()
                                {
                                    FormSignUp.LabelPhone.Text = "이미 가입되어있는 전화번호입니다";
                                });
                                FormSignUp.isPhoneChecked = false;
                            }
                            else
                            {
                                FormSignUp.Invoke((MethodInvoker)delegate ()
                                {
                                    FormSignUp.LabelPhone.Text = string.Empty;
                                });
                                FormSignUp.isPhoneChecked = true;
                            }
                            break;

                        case "CheckNickNameResult":
                            if (!(bool)receiveDataDict["result"])
                            {
                                FormSignUp.Invoke((MethodInvoker)delegate ()
                                {
                                    FormSignUp.LabelNickName.Text = "이미 사용 중인 닉네임입니다";
                                });
                                FormSignUp.isNickNameChecked = false;
                            }
                            else
                            {
                                FormSignUp.Invoke((MethodInvoker)delegate ()
                                {
                                    FormSignUp.LabelNickName.Text = string.Empty;
                                });
                                FormSignUp.isNickNameChecked = true;
                            }
                            break;

                        case "SignUpResult":
                            UIMessageBox.ShowSuccess("회원가입을 완료했습니다", false);
                            FormSignUp.Invoke((MethodInvoker)delegate ()
                            {
                                FormSignUp.DialogResult = DialogResult.OK;
                            });
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}

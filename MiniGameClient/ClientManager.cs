using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameClient
{
    public class ClientManager
    {
        public TcpClient client;
        NetworkStream networkStream;
        public bool isConnect = false;

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

                Console.WriteLine(client.Client.LocalEndPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

                    Console.WriteLine(receiveDataDict["method"]);
                    string method = receiveDataDict["method"].ToString();

                    switch (method)
                    {
                        case "LoginResult":
                            if (!(bool)receiveDataDict["result"])
                            {
                                UIMessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다");
                            }
                            else
                            {
                                UIMessageBox.Show("로그인 성공");
                            }
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

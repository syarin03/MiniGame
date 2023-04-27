using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sunny.UI;

namespace MiniGameServer
{
    internal class ServerManager
    {
        public delegate void AppendText(string str);
        TcpListener listener;
        List<TcpClient> clientList = new List<TcpClient>();
        Queue<Dictionary<string, object>> receiveDataQueue = new Queue<Dictionary<string, object>>();
        Thread listenerThread;
        Thread processThread;
        public bool isRun = false;

        public ServerManager()
        {
            listener = new TcpListener(IPAddress.Any, 2869); // 아무 아이피나 2869포트를 통해서 접속 가능한 리스너
            DBManager.ConnectTest();
        }

        public void ServerStart()
        {
            if (isRun)
            {
                AddLog("Server is already running");
                return;
            }
            listener.Start();

            listenerThread = new Thread(ServerThread)
            {
                IsBackground = true
            };
            listenerThread.Start();

            processThread = new Thread(ProcessReceiveData)
            {
                IsBackground = true
            };
            processThread.Start();

            AddLog("Server Start");

            isRun = true;
        }

        public void ServerStop()
        {
            if (!isRun)
            {
                AddLog("Server is not running");
                return;
            }
            foreach (TcpClient client in clientList)
            {
                client.Close();
            }
            listener.Stop();

            AddLog("Server Stop");

            isRun = false;
        }

        private void ServerThread()
        {
            while (true)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clientList.Add(client);
                    AddLog($"Client \"{client.Client.RemoteEndPoint}\" Connect");

                    Thread clientThread = new Thread(() => ReceiveData(client))
                    {
                        IsBackground = true
                    };
                    clientThread.Start();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void ReceiveData(TcpClient client)
        {
            while (true)
            {
                try
                {
                    NetworkStream networkStream = client.GetStream();
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        byte[] buffer = new byte[client.ReceiveBufferSize];
                        int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
                        memoryStream.Write(buffer, 0, bytesRead);
                        memoryStream.Position = 0;

                        Dictionary<string, object> receiveDataDict = (Dictionary<string, object>)binaryFormatter.Deserialize(memoryStream);

                        receiveDataQueue.Enqueue(receiveDataDict);
                    }
                }
                catch (Exception)
                {
                    AddLog($"Client \"{client.Client.RemoteEndPoint}\" Disconnect");
                    clientList.Remove(client);
                    client.Close();
                    client.Dispose();
                    return;
                }
            }
        }

        private void ProcessReceiveData()
        {
            while (true)
            {
                if (receiveDataQueue.Count <= 0) continue;

                ProcessMethod();
            }
        }

        private void ProcessMethod()
        {
            Dictionary<string, object> receiveDataDict = receiveDataQueue.Dequeue();
            string method = receiveDataDict["method"].ToString();
            Dictionary<string, object> sendDataDict = new Dictionary<string, object>();
            string sender = receiveDataDict["sender"].ToString();
            string sql;

            switch (method)
            {
                case "Login":
                    sendDataDict.Add("method", "LoginResult");
                    string input_login_id = receiveDataDict["input_id"].ToString();
                    string input_login_pw = receiveDataDict["input_pw"].ToString();
                    sql = $"SELECT * FROM table_user WHERE id = \"{input_login_id}\" AND password = \"{input_login_pw}\";";
                    if (DBManager.GetDataCount(sql) <= 0)
                    {
                        sendDataDict.Add("result", false);
                    }
                    else
                    {
                        sendDataDict.Add("result", true);
                    }
                    break;
                case "CheckID":
                    sendDataDict.Add("method", "CheckIDResult");
                    string input_check_id = receiveDataDict["input_id"].ToString();
                    sql = $"SELECT * FROM table_user WHERE id = \"{input_check_id}\";";
                    if (DBManager.GetDataCount(sql) <= 0)
                    {
                        sendDataDict.Add("result", true);
                    }
                    else
                    {
                        sendDataDict.Add("result", false);
                    }
                    break;
                default:
                    break;
            }

            foreach (TcpClient client in clientList)
            {
                if (client.Client.RemoteEndPoint.ToString() == sender)
                {
                    SendData(client, sendDataDict);
                }
            }
        }

        public void SendData(TcpClient client, Dictionary<string, object> sendDataDict)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, sendDataDict);
            byte[] sendData = memoryStream.ToArray();
            NetworkStream networkStream = client.GetStream();

            try
            {
                networkStream.Write(sendData, 0, sendData.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static event AppendText Append;

        public static void AddLog(string log)
        {
            Append(log);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace MiniGameClient
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UILocalizeHelper.SetEN();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                ClientManager clientManager = new ClientManager();
                Thread.Sleep(1000);

                if (clientManager.isConnect)
                {
                    FormLogin formLogin = new FormLogin(clientManager);
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new FormLobby(clientManager));
                    }
                    break;
                }
                else
                {
                    if (!UIMessageBox.Show("서버 연결에 실패했습니다\n재시도 하시겠습니까?", "서버 연결 실패", UIStyle.Red, UIMessageBoxButtons.OKCancel, false))
                        break;
                }
            }
        }
    }
}

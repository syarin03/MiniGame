using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace MiniGameServer
{
    public partial class FormServer : UIForm
    {
        ServerManager serverManager;
        public FormServer()
        {
            InitializeComponent();
            serverManager = new ServerManager();
            ServerManager.Append += new ServerManager.AppendText(AppendText);
        }

        private void AppendText(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    LogHistory.AppendText(DateTime.Now.ToString() + ": " + s);
                    LogHistory.AppendText("\r\n");
                    LogHistory.ScrollToCaret();
                }));
            }
            else
            {
                LogHistory.AppendText(DateTime.Now.ToString() + ": " + s);
                LogHistory.AppendText("\r\n");
                LogHistory.ScrollToCaret();
            }
        }

        private void BtnServerStart_Click(object sender, EventArgs e)
        {
            serverManager.ServerStart();
        }

        private void BtnServerStop_Click(object sender, EventArgs e)
        {
            serverManager.ServerStop();
        }
    }
}

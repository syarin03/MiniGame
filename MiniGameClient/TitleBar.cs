using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameClient
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        public string TitleName
        {
            get
            {
                return LabelTitleName.Text;
            }
            set
            {
                LabelTitleName.Text = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmaCleaning.界面
{
    public partial class 消息提示框 :Form
    {
        public 消息提示框()
        {
            InitializeComponent();
        }
        public void Message(string message)
        {
            lb_message.Text = message;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

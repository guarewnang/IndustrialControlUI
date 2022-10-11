using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlasmaCleaning.BLL;
using PlasmaCleaning.Model;
using System.Data.Entity;

namespace PlasmaCleaning.界面
{
    public delegate void SendLogin(ModelUser user);
    public partial class 登录窗口 :Form
    {
        public SendLogin sendLogin;//实例化后的委托
        UserBLL userBLL = new UserBLL();
        public 登录窗口()
        {
            InitializeComponent();
            this.ControlBox = false;         
        }
        private void 登录窗口_Load(object sender, EventArgs e)
        {          
            comB_userName.Items.Clear();
            List<ModelUser> listuser=userBLL.UserlistLoad();
            listuser.ForEach(s => comB_userName.Items.Add(s.UserName));
            comB_userName.Items.Remove("GOD");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            ModelUser res = userBLL.UserLogIn(comB_userName.Text, txt_passWrod.Text);
            if (res!=null)
            {
                sendLogin(res);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}

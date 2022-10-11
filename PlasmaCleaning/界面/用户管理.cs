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
using System.IO;
using System.Diagnostics;

namespace PlasmaCleaning.界面
{
    public partial class 用户管理 : Form
    {
        UserBLL userBLL = new UserBLL();
        List<ModelUser> manageruser = new List<ModelUser>();
        DataGridViewSelectedRowCollection rowCollection;
        DataGridViewRow row;
        int selectId, selectAuthority;
        string selectName, selectPassword;

        public 用户管理()
        {
            InitializeComponent();
            this.btn_addUser.Click += new System.EventHandler(RefreshData);
            this.btn_deleteUser.Click += new System.EventHandler(RefreshData);
            this.btn_changeUser.Click += new System.EventHandler(RefreshData);
        }
        /// <summary>
        /// 获取选择用户的信息
        /// </summary>
        private void SelectUser()
        {
            rowCollection = dgv_Manager.SelectedRows;
            if (rowCollection.Count == 0) return;
            row = rowCollection[0];
            txt_userName.Text = row.Cells[1].Value.ToString();
            txt_passWord.Text = row.Cells[2].Value.ToString();
            selectId = (int)row.Cells[0].Value;
            selectName = row.Cells[1].Value.ToString();
            selectPassword = row.Cells[2].Value.ToString();
            selectAuthority = (int)row.Cells[3].Value;
            switch ((int)row.Cells[3].Value)
            {
                case 1:
                    comb_level.SelectedIndex = 0;
                    break;
                case 2:
                    comb_level.SelectedIndex = 1;
                    break;
                case 3:
                    comb_level.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (CheckAuthority(MainForm.CurrentInfo.UserAuthority, comb_level.SelectedIndex + 1))
                userBLL.AddUser(txt_userName.Text, txt_passWord.Text, comb_level.SelectedIndex + 1);
        }
        /// <summary>
        /// 删除用户信息,不能删除当前用户，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if (selectId != MainForm.CurrentInfo.UserId)
            {
                userBLL.DeleteUser(selectId);
            }
            else
            {
                MessageBox.Show("您无法删除当前用户", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 选择不同用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Manager_SelectionChanged(object sender, EventArgs e)
        {
            SelectUser();
        }
        /// <summary>
        /// 改变用户信息,先判定改自身还改别人
        /// 改自身：提示改外需要重新登录？是-判定只能改小于等于自身权限的且不能重名；否-退出
        /// 改别人：只能改小于自身权限的他人，且不能有重名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_changeUser_Click(object sender, EventArgs e)
        {
            if (selectId != MainForm.CurrentInfo.UserId)
            {
                if (CheckAuthority(MainForm.CurrentInfo.UserAuthority, comb_level.SelectedIndex + 1) && !userBLL.UserIsExist(txt_userName.Text, selectId))
                    userBLL.ChangeUser(selectId, txt_userName.Text, txt_passWord.Text, comb_level.SelectedIndex + 1);
            }
            else
            {
                DialogResult dr = MessageBox.Show("修改当前用户后需要重新登录！是否修改", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    if (MainForm.CurrentInfo.UserAuthority <= comb_level.SelectedIndex + 1 && !userBLL.UserIsExist(txt_userName.Text, selectId))
                    {
                        userBLL.ChangeUser(selectId, txt_userName.Text, txt_passWord.Text, comb_level.SelectedIndex + 1);
                        MessageBox.Show("用户已修改!请重新登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("修改失败，无法修改高于自身权限或用户名已存在", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }

        }
        private void 用户管理_Load(object sender, EventArgs e)
        {
            RefreshData(null, null);
        }
        /// <summary>
        /// 刷新datagridview数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshData(object sender, EventArgs e)
        {
            manageruser.Clear();
            manageruser = userBLL.UserlistLoad();
            manageruser.RemoveAll(s => s.UserAuthority <= MainForm.CurrentInfo.UserAuthority);//删除同级别及以下用户
            if (MainForm.CurrentInfo.UserAuthority != 0)//保留该用户信息           
                manageruser.Add(MainForm.CurrentInfo);
            dgv_Manager.DataSource = manageruser;
            dgv_Manager.Columns[0].HeaderCell.Value = "ID";
            dgv_Manager.Columns[1].HeaderCell.Value = "用户名";
            dgv_Manager.Columns[2].HeaderCell.Value = "密码";
            dgv_Manager.Columns[3].HeaderCell.Value = "权限等级";
           // dgv_Manager.RowHeadersVisible = false;
        }
        /// <summary>
        /// 检查权限，低等级权限无法建立高等级权限账户
        /// </summary>
        /// <param name="authortiy"></param>
        private bool CheckAuthority(int currentAuthortiy, int comb_selected)
        {
            if (currentAuthortiy < comb_selected)
            {
                return true;
            }
            else
            {
                MessageBox.Show("您只能增加低于自身权限等级的用户，修改自身及低于您权限的用户", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btn_switchUser_Click(object sender, EventArgs e)
        {
            // Program.NeedRestart = true;
            //Application.Exit();
            //开启新的实例

            Process.Start(Application.ExecutablePath);

            //关闭当前实例

            Process.GetCurrentProcess().Kill();
        }

    }
}

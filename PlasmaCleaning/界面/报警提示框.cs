using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool;

namespace PlasmaCleaning.界面
{
    public partial class 报警提示框 :Form
    {
        public 报警提示框()
        {
            InitializeComponent();
        }
        string 当前地址 = "";
        string 解决地址1;
        string 解决地址2;
        DialogResult _结果 = DialogResult.No;
        public DialogResult 结果()
        {
            return _结果;
        }
        public void SetLblText(string info, string sln, string 地址, string 地址2 = null, string 地址3 = null)
        {
            txb_alarmInfo.Text = info;
            txb_sln.Text = sln;
            当前地址 = 地址;
            解决地址1 = 地址2;
            解决地址2 = 地址3;
        }
        private void btn_true_Click(object sender, EventArgs e)
        {
            if (解决地址1 == null && 解决地址2 == null)
            {
                PLCCommunicate.Instance.WriteSingleData(当前地址,"false");
               //PLC.WriteData(当前地址, "0");
            }
            else if (解决地址1 != null && 解决地址2 == null)
            {
                PLCCommunicate.Instance.WriteSingleData(解决地址1,"true");
                // PLC.WriteData(解决地址1, "1");
            }


            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            _结果 = DialogResult.Yes;
            PLCCommunicate.Instance.WriteSingleData(解决地址1, "true");
            // PLC.WriteData(解决地址1, "1");
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            _结果 = DialogResult.No;
            PLCCommunicate.Instance.WriteSingleData(解决地址2, "true");
            //  PLC.WriteData(解决地址2, "1");
            this.Close();
        }

        private void 报警提示框_Load(object sender, EventArgs e)
        {
            if (解决地址2 == null)
            {
               btn_true.Text = 解决地址1 == null ? "确定" : "忽略";
                btn_yes.Visible = false;
                btn_no.Visible = false;
                btn_true.Visible = true;
            }
            else
            {

                btn_yes.Visible = true;
                btn_no.Visible = true;
                btn_true.Visible = false;
            }
        }
    }
}

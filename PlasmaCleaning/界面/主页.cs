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

namespace PlasmaCleaning.界面
{
    public partial class 主页 : Form
    {
        public ProductInfoBLL PIB = new ProductInfoBLL();
        public 主页()
        {
            InitializeComponent();
        }
        private List<PlasmaCleaning.自定义.控件.自定义控件> systemParas = new List<自定义.控件.自定义控件>();
        private void t_UpdateState_Tick(object sender, EventArgs e)
        {
            t_UpdateState.Enabled = false;
            systemParas.ForEach((s) => { s.UpdateState(); });
            t_UpdateState.Enabled = true;
        }
        private void 主页_Load(object sender, EventArgs e)
        {
            PlasmaCleaning.自定义.类.PublicFunc.AddList(this, systemParas);
        }
        private void btn_changeUser_Click(object sender, EventArgs e)
        {
            登录窗口 loginForm = new 登录窗口();
            loginForm.sendLogin += PlasmaCleaning.MainForm.mainform.Login;//用委托的方式将登录界面的信息传递到主面去
            loginForm.ShowDialog();
            ProductInfoUpdate();
        }
        private void btn_findProductInfoByIdentifier_Click(object sender, EventArgs e)
        {
            ProductInfoUpdate();
        }
        private void ProductInfoUpdate()
        {
            dgv_scanProductInfo.DataSource = null;
            dgv_scanProductInfo.DataSource = PIB.FindProductInfoByIdentifier(tbox_scanQRCode.Text).ToList();
            dgv_scanProductInfo.Columns[0].HeaderText = "ID";
            dgv_scanProductInfo.Columns[0].Visible = false;
            dgv_scanProductInfo.Columns[1].HeaderText = "编号";
            dgv_scanProductInfo.Columns[2].HeaderText = "生产厂家";
            dgv_scanProductInfo.Columns[3].HeaderText = "车牌号";
            dgv_scanProductInfo.Columns[4].HeaderText = "采样时间";
            dgv_scanProductInfo.Columns[3].Visible = PlasmaCleaning.MainForm.CurrentInfo.UserAuthority < 3 ? true : false;
            dgv_scanProductInfo.Columns[4].Visible = PlasmaCleaning.MainForm.CurrentInfo.UserAuthority < 3 ? true : false;
            dgv_scanProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Tool.PLCCommunicate.Instance.WriteSingleData("V100.2", "true");
            Tool.PLCCommunicate.Instance.WriteString(S7.Net.DataType.DataBlock, 1, 300, "000005");
            Tool.PLCCommunicate.Instance.WriteWString(S7.Net.DataType.DataBlock, 1, 312, "宁夏煤矿2");
            Tool.PLCCommunicate.Instance.WriteWString(S7.Net.DataType.DataBlock, 1, 340, "晋A8RW94");

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Tool.PLCCommunicate.Instance.WriteSingleData("V100.3", "true");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Tool.PLCCommunicate.Instance.WriteSingleData("V100.4", "true");
        }
    }
}

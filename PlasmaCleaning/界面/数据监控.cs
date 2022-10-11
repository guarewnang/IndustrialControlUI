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
    public partial class 数据监控 : Form
    {
        public ProductInfoBLL PIB = new ProductInfoBLL();
        public 数据监控()
        {
            InitializeComponent();
            ctr_deleteProductInfo.btn_ALLdel.Click += btn_getAllProductInfo_Click;
        }
        private void btn_getAllProductInfo_Click(object sender, EventArgs e)
        {
            dgv_getAllProductInfo.DataSource = null;
            dgv_getAllProductInfo.DataSource = PIB.GetAllProductInfo().ToList();
            dgv_getAllProductInfo.Columns[0].HeaderText = "ID";
            dgv_getAllProductInfo.Columns[0].Visible = false;
            dgv_getAllProductInfo.Columns[1].HeaderText = "编号";
            dgv_getAllProductInfo.Columns[2].HeaderText = "生产厂家";
            dgv_getAllProductInfo.Columns[3].HeaderText = "车牌号";
            dgv_getAllProductInfo.Columns[4].HeaderText = "采样时间";
            dgv_getAllProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btn_findProductInfoByLPN_Click(object sender, EventArgs e)
        {
            dgv_getAllProductInfo.DataSource = null;
            dgv_getAllProductInfo.DataSource = PIB.FindProductInfoByLPN(tbox_licensePlateNumber.Text).ToList();
            dgv_getAllProductInfo.Columns[0].HeaderText = "ID";
            dgv_getAllProductInfo.Columns[0].Visible = false;
            dgv_getAllProductInfo.Columns[1].HeaderText = "编号";
            dgv_getAllProductInfo.Columns[2].HeaderText = "生产厂家";
            dgv_getAllProductInfo.Columns[3].HeaderText = "车牌号";
            dgv_getAllProductInfo.Columns[4].HeaderText = "采样时间";
            dgv_getAllProductInfo.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}

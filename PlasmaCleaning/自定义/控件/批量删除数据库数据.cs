using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool;
using PlasmaCleaning.BLL;

namespace PlasmaCleaning.自定义.控件
{
    public partial class 批量删除数据库数据 : 自定义控件
    {
        public 批量删除数据库数据()
        {
            InitializeComponent();
        }
        private string Str_tbName;
        private string Str_timeName;
        [Browsable(true)]
        [Category("自定义控件属性")]
        [Description("数据库表名称")]
        public string Str_TbName
        {
            get { return Str_tbName; }
            set { Str_tbName = value; }
        }
        [Category("自定义控件属性")]
        [Description("数据库表时间的名称")]
        public string Str_TimeName
        {
            get { return Str_timeName; }
            set { Str_timeName = value; }
        }
        public enum MYBLL
        {
            AlarmLogBLL,
            UserBLL,
            ProductInfoBLL
        }
        private MYBLL sqlBLL;
        [Category("自定义控件属性")]
        [Description("选择删除库类型")]
        public MYBLL SQLBLL
        {
            get { return sqlBLL; }
            set { sqlBLL = value; }
        }

        private void btn_ALLdel_Click(object sender, EventArgs e)
        {
            int timeValue = Convert.ToInt32(nudown_timeValue.Value);
            string StrTimeUnit = "";

            switch (comb_timeUnit.SelectedIndex)
            {
                case 0:
                    StrTimeUnit = "minute";
                    break;
                case 1:
                    StrTimeUnit = "hour";
                    break;
                case 2:
                    StrTimeUnit = "day";
                    break;
                case 3:
                    StrTimeUnit = "month";
                    break;
            }
            DialogResult dr = MessageBox.Show("点击“是”后将只保留" + timeValue.ToString() + comb_timeUnit.SelectedItem + "以内的所有数据" + "！取消操作请点击“否”", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string StrSQLDel = "DELETE FROM " + Str_tbName + " WHERE DATEDIFF(" + StrTimeUnit + "," + Str_timeName + "," + "GETDATE())>=" + timeValue.ToString();
                switch (SQLBLL)
                {
                    case MYBLL.AlarmLogBLL:
                        AlarmLogBLL ab = new AlarmLogBLL();
                        int result = ab.ExecuteSqlCommand(StrSQLDel);
                        MessageBox.Show("已删除"+result.ToString()+"条记录","注意");
                        break;
                    case MYBLL.UserBLL:
                        break;
                    case MYBLL.ProductInfoBLL:
                        ProductInfoBLL pib = new ProductInfoBLL();
                        int result2 = pib.ExecuteSqlCommand(StrSQLDel);
                        MessageBox.Show("已删除"+result2.ToString()+"条记录");
                        break;
                }
            }
            else
            {
                return;
            }
        }
    }
}

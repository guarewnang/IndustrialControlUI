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

namespace PlasmaCleaning.自定义.控件
{
    public partial class 通用参数设置 :自定义控件
    {
        public 通用参数设置()
        {
            InitializeComponent();
        }
        private string _读取地址;
        private bool _可以下传;
        private bool 刷新状态 = true;
        private bool _有小数点 = true;
        private bool _有负数 = true;
        #region //属性
        [Browsable(true)]
        [Category("控件属性")]
        [Description("读取的PLC地址")]
        public string 读取地址
        {
            get { return _读取地址; }
            set { _读取地址 = value; }
        }
        [Category("控件属性")]
        [Description("是否可以写入PLC")]
        public bool 可以下传
        {
            get { return _可以下传; }
            set { _可以下传 = value; }
        }
        [Category("控件属性")]
        [Description("输入框是否可以编辑")]
        public bool 可以输入
        {
            get { return this.textBox1.Enabled; }
            set { this.textBox1.Enabled = value; }
        }
        [Category("控件属性")]
        [Description("输入值是否含小数")]
        public bool 有小数点
        {
            get { return _有小数点; }
            set { _有小数点 = value; }
        }
        [Category("控件属性")]
        [Description("输入值是否含负数")]
        public bool 有负数
        {
            get { return _有负数; }
            set { _有负数 = value; }
        }
        #endregion

        public override void UpdateState()
        {
            if (刷新状态)
            {
                object value = PLCCommunicate.Instance.ReadSingleData(_读取地址, 有小数点,_有负数);
                    textBox1.Text = value.ToString();                                  
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            刷新状态 = false;
            textBox1.ForeColor = Color.Red;
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && (_有小数点 ? e.KeyChar != 46 : true) && (_有负数 ? e.KeyChar != 45 : true))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46)
            {
                if (textBox1.Text.Length <= 0)
                {
                    e.Handled = true;
                }
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false;
                    bool b2 = false;
                    b1 = float.TryParse(textBox1.Text, out oldf);
                    b2 = float.TryParse(textBox1.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == false)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
            if (_可以下传 & e.KeyChar == '\r')
            {
                try
                {
                    if (_有小数点&&(!textBox1.Text.Contains(".")))
                    {
                        textBox1.Text += ".0";
                    }
                        
                    PLCCommunicate.Instance.WriteSingleData(_读取地址,textBox1.Text);
                    刷新状态 = true;
                }
                catch
                {
                    MessageBox.Show("请规范输入数字");
                    刷新状态 = true;
                }

            }

        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            刷新状态 = true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmaCleaning.自定义.控件
{
    public partial class 自定义控件 : UserControl
    {
        public 自定义控件()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 刷新函数 自定义控件基类的虚函数，所有子类均继承该函数
        /// </summary>
        public virtual void UpdateState()
        { 
        
        }
    }
}

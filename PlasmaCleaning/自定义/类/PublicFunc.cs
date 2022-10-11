using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using PlasmaCleaning.自定义.控件 ;

namespace PlasmaCleaning.自定义.类
{
    internal class PublicFunc
    {
        public string FloatToHexByte(float str)
        {
            string s1 = BitConverter.ToString(BitConverter.GetBytes(str));
            string s1a = s1.Substring(9, 2) + " " + s1.Substring(6, 2);
            return s1a;
        }
        public static void AddList(Control obj, List< 自定义控件> list)
        {
            foreach (Control control in obj.Controls)
            {
                if (control is 自定义控件) list.Add((自定义控件)control);
                AddList(control, list);

            }
        }
        public static void bt_MouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Width = Convert.ToInt32(82 * 1.05);
            bt.Height = Convert.ToInt32(44 * 1.05);
            Font font = new Font(bt.Font.FontFamily, 13);
            bt.Font = font;
        }
        public static void bt_MouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Width = 82;
            bt.Height = 44;
            Font font = new Font(bt.Font.FontFamily, 12);
            bt.Font = font;
        }
        #region 禁止系统休眠
        [DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(uint Flags);
        const uint ES_SYSTEM_REQUIRED = 0x00000001;
        const uint ES_DISPLAY_REQUIRED = 0x00000002;
        const uint ES_CONTINUOUS = 0x80000000;

        public static void SleepControl(bool isSleep)
        {
            if (isSleep)
            {
                //阻止休眠时调用
                SetThreadExecutionState(ES_CONTINUOUS | ES_DISPLAY_REQUIRED | ES_SYSTEM_REQUIRED);
            }
            else
            {
                //恢复休眠时调用
                SetThreadExecutionState(ES_CONTINUOUS);
            }
        }
        #endregion
    }
}

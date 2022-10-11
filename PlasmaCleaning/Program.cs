using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using PlasmaCleaning.界面;
using System.Management;
using System.Configuration;
namespace PlasmaCleaning
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (GetSystemId()!="A7BB2801-54B7-11CB-9FAC-C4EF15870FCC") return;
            bool binIsRuning=false;
            using (System.Threading.Mutex mutex = new System.Threading.Mutex(true, Assembly.GetExecutingAssembly().FullName, out binIsRuning))
            {
                if (!binIsRuning)
                {
                    MessageBox.Show("程序已经在运行", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    登录窗口 loginForm = new 登录窗口();
                    MainForm mf = new MainForm();
                    loginForm.sendLogin += mf.Login;//用委托的方式将登录界面的信息传递到主面去
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(mf);
                    }
                }
            }
        }
        public static string GetSystemId()
        {
            string systemId = null;
            using (ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_ComputerSystemProduct"))
            {
                foreach (var item in mos.Get())
                {
                    systemId = item["UUID"].ToString();
                }
            }
            return systemId;
        }
    }
}

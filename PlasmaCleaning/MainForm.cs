using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlasmaCleaning.界面;
using System.Runtime.InteropServices;
using PlasmaCleaning.Model;
using PlasmaCleaning.BLL;
using System.Threading;
using Tool;
using S7.Net;
namespace PlasmaCleaning
{
    public partial class MainForm : Form
    {
        #region 界面初始化
        public static MainForm mainform = null;
        public 主页 homepageInterface = new 主页();
        public 自动操作 automaticOperationInterface = new 自动操作();
        public 手动操作 manualOperationInterface = new 手动操作();
        public 配方管理 recipeManagementInterface = new 配方管理();
        public 数据监控 dataMonitoringInterface = new 数据监控();
        public 系统设置 systemSettingInterface = new 系统设置();
        public 用户管理 userManagementInterface = new 用户管理();
        public 报警列表 alarmListInterface = new 报警列表();
        public 通讯设置 communicationSettingInterface = new 通讯设置();
        public 关于 aboutInterface = new 关于();
        public static 消息提示框 messagePrompt = new 消息提示框();

        private List<Form> pal_FormList = new List<Form>();
        private List<Button> metrobtn = new List<Button>();//按钮组
        public static ModelUser CurrentInfo = new ModelUser();
        public List<Myalarm> alarmlist = new List<Myalarm>();
        public ProductInfoBLL PIB = new ProductInfoBLL();
        System.Threading.Timer scanQRTimer;
        public string[] removeBtn = new string[]
        { 
            "btn_automaticOperationInterface",
            "btn_manualOperationInterface",
            "btn_recipeManagementInterface",
            "btn_systemSettingInterface",
            "btn_communicationSettingInterface",
            "btn_aboutInterface"
        };
        #endregion
        /// <summary>
        /// 主窗体构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//MSN.ssk";
            mainform = this;
            metrobtn.AddRange(from a in this.pal_interfaceBtn.Controls.OfType<Button>() select a);//把界面按钮添加到按钮组中
            metrobtn.ForEach((mb) => { mb.Click += new EventHandler(ShowBar); });//给按钮组中的每个按钮添加显示条事件
            #region 移除不用画面，重置按钮位置
            foreach (string str in removeBtn)
            {
                this.pal_interfaceBtn.Controls.RemoveByKey(str);
            }
            btn_dataMonitoringInterface.Location = new Point(btn_dataMonitoringInterface.Location.X, btn_dataMonitoringInterface.Location.Y - 120);
            btn_userManagementInterface.Location = new Point(btn_userManagementInterface.Location.X, btn_userManagementInterface.Location.Y - 160);
            btn_alarmListInterface.Location = new Point(btn_alarmListInterface.Location.X, btn_alarmListInterface.Location.Y - 160);
            #endregion
        }
        /// <summary>
        /// 登录窗体传递过来的登录信息
        /// </summary>
        /// <param name="user"></param>
        public void Login(ModelUser user)
        {
            CurrentInfo = user;
            tssl_currentUserName.Text = CurrentInfo.UserName;
            tssl_currentUserLevel.Text = Enum.GetName(typeof(AuthorityLevel), CurrentInfo.UserAuthority);
            switch (CurrentInfo.UserAuthority)
            {
                case 0:
                    tssl_currentUserLevel.ForeColor = Color.Purple;
                    tssl_currentUserName.ForeColor = Color.Purple;
                    break;
                case 1:
                    tssl_currentUserLevel.ForeColor = Color.Yellow;
                    tssl_currentUserName.ForeColor = Color.Yellow;
                    break;
                case 2:
                    tssl_currentUserLevel.ForeColor = Color.Blue;
                    tssl_currentUserName.ForeColor = Color.Blue;
                    break;
                case 3:
                    tssl_currentUserLevel.ForeColor = Color.Green;
                    tssl_currentUserName.ForeColor = Color.Green;
                    break;
            }

        }
        //<summary>
        //打开窗体
        //</summary>
        //<param name="frm"></param>
        private void OpenForm(Form frm)
        {
            frm.TopLevel = false;
            frm.TopMost = false;
            if (this.pal_form.Controls.Count > 0) this.pal_form.Controls.Clear();
            this.pal_form.Controls.Add(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = this.pal_form;
            frm.Show();
        }
        /// <summary>
        /// 设置绿色图标，跟随按钮点击来显示当前窗体位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowBar(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.pal_picBar.Location = new Point(btn.Location.X - 10, btn.Location.Y);
        }
        #region 打开界面
        /// <summary>
        /// 打开主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageInterface_Click(object sender, EventArgs e)
        {
            OpenForm(homepageInterface);
            if(!homepageInterface.t_UpdateState.Enabled)
            homepageInterface.t_UpdateState.Start();

        }
        /// <summary>
        /// 打开自动页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_automaticOperationInterface_Click(object sender, EventArgs e)
        {
            OpenForm(automaticOperationInterface);
        }
        /// <summary>
        /// 打开手动页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_manualOperationInterface_Click(object sender, EventArgs e)
        {
            OpenForm(manualOperationInterface);
        }
        /// <summary>
        /// 打开数据监控页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_dataMonitoringInterface_Click(object sender, EventArgs e)
        {
            OpenForm(dataMonitoringInterface);
        }
        /// <summary>
        /// 打开系统设置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_systemSettingInterface_Click(object sender, EventArgs e)
        {
            OpenForm(systemSettingInterface);
        }
        /// <summary>
        /// 打开用户管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_userManagementInterface_Click(object sender, EventArgs e)
        {
            OpenForm(userManagementInterface);
        }
        /// <summary>
        /// 打开通讯设置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_communicationSettingInterface_Click(object sender, EventArgs e)
        {
            OpenForm(communicationSettingInterface);
        }
        /// <summary>
        /// 打开关于页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_aboutInterface_Click(object sender, EventArgs e)
        {
            OpenForm(aboutInterface);
        }
        /// <summary>
        /// 打开配方管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_recipeManagementInterface_Click(object sender, EventArgs e)
        {
            OpenForm(recipeManagementInterface);
        }
        private void btn_alarmListInterface_Click(object sender, EventArgs e)
        {
            OpenForm(alarmListInterface);
        }
        #endregion
        /// <summary>
        /// 主窗体预加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            PlasmaCleaning.自定义.类.PublicFunc.SleepControl(true);//禁止休眠
            #region 刷新时钟
            System.Threading.Timer backstageTimer = new System.Threading.Timer((object o) =>
            {
                if (lb_nowTime.InvokeRequired) this.Invoke(new Action(() => { lb_nowTime.Text = DateTime.Now.ToString("yyyy年MM月dd日  HH:mm:ss"); }));
            }, null, Timeout.Infinite, 1000);
            backstageTimer.Change(0, 1000);
            #endregion
           
            if (!PLCCommunicate.Instance.ConnectToPLC())
            {
                messagePrompt.Message("PLC连接失败，软件将自动退出");
                messagePrompt.ShowDialog();
                mainform.Close();
            }
            #region 后台获取场外扫码信号
            scanQRTimer = new System.Threading.Timer((object o) =>
            {
                scanQRTimer.Change(-1,5000);
                bool BL = (bool)PLCCommunicate.Instance.ReadSingleData("V10.0", false, false);
                if (BL)
                {
                    DateTime dt1 = DateTime.Now;
                    string str1 = PLCCommunicate.Instance.ReadString(DataType.DataBlock, 1, 300, 10);
                    string str2 = PLCCommunicate.Instance.ReadWString(DataType.DataBlock, 1, 312, 28);
                    string str3 = PLCCommunicate.Instance.ReadWString(DataType.DataBlock, 1, 340, 40);
                    DateTime dt = DateTime.Now;
                    PIB.AddProductInfo(str1, str2, str3, dt);
                    PLCCommunicate.Instance.WriteSingleData("V10.0", "false");
                    DateTime dt2 = DateTime.Now;
                    TimeSpan ts = dt2 - dt1;
                    Console.WriteLine(ts.TotalMilliseconds.ToString());
                }
                scanQRTimer.Change(0,5000);
            }, null, Timeout.Infinite, 1000);
            scanQRTimer.Change(0, 1000);
            #endregion
             OpenForm(homepageInterface);
             homepageInterface.t_UpdateState.Start();
            AddAlarmsToList();
            this.t_update.Start();
        }
        /// <summary>
        /// 主窗体预关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.t_update.Stop();
            System.Environment.Exit(0);
        }
        private void AddAlarmsToList()
        {
            alarmlist.Add(new Myalarm("警报：报警1werqwerqwerqwerqwerq", "", "V100.2"));
            alarmlist.Add(new Myalarm("警报：报警2qerqwerqwerqwerqwerqwe", "", "V100.3"));
            alarmlist.Add(new Myalarm("警报：报警3qerqwerwqerqwerqwerqwerqwer", "", "V100.4"));
            alarmlist.Add(new Myalarm("警报：报警4cghdfhfdghfdghfdghfdghfdghfdghdfghdfghdfghdfgh", "", "V100.5"));
        }
        /// <summary>
        /// 主窗体扫描时钟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_update_Tick(object sender, EventArgs e)
        {
            t_update.Enabled = false;
            #region 报警
            bool alarmFlag = false;
            alarmlist.ForEach((m) =>
            {
                if (m.GetAlarmState())
                {
                    alarmFlag = true;
                    this.tssl_alarmLed.Visible = true;
                    this.tssl_alarm.Text = m.AlarmName;
                    if (m.log == false)
                    {
                        alarmListInterface.alb.AddAlarmLog(m.AlarmName, DateTime.Now, CurrentInfo.UserName);
                        m.log = true;
                        alarmListInterface.FistUpdateState();
                        messagePrompt.Message("注意！\n有新触发的报警！");
                        messagePrompt.Show();
                    }
                }
            });
            if (!alarmFlag)
            {
                this.tssl_alarmLed.Visible = false;
                this.tssl_alarm.Text = string.Empty;
            }
            #endregion
            btn_dataMonitoringInterface.Enabled = CurrentInfo.UserAuthority < 3 ? true : false;
            t_update.Enabled = true;
        }
        private void tssl_alarm_Click(object sender, EventArgs e)
        {
            alarmListInterface.FistUpdateState();
            if (alarmListInterface.lv_listAlarm.Items.Count > 1)
            {
                OpenForm(alarmListInterface);
            }
            else
            {
                报警提示框 alarmReminder = new 报警提示框();
                MainForm.mainform.alarmlist.ForEach((al) =>
                {
                    if (al.AlarmName.Equals(tssl_alarm.Text))
                    {
                        if (al.ResetAddress == null && al.ResetAddress2 == null)
                            alarmReminder.SetLblText(al.AlarmName, al.Solution, al.PlcAddress);
                        else if (al.ResetAddress != null && al.ResetAddress2 == null)
                            alarmReminder.SetLblText(al.AlarmName, al.Solution, al.PlcAddress, al.ResetAddress);
                        else
                            alarmReminder.SetLblText(al.AlarmName, al.Solution, al.PlcAddress, al.ResetAddress, al.ResetAddress2);
                        alarmReminder.ShowDialog();
                        alarmReminder.Dispose();
                        if (!al.GetAlarmState())
                        {
                            al.log = false;
                        }
                    }
                });

            }
        }


    }
}

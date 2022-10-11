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
using Tool;

namespace PlasmaCleaning.界面
{
    public partial class 报警列表 : Form
    {
        public AlarmLogBLL alb = new AlarmLogBLL();
        public 报警列表()
        {
            InitializeComponent();
            ctr_deleteAlarmLogs.btn_ALLdel.Click += Btn_ALLdel_Click;
        }

        private void Btn_ALLdel_Click(object sender, EventArgs e)
        {
            openAlarmRecord();
        }

        /// <summary>
        /// 第一次刷新界面状态
        /// </summary>
        public void FistUpdateState()
        {
            Updatelv_AlarmList();
            openAlarmRecord();
        }
        /// <summary>
        /// 刷新报警列表
        /// </summary>
        public void Updatelv_AlarmList()
        {
            lv_listAlarm.Items.Clear();
           MainForm.mainform.alarmlist.ForEach((al)=> { if (al.GetAlarmState()) MainForm.mainform.alarmListInterface.lv_listAlarm.Items.Add(al.AlarmName); });
        }
        /// <summary>
        /// 清除报警列表中所有报警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_clearAllAlarm_Click(object sender, EventArgs e)
        {
            MainForm.mainform.alarmlist.ForEach((al) => {
                if (al.GetAlarmState())
                {
                    PLCCommunicate.Instance.WriteSingleData(al.PlcAddress,"false");
                    //PLC地址写0
                    if (!al.GetAlarmState())
                    {
                        al.log = false;
                    }
                    al.log = false;
                }
                });
            Updatelv_AlarmList();
        }
        /// <summary>
        /// 点击报警列表中的项目奖
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_listAlarm_Click(object sender, EventArgs e)
        {
            if (lv_listAlarm.SelectedItems.Count > 0)
            {
                报警提示框 alarmReminder = new 报警提示框();
                MainForm.mainform.alarmlist.ForEach((al) => {
                    if (al.AlarmName.Equals(lv_listAlarm.SelectedItem.ToString()))
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
                Updatelv_AlarmList();
            }
        }
        public void openAlarmRecord()
        {
            dgv_AlarmLog.DataSource = null;
            dgv_AlarmLog.DataSource = alb.GetAllAlarmLog().ToList();
            dgv_AlarmLog.Columns[0].HeaderText = "ID";
            dgv_AlarmLog.Columns[0].Visible = false;
            dgv_AlarmLog.Columns[1].HeaderText = "报警时间";
            dgv_AlarmLog.Columns[2].HeaderText = "报警内容";
            dgv_AlarmLog.Columns[3].HeaderText = "用户";
            dgv_AlarmLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void 报警列表_Load(object sender, EventArgs e)
        {
            openAlarmRecord();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaCleaning.Model;

namespace PlasmaCleaning.DAL
{
    public class AlarmLogDAL
    {
        public AlarmLogEntity AE = new AlarmLogEntity();
        public AlarmLogDAL()
        {
            AE.Database.CreateIfNotExists();
        }
        /// <summary>
        /// 获取所有报警日志
        /// </summary>
        /// <returns></returns>
        public List<ModelAlarmLog> GetAllAlarmLog()
        {
            List<ModelAlarmLog> alarmLogList = AE.AlarmLogs.ToList();
            alarmLogList.OrderByDescending(s => s.AlarmLogTime);
            return alarmLogList;
        }
        /// <summary>
        /// 新增报警日志
        /// </summary>
        /// <param name="alarmlogname">报警名称</param>
        /// <param name="alarmlogtime">报警时间</param>
        /// <param name="username">用户</param>
        public void AddAlarmLog(string alarmlogname, DateTime alarmlogtime, string username)
        {
            ModelAlarmLog al = new ModelAlarmLog() { AlarmLogName = alarmlogname, AlarmLogTime = alarmlogtime, UserName = username };
            AE.AlarmLogs.Add(al);
            AE.SaveChanges();
        }
        /// <summary>
        /// 执行sql语句，返回发生变化的行数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int ExecuteSqlCommand(string str)
        {
            int result = AE.Database.ExecuteSqlCommand(str);
            return result;
        }
    }
}

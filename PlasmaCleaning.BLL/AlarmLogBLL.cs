using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaCleaning.DAL;
using PlasmaCleaning.Model;

namespace PlasmaCleaning.BLL
{
    public class AlarmLogBLL
    {
        public AlarmLogDAL AD = new AlarmLogDAL();
        /// <summary>
        /// 获取所有报警日志
        /// </summary>
        /// <returns></returns>
        public List<ModelAlarmLog> GetAllAlarmLog()
        {
            return AD.GetAllAlarmLog();
        }
        /// <summary>
        /// 新增报警日志
        /// </summary>
        /// <param name="alarmlogname"></param>
        /// <param name="alarmlogtime"></param>
        /// <param name="username"></param>
        public void AddAlarmLog(string alarmlogname, DateTime alarmlogtime, string username)
        {
            AD.AddAlarmLog(alarmlogname, alarmlogtime, username);
        }
        /// <summary>
        /// 执行sql语句，返回变化行数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int ExecuteSqlCommand(string str)
        {
            int result = AD.ExecuteSqlCommand(str);
            return result;
        }
    }
}

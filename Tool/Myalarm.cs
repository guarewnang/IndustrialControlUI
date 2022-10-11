using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
  public  class Myalarm
    {
        public string AlarmName { get; set; }
        public string Solution { get; set; }
        public string PlcAddress { get; set; }
        public string ResetAddress { get; set; }
        public string ResetAddress2 { get; set; }
        /// <summary>
        /// 是否记录日志
        /// </summary>
        public bool log { get; set; }
        public Myalarm(string AlarmName, string Solution, string PlcAddress)
        {
            this.AlarmName = AlarmName;
            this.Solution = Solution;
            this.PlcAddress = PlcAddress;
        }
        public Myalarm(string AlarmName, string Solution, string PlcAddress, string ResetAddress1)
        {
            this.AlarmName = AlarmName;
            this.Solution = Solution;
            this.PlcAddress = PlcAddress;
            this.ResetAddress = ResetAddress1;

        }
        public Myalarm(string AlarmName, string Solution, string PlcAddress, string ResetAddress1, string ResetAddress2)
        {
            this.AlarmName = AlarmName;
            this.Solution = Solution;
            this.PlcAddress = PlcAddress;
            this.ResetAddress = ResetAddress1;
            this.ResetAddress2= ResetAddress2;
        }
        public bool GetAlarmState()
        {
            bool isFlag =(bool) PLCCommunicate.Instance.ReadSingleData(PlcAddress,false,false);
            // bool isFlag = PLC.ReadData(_plcAddress).Equals("1");
            return isFlag;
        }
    }
}

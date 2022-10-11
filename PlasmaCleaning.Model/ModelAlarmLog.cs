using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlasmaCleaning.Model
{
    public class ModelAlarmLog
    {
        [Key]
        public int AlarmLogId { get; set; }
        public DateTime AlarmLogTime { get; set; }
        public string AlarmLogName { get; set; }
        public string UserName { get; set; }

    }
}

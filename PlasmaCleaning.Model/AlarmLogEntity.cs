using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlasmaCleaning.Model
{
   public class AlarmLogEntity:DbContext
    {
       public AlarmLogEntity():base("name=AlarmLog")
       { }
       public DbSet<ModelAlarmLog> AlarmLogs { get; set; }
    }
}

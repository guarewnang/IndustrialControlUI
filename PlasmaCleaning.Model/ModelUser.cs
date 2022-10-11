using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PlasmaCleaning.Model
{
    public class ModelUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserAuthority { get; set; }
    }
    public enum AuthorityLevel:int
    {
        GOD=0,
        工程师=1,
        管理员=2,
        操作员=3
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlasmaCleaning.Model
{
   public class UserEntity:DbContext
    {
       public UserEntity()
           : base("name=User")
       { }
       public DbSet<ModelUser> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlasmaCleaning.Model
{
    public class ProductInfoEntity : DbContext
    {
        public ProductInfoEntity() : base("name=ProductInfo")
        { }
        public DbSet<ModelProductInfo> ProductInfos { get; set; }
    }
}

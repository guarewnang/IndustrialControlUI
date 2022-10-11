using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlasmaCleaning.Model
{
    public class ModelProductInfo
    {
        [Key]
        public int ProductInfoId { get; set; }
        public string ProductInfoIdentifier { get; set; }
        public string ProductInfoFactory { get; set; }
        public string ProductInfoLicensePlateNumber { get; set; }
        public DateTime ProductInfoSamplingTime { get; set; }

    }
}

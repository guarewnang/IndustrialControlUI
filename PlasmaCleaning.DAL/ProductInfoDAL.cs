using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaCleaning.Model;

namespace PlasmaCleaning.DAL
{
    public class ProductInfoDAL
    {
        ProductInfoEntity PIE = new ProductInfoEntity();
        public ProductInfoDAL()
        {
            PIE.Database.CreateIfNotExists();
        }
        /// <summary>
        /// 获取所有产品信息
        /// </summary>
        /// <returns></returns>
        public List<ModelProductInfo> GetAllProductInfo()
        {
            List<ModelProductInfo> productInfos = PIE.ProductInfos.ToList();
            productInfos.OrderByDescending(s => s.ProductInfoSamplingTime);
            return productInfos;
        }
        /// <summary>
        /// 添加产品信息
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="factory"></param>
        /// <param name="licenseplatenumber"></param>
        /// <param name="samplingtime"></param>
        public void AddProductInfo(string identifier, string factory, string licenseplatenumber, DateTime samplingtime)
        {
            ModelProductInfo mpi = new ModelProductInfo()
            {
                ProductInfoIdentifier = identifier,
                ProductInfoFactory = factory,
                ProductInfoLicensePlateNumber = licenseplatenumber,
                ProductInfoSamplingTime = samplingtime
            };
            PIE.ProductInfos.Add(mpi);
            PIE.SaveChanges();
        }
        /// <summary>
        /// 根据编号查找产品
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public List<ModelProductInfo> FindProductInfoByIdentifier( string identifier)
        {
            List<ModelProductInfo> mpi = new List<ModelProductInfo>();
            var m = from n in PIE.ProductInfos.ToList() where n.ProductInfoIdentifier == identifier select n;
            m.ToList().ForEach(s => mpi.Add(s));
            return mpi;
        }
        /// <summary>
        /// 根据车牌号查找所有信息
        /// </summary>
        /// <param name="licenseplatenumber"></param>
        /// <returns></returns>
        public List<ModelProductInfo> FindProductInfoByLPN(string licenseplatenumber)
        {
            List<ModelProductInfo> mpi = new List<ModelProductInfo>();
            var m = from n in PIE.ProductInfos.ToList() where n.ProductInfoLicensePlateNumber == licenseplatenumber select n;
            m.ToList().ForEach(s => mpi.Add(s));
            return mpi;
        }
        /// <summary>
        /// EF框架下执行ADO
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int ExecuteSqlCommand(string str)
        {
            int result = PIE.Database.ExecuteSqlCommand(str);
            return result;
        }
    }
}

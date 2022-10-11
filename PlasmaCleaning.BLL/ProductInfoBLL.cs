using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaCleaning.DAL;
using PlasmaCleaning.Model;

namespace PlasmaCleaning.BLL
{
    public class ProductInfoBLL
    {
        ProductInfoDAL PID = new ProductInfoDAL();
        /// <summary>
        /// 获取所有产品信息
        /// </summary>
        /// <returns></returns>
        public List<ModelProductInfo> GetAllProductInfo()
        {
            return PID.GetAllProductInfo();
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
            PID.AddProductInfo(identifier, factory, licenseplatenumber, samplingtime);
        }
        /// <summary>
        /// 根据编号查找产品
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public List<ModelProductInfo> FindProductInfoByIdentifier(string identifier)
        {
            return PID.FindProductInfoByIdentifier(identifier);
        }
        /// <summary>
        /// 根据车牌号查找产品信息
        /// </summary>
        /// <param name="licenseplatenumber"></param>
        /// <returns></returns>
        public List<ModelProductInfo> FindProductInfoByLPN(string licenseplatenumber)
        {
            return PID.FindProductInfoByLPN(licenseplatenumber);
        }
        /// <summary>
        /// EF框架下执行ADO
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int ExecuteSqlCommand(string str)
        {
            return PID.ExecuteSqlCommand(str);
        }
    }
}

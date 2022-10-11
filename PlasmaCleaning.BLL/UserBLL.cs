using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PlasmaCleaning.DAL;
using PlasmaCleaning.Model;


namespace PlasmaCleaning.BLL
{
   public class UserBLL
    {
       UserDAL ud = new UserDAL();
       /// <summary>
       /// 业务逻辑层_登录账户，检查账户是否正确
       /// </summary>
       /// <param name="name"></param>
       /// <param name="password"></param>
       /// <returns></returns>
       public ModelUser UserLogIn(string name, string password)
       {
           return ud.UserLogIn(name,password);
       }
       /// <summary>
       /// 业务逻辑层，获取所有用户
       /// </summary>
       /// <returns></returns>
       public List<ModelUser> UserlistLoad()
       {
           return ud.UserlistLoad();
       }
       /// <summary>
       /// 添加用户
       /// </summary>
       /// <param name="name"></param>
       /// <param name="password"></param>
       /// <param name="authority"></param>
       public void AddUser(string name, string password, int authority)
       {
           ud.AddUser(name, password, authority);
       }
       /// <summary>
       /// 删除用户
       /// </summary>
       /// <param name="id"></param>
       public void DeleteUser(int id)
       {
           ud.DeleteUser(id);
       }
       /// <summary>
       /// 修改用户
       /// </summary>
       /// <param name="id"></param>
       /// <param name="name"></param>
       /// <param name="password"></param>
       /// <param name="authority"></param>
       public void ChangeUser(int id, string name, string password, int authority)
       {
           ud.ChangeUser(id,name,password,authority);
       }
       /// <summary>
       /// 检查重名，ID不同，名字相同
       /// </summary>
       /// <param name="name"></param>
       /// <param name="id"></param>
       /// <returns></returns>
       public bool UserIsExist(string name,int id)
       {
           return ud.UserIsExist(name,id);
       }
    }
}

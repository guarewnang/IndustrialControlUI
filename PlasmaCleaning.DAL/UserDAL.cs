using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlasmaCleaning.Model;

namespace PlasmaCleaning.DAL
{
    public class UserDAL
    {
        public UserDAL()
        {
            UE.Database.CreateIfNotExists();
        }
        public UserEntity UE = new UserEntity();
        /// <summary>
        /// 登录SQL检查账号密码
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ModelUser UserLogIn(string name, string password)
        {
            ModelUser u = UE.Users.FirstOrDefault(s => s.UserName == name && s.UserPassword == password);
            if (u != null)
                return u;
            else
                return null;
        }
        /// <summary>
        /// 获取所有用户的用户
        /// </summary>
        /// <returns></returns>
        public List<ModelUser> UserlistLoad()
        {
            List<ModelUser> listuser = UE.Users.ToList();
            listuser.OrderByDescending(s => s.UserAuthority);
            return listuser;
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="authority"></param>
        public void AddUser(string name, string password, int authority)
        {
            ModelUser u0 = UE.Users.FirstOrDefault(s => s.UserName == name);//检查是否有重名
            if (u0!=null)
            {
                System.Windows.Forms.MessageBox.Show("该用户名已存在");
            }
            else
            {
                ModelUser u = new ModelUser() { UserName = name, UserPassword = password, UserAuthority = authority };
                UE.Users.Add(u);
                UE.SaveChanges();
            }
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUser(int id)
        {
            ModelUser u = UE.Users.FirstOrDefault(s => s.UserId == id);
            UE.Users.Remove(u);
            UE.SaveChanges();
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
            ModelUser u = UE.Users.FirstOrDefault(s => s.UserId == id);
            u.UserName = name;
            u.UserPassword = password;
            u.UserAuthority = authority;
            UE.Entry(u).State = System.Data.Entity.EntityState.Modified;
            UE.SaveChanges();
        }
        /// <summary>
        /// 检查重名，名字相同，id不同，则判定重名，名字相同，id也相同，那就是自身
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UserIsExist(string name,int id)
        {
            ModelUser u0 = UE.Users.FirstOrDefault(s => s.UserName == name&&s.UserId!=id);
            if (u0 != null)
            {
                System.Windows.Forms.MessageBox.Show("该用户名已存在");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

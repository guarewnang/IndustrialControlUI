using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Data;

namespace Tool
{
    public class SQL
    {
        private static  SqlConnection sqlCon = null;
        /// <summary>
        ///  SQL静态构造函数，系统自动调用监测数据库文件是否存在
        /// </summary>
        static SQL()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;//获取启动程序exe文件的位置
            string pathStr = Path.GetDirectoryName(path);//获取启动文件exe所在的文件夹
            SqlConnection sqlcon = new SqlConnection("server=.;database=master;Integrated Security=Ture");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from sysdatabase where name='PlasmaCleaning'", sqlcon);
            if (cmd.ExecuteScalar() != null)//返回数据库命令的第一行第一列不为空
            {
                sqlcon.Close();
            }
            else
            {
                string sqlpath = pathStr + @"\PlasmaCleaning.mdf";//数据库文件路径
                string sqllogpath = pathStr + @"\PlasmaCleaning.ldf";//数据库日志文件路径
                if (File.Exists(sqlpath) && File.Exists(sqllogpath))//如果数据库相关文件存在
                {
                    SqlCommand cmd1 = new SqlCommand("exec sp_attach_db @dbname=PlasmaCleaning,@filename1='" + sqlpath + "'，@filename2='" + sqllogpath + "'", sqlcon);
                    cmd1.ExecuteNonQuery();//如果数据库存在就附加数据库文件
                }
                else
                {
                    //新建数据库文件
                    #region 如果数据库文件不存在，则新建数据库文件
                    CreateDatabase("PlasmaCleaningDB",pathStr,sqlcon);//创建数据库文件
                    #region 创建表1
                    //SqlCommand cmd2 = new SqlCommand();
                    //cmd.ExecuteNonQuery();
                    #endregion

                    #endregion
                }
            }
        }
        /// <summary>
        /// 创建数据库文件
        /// </summary>
        /// <param name="dataname">数据库文件名称</param>
        /// <param name="path">数据库路径</param>
        /// <param name="sqlcon">数据库链接</param>
        private static void CreateDatabase(string dataname, string path, SqlConnection sqlcon)
        {
            SqlCommand cmd = new SqlCommand("create database"+dataname+"on primary(name="+dataname+",filename="+
            ","+path+"\\"+dataname+".mdf"+"',size=10MB,filegrowth=1MB)",sqlcon);
        }
        /// <summary>
        /// 打开数据库链接，如果数据库装调试关闭则打开
        /// </summary>
        private static void OpenCon()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);          
            if (sqlCon.State == ConnectionState.Closed)sqlCon.Open();          
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public static void closeCon()
        {
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();           
        }
        /// <summary>
        /// :执行数据库操作方法1，无返回值
        /// </summary>
        /// <param name="sql">数据库指令</param>
        public static void ExecuteSQL(string sql)
        {
            OpenCon();
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            cmd.ExecuteNonQuery();
            closeCon();
        }
        /// <summary>
        /// 执行数据库操作方法2,带参数组，无返回值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlpaprs"></param>
        public static void EeecuteSQL(string sql, SqlParameter[] sqlpaprs)
        {
            OpenCon();
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            cmd.Parameters.AddRange(sqlpaprs);
            cmd.ExecuteNonQuery();
            closeCon();
        }
        /// <summary>
        /// 读取数据库表的所有内容
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetSQLData(string sql)
        {
            OpenCon();
            SqlCommand cmd = new SqlCommand(sql,sqlCon);
            SqlDataReader sd = cmd.ExecuteReader();
            return sd;
        }
        public static DataSet GetSqlDataSet(string sql)
        {
            OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlCon);
            DataSet ds = new DataSet();
            //da.FillSchema(ds, SchemaType.Mapped);
            da.Fill(ds);
            return ds;
        }
        public static void DeleteSqlDataSet(string sql)
        {
            OpenCon();
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.ExecuteNonQuery();
        }
    }
}

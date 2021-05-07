using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MySchool
{
    public static class DBHelper
    {
        private const string constr = "Data Source=LAPTOP-1K4V0UDU;Initial Catalog=MySchool;Persist Security Info=True;User ID=sa;Password=cssl#123";

        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="ex"></param>
        private static void ShowError(Exception ex)
        {
            MessageBox.Show("程序发生异常,错误信息为"+ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 查询第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
        /// <summary>
        /// 查询一行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            
            return null;
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool ExecuteNonQuery(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                return cmd.ExecuteNonQuery()>0;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        /// <summary>
        /// 查询一张表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                DataTable table = new DataTable();
                
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            
            return null;
        }

    }
}

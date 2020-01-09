using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace librarySystem
{
    class MysqlUtil
    {
        public static string connStr = ";database=librarySystem";

        //数据库连接接口
        public static MySqlConnection createConn()
        {
            return new MySqlConnection(connStr);
        }

        /**
         * 数据库增删改接口
         * 返回影响行数，发生异常返回-1
         */
        public static int operation(MySqlConnection conn, string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Connection.Open();
            int num = 0;
            try
            {
                num = cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                Console.WriteLine(e);
                num =  -1;
            }
            finally
            {
                conn.Close();
            }
            return num;
        }
        /**
         * 重载方法
         */
        public static int operation(string sql)
        {
            MySqlConnection conn = createConn();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Connection.Open();
            int num = 0;
            try
            {
                num = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                num = -1;
            }
            finally
            {
                conn.Close();
            }
            return num;
        }
        /**
         * 数据库查询接口
         * 返回SqlDataReader对象,失败返回null
         */
        public static MySqlDataReader search(MySqlConnection conn, string sql)
        {
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //conn.Close();
                return cmd.ExecuteReader();
            }catch(Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
                return null;
            }
        }
        /**
         * 重载方法
         */
        public static MySqlDataReader search(string sql)
        {
            MySqlConnection conn = createConn();
            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
                return null;
            }
        }
        /**
         * 测试函数
         */
        public static void test()
        {
            MySqlConnection conn = MysqlUtil.createConn();
            Console.WriteLine("连接成功");
        }
    }
}

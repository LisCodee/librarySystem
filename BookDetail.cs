using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace librarySystem
{
    public partial class BookDetail : Form
    {
        public BookDetail()
        {
            InitializeComponent();
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            FillList();
        }
        private void FillList()
        {
            gridBook.ColumnCount = 6;
            gridBook.Columns[0].Name = "id";
            gridBook.Columns[1].Name = "借书人";
            gridBook.Columns[2].Name = "书名";
            gridBook.Columns[3].Name = "借书日期";
            gridBook.Columns[4].Name = "应还日期";
            gridBook.Columns[5].Name = "还书日期";
            gridBook.ReadOnly = true;
            //不允许添加行
            gridBook.AllowUserToAddRows = false;
            //背景为白色
            gridBook.BackgroundColor = Color.White;
            //只允许选中单行
            gridBook.MultiSelect = false;
            //整行选中
            gridBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MySqlConnection conn = MysqlUtil.createConn();
            try
            {
                //加载图书数据
                string sqlcmd = "select * from user_book";
                Console.WriteLine(sqlcmd);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, conn);
                DataSet dataset = new DataSet("User_Book");
                //使用SqlDataAdapter对象adapter将查新结果填充到DataSet对象ds中
                adapter.Fill(dataset);
                conn.Close();
                Console.WriteLine(dataset.Tables[0].Rows.Count);
                // 填充表格
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    string id = row["id"].ToString();
                    string bookId = row["book_id"].ToString();
                    string sqlcmd2 = "select title from book where id=" + bookId;
                    string sqlname = "select name from user where id=" + row["user_id"].ToString();
                    string book_name = "";
                    string user_name = "";
                    MySqlDataReader dr = MysqlUtil.search(sqlcmd2);
                    Console.WriteLine(row["book_id"].ToString());
                    if (!dr.Read())
                    {
                        MessageBox.Show("未知错误", "error", MessageBoxButtons.OK);
                        this.Close();
                        return;
                    }
                    else
                    {
                        book_name = dr[0].ToString();
                        Console.WriteLine(book_name);
                    }
                    MySqlDataReader namereader = MysqlUtil.search(sqlname);
                    if (!namereader.Read())
                    {
                        MessageBox.Show("未知错误", "error", MessageBoxButtons.OK);
                        this.Close();
                        return;
                    }
                    else
                    {
                        user_name = namereader[0].ToString();
                    }
                    string[] item = { id,user_name, book_name, row["borrow_time"].ToString(), row["revert_time"].ToString(), row["give_time"].ToString() };
                    gridBook.Rows.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误", "Tip", MessageBoxButtons.OK);
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

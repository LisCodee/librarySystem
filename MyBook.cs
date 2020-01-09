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
    public partial class MyBook : Form
    {
        private string user_id;
        public MyBook(string id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void MyBook_Load(object sender, EventArgs e)
        {
            Console.WriteLine(user_id);
            FillList();
        }
        private void Reload()
        {
            gridBook.Rows.Clear();
            FillList();
        }
        /**
         * 填充数据
         */
        private void FillList()
        {
            gridBook.ColumnCount = 5;
            gridBook.Columns[1].Name = "书名";
            gridBook.Columns[2].Name = "借书日期";
            gridBook.Columns[3].Name = "应还日期";
            gridBook.Columns[4].Name = "还书日期";
            gridBook.Columns[0].Name = "id";
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
                string sqlcmd = "select * from user_book where user_id=" + user_id;
                Console.WriteLine(sqlcmd);
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, conn);
                DataSet dataset = new DataSet("User_Book");
                //使用SqlDataAdapter对象adapter将查新结果填充到DataSet对象ds中
                adapter.Fill(dataset);
                conn.Close();
                Console.WriteLine(dataset.Tables[0].Rows.Count);
                // 填充表格
                foreach(DataRow row in dataset.Tables[0].Rows)
                {
                    string id = row["id"].ToString();
                    string bookId = row["book_id"].ToString();
                    string sqlcmd2 = "select title from book where id=" + bookId;
                    string book_name = "";
                    MySqlDataReader dr = MysqlUtil.search(sqlcmd2);
                    Console.WriteLine(row["book_id"].ToString());
                    if(!dr.Read())
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
                    string[] item = {id, book_name, row["borrow_time"].ToString(), row["revert_time"].ToString(), row["give_time"].ToString()};
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
        /**
         * 还书
         */
        private void btnGiveBack_Click(object sender, EventArgs e)
        {
            string book_id = "";
            string id = "";
            try
            {
                id = gridBook.SelectedRows[0].Cells[0].Value.ToString();
                string give_time = gridBook.SelectedRows[0].Cells[4].Value.ToString();
                Console.WriteLine(give_time);
                if (give_time.Length != 0)
                {
                    DialogResult box = MessageBox.Show("本书已还，不可重复还~", "Tip", MessageBoxButtons.OK);
                    return;
                }
                //book_id = gridBook.SelectedRows[0].Cells[1].Value.ToString();
            }catch(Exception ex)
            {
                DialogResult box = MessageBox.Show("没有选中任何书籍！", "Tip", MessageBoxButtons.OK);
                return;
            }
            DialogResult dr = MessageBox.Show("确定要归还<<" + gridBook.SelectedRows[0].Cells[1].Value.ToString() + ">>这本书？", "Tip", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string updateUserCmd = "update user set num=num+1 where id=" + user_id;
                string searchBook = "select book_id from user_book where id=" + id;
                MySqlDataReader reader = MysqlUtil.search(searchBook);
                if (reader.Read())
                {
                    book_id = reader[0].ToString();
                }
                else
                {
                   DialogResult d = MessageBox.Show("发生未知错误", "Tip", MessageBoxButtons.OK);
                    return;
                }
                string updateBookCmd = "update book set ramined=ramined+1 where id=" + book_id;
                string updateUserBookCmd = "update user_book set give_time = '{0}' where id=" + id;
                DateTime give_time = DateTime.Now;
                updateUserBookCmd = string.Format(updateUserBookCmd, give_time);
                Console.WriteLine(updateBookCmd);
                Console.WriteLine(updateUserCmd);
                Console.WriteLine(updateUserBookCmd);
                //修改数据库
                if (MysqlUtil.operation(updateUserCmd) != -1 && MysqlUtil.operation(updateBookCmd) != -1 && MysqlUtil.operation(updateUserBookCmd) != -1)
                {
                    MessageBox.Show("还书成功", "Tip", MessageBoxButtons.OK);
                    this.Reload();
                }
            }
            
        }
    }
}

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
    public partial class IndexForm : Form
    {
        //用户账号
        private string id;
        private LoginForm superForm;
        private int identity;   //权限控制，0管理员，1学生
        public IndexForm(string id, string name, LoginForm superForm, int identity)
        {
            InitializeComponent();
            this.id = id;
            this.identity = identity;
            this.superForm = superForm;
            labWelcome.Text = labWelcome.Text + name + "!";
           /* Console.WriteLine(name);
            Console.WriteLine(id);*/
        }

        private void 图书搜索BToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Reload()
        {
            FillList();
        }
        /**
         * 页面加载时的方法
         */
        private void IndexForm_Load(object sender, EventArgs e)
        {
            FillList();
            //如果不是管理员，禁用其他按钮
            if(identity == 1)
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnChange.Enabled = false;
                MenuRecord.Enabled = false;
            }
        }
        private void FillList()
        {
            MySqlConnection conn = MysqlUtil.createConn();
            try
            {
                //加载图书数据
                string sqlcmd = "select * from book";
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, conn);
                DataSet dataset = new DataSet();
                //使用SqlDataAdapter对象adapter将查新结果填充到DataSet对象ds中
                adapter.Fill(dataset);
                //设置DataSource属性
                gridBook.DataSource = dataset.Tables[0];
                //设置表头
                gridBook.Columns[0].HeaderText = "id";
                gridBook.Columns[1].HeaderText = "书名";
                gridBook.Columns[2].HeaderText = "作者";
                gridBook.Columns[3].HeaderText = "出版社";
                gridBook.Columns[4].HeaderText = "馆藏";
                gridBook.Columns[5].HeaderText = "剩余";
                gridBook.Columns[6].HeaderText = "位置";
                gridBook.ReadOnly = true;
                //不允许添加行
                gridBook.AllowUserToAddRows = false;
                //背景为白色
                gridBook.BackgroundColor = Color.White;
                //只允许选中单行
                gridBook.MultiSelect = false;
                //整行选中
                gridBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
         * 根据书名搜索书籍
         */
        private void FillList(string title, string author)
        {
            MySqlConnection conn = MysqlUtil.createConn();
            string sqlcmd = "";
            try
            {
                if (author.Length != 0)
                    sqlcmd = "select * from book where title like '%" + title + "%' and author like '%" + author + "%'";
                else
                    sqlcmd = "select * from book where title like '%" + title + "%'";
                //加载图书数据
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, conn);
                DataSet dataset = new DataSet();
                //使用SqlDataAdapter对象adapter将查新结果填充到DataSet对象ds中
                adapter.Fill(dataset);
                //设置DataSource属性
                gridBook.DataSource = dataset.Tables[0];
                //设置表头
                gridBook.Columns[0].HeaderText = "id";
                gridBook.Columns[1].HeaderText = "书名";
                gridBook.Columns[2].HeaderText = "作者";
                gridBook.Columns[3].HeaderText = "出版社";
                gridBook.Columns[4].HeaderText = "馆藏";
                gridBook.Columns[5].HeaderText = "剩余";
                gridBook.Columns[6].HeaderText = "位置";

                gridBook.ReadOnly = true;
                //不允许添加行
                gridBook.AllowUserToAddRows = false;
                //背景为白色
                gridBook.BackgroundColor = Color.White;
                //只允许选中单行
                gridBook.MultiSelect = false;
                //整行选中
                gridBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
         * 关闭
         */
        private void IndexForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void IndexForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出应用么？", "Tip", MessageBoxButtons.OKCancel);
            //Console.WriteLine(dr);
            if (dr == DialogResult.OK)
            {
                Console.WriteLine(superForm.Text);
                superForm.Close();
            }
            else
                e.Cancel = true;
                Console.WriteLine("取消");
        }

        private void search_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            FillList(title, author);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string id = gridBook.SelectedRows[0].Cells[0].Value.ToString();
            Console.WriteLine(id);
            string title = gridBook.SelectedRows[0].Cells[1].Value.ToString();
            string author = gridBook.SelectedRows[0].Cells[2].Value.ToString();
            string press = gridBook.SelectedRows[0].Cells[3].Value.ToString();
            string num = gridBook.SelectedRows[0].Cells[4].Value.ToString();
            string remained = gridBook.SelectedRows[0].Cells[5].Value.ToString();
            string place = gridBook.SelectedRows[0].Cells[6].Value.ToString();
            UpdateForm frm = new UpdateForm(id, title, author, press, num, remained, place, this);
            frm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定删除此条记录？", "删除", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string id = gridBook.SelectedRows[0].Cells[0].Value.ToString();
                string sqlcmd = "delete from book where id=" + id;
                Console.WriteLine(sqlcmd);
                if(MysqlUtil.operation(sqlcmd) == -1)
                {
                    MessageBox.Show("删除失败，请重试!","error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("删除成功!", "Tip", MessageBoxButtons.OK);
                    this.Reload();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertForm frm = new InsertForm(this);
            frm.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此作品为2017级数媒1班李景新课设作品，请勿用于商业用途。", "About", MessageBoxButtons.OK);
        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前版本已是最新版本", "Update", MessageBoxButtons.OK);
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这么简单了，不用说明了吧", "Help", MessageBoxButtons.OK);
        }

        private void 我的图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyBook frm = new MyBook(id);
            frm.Show();
        }

        private void gridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            string book_id = "";
            string ramined = "";
            int remained = 0;
            try
            {
                 book_id = gridBook.SelectedRows[0].Cells[0].Value.ToString();
                 ramined = gridBook.SelectedRows[0].Cells[5].Value.ToString();
                 remained = int.Parse(ramined);
            }catch(Exception ex)
            {
                DialogResult dr = MessageBox.Show("没有选中任何书籍！", "Tip", MessageBoxButtons.OK);
                return;
            }
            if(remained == 0)
            {
                DialogResult dr = MessageBox.Show("余量不足，暂时无法借阅！", "Tip", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("确定要借阅<<" + gridBook.SelectedRows[0].Cells[1].Value.ToString() + ">>这本书？", "Tip", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    string updateUserCmd = "update user set num=num-1 where id=" + id;
                    string updateBookCmd = "update book set ramined=ramined-1 where id=" + book_id;
                    string insertCmd = "INSERT INTO user_book (user_id, book_id, borrow_time, revert_time) VALUES ('{0}', '{1}', '{2}', '{3}')";
                    DateTime borrow_time = DateTime.Now;
                    DateTime revert_time = borrow_time.AddMonths(1);
                    insertCmd = string.Format(insertCmd, id, book_id, borrow_time, revert_time);
                    //修改数据库
                    if(MysqlUtil.operation(updateUserCmd) != -1 && MysqlUtil.operation(updateBookCmd) != -1 && MysqlUtil.operation(insertCmd) != -1)
                    {
                        MessageBox.Show("借阅成功", "Tip", MessageBoxButtons.OK);
                        this.Reload();
                    }
                }
            }
        }

        private void MenuRecord_Click(object sender, EventArgs e)
        {
            BookDetail frm = new BookDetail();
            frm.Show();
        }
    }
}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*
         * 登录时检测用户合法性
         */
        private void btnLogin(object sender, EventArgs e)
        {
            string id = txtUserId.Text;
            string password = txtPassword.Text;
            int identity = radioAdmin.Checked ? 0 : 1;
            Console.WriteLine(id + " " + password + "" + identity);
            string sqlcmd = "select * from user where id=" + id + " and password=" + password + " and super=" + identity;
            Console.WriteLine(sqlcmd);
            MySqlDataReader dr = MysqlUtil.search(sqlcmd);
            //用户合法时的事件
            if (dr.Read())
            {
                //Console.WriteLine("success");
                //Console.WriteLine(String.Format("{0}{1}", dr[0],dr[1]));
                var frm = new IndexForm(String.Format("{0}", dr[0]), String.Format("{0}", dr[1]), this, identity);
                this.Hide();
                frm.Show();
                /* if(identity == 1)
                 {
                     //将id和姓名传递给下一个窗口
                     var frm = new IndexForm(String.Format("{0}", dr[0]),String.Format("{0}", dr[1]), this);
                     this.Hide();
                     frm.Show();
                 }
                 else
                 {
                     //将id和姓名传递给下一个窗口
                     var frm = new AdminForm(String.Format("{0}", dr[0]), String.Format("{0}", dr[1]), this);
                     this.Hide();
                     frm.Show();
                 }*/
            }

            else
                MessageBox.Show("用户名或密码错误，请重新输入!", "Tip", MessageBoxButtons.OK);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioStu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

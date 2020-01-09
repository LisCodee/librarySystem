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
    public partial class UpdateForm : Form
    {
        private string id;
/*        private string name;
        private string author;
        private string press;
        private string num;
        private string remained;
        private string place;*/
        private IndexForm superForm;
        public UpdateForm(string id,string name, string author, string press, string num, string remained,string place, IndexForm superForm)
        {
            InitializeComponent();
            this.id = id;
            txtName.Text = name;
            txtAuthor.Text = author;
            txtPress.Text = press;
            txtNum.Text = num;
            txtRemained.Text = remained;
            txtPlace.Text = place;
            this.superForm = superForm;

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string sqlcmd = "update book set title='{0}',author='{1}',press='{2}',num='{3}',ramined='{4}',place='{5}' where id='{6}'";
            sqlcmd = string.Format(sqlcmd, txtName.Text.ToString(), txtAuthor.Text.ToString(), txtPress.Text.ToString(), txtNum.Text.ToString(), txtRemained.Text.ToString()
                , txtPlace.Text.ToString(), id);
            Console.WriteLine(sqlcmd);
            if (MysqlUtil.operation(sqlcmd) == -1)
            {
                MessageBox.Show("更新时发生了未知错误，请重试", "error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
                superForm.Reload();
            }

        }
    }
}

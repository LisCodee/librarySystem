using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarySystem
{
    public partial class InsertForm : Form
    {
        private IndexForm superForm;
        public InsertForm(IndexForm superForm)
        {
            InitializeComponent();
            this.superForm = superForm;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string title = txtName.Text.ToString();
            string author = txtAuthor.Text.ToString();
            string press = txtPress.Text.ToString();
            string num = txtNum.Text.ToString();
            string remained = txtRemained.Text.ToString();
            string place = txtPlace.Text.ToString();
            string sqlcmd = "INSERT INTO book (title, author, press, num, ramined, place) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
            sqlcmd = string.Format(sqlcmd, title, author, press, num, remained, place);
            Console.WriteLine(sqlcmd);
            if(MysqlUtil.operation(sqlcmd) == -1)
            {
                MessageBox.Show("插入时发生了未知错误，请重试", "error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("插入成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
                superForm.Reload();
            }
        }
    }
}

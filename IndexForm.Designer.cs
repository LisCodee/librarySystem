namespace librarySystem
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助HELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.labWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridBook = new System.Windows.Forms.DataGridView();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助HELPToolStripMenuItem,
            this.查看SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助HELPToolStripMenuItem
            // 
            this.帮助HELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.检查更新ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HELPToolStripMenuItem.Name = "帮助HELPToolStripMenuItem";
            this.帮助HELPToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HELPToolStripMenuItem.Text = "帮助(H)";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 查看SToolStripMenuItem
            // 
            this.查看SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的图书ToolStripMenuItem,
            this.MenuRecord});
            this.查看SToolStripMenuItem.Name = "查看SToolStripMenuItem";
            this.查看SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.查看SToolStripMenuItem.Text = "查看(S)";
            // 
            // 我的图书ToolStripMenuItem
            // 
            this.我的图书ToolStripMenuItem.Name = "我的图书ToolStripMenuItem";
            this.我的图书ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.我的图书ToolStripMenuItem.Text = "我的图书";
            this.我的图书ToolStripMenuItem.Click += new System.EventHandler(this.我的图书ToolStripMenuItem_Click);
            // 
            // MenuRecord
            // 
            this.MenuRecord.Name = "MenuRecord";
            this.MenuRecord.Size = new System.Drawing.Size(180, 22);
            this.MenuRecord.Text = "所有记录";
            this.MenuRecord.Click += new System.EventHandler(this.MenuRecord_Click);
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.Location = new System.Drawing.Point(1090, 35);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(56, 17);
            this.labWelcome.TabIndex = 1;
            this.labWelcome.Text = "欢迎您，";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "作者";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(67, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(148, 23);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(351, 79);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(148, 23);
            this.txtAuthor.TabIndex = 6;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(563, 79);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 7;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(703, 79);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(843, 79);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(983, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridBook
            // 
            this.gridBook.AllowUserToAddRows = false;
            this.gridBook.AllowUserToDeleteRows = false;
            this.gridBook.AllowUserToOrderColumns = true;
            this.gridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBook.Location = new System.Drawing.Point(12, 138);
            this.gridBook.Name = "gridBook";
            this.gridBook.ReadOnly = true;
            this.gridBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridBook.RowTemplate.Height = 23;
            this.gridBook.Size = new System.Drawing.Size(1178, 456);
            this.gridBook.TabIndex = 2;
            this.gridBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBook_CellContentClick);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(1103, 79);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 11;
            this.btnBorrow.Text = "借阅";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridBook);
            this.Controls.Add(this.labWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "IndexForm";
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndexForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IndexForm_FormClosed);
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助HELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRecord;
        private System.Windows.Forms.Label labWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridBook;
        private System.Windows.Forms.Button btnBorrow;
    }
}
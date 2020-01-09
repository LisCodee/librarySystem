namespace librarySystem
{
    partial class MyBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBook));
            this.gridBook = new System.Windows.Forms.DataGridView();
            this.btnGiveBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBook
            // 
            this.gridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBook.Location = new System.Drawing.Point(29, 66);
            this.gridBook.Name = "gridBook";
            this.gridBook.RowTemplate.Height = 23;
            this.gridBook.Size = new System.Drawing.Size(763, 425);
            this.gridBook.TabIndex = 0;
            // 
            // btnGiveBack
            // 
            this.btnGiveBack.Location = new System.Drawing.Point(642, 24);
            this.btnGiveBack.Name = "btnGiveBack";
            this.btnGiveBack.Size = new System.Drawing.Size(75, 23);
            this.btnGiveBack.TabIndex = 1;
            this.btnGiveBack.Text = "归还";
            this.btnGiveBack.UseVisualStyleBackColor = true;
            this.btnGiveBack.Click += new System.EventHandler(this.btnGiveBack_Click);
            // 
            // MyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 514);
            this.Controls.Add(this.btnGiveBack);
            this.Controls.Add(this.gridBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBook";
            this.Text = "我的图书";
            this.Load += new System.EventHandler(this.MyBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBook;
        private System.Windows.Forms.Button btnGiveBack;
    }
}
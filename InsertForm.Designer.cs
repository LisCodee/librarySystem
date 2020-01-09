namespace librarySystem
{
    partial class InsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.btnChange = new System.Windows.Forms.Button();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.labPlace = new System.Windows.Forms.Label();
            this.txtRemained = new System.Windows.Forms.TextBox();
            this.labRemain = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labNum = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.labPress = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labAuthor = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(145, 373);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 25;
            this.btnChange.Text = "插入";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(145, 318);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(142, 21);
            this.txtPlace.TabIndex = 24;
            // 
            // labPlace
            // 
            this.labPlace.AutoSize = true;
            this.labPlace.Location = new System.Drawing.Point(96, 322);
            this.labPlace.Name = "labPlace";
            this.labPlace.Size = new System.Drawing.Size(29, 12);
            this.labPlace.TabIndex = 23;
            this.labPlace.Text = "位置";
            // 
            // txtRemained
            // 
            this.txtRemained.Location = new System.Drawing.Point(145, 261);
            this.txtRemained.Name = "txtRemained";
            this.txtRemained.Size = new System.Drawing.Size(142, 21);
            this.txtRemained.TabIndex = 22;
            // 
            // labRemain
            // 
            this.labRemain.AutoSize = true;
            this.labRemain.Location = new System.Drawing.Point(96, 265);
            this.labRemain.Name = "labRemain";
            this.labRemain.Size = new System.Drawing.Size(29, 12);
            this.labRemain.TabIndex = 21;
            this.labRemain.Text = "可借";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(145, 204);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(142, 21);
            this.txtNum.TabIndex = 20;
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Location = new System.Drawing.Point(96, 208);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(29, 12);
            this.labNum.TabIndex = 19;
            this.labNum.Text = "馆藏";
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(145, 147);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(142, 21);
            this.txtPress.TabIndex = 18;
            // 
            // labPress
            // 
            this.labPress.AutoSize = true;
            this.labPress.Location = new System.Drawing.Point(96, 151);
            this.labPress.Name = "labPress";
            this.labPress.Size = new System.Drawing.Size(41, 12);
            this.labPress.TabIndex = 17;
            this.labPress.Text = "出版社";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(145, 90);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(142, 21);
            this.txtAuthor.TabIndex = 16;
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(96, 94);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(29, 12);
            this.labAuthor.TabIndex = 15;
            this.labAuthor.Text = "作者";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 14;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(96, 37);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(29, 12);
            this.labName.TabIndex = 13;
            this.labName.Text = "书名";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 429);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.labPlace);
            this.Controls.Add(this.txtRemained);
            this.Controls.Add(this.labRemain);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.labNum);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.labPress);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.labAuthor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertForm";
            this.Text = "新增";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label labPlace;
        private System.Windows.Forms.TextBox txtRemained;
        private System.Windows.Forms.Label labRemain;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.Label labPress;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
    }
}
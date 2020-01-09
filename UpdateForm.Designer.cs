namespace librarySystem
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labAuthor = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labNum = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.labPress = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.labPlace = new System.Windows.Forms.Label();
            this.txtRemained = new System.Windows.Forms.TextBox();
            this.labRemain = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(84, 42);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(29, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "书名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(133, 95);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(142, 21);
            this.txtAuthor.TabIndex = 3;
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(84, 99);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(29, 12);
            this.labAuthor.TabIndex = 2;
            this.labAuthor.Text = "作者";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(133, 209);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(142, 21);
            this.txtNum.TabIndex = 7;
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Location = new System.Drawing.Point(84, 213);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(29, 12);
            this.labNum.TabIndex = 6;
            this.labNum.Text = "馆藏";
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(133, 152);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(142, 21);
            this.txtPress.TabIndex = 5;
            // 
            // labPress
            // 
            this.labPress.AutoSize = true;
            this.labPress.Location = new System.Drawing.Point(84, 156);
            this.labPress.Name = "labPress";
            this.labPress.Size = new System.Drawing.Size(41, 12);
            this.labPress.TabIndex = 4;
            this.labPress.Text = "出版社";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(133, 323);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(142, 21);
            this.txtPlace.TabIndex = 11;
            // 
            // labPlace
            // 
            this.labPlace.AutoSize = true;
            this.labPlace.Location = new System.Drawing.Point(84, 327);
            this.labPlace.Name = "labPlace";
            this.labPlace.Size = new System.Drawing.Size(29, 12);
            this.labPlace.TabIndex = 10;
            this.labPlace.Text = "位置";
            // 
            // txtRemained
            // 
            this.txtRemained.Location = new System.Drawing.Point(133, 266);
            this.txtRemained.Name = "txtRemained";
            this.txtRemained.Size = new System.Drawing.Size(142, 21);
            this.txtRemained.TabIndex = 9;
            // 
            // labRemain
            // 
            this.labRemain.AutoSize = true;
            this.labRemain.Location = new System.Drawing.Point(84, 270);
            this.labRemain.Name = "labRemain";
            this.labRemain.Size = new System.Drawing.Size(29, 12);
            this.labRemain.TabIndex = 8;
            this.labRemain.Text = "可借";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(133, 378);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "更新";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // UpdateForm
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "更新";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.Label labPress;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label labPlace;
        private System.Windows.Forms.TextBox txtRemained;
        private System.Windows.Forms.Label labRemain;
        private System.Windows.Forms.Button btnChange;
    }
}
namespace ArchivePassword
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DropFileBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MD5Box = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindPassword = new System.Windows.Forms.TextBox();
            this.DropFileBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DropFileBox
            // 
            this.DropFileBox.Controls.Add(this.label4);
            this.DropFileBox.Controls.Add(this.label3);
            this.DropFileBox.Controls.Add(this.BrowseBtn);
            this.DropFileBox.Controls.Add(this.FilePathBox);
            this.DropFileBox.Controls.Add(this.StartBtn);
            this.DropFileBox.Controls.Add(this.MD5Box);
            this.DropFileBox.Location = new System.Drawing.Point(12, 12);
            this.DropFileBox.Name = "DropFileBox";
            this.DropFileBox.Size = new System.Drawing.Size(373, 118);
            this.DropFileBox.TabIndex = 0;
            this.DropFileBox.TabStop = false;
            this.DropFileBox.Text = "请将文件拖曳到此处";
            this.DropFileBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "MD5值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "文件路径";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(86, 79);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(90, 31);
            this.BrowseBtn.TabIndex = 1;
            this.BrowseBtn.Text = "查询";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.AllowDrop = true;
            this.FilePathBox.Location = new System.Drawing.Point(64, 20);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(301, 21);
            this.FilePathBox.TabIndex = 0;
            this.FilePathBox.TextChanged += new System.EventHandler(this.FilePathBox_TextChanged);
            this.FilePathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePathBox_DragDrop);
            this.FilePathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilePathBox_DragEnter);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(246, 79);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(90, 32);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "关联";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MD5Box
            // 
            this.MD5Box.Location = new System.Drawing.Point(64, 47);
            this.MD5Box.Name = "MD5Box";
            this.MD5Box.Size = new System.Drawing.Size(301, 21);
            this.MD5Box.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(76, 151);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(301, 21);
            this.PasswordBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "查询结果";
            // 
            // FindPassword
            // 
            this.FindPassword.Location = new System.Drawing.Point(76, 178);
            this.FindPassword.Name = "FindPassword";
            this.FindPassword.Size = new System.Drawing.Size(301, 21);
            this.FindPassword.TabIndex = 6;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 213);
            this.Controls.Add(this.FindPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.DropFileBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "压缩包密码管理器";
            this.DropFileBox.ResumeLayout(false);
            this.DropFileBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DropFileBox;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox MD5Box;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FindPassword;
    }
}


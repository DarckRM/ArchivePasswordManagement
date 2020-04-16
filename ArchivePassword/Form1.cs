using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArchivePassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FilePathBox_TextChanged(object sender, EventArgs e)
        {
            MD5Box.Text = MD5Checker.getMD5ByHashAlgorithm(FilePathBox.Text);
        }
        private void FilePathBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FilePathBox_DragDrop(object sender, DragEventArgs e)
        {
            FilePathBox.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string MD5Code;
            string Password = PasswordBox.Text;
            MD5Code = MD5Box.Text + Password;

            FileStream fs = new FileStream("data.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(MD5Code);
            sw.Close();
            fs.Close();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            string line = "";
            string MetaLine = "";
            string MD5Code = MD5Box.Text;
            bool stat = false;
            StreamReader sw = new StreamReader("data.txt");
            while ((MetaLine = sw.ReadLine()) != null)
            {
                line = MetaLine.Substring(0, 32);
                if (line == MD5Code)
                {
                    MessageBox.Show("密码是" + MetaLine.Remove(0, 32));
                    FindPassword.Text = MetaLine.Remove(0, 32);
                    stat = true;
                    break;
                }
            }
            if(!stat)
            {
                MessageBox.Show("抱歉，并未查找到密码");
            }
            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCleanMemoryTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timeBox.Text = "300";
            paramBox.Text = "-Ew";
            //开始新线程
            var task = new Task(() =>
            {
                while (true)
                {
                    CleanMemory();
                    var time = int.Parse(timeBox.Text);
                    Thread.Sleep(1000 * time);//延时
                }
            }
             );
            task.Start();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            CleanMemory();
        }
        public void CleanMemory()
        {

            string ramMapPath =Environment.CurrentDirectory + @"\RAMMap64.exe";
            var pdfGeneratorProcess = Process.Start(ramMapPath, paramBox.Text);  //直接调用打开文件
            pdfGeneratorProcess.WaitForExit();//等它执行完
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 注意判断关闭事件reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //取消"关闭窗口"事件
                e.Cancel = true; // 取消关闭窗体 

                //使关闭时窗口向右下角缩小的效果
                this.WindowState = FormWindowState.Minimized;
                this.mainNotifyIcon.Visible = true;
                //this.m_cartoonForm.CartoonClose();
                this.Hide();
                return;
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            //双击显示主界面
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Minimized;
                this.mainNotifyIcon.Visible = true;
                this.Hide();
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }
        /// <summary>
        /// 退出窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
    
}

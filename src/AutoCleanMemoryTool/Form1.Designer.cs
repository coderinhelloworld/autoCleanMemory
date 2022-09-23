namespace AutoCleanMemoryTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.paramBox = new System.Windows.Forms.TextBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "定时任务间隔(秒)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "参数";
            // 
            // timeBox
            // 
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox.Location = new System.Drawing.Point(177, 37);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(75, 14);
            this.timeBox.TabIndex = 2;
            // 
            // paramBox
            // 
            this.paramBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paramBox.Location = new System.Drawing.Point(177, 83);
            this.paramBox.Name = "paramBox";
            this.paramBox.Size = new System.Drawing.Size(75, 14);
            this.paramBox.TabIndex = 3;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Location = new System.Drawing.Point(291, 49);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(85, 40);
            this.cleanBtn.TabIndex = 4;
            this.cleanBtn.Text = "清理内存";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "AutoClean\r\nv1.0";
            this.mainNotifyIcon.Visible = true;
            this.mainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "退出";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 149);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.paramBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClean";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox paramBox;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


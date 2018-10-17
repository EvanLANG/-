namespace MySchool
{
    partial class StudentForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tsStudent = new System.Windows.Forms.ToolStrip();
            this.tsbtnModifySelfInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnQuiz = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchMark = new System.Windows.Forms.ToolStripButton();
            this.quit = new System.Windows.Forms.ToolStripButton();
            this.ssStudent = new System.Windows.Forms.StatusStrip();
            this.lblLoginType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStudent.SuspendLayout();
            this.ssStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsStudent
            // 
            this.tsStudent.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnModifySelfInfo,
            this.tsbtnQuiz,
            this.tsbtnSearchMark,
            this.quit});
            this.tsStudent.Location = new System.Drawing.Point(0, 0);
            this.tsStudent.Name = "tsStudent";
            this.tsStudent.Size = new System.Drawing.Size(553, 25);
            this.tsStudent.TabIndex = 1;
            this.tsStudent.Text = "toolStrip1";
            // 
            // tsbtnModifySelfInfo
            // 
            this.tsbtnModifySelfInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModifySelfInfo.Name = "tsbtnModifySelfInfo";
            this.tsbtnModifySelfInfo.Size = new System.Drawing.Size(60, 22);
            this.tsbtnModifySelfInfo.Text = "修改密码";
            this.tsbtnModifySelfInfo.Click += new System.EventHandler(this.tsbtnModifySelfInfo_Click);
            // 
            // tsbtnQuiz
            // 
            this.tsbtnQuiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuiz.Name = "tsbtnQuiz";
            this.tsbtnQuiz.Size = new System.Drawing.Size(60, 22);
            this.tsbtnQuiz.Text = "选择考试";
            this.tsbtnQuiz.Click += new System.EventHandler(this.tsmiQuiz_Click);
            // 
            // tsbtnSearchMark
            // 
            this.tsbtnSearchMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchMark.Name = "tsbtnSearchMark";
            this.tsbtnSearchMark.Size = new System.Drawing.Size(60, 22);
            this.tsbtnSearchMark.Text = "成绩查询";
            this.tsbtnSearchMark.Click += new System.EventHandler(this.tsbtnSearchMark_Click);
            // 
            // quit
            // 
            this.quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(36, 22);
            this.quit.Text = "退出";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // ssStudent
            // 
            this.ssStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoginType});
            this.ssStudent.Location = new System.Drawing.Point(0, 353);
            this.ssStudent.Name = "ssStudent";
            this.ssStudent.Size = new System.Drawing.Size(553, 22);
            this.ssStudent.TabIndex = 3;
            // 
            // lblLoginType
            // 
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(32, 17);
            this.lblLoginType.Text = "学生";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MySchool.Properties.Resources.backgroud4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 375);
            this.Controls.Add(this.ssStudent);
            this.Controls.Add(this.tsStudent);
            this.IsMdiContainer = true;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线考试系统--学生";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.tsStudent.ResumeLayout(false);
            this.tsStudent.PerformLayout();
            this.ssStudent.ResumeLayout(false);
            this.ssStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsStudent;
        private System.Windows.Forms.ToolStripButton tsbtnModifySelfInfo;
        private System.Windows.Forms.ToolStripButton tsbtnQuiz;
        private System.Windows.Forms.ToolStripButton tsbtnSearchMark;
        private System.Windows.Forms.StatusStrip ssStudent;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginType;
        private System.Windows.Forms.ToolStripButton quit;
    }
}


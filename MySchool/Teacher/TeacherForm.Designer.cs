namespace MySchool
{
    partial class TeacherForm
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
            this.tsTeacher = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddTest = new System.Windows.Forms.ToolStripButton();
            this.tsbtnViewTest = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTestDetail = new System.Windows.Forms.ToolStripButton();
            this.quit = new System.Windows.Forms.ToolStripButton();
            this.ssTeacher = new System.Windows.Forms.StatusStrip();
            this.lbWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbtnViewStudent = new System.Windows.Forms.ToolStripButton();
            this.tsTeacher.SuspendLayout();
            this.ssTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTeacher
            // 
            this.tsTeacher.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnViewStudent,
            this.tsbtnAddTest,
            this.tsbtnViewTest,
            this.tsbtnTestDetail,
            this.quit});
            this.tsTeacher.Location = new System.Drawing.Point(0, 0);
            this.tsTeacher.Name = "tsTeacher";
            this.tsTeacher.Size = new System.Drawing.Size(761, 25);
            this.tsTeacher.TabIndex = 2;
            // 
            // tsbtnAddTest
            // 
            this.tsbtnAddTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddTest.Name = "tsbtnAddTest";
            this.tsbtnAddTest.Size = new System.Drawing.Size(60, 22);
            this.tsbtnAddTest.Text = "添加考试";
            this.tsbtnAddTest.Click += new System.EventHandler(this.tsbtnAddTest_Click);
            // 
            // tsbtnViewTest
            // 
            this.tsbtnViewTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnViewTest.Name = "tsbtnViewTest";
            this.tsbtnViewTest.Size = new System.Drawing.Size(60, 22);
            this.tsbtnViewTest.Text = "批改考试";
            this.tsbtnViewTest.Click += new System.EventHandler(this.tsbtnViewTest_Click);
            // 
            // tsbtnTestDetail
            // 
            this.tsbtnTestDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTestDetail.Name = "tsbtnTestDetail";
            this.tsbtnTestDetail.Size = new System.Drawing.Size(60, 22);
            this.tsbtnTestDetail.Text = "考试详情";
            this.tsbtnTestDetail.Click += new System.EventHandler(this.tsbtnTestDetail_Click);
            // 
            // quit
            // 
            this.quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(36, 22);
            this.quit.Text = "退出";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // ssTeacher
            // 
            this.ssTeacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbWelcome});
            this.ssTeacher.Location = new System.Drawing.Point(0, 502);
            this.ssTeacher.Name = "ssTeacher";
            this.ssTeacher.Size = new System.Drawing.Size(761, 22);
            this.ssTeacher.TabIndex = 4;
            // 
            // lbWelcome
            // 
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(32, 17);
            this.lbWelcome.Text = "教师";
            // 
            // tsbtnViewStudent
            // 
            this.tsbtnViewStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnViewStudent.Name = "tsbtnViewStudent";
            this.tsbtnViewStudent.Size = new System.Drawing.Size(60, 22);
            this.tsbtnViewStudent.Text = "学生信息";
            this.tsbtnViewStudent.Click += new System.EventHandler(this.tsbtnViewStudent_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MySchool.Properties.Resources.backgroud3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 524);
            this.Controls.Add(this.ssTeacher);
            this.Controls.Add(this.tsTeacher);
            this.IsMdiContainer = true;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上海电力学院在线考试系统--教师";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.tsTeacher.ResumeLayout(false);
            this.tsTeacher.PerformLayout();
            this.ssTeacher.ResumeLayout(false);
            this.ssTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTeacher;
        private System.Windows.Forms.ToolStripButton tsbtnAddTest;
        private System.Windows.Forms.ToolStripButton tsbtnViewTest;
        private System.Windows.Forms.ToolStripButton tsbtnTestDetail;
        private System.Windows.Forms.StatusStrip ssTeacher;
        private System.Windows.Forms.ToolStripStatusLabel lbWelcome;
        private System.Windows.Forms.ToolStripButton quit;
        private System.Windows.Forms.ToolStripButton tsbtnViewStudent;
    }
}
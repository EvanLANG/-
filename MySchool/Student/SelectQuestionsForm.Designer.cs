namespace MySchool
{
    partial class SelectQuestionsForm
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
            this.lblSubjects = new System.Windows.Forms.Label();
            this.cboSubjects = new System.Windows.Forms.ComboBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.grpDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubjects.Location = new System.Drawing.Point(71, 85);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(35, 14);
            this.lblSubjects.TabIndex = 0;
            this.lblSubjects.Text = "科目";
            // 
            // cboSubjects
            // 
            this.cboSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjects.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSubjects.FormattingEnabled = true;
            this.cboSubjects.Location = new System.Drawing.Point(131, 82);
            this.cboSubjects.Name = "cboSubjects";
            this.cboSubjects.Size = new System.Drawing.Size(315, 22);
            this.cboSubjects.TabIndex = 1;
            this.cboSubjects.SelectedIndexChanged += new System.EventHandler(this.cboSubjects_SelectedIndexChanged);
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBegin.Location = new System.Drawing.Point(334, 258);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "开始答题";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGiveUp.Location = new System.Drawing.Point(416, 258);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(75, 23);
            this.btnGiveUp.TabIndex = 8;
            this.btnGiveUp.Text = "放弃";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(126, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "上海电力学院在线考试系统\r\n";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDescription.Location = new System.Drawing.Point(40, 24);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(303, 92);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "1.题目为单项选择题、填空题和简答题；\r\n2.题量为20题\r\n3.答题时间为20分钟\r\nGood Luck！\r\n\r\n";
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.lblDescription);
            this.grpDescription.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpDescription.Location = new System.Drawing.Point(12, 133);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(479, 119);
            this.grpDescription.TabIndex = 11;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "说明";
            // 
            // SelectQuestionsForm
            // 
            this.AcceptButton = this.btnBegin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 293);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.cboSubjects);
            this.Controls.Add(this.lblSubjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题选择";
            this.Load += new System.EventHandler(this.SelectQuestionsForm_Load);
            this.grpDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.ComboBox cboSubjects;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox grpDescription;
    }
}
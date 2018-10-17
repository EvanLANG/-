namespace MySchool
{
    partial class AddSubjectName
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
            this.btaddsubject = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btaddsubject
            // 
            this.btaddsubject.Location = new System.Drawing.Point(87, 159);
            this.btaddsubject.Name = "btaddsubject";
            this.btaddsubject.Size = new System.Drawing.Size(96, 30);
            this.btaddsubject.TabIndex = 7;
            this.btaddsubject.Text = "添加";
            this.btaddsubject.UseVisualStyleBackColor = false;
            this.btaddsubject.Click += new System.EventHandler(this.btaddsubject_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(288, 159);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 30);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(84, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "科目名称";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtSubjectName.Location = new System.Drawing.Point(177, 60);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(206, 26);
            this.txtSubjectName.TabIndex = 0;
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Font = new System.Drawing.Font("宋体", 12F);
            this.txtSubjectId.Location = new System.Drawing.Point(177, 102);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(206, 26);
            this.txtSubjectId.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "科目代码";
            // 
            // AddSubjectName
            // 
            this.AcceptButton = this.btaddsubject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btaddsubject);
            this.Controls.Add(this.cancel);
            this.Name = "AddSubjectName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加考试";
            this.Load += new System.EventHandler(this.AddSubjectName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btaddsubject;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.Label label1;

    }
}
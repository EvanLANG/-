namespace MySchool
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btexec = new System.Windows.Forms.Button();
            this.lbmsg = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.ssAdmin = new System.Windows.Forms.StatusStrip();
            this.lblLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ssAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtorder
            // 
            this.txtorder.Location = new System.Drawing.Point(22, 61);
            this.txtorder.Multiline = true;
            this.txtorder.Name = "txtorder";
            this.txtorder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtorder.Size = new System.Drawing.Size(496, 85);
            this.txtorder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "命令:";
            // 
            // btexec
            // 
            this.btexec.Location = new System.Drawing.Point(443, 165);
            this.btexec.Name = "btexec";
            this.btexec.Size = new System.Drawing.Size(75, 25);
            this.btexec.TabIndex = 2;
            this.btexec.Text = "执行";
            this.btexec.UseVisualStyleBackColor = true;
            this.btexec.Click += new System.EventHandler(this.btexec_Click);
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Location = new System.Drawing.Point(82, 212);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(35, 12);
            this.lbmsg.TabIndex = 3;
            this.lbmsg.Text = "消息:";
            this.lbmsg.Visible = false;
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(82, 252);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(0, 12);
            this.lbresult.TabIndex = 3;
            this.lbresult.Visible = false;
            // 
            // ssAdmin
            // 
            this.ssAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoginName});
            this.ssAdmin.Location = new System.Drawing.Point(0, 333);
            this.ssAdmin.Name = "ssAdmin";
            this.ssAdmin.Size = new System.Drawing.Size(538, 22);
            this.ssAdmin.TabIndex = 4;
            // 
            // lblLoginName
            // 
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(44, 17);
            this.lblLoginName.Text = "管理员";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 196);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(496, 115);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(443, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AcceptButton = this.btexec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ssAdmin);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.btexec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtorder);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上海电力学院在线考试系统-管理员";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ssAdmin.ResumeLayout(false);
            this.ssAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btexec;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.StatusStrip ssAdmin;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
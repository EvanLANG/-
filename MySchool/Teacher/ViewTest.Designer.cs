namespace MySchool
{
    partial class ViewTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.questionDetail1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.Button();
            this.lbtestflag = new System.Windows.Forms.Label();
            this.lbmaxscore = new System.Windows.Forms.Label();
            this.lbminscore = new System.Windows.Forms.Label();
            this.lbaveragescore = new System.Windows.Forms.Label();
            this.lbnumber = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSubjects = new System.Windows.Forms.ComboBox();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.btnViewTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.questionDetail1);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Controls.Add(this.lbtestflag);
            this.panel1.Controls.Add(this.lbmaxscore);
            this.panel1.Controls.Add(this.lbminscore);
            this.panel1.Controls.Add(this.lbaveragescore);
            this.panel1.Controls.Add(this.lbnumber);
            this.panel1.Controls.Add(this.lbtime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 440);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(613, 210);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(415, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 81);
            this.label5.TabIndex = 14;
            this.label5.Text = "每题10分,总分二十;\r\n阅读完两题后;\r\n录入总分.\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // questionDetail1
            // 
            this.questionDetail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionDetail1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.questionDetail1.Location = new System.Drawing.Point(32, 32);
            this.questionDetail1.Name = "questionDetail1";
            this.questionDetail1.Size = new System.Drawing.Size(300, 152);
            this.questionDetail1.TabIndex = 8;
            this.questionDetail1.Text = "问题";
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.Transparent;
            this.input1.Location = new System.Drawing.Point(370, 158);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(115, 26);
            this.input1.TabIndex = 7;
            this.input1.Text = "录入";
            this.input1.UseVisualStyleBackColor = false;
            this.input1.Click += new System.EventHandler(this.input1_Click);
            // 
            // lbtestflag
            // 
            this.lbtestflag.AutoSize = true;
            this.lbtestflag.Location = new System.Drawing.Point(355, 153);
            this.lbtestflag.Name = "lbtestflag";
            this.lbtestflag.Size = new System.Drawing.Size(0, 12);
            this.lbtestflag.TabIndex = 6;
            // 
            // lbmaxscore
            // 
            this.lbmaxscore.AutoSize = true;
            this.lbmaxscore.Location = new System.Drawing.Point(160, 96);
            this.lbmaxscore.Name = "lbmaxscore";
            this.lbmaxscore.Size = new System.Drawing.Size(0, 12);
            this.lbmaxscore.TabIndex = 6;
            // 
            // lbminscore
            // 
            this.lbminscore.AutoSize = true;
            this.lbminscore.Location = new System.Drawing.Point(143, 153);
            this.lbminscore.Name = "lbminscore";
            this.lbminscore.Size = new System.Drawing.Size(0, 12);
            this.lbminscore.TabIndex = 6;
            // 
            // lbaveragescore
            // 
            this.lbaveragescore.AutoSize = true;
            this.lbaveragescore.Location = new System.Drawing.Point(338, 96);
            this.lbaveragescore.Name = "lbaveragescore";
            this.lbaveragescore.Size = new System.Drawing.Size(0, 12);
            this.lbaveragescore.TabIndex = 6;
            // 
            // lbnumber
            // 
            this.lbnumber.AutoSize = true;
            this.lbnumber.Location = new System.Drawing.Point(355, 40);
            this.lbnumber.Name = "lbnumber";
            this.lbnumber.Size = new System.Drawing.Size(0, 12);
            this.lbnumber.TabIndex = 6;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.BackColor = System.Drawing.Color.White;
            this.lbtime.Location = new System.Drawing.Point(143, 40);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(0, 12);
            this.lbtime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // cboSubjects
            // 
            this.cboSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjects.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSubjects.FormattingEnabled = true;
            this.cboSubjects.Location = new System.Drawing.Point(111, 29);
            this.cboSubjects.Name = "cboSubjects";
            this.cboSubjects.Size = new System.Drawing.Size(315, 22);
            this.cboSubjects.TabIndex = 5;
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubjects.Location = new System.Drawing.Point(59, 32);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(40, 16);
            this.lblSubjects.TabIndex = 4;
            this.lblSubjects.Text = "科目";
            // 
            // btnViewTest
            // 
            this.btnViewTest.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTest.Location = new System.Drawing.Point(571, 27);
            this.btnViewTest.Name = "btnViewTest";
            this.btnViewTest.Size = new System.Drawing.Size(105, 26);
            this.btnViewTest.TabIndex = 6;
            this.btnViewTest.Text = "查看";
            this.btnViewTest.UseVisualStyleBackColor = false;
            this.btnViewTest.Click += new System.EventHandler(this.btnViewTest_Click);
            // 
            // ViewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 524);
            this.Controls.Add(this.btnViewTest);
            this.Controls.Add(this.cboSubjects);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ViewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批阅";
            this.Load += new System.EventHandler(this.ViewTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSubjects;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewTest;
        private System.Windows.Forms.Label lbtestflag;
        private System.Windows.Forms.Label lbmaxscore;
        private System.Windows.Forms.Label lbminscore;
        private System.Windows.Forms.Label lbaveragescore;
        private System.Windows.Forms.Label lbnumber;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label questionDetail1;
        private System.Windows.Forms.Button input1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
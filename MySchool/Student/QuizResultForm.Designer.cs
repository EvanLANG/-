namespace MySchool
{
    partial class QuizResultForm
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
        /// 设计器支持所需的方法 - 不要QuizHelper
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResultForm));
            this.lblStudentScore = new System.Windows.Forms.Label();
            this.lblStudentScoreStrip = new System.Windows.Forms.Label();
            this.lblFullMark = new System.Windows.Forms.Label();
            this.lblFullMarkStrip = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentScore
            // 
            this.lblStudentScore.AutoSize = true;
            this.lblStudentScore.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentScore.Location = new System.Drawing.Point(30, 192);
            this.lblStudentScore.Name = "lblStudentScore";
            this.lblStudentScore.Size = new System.Drawing.Size(77, 14);
            this.lblStudentScore.TabIndex = 0;
            this.lblStudentScore.Text = "你的得分：";
            // 
            // lblStudentScoreStrip
            // 
            this.lblStudentScoreStrip.BackColor = System.Drawing.Color.Red;
            this.lblStudentScoreStrip.Location = new System.Drawing.Point(102, 187);
            this.lblStudentScoreStrip.Name = "lblStudentScoreStrip";
            this.lblStudentScoreStrip.Size = new System.Drawing.Size(100, 23);
            this.lblStudentScoreStrip.TabIndex = 1;
            // 
            // lblFullMark
            // 
            this.lblFullMark.AutoSize = true;
            this.lblFullMark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFullMark.Location = new System.Drawing.Point(16, 230);
            this.lblFullMark.Name = "lblFullMark";
            this.lblFullMark.Size = new System.Drawing.Size(91, 14);
            this.lblFullMark.TabIndex = 2;
            this.lblFullMark.Text = "客观题满分：";
            // 
            // lblFullMarkStrip
            // 
            this.lblFullMarkStrip.BackColor = System.Drawing.Color.Green;
            this.lblFullMarkStrip.Location = new System.Drawing.Point(102, 225);
            this.lblFullMarkStrip.Name = "lblFullMarkStrip";
            this.lblFullMarkStrip.Size = new System.Drawing.Size(300, 23);
            this.lblFullMarkStrip.TabIndex = 3;
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl100.Location = new System.Drawing.Point(418, 230);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(35, 14);
            this.lbl100.TabIndex = 4;
            this.lbl100.Text = "80分";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMark.Location = new System.Drawing.Point(418, 195);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(0, 14);
            this.lblMark.TabIndex = 5;
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(61, 12);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(128, 128);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFace.TabIndex = 6;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // lblComment
            // 
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComment.Location = new System.Drawing.Point(238, 59);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(256, 81);
            this.lblComment.TabIndex = 7;
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(445, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "face1.png");
            this.ilFaces.Images.SetKeyName(1, "face2.png");
            this.ilFaces.Images.SetKeyName(2, "face3.png");
            this.ilFaces.Images.SetKeyName(3, "face4.png");
            // 
            // QuizResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 331);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lblFullMarkStrip);
            this.Controls.Add(this.lblFullMark);
            this.Controls.Add(this.lblStudentScoreStrip);
            this.Controls.Add(this.lblStudentScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "答题结果";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizResultForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentScore;
        private System.Windows.Forms.Label lblStudentScoreStrip;
        private System.Windows.Forms.Label lblFullMark;
        private System.Windows.Forms.Label lblFullMarkStrip;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList ilFaces;
    }
}
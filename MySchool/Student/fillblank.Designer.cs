namespace MySchool
{
    partial class fillblank
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestionDetails = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerCard = new System.Windows.Forms.Button();
            this.rdoOptionF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tmrCostTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(448, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(107, 21);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblQuestionDetails
            // 
            this.lblQuestionDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionDetails.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestionDetails.Location = new System.Drawing.Point(12, 92);
            this.lblQuestionDetails.Name = "lblQuestionDetails";
            this.lblQuestionDetails.Size = new System.Drawing.Size(543, 114);
            this.lblQuestionDetails.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 14);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "问题15:";
            // 
            // btnAnswerCard
            // 
            this.btnAnswerCard.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAnswerCard.Location = new System.Drawing.Point(337, 16);
            this.btnAnswerCard.Name = "btnAnswerCard";
            this.btnAnswerCard.Size = new System.Drawing.Size(103, 23);
            this.btnAnswerCard.TabIndex = 3;
            this.btnAnswerCard.Text = "答题卡";
            this.btnAnswerCard.UseVisualStyleBackColor = true;
            this.btnAnswerCard.Click += new System.EventHandler(this.btnAnswerCard_Click);
            // 
            // rdoOptionF
            // 
            this.rdoOptionF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdoOptionF.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOptionF.Location = new System.Drawing.Point(107, 253);
            this.rdoOptionF.Multiline = true;
            this.rdoOptionF.Name = "rdoOptionF";
            this.rdoOptionF.Size = new System.Drawing.Size(164, 25);
            this.rdoOptionF.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "答案：";
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnNext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(337, 281);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(218, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tmrCostTime
            // 
            this.tmrCostTime.Interval = 1000;
            this.tmrCostTime.Tick += new System.EventHandler(this.tmrCostTime_Tick);
            // 
            // fillblank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 331);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoOptionF);
            this.Controls.Add(this.btnAnswerCard);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionDetails);
            this.Controls.Add(this.lblTimer);
            this.Name = "fillblank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "填空题";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fillblank_FormClosing);
            this.Load += new System.EventHandler(this.fillblank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestionDetails;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerCard;
        private System.Windows.Forms.TextBox rdoOptionF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer tmrCostTime;
    }
}
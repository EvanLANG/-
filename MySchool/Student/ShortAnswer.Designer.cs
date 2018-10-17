namespace MySchool
{
    partial class ShortAnswer
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
            this.btnAnswerCard = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rdoOptionS = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionDetails = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrCostTime = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnswerCard
            // 
            this.btnAnswerCard.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAnswerCard.Location = new System.Drawing.Point(348, 27);
            this.btnAnswerCard.Name = "btnAnswerCard";
            this.btnAnswerCard.Size = new System.Drawing.Size(103, 23);
            this.btnAnswerCard.TabIndex = 0;
            this.btnAnswerCard.Text = "答题卡";
            this.btnAnswerCard.UseVisualStyleBackColor = true;
            this.btnAnswerCard.Click += new System.EventHandler(this.btnAnswerCard_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(348, 296);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(216, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rdoOptionS
            // 
            this.rdoOptionS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdoOptionS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOptionS.Location = new System.Drawing.Point(21, 213);
            this.rdoOptionS.Multiline = true;
            this.rdoOptionS.Name = "rdoOptionS";
            this.rdoOptionS.Size = new System.Drawing.Size(543, 77);
            this.rdoOptionS.TabIndex = 2;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestion.Location = new System.Drawing.Point(18, 31);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 14);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "问题19:";
            // 
            // lblQuestionDetails
            // 
            this.lblQuestionDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestionDetails.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestionDetails.Location = new System.Drawing.Point(21, 72);
            this.lblQuestionDetails.Name = "lblQuestionDetails";
            this.lblQuestionDetails.Size = new System.Drawing.Size(543, 114);
            this.lblQuestionDetails.TabIndex = 4;
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(457, 27);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(107, 21);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "答案：";
            // 
            // tmrCostTime
            // 
            this.tmrCostTime.Interval = 1000;
            this.tmrCostTime.Tick += new System.EventHandler(this.tmrCostTime_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "提示：解答不得超过100字。";
            // 
            // ShortAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestionDetails);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rdoOptionS);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAnswerCard);
            this.Name = "ShortAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简答题";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShortAnswer_FormClosing);
            this.Load += new System.EventHandler(this.ShortAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswerCard;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox rdoOptionS;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionDetails;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCostTime;
        private System.Windows.Forms.Label label2;
    }
}
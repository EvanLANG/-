using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    public partial class AnswerCardForm : Form
    {
        public AnswerCardForm()
        {
            InitializeComponent();
        }

        // 计时器的 Tick 事件 
        private void tmrCostTime_Tick(object sender, EventArgs e)
        {
            int minute;   // 当前的分钟
            int second;   // 秒

            // 如果还剩有答题时间，就显示剩余的时间
            if (QuizHelper.remainSeconds > 0)
            {
                minute = QuizHelper.remainSeconds / 60;
                second = QuizHelper.remainSeconds % 60;
                lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);  // 补充知识点
                QuizHelper.remainSeconds--;
            }
            // 否则，停止计时，提示交卷
            else 
            {
                tmrCostTime.Stop();
                MessageBox.Show("时间到了，该交卷了！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuizResultForm quizResultForm = new QuizResultForm();
                quizResultForm.Show();
                this.Close();
            }
        }

        // 窗体加载时，显示答案
        private void AnswerCardForm_Load(object sender, EventArgs e)
        {
            tmrCostTime.Start();  // 启动计时器
           /* int index = 0;
            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    index = Convert.ToInt32(item.Tag);
                    if (index != -1)
                    {
                        item.Text = QuizHelper.studentAnswers[index];
                    }
                }
            }*/

            
            
        }

        // 交卷
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 创建答题结果窗体并显示，关闭当前窗体
            QuizResultForm quizResultForm = new QuizResultForm();
            quizResultForm.MdiParent = this.MdiParent;
            quizResultForm.Show();
            this.Close();
        }        

        // 转到相应的题目
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            int questionIndex = Convert.ToInt32(((Button)sender).Tag);
            if (questionIndex < 15)
            {
                AnswerQuestionForm answerQuestionForm = new AnswerQuestionForm();
                answerQuestionForm.questionIndex = questionIndex;
                answerQuestionForm.MdiParent = this.MdiParent;
                answerQuestionForm.Show();
            }
            else if (14 < questionIndex && questionIndex < 19)
            {
                fillblank fillblank = new fillblank();
                fillblank.questionIndex21 = questionIndex;
                fillblank.MdiParent = this.MdiParent;
                fillblank.Show();
            }
            else
            {
                ShortAnswer shortanswer = new ShortAnswer();
                shortanswer.questionIndex31 = questionIndex;
                shortanswer.MdiParent =this.MdiParent ;
                shortanswer.Show();
 
            }
            this.Close();

        }        
    }
}
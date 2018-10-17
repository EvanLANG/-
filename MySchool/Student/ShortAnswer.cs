using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class ShortAnswer : Form
    {
        public int questionIndex3 = 0;
        public int questionIndex31 = 19;
        public ShortAnswer()
        {
            InitializeComponent();
        }

        private void btnAnswerCard_Click(object sender, EventArgs e)
        {
            OpenAnswerCard();
        }
        private void OpenAnswerCard()
        {
            AnswerCardForm answerCardForm = new AnswerCardForm();
            answerCardForm.MdiParent = this.MdiParent;
            answerCardForm.Show();
            QuizHelper.showquittips = false;
            this.Close();
        }

        private void ShortAnswer_Load(object sender, EventArgs e)
        {
            QuizHelper.showquittips = true;//设置显示关闭提醒
            tmrCostTime.Start();   // 启动计时器

            GetQuestionDetails();  // 显示题目信息
            //CheckOption();   　　　// 如果题目已经答过，让相应的选项选中 
            CheckBtnNext();  　    // 确定是否到了最后一题
        }
        public void GetQuestionDetails()
        {
            lblQuestion.Text = string.Format("问题{0}：", questionIndex31++);

            string strsql = "select Question from ShortAnswer where QuestionId=" + QuizHelper.selectedQuestionIds3[questionIndex3];
            
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr = null;
            try
            {
                DBHelper.connection.Open();
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    lblQuestionDetails.Text = dr["Question"].ToString();

                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("题目加载失败！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {

                DBHelper.connection.Close();

            }
        }
            private void CheckBtnNext()
        {
            // 如果达到20题，就显示答题结束
            if (questionIndex3 >= QuizHelper.selectedQuestionIds3.Length - 1)
            {

                btnNext.Text = "答题结束";
                /*ShortAnswer shortanswer = new ShortAnswer();
                shortanswer.Show();*/
            }
        }

            private void tmrCostTime_Tick(object sender, EventArgs e)
            {
                int minute;   // 当前的分钟
                int second;   // 秒

                // 如果还有剩余时间，就显示剩余的分钟和秒数
                if (QuizHelper.remainSeconds > 0)
                {
                    QuizHelper.remainSeconds--;
                    minute = QuizHelper.remainSeconds / 60;
                    second = QuizHelper.remainSeconds % 60;
                    lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);
                }
                // 否则，就提示交卷
                else
                {
                    tmrCostTime.Stop();
                    MessageBox.Show("时间到了，该交卷了！", "在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QuizResultForm quizResultForm = new QuizResultForm();
                    //quizResultForm.MdiParent = this.MdiParent;
                    quizResultForm.Show();
                    this.Close();
                }
            }

            private void ShortAnswer_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (QuizHelper.showquittips)
                {
                    if (DialogResult.OK == MessageBox.Show("你确定要退出考试吗？", "上海电力学院在线考试系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        QuizHelper.subjectId = 0;
                    }
                    else
                        e.Cancel = true;

                }
            }

            private void btnNext_Click(object sender, EventArgs e)
            {
                QuizHelper.studentAnswers3[questionIndex3] = rdoOptionS.Text;
                rdoOptionS.Text="";

                if (questionIndex3 < QuizHelper.selectedQuestionIds3.Length - 1)
                {
                    questionIndex3++;

                    GetQuestionDetails();  // 显示试题信息
                     
                    CheckBtnNext(); 　     // 确定是否到了最后一题
                }
                else  // 否则，打开答题卡窗体
                {
                    AnswerCardForm AnswerCardForm = new AnswerCardForm();
                    AnswerCardForm.Show();

                    this.Hide();
                }
            }
        
    }
}

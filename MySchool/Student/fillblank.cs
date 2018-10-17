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
    public partial class fillblank : Form
    {
        public int questionIndex2 =0;
        public int questionIndex21 = 15;
        public fillblank()
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

        private void fillblank_Load(object sender, EventArgs e)
        {
            QuizHelper.showquittips = true;//设置显示关闭提醒
            tmrCostTime.Start();   // 启动计时器

            GetQuestionDetails();  // 显示题目信息
            //CheckOption();   　　　// 如果题目已经答过，让相应的选项选中 
            CheckBtnNext();  　    // 确定是否到了最后一题
        }
        public void GetQuestionDetails()
        {
            lblQuestion.Text = string.Format("问题{0}：", questionIndex21++);
            
            string strsql = "select Question from fillblank where QuestionId=" + QuizHelper.selectedQuestionIds2[questionIndex2];
           // questionIndex2 = questionIndex2 + 1;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers2[questionIndex2] = rdoOptionF.Text;
            rdoOptionF.Text="";
            if (questionIndex2 < QuizHelper.selectedQuestionIds2.Length - 1)
            {
                questionIndex2++;

                GetQuestionDetails();  // 显示试题信息
                    
                CheckBtnNext(); 　     // 确定是否到了最后一题
            }
            else  // 否则，打开答题卡窗体
            {
                ShortAnswer shortanswer = new ShortAnswer();
                shortanswer.Show();
                this.Hide();
            }
        }
        private void CheckBtnNext()
        {
            // 如果达到18题，就显示简答题开始
            if (questionIndex2 >= QuizHelper.selectedQuestionIds2.Length - 1)
            {

                btnNext.Text = "填空题结束,简答题题开始";
                /*ShortAnswer shortanswer = new ShortAnswer();
                shortanswer.Show();*/
            }
        }
        private void CheckOption()
        {
              //if(rdoOptionF.Text == QuizHelper.studentAnswers2[questionIndex2] )

          
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

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
        private void fillblank_FormClosing(object sender, FormClosingEventArgs e)
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
        }
    }

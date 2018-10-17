using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    /// <summary>
    /// 试题选择窗体
    /// </summary>
    public partial class SelectQuestionsForm : Form
    {
        public SelectQuestionsForm()
        {
            InitializeComponent();
        }

        // 窗体加载时，将科目从数据库中读取出来显示在组合框中
        private void SelectQuestionsForm_Load(object sender, EventArgs e)
        {
            string strsql = "select * from Subject";
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr  =null;
            try
            {
                DBHelper.connection.Open();
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
                cboSubjects.Items.Clear();
                while (dr.Read())
                {
                    Subject subject = new Subject();
                    subject.SubjectId = (int)dr[1];
                    subject.SubjectName = dr[2].ToString();
                    cboSubjects.Items.Add(subject);
                }
            }
            catch
            {
                MessageBox.Show("加载课程科目信息失败!", "上海电力学院线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                DBHelper.connection.Close();
               
            }
        }

        // 放弃答题，退出应用程序
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要放弃此次答题测试吗？", "上海电力学院线考试系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuizHelper.subjectId = 0;
                this.Close();
            }
        }

        // 单击“开始答题”按钮
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (cboSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("请选择科目！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSubjects.Focus(); 
            }
            else if(!iscantest())
            {
                MessageBox.Show("该科目已经考试过，请重新选择科目！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuizHelper.subjectId = 0;
                cboSubjects.Focus();  
            }

            else
            {
                int subjectId = QuizHelper.subjectId;

                // 该科目问题总数
                int allQuestionCount = GetQuestionCount(subjectId);
                int allQuestionCount2 = GetQuestionCount2(subjectId);
                int allQuestionCount3 = GetQuestionCount3(subjectId);

                // 指定所有问题数组的长度                
                QuizHelper.allQuestionIds = new int[allQuestionCount];
                QuizHelper.allQuestionIds2 = new int[allQuestionCount2];
                QuizHelper.allQuestionIds3 = new int[allQuestionCount3];

                // 指定是否选择标记的长度
                QuizHelper.selectedStates = new bool[allQuestionCount];
                QuizHelper.selectedStates2 = new bool[allQuestionCount2];
                QuizHelper.selectedStates3= new bool[allQuestionCount3];

                // 找出该科目的所有的问题
                SetAllQuestionIds(subjectId);
                SetAllQuestionIds2(subjectId);
                SetAllQuestionIds3(subjectId);

                // 抽题
                SetSelectedQuestionIds();
                SetSelectedQuestionIds2();
                SetSelectedQuestionIds3();

                // 取出标准答案
                SetRightAnswers();
                SetRightAnswers2();

                // 剩余时间为20分钟
                QuizHelper.remainSeconds = 1200;

                // 将学生答案数组初始化
                for (int i = 0; i < QuizHelper.studentAnswers.Length; i++)
                {
                    QuizHelper.studentAnswers[i] = "未回答";
                }

                // 打开答题窗体
                AnswerQuestionForm answerQuestion = new AnswerQuestionForm();
                answerQuestion.MdiParent = this.MdiParent;
                answerQuestion.Show();
                this.Close();
            }
        }



        private bool iscantest()
        {
            bool returnvalue = false;
            // 获得选中科目的Id
            QuizHelper.subjectId = GetSubjectId();

            string strsql = "select count(*) from Score where Sno ='" + UserHelper.loginId + "' and SubjectID= '" + QuizHelper.subjectId + "'";
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                //原密码验证
                DBHelper.connection.Open();
                int result = (int)comm.ExecuteScalar();
                if (result == 0)
                    returnvalue = true;
                else
                    returnvalue = false;
   
            }
            catch
            {

            }

            finally
            {
                DBHelper.connection.Close();
            }

            return returnvalue;
        }

        // 获得对应科目的题目的总数
        private static int GetQuestionCount(int subjectId)
        {
            
           // return -1;
            string strsql = "select count(*) from ChoiceQuestion where SubjectId=" + subjectId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                return (int)comm.ExecuteScalar();
               
            }
            catch(Exception ex)
            {
                throw ex;
               
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
        private static int GetQuestionCount2(int subjectId)
        {
            
            // return -1;
            string strsql = "select count(*) from fillblank where SubjectID=" + subjectId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                return (int)comm.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                DBHelper.connection.Close();
            }
        }

        private static int GetQuestionCount3(int subjectId)
        {
            
            // return -1;
            string strsql = "select count(*) from ShortAnswer where SubjectID=" + subjectId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                return (int)comm.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                DBHelper.connection.Close();
            }
        }


        // 获得科目的Id
        private int GetSubjectId()
        {
           
            object item = cboSubjects.SelectedItem;
            if (item != null)
            {
                Subject subject = item as Subject;
                return subject.SubjectId;
            }
            else
                return -1;
            
        }

        // 获得某科目所有问题的Id
        private void SetAllQuestionIds(int subjectId)
        {
          
            string strsql = "select QuestionId from ChoiceQuestion where subjectId = " + subjectId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr = null;
            try
            {
                DBHelper.connection.Open();
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    QuizHelper.allQuestionIds[i] = (int)dr[0];
                    QuizHelper.selectedStates[i] = false;
                    i++;
                }
               
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            { 
               dr.Close();
                DBHelper.connection.Close();
            }
        }
        private void SetAllQuestionIds2(int subjectId)
        {

            string strsql = "select QuestionId from fillblank where SubjectID = " + subjectId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr = null;
            try
            {
                DBHelper.connection.Open();
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    QuizHelper.allQuestionIds2[i] = (int)dr[0];
                    QuizHelper.selectedStates2[i] = false;
                    i++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                DBHelper.connection.Close();
            }
        }
        private void SetAllQuestionIds3(int subjectId)
        {

            string strsql = "select QuestionId from ShortAnswer where SubjectID = " + subjectId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr = null;
            try
            {
                DBHelper.connection.Open();
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    QuizHelper.allQuestionIds3[i] = (int)dr[0];
                    QuizHelper.selectedStates3[i] = false;
                    i++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dr.Close();
                DBHelper.connection.Close();
            }
        }
        // 抽取试题
        private void SetSelectedQuestionIds()
        {
            //抽取试题
            Random random = new Random();
            int questionIndex = 0; //随机产生问题的索引值
            int i = 0;
            while (i < QuizHelper.questionNum)
            {
                questionIndex = random.Next(QuizHelper.allQuestionIds.Length);
                if (QuizHelper.selectedStates[questionIndex] == false)
                {
                    QuizHelper.selectedQuestionIds[i] = QuizHelper.allQuestionIds[questionIndex];
                    QuizHelper.selectedStates[questionIndex] = true;
                    i++;
                }
            }
                  
        }
        private void SetSelectedQuestionIds2()
        {
            //抽取试题
            Random random = new Random();
            int questionIndex = 0; //随机产生问题的索引值
            int i = 0;
            while (i < QuizHelper.questionNum2)
            {
                questionIndex = random.Next(QuizHelper.allQuestionIds2.Length);
                if (QuizHelper.selectedStates2[questionIndex] == false)
                {
                    QuizHelper.selectedQuestionIds2[i] = QuizHelper.allQuestionIds2[questionIndex];
                    QuizHelper.selectedStates2[questionIndex] = true;
                    i++;
                }
            }

        }
        private void SetSelectedQuestionIds3()
        {
            //抽取试题
            Random random = new Random();
            int questionIndex = 0; //随机产生问题的索引值
            int i = 0;
            while (i < QuizHelper.questionNum3)
            {
                questionIndex = random.Next(QuizHelper.allQuestionIds3.Length);
                if (QuizHelper.selectedStates3[questionIndex] == false)
                {
                    QuizHelper.selectedQuestionIds3[i] = QuizHelper.allQuestionIds3[questionIndex];
                    QuizHelper.selectedStates3[questionIndex] = true;
                    i++;
                }
            }

        }

        // 取出试题的标准答案
        private void SetRightAnswers()
        {
            //TODO:取出试题的标准答案
            for (int i = 0; i < QuizHelper.selectedQuestionIds.Length; i++)
            {
                int questionId = QuizHelper.selectedQuestionIds[i];
                QuizHelper.correctAnswers[i] = this.GetAnswerByQuestionId(questionId);

            }
        }
        private void SetRightAnswers2()
        {
            //TODO:取出试题的标准答案
            for (int i = 0; i < QuizHelper.selectedQuestionIds2.Length; i++)
            {
                int questionId = QuizHelper.selectedQuestionIds2[i];
                QuizHelper.correctAnswers2[i] = this.GetAnswerByQuestionId2(questionId);

            }
        }
        
        
        // 根据题目编号得题目答案
        private string GetAnswerByQuestionId(int questionId)
        {
            string strsql = "select Answer from ChoiceQuestion where questionId=" + questionId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch
            {
                return "";
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
        private string GetAnswerByQuestionId2(int questionId)
        {
            string strsql = "select Answer from fillblank where QuestionId=" + questionId;
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                return comm.ExecuteScalar().ToString();
            }
            catch
            {
                return "";
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }
        private void cboSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
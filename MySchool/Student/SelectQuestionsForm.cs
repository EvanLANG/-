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
    /// ����ѡ����
    /// </summary>
    public partial class SelectQuestionsForm : Form
    {
        public SelectQuestionsForm()
        {
            InitializeComponent();
        }

        // �������ʱ������Ŀ�����ݿ��ж�ȡ������ʾ����Ͽ���
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
                MessageBox.Show("���ؿγ̿�Ŀ��Ϣʧ��!", "�Ϻ�����ѧԺ�߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                DBHelper.connection.Close();
               
            }
        }

        // �������⣬�˳�Ӧ�ó���
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��ȷ��Ҫ�����˴δ��������", "�Ϻ�����ѧԺ�߿���ϵͳ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuizHelper.subjectId = 0;
                this.Close();
            }
        }

        // ��������ʼ���⡱��ť
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (cboSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ���Ŀ��", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSubjects.Focus(); 
            }
            else if(!iscantest())
            {
                MessageBox.Show("�ÿ�Ŀ�Ѿ����Թ���������ѡ���Ŀ��", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuizHelper.subjectId = 0;
                cboSubjects.Focus();  
            }

            else
            {
                int subjectId = QuizHelper.subjectId;

                // �ÿ�Ŀ��������
                int allQuestionCount = GetQuestionCount(subjectId);
                int allQuestionCount2 = GetQuestionCount2(subjectId);
                int allQuestionCount3 = GetQuestionCount3(subjectId);

                // ָ��������������ĳ���                
                QuizHelper.allQuestionIds = new int[allQuestionCount];
                QuizHelper.allQuestionIds2 = new int[allQuestionCount2];
                QuizHelper.allQuestionIds3 = new int[allQuestionCount3];

                // ָ���Ƿ�ѡ���ǵĳ���
                QuizHelper.selectedStates = new bool[allQuestionCount];
                QuizHelper.selectedStates2 = new bool[allQuestionCount2];
                QuizHelper.selectedStates3= new bool[allQuestionCount3];

                // �ҳ��ÿ�Ŀ�����е�����
                SetAllQuestionIds(subjectId);
                SetAllQuestionIds2(subjectId);
                SetAllQuestionIds3(subjectId);

                // ����
                SetSelectedQuestionIds();
                SetSelectedQuestionIds2();
                SetSelectedQuestionIds3();

                // ȡ����׼��
                SetRightAnswers();
                SetRightAnswers2();

                // ʣ��ʱ��Ϊ20����
                QuizHelper.remainSeconds = 1200;

                // ��ѧ���������ʼ��
                for (int i = 0; i < QuizHelper.studentAnswers.Length; i++)
                {
                    QuizHelper.studentAnswers[i] = "δ�ش�";
                }

                // �򿪴��ⴰ��
                AnswerQuestionForm answerQuestion = new AnswerQuestionForm();
                answerQuestion.MdiParent = this.MdiParent;
                answerQuestion.Show();
                this.Close();
            }
        }



        private bool iscantest()
        {
            bool returnvalue = false;
            // ���ѡ�п�Ŀ��Id
            QuizHelper.subjectId = GetSubjectId();

            string strsql = "select count(*) from Score where Sno ='" + UserHelper.loginId + "' and SubjectID= '" + QuizHelper.subjectId + "'";
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                //ԭ������֤
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

        // ��ö�Ӧ��Ŀ����Ŀ������
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


        // ��ÿ�Ŀ��Id
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

        // ���ĳ��Ŀ���������Id
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
        // ��ȡ����
        private void SetSelectedQuestionIds()
        {
            //��ȡ����
            Random random = new Random();
            int questionIndex = 0; //����������������ֵ
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
            //��ȡ����
            Random random = new Random();
            int questionIndex = 0; //����������������ֵ
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
            //��ȡ����
            Random random = new Random();
            int questionIndex = 0; //����������������ֵ
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

        // ȡ������ı�׼��
        private void SetRightAnswers()
        {
            //TODO:ȡ������ı�׼��
            for (int i = 0; i < QuizHelper.selectedQuestionIds.Length; i++)
            {
                int questionId = QuizHelper.selectedQuestionIds[i];
                QuizHelper.correctAnswers[i] = this.GetAnswerByQuestionId(questionId);

            }
        }
        private void SetRightAnswers2()
        {
            //TODO:ȡ������ı�׼��
            for (int i = 0; i < QuizHelper.selectedQuestionIds2.Length; i++)
            {
                int questionId = QuizHelper.selectedQuestionIds2[i];
                QuizHelper.correctAnswers2[i] = this.GetAnswerByQuestionId2(questionId);

            }
        }
        
        
        // ������Ŀ��ŵ���Ŀ��
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
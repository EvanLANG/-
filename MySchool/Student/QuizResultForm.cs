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
    public partial class QuizResultForm : Form
    {
        public QuizResultForm()
        {
            InitializeComponent();
        }

        // �˳�Ӧ�ó���
        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        // ��ʾ����
        private void QuizResultForm_Load(object sender, EventArgs e)
        {
            int correctNum = 0;
            int correctNum2 = 0;
            for (int i = 0; i < QuizHelper.questionNum; i++)
            {
                if (QuizHelper.studentAnswers[i] == QuizHelper.correctAnswers[i])
                {
                    correctNum++;
                }
            }
            for (int i = 0; i < QuizHelper.questionNum2; i++)
            {
                if (QuizHelper.studentAnswers2[i] == QuizHelper.correctAnswers2[i])
                {
                    correctNum2++;
                }
            }
            int score1 = correctNum * 4;
            int score2 = correctNum2 * 6;
            int score = score1 + score2;
            lblMark.Text = score.ToString() + "��";

            lblStudentScoreStrip.Width = lblFullMarkStrip.Width * score / 80;




            //������ݵ����Լ�¼��
            string strsql = string.Format("insert into Score values ({0},{1},{2},getdate(),'0','0','0','0','0')", QuizHelper.subjectId, UserHelper.loginId, score);
            SqlCommand comm = null;
            comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
               DBHelper.connection.Open();
               comm.ExecuteScalar();
            }
            catch
            {
               
            }
            finally
            {
                DBHelper.connection.Close();
            }
            //�����������

            string strsql1 = string.Format("Update {6} set Objanswer1='{0}' , Objanswer2='{1}',QuestionID1='{2}',QuestionID2='{3}'where Sno='{4}' and SubjectId='{5}'", QuizHelper.studentAnswers3[0], QuizHelper.studentAnswers3[1], QuizHelper.selectedQuestionIds3[0],QuizHelper.selectedQuestionIds3[1], UserHelper.loginId, QuizHelper.subjectId, "Score");
            SqlCommand comm1 = null;
            comm1 = new SqlCommand(strsql1, DBHelper.connection);
            DBHelper.connection.Open();
            comm1.ExecuteScalar();
            DBHelper.connection.Close();

           
            if (score < 50)
            {
                lblComment.Text = "�úúø�ϰ��!";
                lblStudentScoreStrip.BackColor = Color.Red;
                picFace.Image = ilFaces.Images[0];
            }
            else if (score >= 50 && score < 70)
            {
                lblComment.Text = "����������Ŭ��!";
                lblStudentScoreStrip.BackColor = Color.Blue;
                picFace.Image = ilFaces.Images[1];
            }
            else if (score >= 70 && score < 80)
            {
                lblComment.Text = "����������������!";
                lblStudentScoreStrip.BackColor = Color.CornflowerBlue;
                picFace.Image = ilFaces.Images[2];
            }
            else if (score == 80)
            {

                lblComment.Text = "������̫�����ˣ���������!";
                lblStudentScoreStrip.BackColor = Color.Green;
                picFace.Image = ilFaces.Images[3];
            }
        }

        private void QuizResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuizHelper.subjectId = 0;
        }

        private void picFace_Click(object sender, EventArgs e)
        {

        }
    }
}
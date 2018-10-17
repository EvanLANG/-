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
    /// ���ⴰ��
    /// </summary>
    public partial class AnswerQuestionForm : Form
    {
        public int questionIndex = 0;  // ��ǰ�������Ӧ����������

        public AnswerQuestionForm()
        {
            InitializeComponent();
        }        

        // �������ʱ����ʾ��Ӧ��Ŀ����Ϣ
        private void AnswerQuestionForm_Load(object sender, EventArgs e)
        {
            QuizHelper.showquittips = true;//������ʾ�ر�����
            tmrCostTime.Start();   // ������ʱ��
            
            GetQuestionDetails();  // ��ʾ��Ŀ��Ϣ
            CheckOption();   ������// �����Ŀ�Ѿ����������Ӧ��ѡ��ѡ�� 
            CheckBtnNext();  ��    // ȷ���Ƿ������һ��
        }

        // ȷ������һ�⡱��ťӦ����ʾ������
        private void CheckBtnNext()
        {
            // ����ﵽ14�⣬�Ϳ�ʼ�����
            if (questionIndex >= QuizHelper.selectedQuestionIds.Length - 1)
            {
                
                btnNext.Text = "ѡ�������,����⿪ʼ";
                /*fillblank fillblank = new fillblank();
                fillblank.Show();*/
            }
        }
        
        // ��������һ�⡱��ťʱ��Ϊ�����鸳ֵ������ʾ��һ�����Ϣ
        private void btnNext_Click(object sender, EventArgs e)
        {
            // ���û�е����һ�⣬�ͼ�����ʾ����Ŀ��Ϣ
            if (questionIndex < QuizHelper.selectedQuestionIds.Length - 1)
            {
                questionIndex++;
                
                GetQuestionDetails();  // ��ʾ������Ϣ
                CheckOption();         // �����Ŀ�Ѿ����������Ӧ��ѡ��ѡ��    
                CheckBtnNext(); ��     // ȷ���Ƿ������һ��
            }
            else  // ���򣬿�ʼ�����
            {
                fillblank fillblank = new fillblank();
                fillblank.Show();
                this.Hide();
            }
        }       

        // �򿪴��⿨����
        private void OpenAnswerCard()
        {
            AnswerCardForm answerCardForm = new AnswerCardForm();
            answerCardForm.MdiParent = this.MdiParent;
            answerCardForm.Show();
            QuizHelper.showquittips = false;
            this.Close();
        }

        // ��ʱ���¼�
        public void tmrCostTime_Tick(object sender, EventArgs e)
        {
            int minute;   // ��ǰ�ķ���
            int second;   // ��

            // �������ʣ��ʱ�䣬����ʾʣ��ķ��Ӻ�����
            if (QuizHelper.remainSeconds > 0)
            {
                QuizHelper.remainSeconds--; 
                minute = QuizHelper.remainSeconds / 60;
                second = QuizHelper.remainSeconds % 60;
                lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);                             
            }
            // ���򣬾���ʾ����
            else 
            {
                tmrCostTime.Stop();
                MessageBox.Show("ʱ�䵽�ˣ��ý����ˣ�", "���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuizResultForm quizResultForm = new QuizResultForm();
                quizResultForm.MdiParent = this.MdiParent;
                quizResultForm.Show();
                this.Close();
            }
        }
  
        // ѡ�ѡ��ť�ĵ����¼�����ѡ���ʱ����¼��
        private void rdoOption_Click(object sender, EventArgs e)
        {
            QuizHelper.studentAnswers[questionIndex] = ((RadioButton)sender).Tag.ToString();
        }

        // ���������⿨����ťʱ���򿪴��⿨����
        private void btnAnswerCard_Click(object sender, EventArgs e)
        {
            OpenAnswerCard();
        }

        // ���������Id����ʾ��Ŀ����ϸ��Ϣ
        public void GetQuestionDetails()
        {
            lblQuestion.Text = string.Format("����{0}��", questionIndex + 1);
            string strsql = "select Question,OptionA,OptionB,OptionC,OptionD from ChoiceQuestion where questionId=" + QuizHelper.selectedQuestionIds[questionIndex];
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr = null;
            try
            {
                DBHelper.connection.Open();
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    lblQuestionDetails.Text = dr["Question"].ToString();
                    rdoOptionA.Text = string.Format("A.{0}", dr["OptionA"].ToString());
                    rdoOptionB.Text = string.Format("B.{0}", dr["OptionB"].ToString());
                    rdoOptionC.Text = string.Format("C:{0}", dr["OptionC"].ToString());
                    rdoOptionD.Text = string.Format("D:{0}", dr["OptionD"].ToString());
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("��Ŀ����ʧ�ܣ�", "���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            finally
            {
               
                DBHelper.connection.Close();

            }
        }

        // ����Ѿ�������Ŀ��ѡ����Ӧ��ѡ��
        private void CheckOption()
        {
            switch (QuizHelper.studentAnswers[questionIndex])
            {
                case "A":
                    rdoOptionA.Checked = true;
                    break;
                case "B":
                    rdoOptionB.Checked = true;
                    break;
                case "C":
                    rdoOptionC.Checked = true;
                    break;
                case "D":
                    rdoOptionD.Checked = true;
                    break;
                default:
                    rdoOptionA.Checked = false;
                    rdoOptionB.Checked = false;
                    rdoOptionC.Checked = false;
                    rdoOptionD.Checked = false;
                    break;
            }
        }

        private void AnswerQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(QuizHelper.showquittips)
           {
               if (DialogResult.OK == MessageBox.Show("��ȷ��Ҫ�˳�������", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
               {
                   QuizHelper.subjectId = 0;
               }
               else
                   e.Cancel = true;
           
           }     
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
      
    }
}
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
    /// 教员登录后的主窗体
    /// </summary> 
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        // 单击“退出”菜单项时，退出应用程序
        private void tsmiExit_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
                       
        }        

        // 窗体加载事件处理
        private void StudentForm_Load(object sender, EventArgs e)
        {
            string strsql2 = string.Format("select name from login_info where no ='{0}'", UserHelper.loginId);
            SqlCommand comm2 = new SqlCommand(strsql2, DBHelper.connection);
            SqlDataReader dr = null;
            try
            {
                DBHelper.connection.Open();
                dr = comm2.ExecuteReader();
                if (dr.Read())
                {
                    UserHelper.loginName= dr[0].ToString();

                }
                dr.Close();
            }
            catch
            {

            }
            finally
            {
                DBHelper.connection.Close();
            }

            

            lblLoginType.Text = string.Format("你好，{0}！", UserHelper.loginName);
        }





        // 进入在线答题模块，显示选题窗体
        private void tsmiQuiz_Click(object sender, EventArgs e)
        {
            if (QuizHelper.subjectId > 0)
            {
                MessageBox.Show("请先完成其他的考试！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SelectQuestionsForm selectQuestionsForm = new SelectQuestionsForm();
           
            selectQuestionsForm.Show();
        }

        private void tsbtnSearchMark_Click(object sender, EventArgs e)
        {
            ViewMyScoreForm viewmyscoreform = new ViewMyScoreForm();

            viewmyscoreform.Show();
        }

        private void tsbtnModifySelfInfo_Click(object sender, EventArgs e)
        {
            AlterPersonInfo alterpersoninfo = new AlterPersonInfo();

            alterpersoninfo.Show();
        }


        // 窗体关闭事件
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        public string LoginType
        {
            get {
                return lblLoginType.Text;
            }
            set {
                lblLoginType.Text = value;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       
    }
}
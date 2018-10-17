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
    public partial class ViewTest : Form
    {
        public ViewTest()
        {
            InitializeComponent();
        }


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

        private void ViewTest_Load(object sender, EventArgs e)
        {
            string strsql = "select * from Subject where TeacherId = '" + UserHelper.loginId +"'";
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            SqlDataReader dr = null;
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
                dr.Close();
            }
            catch
            {
                MessageBox.Show("加载课程科目信息失败!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                DBHelper.connection.Close();

            }
        }

        private DataSet sqlds = new DataSet();
        private SqlDataAdapter sqlda = new SqlDataAdapter();

        private void btnViewTest_Click(object sender, EventArgs e)
        {
            int id = GetSubjectId();



            SqlConnection conn = new SqlConnection("Server=LANG-VAIO;Database=OnlineExam;Trusted_Connection=SSPI");
            sqlda = new SqlDataAdapter("select TestId 序号,QuestionID1 题号1, Objanswer1 答案1, QuestionID2 题号2,Objanswer2 答案2,Objective 分数,Sno 学号,Subjective 客观题分数, TestTime 考试时间 from Score where SubjectId='" + id + "'  order by TestId asc", conn);
            sqlds = new DataSet();
            sqlda.Fill(sqlds, "Score");
            dataGridView1.DataSource = sqlds.Tables["Score"];
            SqlCommandBuilder sqlCmdBuilder = new SqlCommandBuilder(sqlda);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input1_Click(object sender, EventArgs e)
        {
            if (sqlds.HasChanges())//如果数据集因我们对datagridview的操作发生改变
            {
                try
                {
                    sqlda.Update(sqlds.Tables["Score"]);
                    sqlds.Tables["Score"].AcceptChanges();//接受对数据的修改
                    MessageBox.Show("更新成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示更新成功
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "更新失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //出现异常提示更新失败
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0 && this.dataGridView1.CurrentCell .ColumnIndex  > 3)
            {
                
                this.questionDetail1.Text = this.dataGridView1.CurrentRow.Cells["答案2"].Value.ToString();
            }
            else
            {
                this.questionDetail1.Text = this.dataGridView1.CurrentRow.Cells["答案1"].Value.ToString();
 
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

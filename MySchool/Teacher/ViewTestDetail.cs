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
    public partial class ViewTestDetail : Form
    {
        public ViewTestDetail()
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

        private void bt_sure_Click(object sender, EventArgs e)
        {
            int select = GetSubjectId();

            if (select == -1)
            {
                MessageBox.Show("请选择科目！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSubjects.Focus();
            }
            else
            {
                dataGridView1.DataSource = bindingSource1;

                string strsql = "select login_info.name 姓名,Score.Subjective 客观题分数,Score.Objective 主观题分数,Score.Subjective+Score.Objective 总分,Score.TestTime 考试时间 from login_info , Subject ,Score where Subject.SubjectId = Score.SubjectId and login_info.no=Score.Sno and Subject.TeacherId = '" + UserHelper.loginId + "' and Subject.SubjectId = " + select;

                SqlDataAdapter sda = new SqlDataAdapter(strsql, DBHelper.connection);


                try
                {
                    DBHelper.connection.Open();
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);

                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    sda.Fill(table);
                    bindingSource1.DataSource = table;


                }
                catch
                {
                    MessageBox.Show("加载考试详情失败!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBHelper.connection.Close();

                }
            
            }          
        }

        private void ViewTestDetail_Load(object sender, EventArgs e)
        {
            string strsql = "select * from Subject where TeacherId = '" + UserHelper.loginId + "'";
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
            }
            catch
            {
                MessageBox.Show("加载课程科目信息失败!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                DBHelper.connection.Close();

            }
        }
    }
}

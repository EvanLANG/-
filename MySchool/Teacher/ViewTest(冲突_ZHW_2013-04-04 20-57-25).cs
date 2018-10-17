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



        private void lbtestflag_Click(object sender, EventArgs e)
        {
             int select = GetSubjectId();

             int state=(lbtestflag.Text=="有效"?0:1);
             string strsql1 = "update Subject set TestFlag = "+ state+" where SubjectId = " + select + ";";
             SqlCommand comm1 = new SqlCommand(strsql1, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                comm1.ExecuteReader();
                lbtestflag.Text=(state==1?"有效":"无效");
                MessageBox.Show("更改设置成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("更改设置失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DBHelper.connection.Close();
            }

 
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
                    subject.SubjectId = (int)dr[0];
                    subject.SubjectName = dr[1].ToString();
                    cboSubjects.Items.Add(subject);
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("加载课程科目信息失败!", "CTGU在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                DBHelper.connection.Close();

            }
        }



        private void btnViewTest_Click(object sender, EventArgs e)
        {
            int select = GetSubjectId();

            if (select == -1)
            {
                MessageBox.Show("请选择科目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSubjects.Focus();
            }
            else
            {
               
                string strsql1= "select Subject.CreateTime createtime,Subject.TestFlag flag from Subject where SubjectId = "+ select+";";
                string strsql2 = " select count(score) testnum,avg(score) avgscore,max(score) maxscore,min(score) minscore from TestResult where Subjectid =" + select + ";";
                SqlCommand comm1 = new SqlCommand(strsql1, DBHelper.connection);
                SqlCommand comm2 = new SqlCommand(strsql2, DBHelper.connection);
                SqlDataReader dr1 = null;
                SqlDataReader dr2 = null;
                try
                {
                    lbtime.Visible = true;
                    lbaveragescore.Visible = true;
                    lbnumber.Visible = true;
                    lbmaxscore.Visible = true;
                    lbminscore.Visible = true;
                    lbtestflag.Visible = true;
                    DBHelper.connection.Open();
                    dr1 = comm1.ExecuteReader();
                   if (dr1.Read())
                    {
                        lbtime.Text = dr1["createtime"].ToString();
                       lbtestflag.Text = ( dr1["flag"].ToString()=="1"?"有效":"无效");                    
                    }
                    dr1.Close();

                    try
                    {
                        
                        dr2 = comm2.ExecuteReader();
                        if (dr2.Read())
                        {
                            lbaveragescore.Text = dr2["avgscore"].ToString();
                            lbnumber.Text = dr2["testnum"].ToString();
                            lbmaxscore.Text = dr2["maxscore"].ToString();
                            lbminscore.Text = dr2["minscore"].ToString();
                        }
                        dr2.Close();
                    }
                    catch
                    {
                        lbaveragescore.Visible = false;
                        lbnumber.Visible = false;
                        lbmaxscore.Visible = false;
                        lbminscore.Visible = false;
                        MessageBox.Show("读取数据错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {}
                }
                catch
                {
                    lbtime.Visible = false;
                    lbaveragescore.Visible = false;
                    lbnumber.Visible = false;
                    lbmaxscore.Visible = false;
                    lbminscore.Visible = false;
                    lbtestflag.Visible = false;
                    MessageBox.Show("读取数据错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    DBHelper.connection.Close();

                }
            }          

        }
    }
}

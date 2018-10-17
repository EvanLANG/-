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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
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
                    UserHelper.loginName = dr[0].ToString();
                    lbWelcome.Text = UserHelper.loginName + ",欢迎你！";
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
           
        }

        public void test()
        { }

        private void tsbtnAddTest_Click(object sender, EventArgs e)
        {
            AddSubjectName asn = new AddSubjectName();
            //asn.MdiParent = this;
            asn.Show();
        }

        private void tsbtnViewTest_Click(object sender, EventArgs e)
        {
            ViewTest vt = new ViewTest();
            //vt.MdiParent = this;
            vt.Show();
        }

        private void tsbtnTestDetail_Click(object sender, EventArgs e)
        {
            ViewTestDetail vtd = new ViewTestDetail();
            //vtd.MdiParent =this;
            vtd.Show();

        }

       

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudent nmd = new ViewStudent();
            nmd.Show();
            
        }
    }
}

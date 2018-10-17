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
    public partial class AddSubjectName : Form
    {
        public AddSubjectName()
        {
            InitializeComponent();
        }
       
        private void AddSubjectName_Load(object sender, EventArgs e)
        {

        }

        private void btaddsubject_Click(object sender, EventArgs e)
        {
            if (!chkInput())
            {
                MessageBox.Show("该科目已经存在或缺少必要信息，请重新输入！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectName.Text = "";
                txtSubjectId.Text = "";
                return;
            }

            else
            {
                string strsql = string.Format("insert into Subject values ('{0}','{1}','{2}',getdate());", txtSubjectId.Text, txtSubjectName.Text, UserHelper.loginId);
               
                SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
               try
                {
                    DBHelper.connection.Open();
                    comm.ExecuteScalar();
                    MessageBox.Show("添加考试成功！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("添加失败!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                finally
                {
                    DBHelper.connection.Close();
                }
                this.Close();
            }
        }

        private bool chkInput()
        {
            string name = txtSubjectName.Text;
            string id = txtSubjectId.Text;

            if (name == ""||id =="")
            {
                MessageBox.Show("请输入完整科目信息!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string strsql = string.Format("select count(*) from Subject where SubjectId='{0}'",id );
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                int result = (int)comm.ExecuteScalar();

                return result == 0;

            }
            catch
            {
                return false;
            }
            finally
            {
                DBHelper.connection.Close();
            }



        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

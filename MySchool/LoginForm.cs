using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using namespace MySchool.Admin;

namespace MySchool
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录类型属性
        /// </summary>
        public string LoginType {
            get {
                return this.cboLoginType.Text;
            }
        }
        /// <summary>
        /// 登录帐号属性
        /// </summary>
        public string LoginId {
            get {
                return txtLoginId.Text.Trim();
            }
        }

        // “登录”按钮的单击事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!chkInput()) return; //检查输入

            string loginType = cboLoginType.Text;
            Form firform = null;

            switch (loginType)
            {
                case "教师":
                    if (TeacherLogin())
                        firform = new TeacherForm();
                    break;
                case "管理员":
                    if (AdminLogin())
                        firform = new AdminForm1();
                    break;
                case "学生":
                    if (StudentLogin())
                        firform = new StudentForm();
                    break;

            }
           
            if (firform!=null)
            {
                //this.Hide();
                firform.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("登录失败,请检查帐号或密码是否有误!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private bool StudentLogin()
        {
            UserHelper.loginId = txtLoginId.Text;

            string strsql = string.Format("select count(*) from {3} where no='{0}' and Pwd='{1}'and userType='{2}'", txtLoginId.Text, txtLoginPwd.Text, cboLoginType.Text, "login_info");
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                int result = (int)comm.ExecuteScalar();
               
                    
                    return result > 0;
              
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

        private bool AdminLogin()
        {
            UserHelper.loginId = txtLoginId.Text;
            string strsql = string.Format("select count(*) from {3} where no='{0}' and Pwd='{1}'and userType='{2}'", txtLoginId.Text, txtLoginPwd.Text, cboLoginType.Text, "login_info");
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                int result = (int)comm.ExecuteScalar();
                return result > 0;
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
       
        private bool TeacherLogin()
        {
            UserHelper.loginId = txtLoginId.Text;
            string strsql = string.Format("select count(*) from {3} where no='{0}' and Pwd='{1}'and userType='{2}'", txtLoginId.Text, txtLoginPwd.Text, cboLoginType.Text, "login_info");
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                DBHelper.connection.Open();
                int result = (int)comm.ExecuteScalar();
                return result > 0;
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
        /// <summary>
        /// 主要用于校验客户端的输入的合法性
       
        private bool chkInput()
        {
            string accountId = txtLoginId.Text.Trim();
            string pwd = txtLoginPwd.Text;

            if (accountId == "")
            {
                MessageBox.Show("帐号不允许为空!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pwd == "")
            {
                MessageBox.Show("请输入密码!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string loginType = cboLoginType.Text;

            if (loginType == "")
            {
                MessageBox.Show("请选择登陆类型!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            this.Close();
           
              
        }

        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
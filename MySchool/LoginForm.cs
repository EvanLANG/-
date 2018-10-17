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
    /// ��¼����
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ��¼��������
        /// </summary>
        public string LoginType {
            get {
                return this.cboLoginType.Text;
            }
        }
        /// <summary>
        /// ��¼�ʺ�����
        /// </summary>
        public string LoginId {
            get {
                return txtLoginId.Text.Trim();
            }
        }

        // ����¼����ť�ĵ����¼�
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!chkInput()) return; //�������

            string loginType = cboLoginType.Text;
            Form firform = null;

            switch (loginType)
            {
                case "��ʦ":
                    if (TeacherLogin())
                        firform = new TeacherForm();
                    break;
                case "����Ա":
                    if (AdminLogin())
                        firform = new AdminForm1();
                    break;
                case "ѧ��":
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
                MessageBox.Show("��¼ʧ��,�����ʺŻ������Ƿ�����!", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// ��Ҫ����У��ͻ��˵�����ĺϷ���
       
        private bool chkInput()
        {
            string accountId = txtLoginId.Text.Trim();
            string pwd = txtLoginPwd.Text;

            if (accountId == "")
            {
                MessageBox.Show("�ʺŲ�����Ϊ��!", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pwd == "")
            {
                MessageBox.Show("����������!", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string loginType = cboLoginType.Text;

            if (loginType == "")
            {
                MessageBox.Show("��ѡ���½����!", "�Ϻ�����ѧԺ���߿���ϵͳ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
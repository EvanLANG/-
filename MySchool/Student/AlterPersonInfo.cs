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
    public partial class AlterPersonInfo : Form
    {
        public AlterPersonInfo()
        {
            InitializeComponent();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (!chkInput())
                return;

            bool isclose = false;
            string strsql = "select count(*) from login_info where no=" + UserHelper.loginId +"and Pwd ="+txtOldPwd.Text.ToString();
            SqlCommand comm = new SqlCommand(strsql, DBHelper.connection);
            try
            {
                //原密码验证
                DBHelper.connection.Open();
                int result = (int)comm.ExecuteScalar();
                if (result == 0)
                {
                    MessageBox.Show("原密码错误！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DBHelper.connection.Close();
                    return;
                    
                }


                
                //通过原密码，新密码验证
                if (txtnewpwd.Text.ToString() != txtconcern.Text.ToString())
                {
                    MessageBox.Show("新密码两次输入不相同！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DBHelper.connection.Close();
                    return;
                }
                //通过新密码验证，修改密码
                string strsql2 = "update login_info set Pwd =" + txtnewpwd.Text.ToString() + "where no =" + UserHelper.loginId;
                SqlCommand comm2=new SqlCommand(strsql2,DBHelper.connection);
                comm2.ExecuteScalar();
                MessageBox.Show("修改密码成功！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isclose = true;

            }
            catch
            {

            }

            finally
            {
                DBHelper.connection.Close();
            }

            if (isclose)
                this.Close();

        }
        private bool chkInput()
        {
            string oldpwd = txtOldPwd.Text.Trim();
            string newpwd = txtnewpwd.Text.Trim();
            string conpwd = txtconcern.Text.Trim();

            if (oldpwd == "")
            {
                MessageBox.Show("请输入原密码!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (newpwd == "")
            {
                MessageBox.Show("请输入新密码!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (conpwd == "")
            {
                MessageBox.Show("请输入确认密码!", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }




        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

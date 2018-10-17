using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class AdminForm1 : Form
    {
        public AdminForm1()
        {
            InitializeComponent();
        }

        private void AdminForm1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“onlineExamDataSet1.login_info”中。您可以根据需要移动或删除它。
            this.login_infoTableAdapter1.Fill(this.onlineExamDataSet1.login_info);
            // TODO: 这行代码将数据加载到表“onlineExamDataSet.login_info”中。您可以根据需要移动或删除它。
            //this.login_infoTableAdapter.Fill(this.onlineExamDataSet.login_info);

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
                }
                dr.Close();
                lblLoginName.Text = UserHelper.loginName + "，欢迎你！";
            }
            catch
            {

                MessageBox.Show("加载姓名失败！", "上海电力学院在线考试系统", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                DBHelper.connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm adminform = new AdminForm();
            adminform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.login_infoTableAdapter1.Update(this.onlineExamDataSet1.login_info);
            MessageBox.Show("更新成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            this.login_infoTableAdapter1.Update(this.onlineExamDataSet1.login_info);
            MessageBox.Show("删除成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

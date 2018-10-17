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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
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
        private bool chkInput()
        {
            if(txtorder.Text=="")
            {
                MessageBox.Show("请输入命令再执行！","上海电力学院在线考试系统",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
 
        }

        private void btexec_Click(object sender, EventArgs e)
        {
            if (!chkInput())
                return;

            string order = txtorder.Text;
            string suborder = order.Substring(0, 6);
            //判断是否是查询语句
            if (suborder == "select" || suborder == "SELECT")
                query();
            else
                exec();
        }

        //查询命令，显示查询结果
        private void query()
        {
            dataGridView1.DataSource = bindingSource1;

            string strsql = txtorder.Text;

            SqlDataAdapter sda = new SqlDataAdapter(strsql, DBHelper.connection);


            try
            {
                DBHelper.connection.Open();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                sda.Fill(table);
                bindingSource1.DataSource = table;
    
                dataGridView1.Visible = true;
                lbresult.Visible = false;
                lbmsg.Visible = false;

            }
            catch
            {
                dataGridView1.Visible = false;
                lbmsg.Visible = true;
                lbresult.Visible = true;
                lbresult.Text = "命令：" + txtorder.Text + "执行失败！";
            }
            finally
            {
                DBHelper.connection.Close();

            }

        }
        private void exec()
        {
            string strsql2 = txtorder.Text;
            SqlCommand comm2 = new SqlCommand(strsql2, DBHelper.connection);
            
            try
            {
                DBHelper.connection.Open();
                comm2.ExecuteScalar();
                lbresult.Text = "命令：" + txtorder.Text + "执行成功！";
            }
            catch
            {
                lbresult.Text = "命令：" + txtorder.Text + "执行失败！";
            }
            finally
            {
                if (DBHelper.connection.State == ConnectionState.Open)
                    DBHelper.connection.Close();
            }
            
            dataGridView1.Visible = false;
            lbmsg.Visible = true;
            lbresult.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

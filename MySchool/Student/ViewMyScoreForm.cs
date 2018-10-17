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
    public partial class ViewMyScoreForm : Form
    {
        public ViewMyScoreForm()
        {
            InitializeComponent();
        }

        private void bt_sure_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMyScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;

            string strsql = "select a.SubjectId 课程号, b.SubjectName 科目,Subjective+Objective 总分 ,a.TestTime 考试时间 from Score a  ,Subject b where a.SubjectId = b.SubjectId and a.Sno = " + UserHelper.loginId;

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

            }
            finally
            {

                DBHelper.connection.Close();

            }
        }
    }
}

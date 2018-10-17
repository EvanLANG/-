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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void txtSearch_Click(object sender, EventArgs e)
        {
            string no = this.textSno .Text ;
            dataGridView1.DataSource = bindingSource1;

            string strsql = "select * from student_info where sno = '"+no+"'";

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

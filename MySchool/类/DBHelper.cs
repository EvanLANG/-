using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MySchool
{
    // ������ݿ������ַ��������ݿ����Ӷ���
    class DBHelper
    {
        // ���ݿ������ַ���        
        public static string connectionString = "Server=LANG-VAIO;Database=OnlineExam;Trusted_Connection=SSPI";
        // ���ݿ����Ӷ���
        public static SqlConnection connection = new SqlConnection(connectionString);
    }
}

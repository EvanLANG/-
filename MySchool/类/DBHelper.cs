using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MySchool
{
    // 存放数据库连接字符串和数据库连接对象
    class DBHelper
    {
        // 数据库连接字符串        
        public static string connectionString = "Server=LANG-VAIO;Database=OnlineExam;Trusted_Connection=SSPI";
        // 数据库连接对象
        public static SqlConnection connection = new SqlConnection(connectionString);
    }
}

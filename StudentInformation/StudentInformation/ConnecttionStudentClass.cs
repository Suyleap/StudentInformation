using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentInformation
{
    class ConnecttionStudentClass
    {
        public string SQL;
        public System.Data.SqlClient.SqlConnection CON;
        public System.Data.SqlClient.SqlCommand CMD;
        public System.Data.SqlClient.SqlDataReader READER;

       public ConnecttionStudentClass()
        { }

        public String SQLs
        {
            get { return SQL; }
            set { SQL = value; }
        }

        public void   connection() 
        {
            try
            {
                CON = new System.Data.SqlClient.SqlConnection();
                SQL = "Server=SHIWU;Database=Student;User ID=ShiwuNi;Password=ShiwuNi016851518";
                CON.ConnectionString = SQL;
                CON.Open();
                Console.WriteLine("connection open");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public object  UseDataBase(string sql)
        {
            try
            {
                connection();
                SQLs = sql;
                CMD = new SqlCommand(SQLs);
                CMD.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return CMD;
        }

        public object  UseDatabaseToRead(string sql)
        {
            try
            {
                connection();
                SQLs = sql;
                CMD = new SqlCommand(SQLs);
                READER = CMD.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return READER;
        }
    }
}

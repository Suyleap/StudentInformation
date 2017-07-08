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

        public void connection()
        { 
            CON=new System.Data.SqlClient.SqlConnection();
            String LeapSQL = "Server=SHIWU;Database=Student;User ID=ShiwuNi;Password=ShiwuNi016851518";
            String DySQL = "Server=ADMINRG-6O4VBOP\\BONGDYSERVER;Database=StudentInfo;User ID=sa;Password=Pl3chbataii";

            try
            {
                CON.ConnectionString = LeapSQL;
                CON.Open();
                SQL = LeapSQL;
            }
            catch
            {
                CON.ConnectionString = DySQL;
                CON.Open();
                SQL = DySQL;
            }
            Console.WriteLine("connection open");
        }

        public object  UseDataBase(string sql)
        {
            this.connection();
            SQLs = sql;
            CMD = new SqlCommand(SQL);
            CMD.ExecuteNonQuery();
            return CMD;
        }

        public object  UseDatabaseToRead(string sql)
        {
            this.connection();
            SQL = sql;
            CMD=new SqlCommand (SQL );
            READER = CMD.ExecuteReader();
            return READER;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms ;
using System.Data.SqlClient;

namespace StudentInformation
{
    class StuInfo
    {
  
        private ConnecttionStudentClass con =new ConnecttionStudentClass ();
        public string ID,NAME,ADDRESS;
        public int AGE;

        public string IDs
        {
            get { return ID; }
            set { ID = value; }
        }
        
        public string NAMEs 
        {
            get { return NAME; }
            set { NAME = value; }
        }

        public int  AGEs
        {
            get { return AGE ; }
            set { AGE  = value; }
        }

        public string ADDRESSs
        {
            get { return ADDRESS ; }
            set { ADDRESS  = value; }
        }

        public StuInfo()
        {
        }

        public StuInfo(string id, string name, int age, string address)
        {
            this.ID = id;
            this.NAME = name;
            this.AGE = age;
            this.ADDRESS = address;
        }
        public object ShowStudentInfor()
        {
            BindingSource bs= new BindingSource ();
            StuInfo stu ;
            List<StuInfo> stus =new List<StuInfo>();
            try
            {
                con.SQLs = "SELECT * FROM tbStuInfo";
                con.UseDatabaseToRead(con.SQLs);
                while  (con.READER.Read() )
                {
                    //stu = new StuInfo(con.READER.GetString(0), con.READER.GetString(1), con.READER.GetInt16(2), con.READER.GetString(3));
                   // stu = new StuInfo(con.READER.GetValue(0).ToString(), con.READER.GetValue(1).ToString(), con.READER.GetValue(2).ToString(), con.READER.GetValue(3).ToString());
                    ID = con.READER.GetValue(0).ToString();
                    NAME = con.READER.GetValue(1).ToString();
                    AGE =Convert.ToInt16 ( con.READER.GetValue(2));
                    ADDRESS = con.READER.GetValue(3).ToString();
                    stu = new StuInfo(ID, NAME, AGE, ADDRESS);
                    stus.Add(stu);
                    bs.DataSource = stus;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return bs;
        }
    }
}

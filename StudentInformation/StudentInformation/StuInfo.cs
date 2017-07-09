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
                    ID = con.READER.GetValue(0).ToString();
                    NAME = con.READER.GetValue(1).ToString();
                    AGE =Convert.ToInt16 ( con.READER.GetValue(2));
                    ADDRESS = con.READER.GetValue(3).ToString();
                    stu = new StuInfo(ID, NAME, AGE, ADDRESS);
                    stus.Add(stu);
                    bs.DataSource = stus;
                }
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return bs;
        }
        public void InsertData(string id,string name,int age,string address)
        {
            try
            {
                con.SQLs = "Insert into tbStuInfo values('" + id.ToString() + "','" + name.ToString() + "'," + Convert.ToInt16(age) + ",'" + address.ToString() + "')";
                con.UseDataBase(con.SQLs);
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

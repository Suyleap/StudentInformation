using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentInformation
{
    class StuInfo
    {
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

        public string AGEs
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
    }
}

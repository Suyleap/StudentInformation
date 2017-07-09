using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {

        private StuInfo stu = new StuInfo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                dgvStudent.DataSource = stu.ShowStudentInfor();
                this.Refresh();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = stu.ShowStudentInfor();
            this.Refresh();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            stu.InsertData(txtID.Text, txtName.Text, Convert.ToInt16( txtAge.Text), txtAddress.Text);
            this.Refresh();
        }
    }
}

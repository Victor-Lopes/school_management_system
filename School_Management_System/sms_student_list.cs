using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class sms_student_list : Form
    {
        public sms_student_list()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sms_create_student sms = new sms_create_student();
            sms.TopMost = true;
            sms.Show();
        }

        private void lbl_row_Click(object sender, EventArgs e)
        {

        }

        private void sms_student_list_Load(object sender, EventArgs e)
        {

        }
    }
}

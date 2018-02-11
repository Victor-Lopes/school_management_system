using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Form;
namespace School_Management_System
{
    public partial class sms_examination : Design.Controls.MdiForm
    {
        public sms_examination()
        {
            InitializeComponent();
        }

        private void toolStripbtnsave_Click(object sender, EventArgs e)
        {
            sms_setExamination sms = new sms_setExamination();
            sms.ShowDialog();
        }
    }
}

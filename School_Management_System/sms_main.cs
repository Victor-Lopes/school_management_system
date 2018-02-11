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
    public partial class sms_main : Design.Controls.MdiForm
    {
        public sms_main()
        {
            InitializeComponent();
        }

        private void sms_main_Load(object sender, EventArgs e)
        {

        }

       
        private void showForm(Form sms)
        {
            sms.TopLevel = false;
            sms.AutoScroll = true;
            sms.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sms.WindowState = FormWindowState.Maximized;
            sms_dashboard_v2 dash = new sms_dashboard_v2();
            //dash.panelFrom.Controls.Clear();
            //dash.panelFrom.Controls.Add(sms);
            sms.Show();

        }
       
    }
}

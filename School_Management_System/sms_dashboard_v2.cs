using School_Management_System.Properties;
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
    public partial class sms_dashboard_v2 : Design.Controls.Form
    {
        public sms_dashboard_v2()
        {
            InitializeComponent();

            lbuser.Text = Settings.Default.StaffName;
            lbposition.Text = Settings.Default.Position;
            this.WindowState = FormWindowState.Maximized;

            if (lbuser.Text == "owner" || lbuser.Text == "Owner")
            {
                securityToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                schoolsToolStripMenuItem.Visible = false;
                branchOfSchoolsToolStripMenuItem.Visible = false;
            }
            else if (lbuser.Text == "account" || lbuser.Text == "Account")
            {
                settingToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                securityToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                staffToolStripMenuItem.Visible = false;
                schoolsToolStripMenuItem.Visible = false;
                branchOfSchoolsToolStripMenuItem.Visible = false;
            }
            else if (lbuser.Text == "cashier" || lbuser.Text == "Cashier")
            {
                settingToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                staffToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                teacherToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                schoolsToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                securityToolStripMenuItem.Visible = false;//disables save as menu item in file menu list
                staffToolStripMenuItem.Visible = false;
                schoolsToolStripMenuItem.Visible = false;
                branchOfSchoolsToolStripMenuItem.Visible = false;
            }
        }
        
        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_create_staff sms = new sms_create_staff();
            showForm(sms);
        }

        private void staffListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_staff_list sms = new sms_staff_list();
            showForm(sms);
        }

        private void searchStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void showForm(Form sms)
        {            
            sms.TopLevel = false;
            sms.AutoScroll = true;
            sms.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sms.WindowState = FormWindowState.Maximized;
            this.panelFrom.Controls.Clear();
            this.panelFrom.Controls.Add(sms);
            sms.Show();
        
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_create_teacher sms = new sms_create_teacher();
            showForm(sms);
        }

        private void listsTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_teacher_list sms = new sms_teacher_list();
            showForm(sms);
        }

        private void newStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_create_student sms = new sms_create_student();
            showForm(sms);
        }

        private void listStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_student_list sms = new sms_student_list();
            showForm(sms);
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_payment sms = new sms_payment();
            showForm(sms);
        }

        private void listsPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_payment_list sms = new sms_payment_list();
            showForm(sms);
        }

        private void staffsAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_staff_attendence sms = new sms_staff_attendence();
            showForm(sms);
        }

        private void teacherAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_teacher_attendance sms = new sms_teacher_attendance();
            showForm(sms);
        }

        private void studentsAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_student_attendence sms = new sms_student_attendence();
            showForm(sms);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_user_account sms = new sms_user_account();
            showForm(sms);
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_user_permission sms = new sms_user_permission();
            showForm(sms);
        }

        private void schoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_school sms = new sms_school();
            showForm(sms);
        }

        private void branchOfSchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_branch_school sms = new sms_branch_school();
            showForm(sms);
        }

        private void yearOfSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_year_school sms = new sms_year_school();
            showForm(sms);
        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_addclassandsection sms = new sms_addclassandsection();
            showForm(sms);
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_subject sms = new sms_subject();
            showForm(sms);
        }

        private void examinationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            sms_login sms = new sms_login();
            this.Hide();
            sms.ShowDialog();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_about sms = new sms_about();
            sms.StartPosition = FormStartPosition.CenterScreen;
            sms.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            sms.ShowDialog();
        }

        private void aboutSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_help sms = new sms_help();
            sms.StartPosition = FormStartPosition.CenterScreen;
            sms.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            sms.ShowDialog();
        }

        private void sms_dashboard_v2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbdate.Text = DateTime.Now.ToString("dd - MMM - yyyy");
            lbtime.Text = DateTime.Now.ToString("hh : mm : ss tt");

            //sms_main sms = new sms_main();
            //showForm(sms);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToString("dd - MMM - yyyy");
            lbtime.Text = DateTime.Now.ToString("hh : mm : ss  tt");
        }

        private void examinationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void examResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_setexamgrade sms = new sms_setexamgrade();
            showForm(sms);
        }

        private void listsGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_grade_list sms = new sms_grade_list();
            showForm(sms);
        }

        private void levelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sms_level sms = new sms_level();
            showForm(sms);
        }

        private void listsLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_level_list sms = new sms_level_list();
            showForm(sms);
        }

        private void enrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_enroll sms = new sms_enroll();
            showForm(sms);
        }

        private void staffReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_staff_report sms = new sms_staff_report();
            showForm(sms);
        }

        private void teacherReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_teacher_report sms = new sms_teacher_report();
            showForm(sms);
        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_student_report sms = new sms_student_report();
            showForm(sms);
        }

        private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_payment_report sms = new sms_payment_report();
            showForm(sms);
        }

        private void staffAttendenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_staff_attendance_report sms = new sms_staff_attendance_report();
            showForm(sms);
        }

        private void teacherAttendenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_teacher_attendance_report sms = new sms_teacher_attendance_report();
            showForm(sms);
        }

        private void studentAttendenceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_student_attendance_report sms = new sms_student_attendance_report();
            showForm(sms);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_main sms = new sms_main();
            showForm(sms);
        }

        private void examinationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sms_examination sms = new sms_examination();
            showForm(sms);
        }

        private void examResultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sms_examresult sms = new sms_examresult();
            showForm(sms);
        }

        private void panelstaff_MouseClick(object sender, MouseEventArgs e)
        {
            sms_create_staff sms = new sms_create_staff();
            showForm(sms);
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_setexamgrade sms = new sms_setexamgrade();
            showForm(sms);
        }
        

       

    }
}

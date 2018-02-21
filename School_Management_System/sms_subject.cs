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
    public partial class sms_subject :Design.Controls.MdiForm
    {
        sch_operation op = new sch_operation();
        string status;
        string subjectid;
        string sql;
        int k;
        public sms_subject(string _status,string _subjectid)
        {
            InitializeComponent();
            status = _status;
            subjectid = _subjectid;
        }

        private void sms_subject_Load(object sender, EventArgs e)
        {
            if (status == "old")
            {

                enabledControls(true);
                clearControls();
                displayrecords(subjectid);
            }
            else
            {
                enabledControls(false);
            }
            
        }

        private void displayrecords(string subjectid)
        {
            try
            {
                op.setConnection();
                //sql = "select [firstname_en],[lastname_en] ,[firstname_kh],[lastname_kh] ,[gender] ,[birthdate],[nationality]"+
                //      ",[education_level],[position],[salary],[email],[phone],[father_name],[father_position],[father_phone]"+
                //      ",[mother_name],[mother_position],[mother_phone],[home],[village] ,[district],[division],[city],[active]"+
                //      ",[description] from sch_tblstaff where staff_code='" + staffcode + "'";
                sql = "select Subject_Name,Description from sch_v_subject where Subject_ID='" + subjectid + "'";
                op.displayRecord(sql,txtsubject_name.textBox1,txtdescription.textBox1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            clearControls();
            enabledControls(true);
            status = "new";
        }       
        
        private void searchButtonBoxClass_ButtonSeachClick(object sender, EventArgs e)
        {
            searchButtonBoxClass.SQL = "select room_id as [Room ID],room_num as [Room Name],description as Description from sch_tblroom where islocked=1";
            searchButtonBoxClass.setDataSource(searchButtonBoxClass.SQL);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            int optionl;
            op.setConnection();
            errorProvider1.Clear();
            bool chk = op.checkEmpty(errorProvider1,txtdescription.textBox1,txtsubject_name.textBox1);
            if (chk == true) return;
            if(rdono.Checked == true && rdoyes.Checked == false) optionl=0;
            else optionl=1;
            try
            {
                if (status == "new")
                {
                    k = 0;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblsubject";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("subject_id", "");
                    op.sqlcmd.Parameters.AddWithValue("subject_name", txtsubject_name.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("optional_subject", optionl);
                    op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("query", "insert");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();
                }
                else
                {
                    k = 1;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblsubject";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("subject_id", subjectid);
                    op.sqlcmd.Parameters.AddWithValue("subject_name",txtsubject_name.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("optional_subject", optionl);
                    op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("query", "update");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();                   
                }
                if (k == 0)
                    MessageBox.Show("Subject has been created successfully");
                else
                    MessageBox.Show("Subject has been updated successfully");
                clearControls();
                enabledControls(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commit Exception Type: " + ex.GetType(), "Commit Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("  Message: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
        void clearControls()
        {
            txtsubject_name.textBox1.Clear();
            txtdescription.textBox1.Clear();
        }

        private void enabledControls(bool b)
        {
            txtsubject_name.textBox1.Enabled = b;
            txtdescription.textBox1.Enabled = b;
        }

    }
}

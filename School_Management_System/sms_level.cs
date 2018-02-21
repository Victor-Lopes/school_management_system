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
    public partial class sms_level : Design.Controls.MdiForm
    {
        sch_operation op = new sch_operation();
        string status;
        int k;
        public sms_level()
        {
            InitializeComponent();
        }

        private void sms_level_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            int optionl;
            op.setConnection();
            errorProvider1.Clear();
            bool chk = op.checkEmpty(errorProvider1,cbobranchname.comboBox1,txtlevelname.textBox1,txtstarttime.textBox1,txtendtime.textBox1);
            if (chk == true) return;
            else optionl=1;
            try
            {
                if (status == "new")
                {
                    //k = 0;
                    //op.sqlcmd = op.sqlcon.CreateCommand();
                    //op.sqlcmd.CommandText = "sp_sch_tblsubject";
                    //op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    //op.sqlcmd.Parameters.AddWithValue("subject_id", "");
                    //op.sqlcmd.Parameters.AddWithValue("subject_name", txtsubject_name.textBox1.Text);
                    //op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    //op.sqlcmd.Parameters.AddWithValue("optional_subject", optionl);
                    //op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    //op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    //op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    //op.sqlcmd.Parameters.AddWithValue("query", "insert");
                    //op.sqlcmd.ExecuteNonQuery();
                    //op.sqlcon.Close();
                }
                else
                {
                    //k = 1;
                    //op.sqlcmd = op.sqlcon.CreateCommand();
                    //op.sqlcmd.CommandText = "sp_sch_tblsubject";
                    //op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    //op.sqlcmd.Parameters.AddWithValue("subject_id", subjectid);
                    //op.sqlcmd.Parameters.AddWithValue("subject_name",txtsubject_name.textBox1.Text);
                    //op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    //op.sqlcmd.Parameters.AddWithValue("optional_subject", optionl);
                    //op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    //op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    //op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    //op.sqlcmd.Parameters.AddWithValue("query", "update");
                    //op.sqlcmd.ExecuteNonQuery();
                    //op.sqlcon.Close();                   
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

        private void enabledControls(bool b)
        {
            throw new NotImplementedException();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void clearControls() 
        {
            cbobranchname.comboBox1.Items.Clear();
            txtlevelname.textBox1.Clear();
            txtstarttime.textBox1.Clear();
            txtendtime.textBox1.Clear();
        }
    }
}

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
    public partial class sms_year_school : Design.Controls.MdiForm
    {
        sch_operation op = new sch_operation();
        string status;
        int k;

        public sms_year_school()
        {
            InitializeComponent();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            txtyear.textBox1.Clear();
            status = "new";
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            op.setConnection();
            errorProvider1.Clear();
            bool chk = op.checkEmpty(errorProvider1,
                txtyear.textBox1);
            if (chk == true) return;
           
            try
            {
                if (status == "new")
                {
                    k = 0;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblyear";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("year_id", "null");
                    op.sqlcmd.Parameters.AddWithValue("year", txtyear.textBox1.Text);
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
                    op.sqlcmd.CommandText = "sp_sch_tblyear";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("year_id", "null");
                    op.sqlcmd.Parameters.AddWithValue("year", txtyear.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("query", "update");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commit Exception Type: " + ex.GetType(), "Commit Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("  Message: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (k == 0)
                    MessageBox.Show("School year has been created successfully");
                else
                    MessageBox.Show("School year has been updated successfully");
            }
        }
    }
}

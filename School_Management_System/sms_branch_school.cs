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
    public partial class sms_branch_school : Design.Controls.MdiForm
    {
        sch_operation op = new sch_operation();
        int k;
        string sql;
        string status;
        public sms_branch_school()
        {
            InitializeComponent();
        }

        void clearControls() {
           
            txtbranchname.textBox1.Clear();
            txtphonenumber.textBox1.Clear();
            txtaddress.Clear();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            clearControls();
            status = "new";
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            op.setConnection();
            errorProvider1.Clear();
            bool chk = op.checkEmpty(errorProvider1,
                cboschoolname.comboBox1,
                txtbranchname.textBox1,
                txtphonenumber.textBox1);
            if (chk == true) return;
           
            try
            {
                if (status == "new")
                {
                    k = 0;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblbranch";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("branch_id", "null");
                    op.sqlcmd.Parameters.AddWithValue("branch_name", txtbranchname.textBox1.Text );
                    op.sqlcmd.Parameters.AddWithValue("school_id", cboschoolname.comboBox1.SelectedValue);
                    op.sqlcmd.Parameters.AddWithValue("phonenumber", txtphonenumber.textBox1.Text );
                    op.sqlcmd.Parameters.AddWithValue("address", txtaddress.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by",Settings.Default.StaffID.ToString());
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
                    op.sqlcmd.CommandText = "sp_sch_tblbranch";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("branch_id", "null");
                    op.sqlcmd.Parameters.AddWithValue("branch_name", txtbranchname.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("school_id", cboschoolname.comboBox1.SelectedValue);
                    op.sqlcmd.Parameters.AddWithValue("phonenumber", txtphonenumber.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("address", txtaddress.Text);
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
                    MessageBox.Show("School Branch has been created successfully");
                else
                    MessageBox.Show("School Branch has been updated successfully");
                clearControls();
                //enabledControls(false);
            }
        }

        private void sms_branch_school_Load(object sender, EventArgs e)
        {
                string sql = "select school_code,school_name_en from sch_tblschool";
                op.bindComboBox(cboschoolname.comboBox1, sql, "school_name_en", "school_code");
                dataGridView1.RowTemplate.Height = 30;
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            try
            {
                sql = "select * from sch_v_branch";
                op.bindGridView(dataGridView1, sql);
                op.autoSizeModeDataGrind(dataGridView1);
                dataGridView1.RowTemplate.Height = 30;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

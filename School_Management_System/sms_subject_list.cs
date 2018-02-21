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
    public partial class sms_subject_list : Form
    {
        sch_operation op = new sch_operation();
        string sql;
        string items;
        string subjectid;
        public sms_subject_list()
        {
            InitializeComponent();
        }

        private void sms_subject_list_Load(object sender, EventArgs e)
        {
            refreshData();
            sch_operation.bindComboBoxFilter(dataGridView1, cbosearch_by);
            cbosearch_by.SelectedIndex = 0;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCyan;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        public void refreshData()
        {
            try
            {
                cboItems.SelectedIndex = 1;
                sql = "select top " + items + " * from sch_v_subject order by Hired_Date";
                op.bindGridView(dataGridView1, sql);
                op.autoSizeModeDataGrind(dataGridView1);
                lb_rows.Text = "Showing : " + dataGridView1.RowCount.ToString() + " entries";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            items = cboItems.Text;
            try
            {
                if (items == "All")
                {
                    sql = "select * from sch_v_subject order by Hired_Date";
                }
                else
                {
                    sql = "select top " + items + " * from sch_v_subject order by Hired_Date";
                }

                op.bindGridView(dataGridView1, sql);
                op.autoSizeModeDataGrind(dataGridView1);
                lb_rows.Text = "Showing : " + dataGridView1.RowCount.ToString() + " entries";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (cbosearch_by.SelectedItem == null)
            {
                txtsearch.ReadOnly = true;
                MessageBox.Show("Please select a search item");
            }
            else
            {
                try
                {
                    ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                                 cbosearch_by.Text.Trim(), txtsearch.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnnew_subject_Click(object sender, EventArgs e)
        {
            sms_subject subject = new sms_subject("new","");
            subject.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                subjectid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            }
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sms_subject subject = new sms_subject("old", subjectid);
            subject.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

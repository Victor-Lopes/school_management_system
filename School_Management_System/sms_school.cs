using School_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Form;
namespace School_Management_System
{
    public partial class sms_school : Design.Controls.MdiForm
    {
        sch_operation op = new sch_operation();
        string sql;
        string status;
        string schoolcode;
        string fp;
        byte[] binpic;
        MemoryStream ms;
        int k;
        public sms_school()
        {
            InitializeComponent();
        }

        private void sms_school_Load(object sender, EventArgs e)
        {
            enabledControls(false);
            clearControls();
            refreshData();
            
        }
        public void refreshData()
        {
            try
            {
                sql = "select * from sch_v_school";
                op.bindGridView(dataGridView1, sql);
                op.autoSizeModeDataGrind(dataGridView1);
                dataGridView1.RowTemplate.Height = 50;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        break;
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            enabledControls(true);
            clearControls();
            Font font = new Font("Khmer OS Siemreap", 10.0f);
            txtschool_name_kh.textBox1.Font = font;
            status = "new";
            schoolcode = "";
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            op.setConnection();
            errorProvider1.Clear();
            bool chk = op.checkEmpty(errorProvider1,
                txtschool_name_en.textBox1,
                txtschool_name_kh.textBox1);
            if (chk == true) return;
            if (fp == null)
            {
                fp = Path.GetDirectoryName(Application.ExecutablePath);
                fp = fp + "/user.png";
            }
            binpic = System.IO.File.ReadAllBytes(fp);
            ms = new MemoryStream(binpic);
            picureBrowers1.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            picureBrowers1.pictureBox1.Image = Image.FromStream(ms);
            try
            {
                if (status == "new")
                {
                    k = 0;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblschool";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("school_code", "NULL");
                    op.sqlcmd.Parameters.AddWithValue("school_name_en", txtschool_name_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("school_name_kh", txtschool_name_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("photo", binpic);
                    op.sqlcmd.Parameters.AddWithValue("query", "insert");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();
                }
                else
                {
                    k = 1;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblschool";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("school_code", schoolcode);
                    op.sqlcmd.Parameters.AddWithValue("school_name_en", txtschool_name_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("school_name_kh", txtschool_name_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by", Settings.Default.StaffID.ToString());
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("photo", binpic);
                    op.sqlcmd.Parameters.AddWithValue("query", "update");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Commit Exception Type: " + ex.GetType(), "Commit Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("  Message: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (k == 0)
                    MessageBox.Show("School has been created successfully");
                else
                    MessageBox.Show("School has been updated successfully");
                clearControls();
                enabledControls(false);
            }
        }

        private void enabledControls(bool b)
        {
            txtschool_name_kh.textBox1.Enabled = b;
            txtschool_name_en.textBox1.Enabled = b;
        }

        private void clearControls()
        {
            txtschool_name_kh.textBox1.Clear();
            txtschool_name_en.textBox1.Clear();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                clearControls();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                refreshData();
            }catch(Exception ex){}
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            clearControls();
            enabledControls(false);
        }

        private void picureBrowers1_ButtonBrows(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All File|*.*|BMP FILE| *.bmp|JPEG FILE| *.jpg; *.jpeg|PNG FILE| *.png";
            fd.Title = "Open an image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                if (fp == null)
                {
                    fp = Path.GetDirectoryName(Application.ExecutablePath);
                    fp = fp + "/user.png";
                }
                binpic = System.IO.File.ReadAllBytes(fp);
                ms = new MemoryStream(binpic);
                picureBrowers1.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                picureBrowers1.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void txtschool_name_kh_Enter(object sender, EventArgs e)
        {
            op.Set2Kh();
            Font font = new Font("Khmer OS Siemreap", 10.0f);
            txtschool_name_kh.textBox1.Font = font;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            enabledControls(true);
            status = "old";
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                schoolcode = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtschool_name_en.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                txtschool_name_kh.textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            refreshData();
        }
    }
}

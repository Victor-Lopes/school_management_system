using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Form;
namespace School_Management_System
{
    public partial class sms_create_staff : Design.Controls.MdiForm
    {
        School_Management_System.sch_operation op = new sch_operation();
        string status;
        string staffcode;
        string sql;
        string fp;
        byte[] binpic;
        MemoryStream ms;
        int k;
        public sms_create_staff(string status,string staffcode)
        {
            InitializeComponent();
            this.status = status;
            this.staffcode = staffcode;
        }

        private void sms_create_staff_Load(object sender, EventArgs e)
        {
            if (status == "old")
            {
                comboBoxControl();
                displayrecords(staffcode);
                enabledControls(true);
                
            }
            else
            {
                enabledControls(false);
            }
        }

        private void displayrecords(string staffcode)
        {
            try
            {
                op.setConnection();
                //sql = "select [firstname_en],[lastname_en] ,[firstname_kh],[lastname_kh] ,[gender] ,[birthdate],[nationality]"+
                //      ",[education_level],[position],[salary],[email],[phone],[father_name],[father_position],[father_phone]"+
                //      ",[mother_name],[mother_position],[mother_phone],[home],[village] ,[district],[division],[city],[active]"+
                //      ",[description] from sch_tblstaff where staff_code='" + staffcode + "'";
                sql = "select *from sch_tblstaff where staff_code='" + staffcode + "'";
                op.displayRecord(sql, txtfirstname_en.textBox1, txtfirstname_en.textBox1, txtfirstname_en.textBox1, txtlastname_en.textBox1, txtfirstname_kh.textBox1, txtlastname_kh.textBox1, cbogender.comboBox1, dtpbod.dateTimePicker1, txtnationality.textBox1,
                    txteducation_level.textBox1, cboposition.comboBox1, txtsalary.textBox1, txtemail.textBox1, txtphone.textBox1, txtfathername.textBox1, txtfather_position.textBox1, txtfather_phone.textBox1,
                    txtmothername.textBox1, txtmother_position.textBox1, txtmother_phone.textBox1, txthome.textBox1, cbovillage.textBoxLabel1.textBox1, cbodistrict.textBoxLabel1.textBox1,
                    cbodivision.textBoxLabel1.textBox1, cbocity.textBoxLabel1.textBox1, cbostatus.comboBox1, txtdescription.textBox1);

                if (cbogender.comboBox1.Text == "Female")
                    cbogender.comboBox1.SelectedIndex = 0;
                else
                    cbogender.comboBox1.SelectedIndex = 1;

                if (cbostatus.comboBox1.Text == "1")
                    cbostatus.comboBox1.SelectedIndex = 0;
                else if (cbostatus.comboBox1.Text == "2")
                    cbostatus.comboBox1.SelectedIndex = 1;
                else
                    cbostatus.comboBox1.SelectedIndex = 2;
                sql = "select * from sch_v_education where Education = '" + staffcode + "'";
                dataGridView1.Columns.Clear();
                op.bindGridView(dataGridView1, sql);
                dataGridView1.Columns[0].Visible = false;
                sql = "select photo from sch_tblphoto where photocode = '" + staffcode + "'";
                op.sqlcmd = new SqlCommand(sql, op.sqlcon);
                binpic = (byte[])op.sqlcmd.ExecuteScalar();
                if (binpic == null)
                {
                    fp = Path.GetDirectoryName(Application.ExecutablePath);
                    fp = fp + "/user.png";
                    binpic = System.IO.File.ReadAllBytes(fp);
                }
                ms = new MemoryStream(binpic);
                picureBrowers1.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                picureBrowers1.pictureBox1.Image = Image.FromStream(ms);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Photo : " + ex.Message);
            }
            finally 
            {
                Font font = new Font("Khmer OS Siemreap", 10.0f);
                txtfirstname_kh.textBox1.Font = font;
                txtlastname_kh.textBox1.Font = font; 
            }
        }

        public void comboBoxControl() 
        {
            cbogender.comboBox1.Items.Clear();
            cboposition.comboBox1.Items.Clear();
            cbostatus.comboBox1.Items.Clear();

            cbogender.comboBox1.Items.Add("Female");
            cbogender.comboBox1.Items.Add("Male");

            cboposition.comboBox1.Items.Add("Manager");
            cboposition.comboBox1.Items.Add("Staff");
            cboposition.comboBox1.Items.Add("Cashier");

            cbostatus.comboBox1.Items.Add("Start");
            cbostatus.comboBox1.Items.Add("Stop");
            cbostatus.comboBox1.Items.Add("Working");
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            status = "New";
            clearControls();
            enabledControls(true);
            comboBoxControl();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {            
            op.setConnection();
            errorProvider1.Clear();
            int active = 0;
            bool chk = op.checkEmpty(errorProvider1, 
                txtfirstname_en.textBox1, 
                txtlastname_en.textBox1,
                txtfirstname_kh.textBox1,
                txtlastname_kh.textBox1,
                cbogender.comboBox1,
                dtpbod.dateTimePicker1,
                txtnationality.textBox1,
                txteducation_level.textBox1,
                cboposition.comboBox1,
                txtsalary.textBox1,
                txtphone.textBox1,
                txtfathername.textBox1,
                txtmothername.textBox1,
                cbostatus.comboBox1);
            if (chk == true) return;
            if (cbostatus.comboBox1.Text == "Start")
                active = 1;
            else if (cbostatus.comboBox1.Text == "Stop")
                active = 0;
            else
                active = 2;
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
                if (status == "New")
                {
                    k=0;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblstaff";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("staff_code", "NULL");
                    op.sqlcmd.Parameters.AddWithValue("firstname_en", txtfirstname_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("lastname_en", txtlastname_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("firstname_kh", txtfirstname_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("lastname_kh", txtlastname_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("gender", cbogender.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("birthdate", dtpbod.dateTimePicker1.Text.ToString());
                    op.sqlcmd.Parameters.AddWithValue("nationality", txtnationality.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("education_level", txteducation_level.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("position", cboposition.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("salary", txtsalary.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("email", txtemail.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("phone", txtphone.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("father_name", txtfathername.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("father_position", txtfather_position.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("father_phone", txtfather_phone.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("mother_name", txtmothername.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("mother_position", txtmother_position.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("mother_phone", txtmother_phone.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("home", txthome.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("village", cbovillage.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("district", cbodistrict.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("division", cbodivision.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("city", cbocity.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("active", active);
                    op.sqlcmd.Parameters.AddWithValue("photo", binpic);
                    op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by", "null");
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("query", "insert");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();

                    op.setConnection();
                    for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        op.sqlcmd = op.sqlcon.CreateCommand();
                        op.sqlcmd.CommandText = "sp_sch_tbleducation";
                        op.sqlcmd.CommandType = CommandType.StoredProcedure;
                        op.sqlcmd.Parameters.AddWithValue("foreign_key", "code");
                        op.sqlcmd.Parameters.AddWithValue("education_name", dataGridView1.Rows[i].Cells[0].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("startyear", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("endyear", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("description", dataGridView1.Rows[i].Cells[3].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("query", "insert");
                        op.sqlcmd.ExecuteNonQuery();

                    }                   
                    op.sqlcon.Close();                    
                }
                else
                {
                    k=1;
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblstaff";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("staff_code", staffcode);
                    op.sqlcmd.Parameters.AddWithValue("firstname_en", txtfirstname_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("lastname_en", txtlastname_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("firstname_kh", txtfirstname_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("lastname_kh", txtlastname_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("gender", cbogender.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("birthdate", dtpbod.dateTimePicker1.Text.ToString());
                    op.sqlcmd.Parameters.AddWithValue("nationality", txtnationality.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("education_level", txteducation_level.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("position", cboposition.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("salary", txtsalary.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("email", txtemail.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("phone", txtphone.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("father_name", txtfathername.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("father_position", txtfather_position.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("father_phone", txtfather_phone.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("mother_name", txtmothername.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("mother_position", txtmother_position.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("mother_phone", txtmother_phone.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("home", txthome.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("village", cbovillage.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("district", cbodistrict.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("division", cbodivision.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("city", cbocity.textBoxLabel1.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("active", active);
                    op.sqlcmd.Parameters.AddWithValue("photo", binpic);
                    op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by", "" );
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("updated_at", DateTime.Now.ToString());
                    op.sqlcmd.Parameters.AddWithValue("query", "update");
                    op.sqlcmd.ExecuteNonQuery();
                    op.sqlcon.Close();

                    op.setConnection();
                    for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        op.sqlcmd = op.sqlcon.CreateCommand();
                        op.sqlcmd.CommandText = "sp_sch_tbleducation";
                        op.sqlcmd.CommandType = CommandType.StoredProcedure;
                        op.sqlcmd.Parameters.AddWithValue("foreign_key", staffcode);
                        op.sqlcmd.Parameters.AddWithValue("education_name", dataGridView1.Rows[i].Cells[0].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("startyear", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("endyear", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("description", dataGridView1.Rows[i].Cells[3].Value.ToString());
                        op.sqlcmd.Parameters.AddWithValue("query", "update");
                        op.sqlcmd.ExecuteNonQuery();
                    }                    
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
                if(k == 0)
                    MessageBox.Show("Staff has been created successfully");
                else
                    MessageBox.Show("Staff has been updated successfully");
                clearControls();
                enabledControls(false);
            }
            
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

        // method for enable or disenable controls
        // example true = enable and false = disenable
        void enabledControls(bool b)
        {
            txtfirstname_en.textBox1.Enabled = b;
            txtlastname_en.textBox1.Enabled = b;
            txtfirstname_kh.textBox1.Enabled = b;
            txtlastname_kh.textBox1.Enabled = b;
            dtpbod.dateTimePicker1.Enabled = b;
            txtnationality.textBox1.Enabled = b;
            txteducation_level.textBox1.Enabled = b;
            txtemail.textBox1.Enabled = b;
            txtphone.textBox1.Enabled = b;
            txtdescription.textBox1.Enabled = b;

            cbocity.textBoxLabel1.textBox1.Enabled = b;
            cbodivision.textBoxLabel1.textBox1.Enabled = b;
            cbodistrict.textBoxLabel1.textBox1.Enabled = b;
            cbovillage.textBoxLabel1.textBox1.Enabled = b;
            txthome.textBox1.Enabled = b;

            txtfathername.textBox1.Enabled = b;
            txtfather_position.textBox1.Enabled = b;
            txtfather_phone.textBox1.Enabled = b;
            txtmothername.textBox1.Enabled = b;
            txtmother_position.textBox1.Enabled = b;
            txtmother_phone.textBox1.Enabled = b;
        }
        // method for clear controls
        void clearControls()
        {
            txtfirstname_en.textBox1.Clear();
            txtlastname_en.textBox1.Clear();
            txtfirstname_kh.textBox1.Clear();
            txtlastname_kh.textBox1.Clear();
            txtnationality.textBox1.Clear();
            txteducation_level.textBox1.Clear();
            txtemail.textBox1.Clear();
            txtsalary.textBox1.Clear();
            txtphone.textBox1.Clear();
            txtdescription.textBox1.Clear();

            cbocity.textBoxLabel1.textBox1.Clear();
            cbodivision.textBoxLabel1.textBox1.Clear();
            cbodistrict.textBoxLabel1.textBox1.Clear();
            cbovillage.textBoxLabel1.textBox1.Clear();
            txthome.textBox1.Clear();

            txtfathername.textBox1.Clear();
            txtfather_position.textBox1.Clear();
            txtfather_phone.textBox1.Clear();
            txtmothername.textBox1.Clear();
            txtmother_position.textBox1.Clear();
            txtmother_phone.textBox1.Clear();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            clearControls();
            comboBoxControl();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            clearControls();
            comboBoxControl();
        }

        private void txtfirstname_kh_Enter(object sender, EventArgs e)
        {
            op.Set2Kh();
            Font font = new Font("Khmer OS Siemreap", 10.0f);
            txtfirstname_kh.textBox1.Font = font;
        }

        private void txtlastname_kh_Enter(object sender, EventArgs e)
        {
            op.Set2Kh();
            Font font = new Font("Khmer OS Siemreap", 10.0f);
            txtlastname_kh.textBox1.Font = font;
        }

        private void txtlastname_kh_Leave(object sender, EventArgs e)
        {
            op.Set2En();
            
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
       
    }
}

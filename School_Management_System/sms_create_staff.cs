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
    public partial class sms_create_staff : Design.Controls.MdiForm
    {
        School_Management_System.sch_operation op = new sch_operation();
        string status;
        string fp;
        byte[] binpic;
        MemoryStream ms;
        public sms_create_staff()
        {
            InitializeComponent();
        }

        private void sms_create_staff_Load(object sender, EventArgs e)
        {
            enabledControls(false);
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
            cboposition.comboBox1.Items.Add("Teacher");
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
                txtphone.textBox1,
                txtfathername.textBox1,
                txtmothername.textBox1);
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
                //if (status == "New")
                //{  
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
                    op.sqlcmd.Parameters.AddWithValue("position",cboposition.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("email", txtemail.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("phone",txtphone.textBox1.Text);
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

                    //for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    //{
                    //    op.setConnection();
                    //    op.sqlcmd = op.sqlcon.CreateCommand();
                    //    op.sqlcmd.CommandText = "sp_sch_tbleducation";
                    //    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    //    op.sqlcmd.Parameters.AddWithValue("education_name", dataGridView1.Rows[i].Cells[5].Value);
                    //    op.sqlcmd.Parameters.AddWithValue("start_year", dataGridView1.Rows[i].Cells[2].Value);
                    //    op.sqlcmd.Parameters.AddWithValue("end_year", dataGridView1.Rows[i].Cells[3].Value);
                    //    op.sqlcmd.Parameters.AddWithValue("description", dataGridView1.Rows[i].Cells[4].Value);
                    //    op.sqlcmd.Parameters.AddWithValue("query", "insert");
                    //    op.sqlcmd.ExecuteNonQuery();
                    //    op.sqlcon.Close();
                    //}       

                    MessageBox.Show("Staff has been created successfully");
                    //op.clearControls(panel1);
                //}
                //else
                //{
                    //op.sqlCmd = op.sqlCon.CreateCommand();
                    //op.sqlCmd.CommandText = "sp_pos_customer_update";
                    //op.sqlCmd.CommandType = CommandType.StoredProcedure;
                    //op.sqlCmd.Parameters.AddWithValue("CustomerCode", _code);
                    //op.sqlCmd.Parameters.AddWithValue("CustomerName", _fullname);
                    //op.sqlCmd.Parameters.AddWithValue("Phone", _telephone);
                    //op.sqlCmd.Parameters.AddWithValue("Address", _address);
                    //op.sqlCmd.Parameters.AddWithValue("Updateddate", DateTime.Now);
                    //MessageBox.Show(this, "Customer has been update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //op.clearControls(panel1);
                //}                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commit Exception Type: " + ex.GetType(), "Commit Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("  Message: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    fp = fp + "/pos_logo.png";
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
       
    }
}

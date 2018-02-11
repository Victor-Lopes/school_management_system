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
            op.enabledControls(this, false);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            status = "New";
            op.enabledControls(this, true);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            op.setConnection();
            errorProvider1.Clear();
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
            try
            {
                if (status == "New")
                {  
                    op.sqlcmd = op.sqlcon.CreateCommand();
                    op.sqlcmd.CommandText = "sp_sch_tblstaff";
                    op.sqlcmd.CommandType = CommandType.StoredProcedure;
                    op.sqlcmd.Parameters.AddWithValue("staff_code", "NULL");
                    op.sqlcmd.Parameters.AddWithValue("firstname_en", txtfirstname_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("lastname_en", txtlastname_en.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("firstname_kh", txtfirstname_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("lastname_kh", txtlastname_kh.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("gender", cbogender.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("birthdate", dtpbod.dateTimePicker1.Text);
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
                    op.sqlcmd.Parameters.AddWithValue("active", cbostatus.comboBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("photo", binpic);
                    op.sqlcmd.Parameters.AddWithValue("description", txtdescription.textBox1.Text);
                    op.sqlcmd.Parameters.AddWithValue("created_by", "NULL");
                    op.sqlcmd.Parameters.AddWithValue("created_at", DateTime.Now);
                    op.sqlcmd.Parameters.AddWithValue("updated_at", "NULL");
                    op.sqlcmd.Parameters.AddWithValue("query", "insert");

                    for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        op.setConnection();
                        op.sqlcmd = op.sqlcon.CreateCommand();
                        op.sqlcmd.CommandText = "sp_sch_tbleducation";
                        op.sqlcmd.CommandType = CommandType.StoredProcedure;
                        op.sqlcmd.Parameters.AddWithValue("education_name", dataGridView1.Rows[i].Cells[5].Value);
                        op.sqlcmd.Parameters.AddWithValue("start_year", dataGridView1.Rows[i].Cells[2].Value);
                        op.sqlcmd.Parameters.AddWithValue("end_year", dataGridView1.Rows[i].Cells[3].Value);
                        op.sqlcmd.Parameters.AddWithValue("description", dataGridView1.Rows[i].Cells[4].Value);
                        op.sqlcmd.Parameters.AddWithValue("query", "insert");
                        op.sqlcmd.ExecuteNonQuery();
                        op.sqlcon.Close();
                    }       

                    MessageBox.Show("Staff has been created successfully");
                    op.clearControls(panel1);
                }
                else
                {
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
                }
                op.sqlcmd.ExecuteNonQuery();
                op.sqlcon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Commit Exception Type: " + ex.GetType(), "Commit Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("  Message: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    fp = fp + "/pos_logo.png";
                }
                binpic = System.IO.File.ReadAllBytes(fp);
                ms = new MemoryStream(binpic);
                picureBrowers1.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                picureBrowers1.pictureBox1.Image = Image.FromStream(ms);
            }

        }

       
    }
}

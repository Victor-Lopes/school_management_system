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

namespace School_Management_System
{
    public partial class sms_login : Form
    {
        bool b = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public sms_login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }
             


        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Checks if the user exist 'username' + '.txt' 
            if (!File.Exists(@"C:\SMS\" + txtusername.Text + ".ini"))
            {
                //If not exists the set a error 
                //NOTE: err = errorprovider 
                errorProvider1.SetError(txtusername, "User does not exist"); //sets the error 
            }
            // If it exists 
            else
            {
                //Clear the errors 
                errorProvider1.SetError(txtusername, "");
                errorProvider1.SetError(txtpassword, "");

                //Read the text file 
                TextReader tr = new StreamReader(@"C:\SMS\" + txtusername.Text + ".ini");

                //Read the password wich is stored on the first line 
                string pass = tr.ReadLine();

                //CHecks if the password equal to the password in the textbox 
                if (pass == txtpassword.Text)
                {
                    //If so the show the app and hide this one 
                    Settings.Default.StaffName = txtusername.Text;
                    Settings.Default.Position = txtpassword.Text;
                    Settings.Default.Save();
                    sms_dashboard_v2 sms = new sms_dashboard_v2();
                    sms.Show();
                    this.Hide();
                }
                //Else 
                else
                {
                    //Show error 
                    errorProvider1.SetError(txtpassword, "Incorrect password");
                }
            } 
        }
      

        private void sms_login_Load(object sender, EventArgs e)
        {
            txtusername.Text = "Username";
            txtpassword.Text = "Password";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            errorProvider1.SetError(txtusername, "");
            errorProvider1.SetError(txtpassword, "");
            if (txtusername.Text == "")
            {
                errorProvider1.SetError(txtusername, "Incorrect username");
            }
            else if (txtpassword.Text == "")
            {
                errorProvider1.SetError(txtpassword, "Incorrect password");
            }
            else
            {
                //Creates a new text file 'username' + '.txt' 
                System.IO.TextWriter tw = new System.IO.StreamWriter(@"C:\SMS\" + txtusername.Text + ".ini");

                //Write the password on the first line 
                tw.WriteLine(txtpassword.Text);

                //Closes & disposes the textwriter 
                tw.Close();
                tw.Dispose();

                //Close this form 
                //this.Close();
                MessageBox.Show("Your account is complated!");
                sms_login_Load(sender, e);
            }

            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sms_login_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            base.WndProc(ref msg);
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if(txtusername.Text == "Username")
            {
                txtusername.Text = "";
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
            } 
       }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
            } 
        }
            

    }
}

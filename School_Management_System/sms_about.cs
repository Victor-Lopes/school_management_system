using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class sms_about : Form
    {
        public sms_about()
        {
            InitializeComponent();
        }

        private void sms_about_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel1.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + "plus.google.com/u/1/117706441984509462773";

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            linkLabel1.LinkVisited = true;
        }
    }
}

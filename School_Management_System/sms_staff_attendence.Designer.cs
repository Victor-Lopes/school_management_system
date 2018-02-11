namespace School_Management_System
{
    partial class sms_staff_attendence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sms_staff_attendence));
            this.rdopermission = new Design.Controls.RadioButton();
            this.rdoabsence = new Design.Controls.RadioButton();
            this.rdopresent = new Design.Controls.RadioButton();
            this.label1 = new Design.Controls.Label();
            this.panel3 = new Design.Controls.Panel();
            this.groupBox1 = new Design.Controls.GroupBox();
            this.txtdescription = new Design.Controls.TextBoxLabel();
            this.dtpattendance_date = new Design.Controls.DateTimePIckerLabel();
            this.txtstaff_name = new Design.Controls.TextBoxLabel();
            this.txtstaff_code = new Design.Controls.TextBoxLabel();
            this.panel2 = new Design.Controls.Panel();
            this.buttonGroup1 = new Design.Controls.ButtonGroup();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new Design.Controls.Panel();
            this.toolStrip1 = new Design.Controls.ToolStrip();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdopermission
            // 
            this.rdopermission.AutoSize = true;
            this.rdopermission.Location = new System.Drawing.Point(467, 115);
            this.rdopermission.Name = "rdopermission";
            this.rdopermission.Size = new System.Drawing.Size(75, 17);
            this.rdopermission.TabIndex = 7;
            this.rdopermission.TabStop = true;
            this.rdopermission.Text = "Permission";
            this.rdopermission.UseVisualStyleBackColor = true;
            // 
            // rdoabsence
            // 
            this.rdoabsence.AutoSize = true;
            this.rdoabsence.Location = new System.Drawing.Point(368, 115);
            this.rdoabsence.Name = "rdoabsence";
            this.rdoabsence.Size = new System.Drawing.Size(67, 17);
            this.rdoabsence.TabIndex = 7;
            this.rdoabsence.TabStop = true;
            this.rdoabsence.Text = "Adsence";
            this.rdoabsence.UseVisualStyleBackColor = true;
            // 
            // rdopresent
            // 
            this.rdopresent.AutoSize = true;
            this.rdopresent.Location = new System.Drawing.Point(265, 115);
            this.rdopresent.Name = "rdopresent";
            this.rdopresent.Size = new System.Drawing.Size(61, 17);
            this.rdopresent.TabIndex = 7;
            this.rdopresent.TabStop = true;
            this.rdopresent.Text = "Present";
            this.rdopresent.UseVisualStyleBackColor = true;
            this.rdopresent.CheckedChanged += new System.EventHandler(this.rdopresent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(184, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 290);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtdescription);
            this.groupBox1.Controls.Add(this.dtpattendance_date);
            this.groupBox1.Controls.Add(this.txtstaff_name);
            this.groupBox1.Controls.Add(this.txtstaff_code);
            this.groupBox1.Controls.Add(this.rdopermission);
            this.groupBox1.Controls.Add(this.rdoabsence);
            this.groupBox1.Controls.Add(this.rdopresent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Attendances";
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.Transparent;
            this.txtdescription.BoxWidth = 393;
            this.txtdescription.LabelText = "Description :";
            this.txtdescription.Location = new System.Drawing.Point(5, 172);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.PasswordChar = '\0';
            this.txtdescription.ReadOnly = false;
            this.txtdescription.Size = new System.Drawing.Size(905, 33);
            this.txtdescription.TabIndex = 11;
            this.txtdescription.TextBoxText = "";
            // 
            // dtpattendance_date
            // 
            this.dtpattendance_date.BackColor = System.Drawing.Color.Transparent;
            this.dtpattendance_date.BoxWidth = 393;
            this.dtpattendance_date.EnableDate = true;
            this.dtpattendance_date.FormatDateTime = Utils.Form.DateTimeFormat.DdMmMyyyy;
            this.dtpattendance_date.LabelText = "Attendance date :";
            this.dtpattendance_date.Location = new System.Drawing.Point(6, 141);
            this.dtpattendance_date.Name = "dtpattendance_date";
            this.dtpattendance_date.Size = new System.Drawing.Size(843, 34);
            this.dtpattendance_date.TabIndex = 10;
            // 
            // txtstaff_name
            // 
            this.txtstaff_name.BackColor = System.Drawing.Color.Transparent;
            this.txtstaff_name.BoxWidth = 393;
            this.txtstaff_name.LabelText = "Staff name :";
            this.txtstaff_name.Location = new System.Drawing.Point(6, 71);
            this.txtstaff_name.Name = "txtstaff_name";
            this.txtstaff_name.PasswordChar = '\0';
            this.txtstaff_name.ReadOnly = false;
            this.txtstaff_name.Size = new System.Drawing.Size(796, 38);
            this.txtstaff_name.TabIndex = 9;
            this.txtstaff_name.TextBoxText = "";
            // 
            // txtstaff_code
            // 
            this.txtstaff_code.BackColor = System.Drawing.Color.Transparent;
            this.txtstaff_code.BoxWidth = 393;
            this.txtstaff_code.LabelText = "Staff code :";
            this.txtstaff_code.Location = new System.Drawing.Point(5, 34);
            this.txtstaff_code.Name = "txtstaff_code";
            this.txtstaff_code.PasswordChar = '\0';
            this.txtstaff_code.ReadOnly = false;
            this.txtstaff_code.Size = new System.Drawing.Size(809, 31);
            this.txtstaff_code.TabIndex = 8;
            this.txtstaff_code.TextBoxText = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonGroup1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 330);
            this.panel2.TabIndex = 1;
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup1.DrownImage = ((System.Drawing.Image)(resources.GetObject("buttonGroup1.DrownImage")));
            this.buttonGroup1.ImageShowDetail = Design.Controls.ButtonGroup.Arrow.Down;
            this.buttonGroup1.Location = new System.Drawing.Point(0, 0);
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Owner = this.panel3;
            this.buttonGroup1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonGroup1.Size = new System.Drawing.Size(974, 40);
            this.buttonGroup1.TabIndex = 0;
            this.buttonGroup1.Title = "Attendance Information";
            this.buttonGroup1.TitleColor = System.Drawing.Color.DarkGreen;
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.Image = global::School_Management_System.Properties.Resources.Cancel_30px;
            this.toolStripButtonCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(115, 26);
            this.toolStripButtonCancel.Text = "Cancel Record";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::School_Management_System.Properties.Resources.Refresh_30px;
            this.toolStripButtonRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(78, 26);
            this.toolStripButtonRefresh.Text = "Refresh";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::School_Management_System.Properties.Resources.Save_Row_30px;
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(103, 26);
            this.toolStripButtonSave.Text = "Save Record";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = global::School_Management_System.Properties.Resources.Add_Row_30px;
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(103, 26);
            this.toolStripButtonNew.Text = "New Record";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 397);
            this.panel1.TabIndex = 60;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripSeparator1,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonRefresh,
            this.toolStripSeparator3,
            this.toolStripButtonCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(974, 29);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sms_staff_attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "sms_staff_attendence";
            this.Text = "sms_staff_attendence";
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.Controls.RadioButton rdopermission;
        private Design.Controls.RadioButton rdoabsence;
        private Design.Controls.RadioButton rdopresent;
        private Design.Controls.Label label1;
        private Design.Controls.Panel panel3;
        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.Panel panel2;
        private Design.Controls.ButtonGroup buttonGroup1;
        public System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private Design.Controls.Panel panel1;
        private Design.Controls.ToolStrip toolStrip1;
        private Design.Controls.TextBoxLabel txtstaff_name;
        private Design.Controls.TextBoxLabel txtstaff_code;
        private Design.Controls.TextBoxLabel txtdescription;
        private Design.Controls.DateTimePIckerLabel dtpattendance_date;

    }
}
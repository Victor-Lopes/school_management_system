namespace School_Management_System
{
    partial class sms_level
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new Design.Controls.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolBar1 = new Design.Controls.ToolBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbobranchname = new Design.Controls.ComboBoxLabel();
            this.txtlevelname = new Design.Controls.TextBoxLabel();
            this.groupBox1 = new Design.Controls.GroupBox();
            this.txtamount = new Design.Controls.NumericUpDownLabel();
            this.dtpenddate = new Design.Controls.DateTimePIckerLabel();
            this.dtpstartdate = new Design.Controls.DateTimePIckerLabel();
            this.txtendtime = new Design.Controls.TextBoxLabel();
            this.txtstarttime = new Design.Controls.TextBoxLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(916, 29);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = global::School_Management_System.Properties.Resources.Add_Row_30px;
            this.toolStripButtonNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(103, 26);
            this.toolStripButtonNew.Text = "New Record";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::School_Management_System.Properties.Resources.Save_Row_30px;
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(103, 26);
            this.toolStripButtonSave.Text = "Save Record";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::School_Management_System.Properties.Resources.Refresh_30px;
            this.toolStripButtonRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(78, 26);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.Image = global::School_Management_System.Properties.Resources.Cancel_30px;
            this.toolStripButtonCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(115, 26);
            this.toolStripButtonCancel.Text = "Cancel Record";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.LightCyan;
            this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBar1.DataSource = null;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar1.isSearch = false;
            this.toolBar1.LabelText = "Stock number";
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Margin = new System.Windows.Forms.Padding(5);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(916, 40);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 63;
            this.toolBar1.TextBoxText = "";
            this.toolBar1.TextResult = "";
            this.toolBar1.VisibleSearch = false;
            this.toolBar1.VisibleTlabel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Add New Level Information";
            // 
            // cbobranchname
            // 
            this.cbobranchname.BackColor = System.Drawing.Color.Transparent;
            this.cbobranchname.BoxWidth = 223;
            this.cbobranchname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbobranchname.Item = null;
            this.cbobranchname.LabelText = "Branch Name :";
            this.cbobranchname.Location = new System.Drawing.Point(35, 31);
            this.cbobranchname.Name = "cbobranchname";
            this.cbobranchname.Size = new System.Drawing.Size(435, 26);
            this.cbobranchname.TabIndex = 67;
            // 
            // txtlevelname
            // 
            this.txtlevelname.BackColor = System.Drawing.Color.Transparent;
            this.txtlevelname.BoxWidth = 223;
            this.txtlevelname.LabelText = "Level Name :";
            this.txtlevelname.Location = new System.Drawing.Point(35, 63);
            this.txtlevelname.Name = "txtlevelname";
            this.txtlevelname.PasswordChar = '\0';
            this.txtlevelname.ReadOnly = false;
            this.txtlevelname.Size = new System.Drawing.Size(435, 26);
            this.txtlevelname.TabIndex = 68;
            this.txtlevelname.TextBoxText = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.dtpenddate);
            this.groupBox1.Controls.Add(this.dtpstartdate);
            this.groupBox1.Controls.Add(this.txtendtime);
            this.groupBox1.Controls.Add(this.txtstarttime);
            this.groupBox1.Controls.Add(this.cbobranchname);
            this.groupBox1.Controls.Add(this.txtlevelname);
            this.groupBox1.Location = new System.Drawing.Point(0, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 268);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level Information";
            // 
            // txtamount
            // 
            this.txtamount.BoxWidth = 223;
            this.txtamount.LabelText = "Amount :";
            this.txtamount.Location = new System.Drawing.Point(35, 223);
            this.txtamount.Name = "txtamount";
            this.txtamount.numericControlReadOnly = false;
            this.txtamount.Size = new System.Drawing.Size(417, 27);
            this.txtamount.TabIndex = 73;
            // 
            // dtpenddate
            // 
            this.dtpenddate.BackColor = System.Drawing.Color.Transparent;
            this.dtpenddate.BoxWidth = 223;
            this.dtpenddate.EnableDate = true;
            this.dtpenddate.FormatDateTime = Utils.Form.DateTimeFormat.DdMmMyyyy;
            this.dtpenddate.LabelText = "End Date :";
            this.dtpenddate.Location = new System.Drawing.Point(35, 125);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(422, 24);
            this.dtpenddate.TabIndex = 71;
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.BackColor = System.Drawing.Color.Transparent;
            this.dtpstartdate.BoxWidth = 223;
            this.dtpstartdate.EnableDate = true;
            this.dtpstartdate.FormatDateTime = Utils.Form.DateTimeFormat.DdMmMyyyy;
            this.dtpstartdate.LabelText = "Start Date :";
            this.dtpstartdate.Location = new System.Drawing.Point(35, 95);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(422, 24);
            this.dtpstartdate.TabIndex = 72;
            // 
            // txtendtime
            // 
            this.txtendtime.BackColor = System.Drawing.Color.Transparent;
            this.txtendtime.BoxWidth = 223;
            this.txtendtime.LabelText = "End Time :";
            this.txtendtime.Location = new System.Drawing.Point(35, 191);
            this.txtendtime.Name = "txtendtime";
            this.txtendtime.PasswordChar = '\0';
            this.txtendtime.ReadOnly = false;
            this.txtendtime.Size = new System.Drawing.Size(483, 26);
            this.txtendtime.TabIndex = 69;
            this.txtendtime.TextBoxText = "";
            // 
            // txtstarttime
            // 
            this.txtstarttime.BackColor = System.Drawing.Color.Transparent;
            this.txtstarttime.BoxWidth = 223;
            this.txtstarttime.LabelText = "Start Time :";
            this.txtstarttime.Location = new System.Drawing.Point(35, 159);
            this.txtstarttime.Name = "txtstarttime";
            this.txtstarttime.PasswordChar = '\0';
            this.txtstarttime.ReadOnly = false;
            this.txtstarttime.Size = new System.Drawing.Size(483, 26);
            this.txtstarttime.TabIndex = 70;
            this.txtstarttime.TextBoxText = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // sms_level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolBar1);
            this.Name = "sms_level";
            this.Text = "sms_level";
            this.Load += new System.EventHandler(this.sms_level_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.Controls.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private Design.Controls.ToolBar toolBar1;
        private System.Windows.Forms.Label label2;
        private Design.Controls.ComboBoxLabel cbobranchname;
        private Design.Controls.TextBoxLabel txtlevelname;
        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.NumericUpDownLabel txtamount;
        private Design.Controls.DateTimePIckerLabel dtpenddate;
        private Design.Controls.DateTimePIckerLabel dtpstartdate;
        private Design.Controls.TextBoxLabel txtendtime;
        private Design.Controls.TextBoxLabel txtstarttime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
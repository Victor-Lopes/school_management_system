namespace School_Management_System
{
    partial class sms_setExamination
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sms_setExamination));
            this.toolStrip1 = new Design.Controls.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.dtpdate = new Design.Controls.DateTimePicker();
            this.cboselect_day = new Design.Controls.ComboBox();
            this.cboselect_code = new Design.Controls.ComboBox();
            this.cboselect_subject = new Design.Controls.ComboBox();
            this.txtroom_no = new Design.Controls.TextBox();
            this.txtstart_time = new Design.Controls.TextBox();
            this.txtend_time = new Design.Controls.TextBox();
            this.cboselect_shift = new Design.Controls.ComboBox();
            this.dataGridView1 = new Design.Controls.DataGridView();
            this.button2 = new Design.Controls.Button();
            this.button1 = new Design.Controls.Button();
            this.label1 = new Design.Controls.Label();
            this.label2 = new Design.Controls.Label();
            this.toolBar1 = new Design.Controls.ToolBar();
            this.label3 = new Design.Controls.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripSeparator1,
            this.toolStripButtonSave,
            this.toolStripSeparator2,
            this.toolStripButtonRefresh,
            this.toolStripSeparator3,
            this.toolStripButtonCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(451, 29);
            this.toolStrip1.TabIndex = 62;
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
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd - MMM - yyyy - hh:mm tt";
            this.dtpdate.DateTimeFormat = Utils.Form.DateTimeFormat.DdMmMyyyyhhmmtt;
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(14, 94);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(136, 23);
            this.dtpdate.TabIndex = 63;
            // 
            // cboselect_day
            // 
            this.cboselect_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboselect_day.FormattingEnabled = true;
            this.cboselect_day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cboselect_day.Location = new System.Drawing.Point(156, 93);
            this.cboselect_day.Name = "cboselect_day";
            this.cboselect_day.Size = new System.Drawing.Size(121, 24);
            this.cboselect_day.Source = null;
            this.cboselect_day.TabIndex = 64;
            this.cboselect_day.Text = "  Select Day";
            // 
            // cboselect_code
            // 
            this.cboselect_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboselect_code.FormattingEnabled = true;
            this.cboselect_code.Location = new System.Drawing.Point(423, 94);
            this.cboselect_code.Name = "cboselect_code";
            this.cboselect_code.Size = new System.Drawing.Size(134, 24);
            this.cboselect_code.Source = null;
            this.cboselect_code.TabIndex = 64;
            this.cboselect_code.Text = "  Select Code";
            // 
            // cboselect_subject
            // 
            this.cboselect_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboselect_subject.FormattingEnabled = true;
            this.cboselect_subject.Location = new System.Drawing.Point(283, 93);
            this.cboselect_subject.Name = "cboselect_subject";
            this.cboselect_subject.Size = new System.Drawing.Size(134, 24);
            this.cboselect_subject.Source = null;
            this.cboselect_subject.TabIndex = 64;
            this.cboselect_subject.Text = "  Select Subject";
            // 
            // txtroom_no
            // 
            this.txtroom_no.EnterKeys = Design.Controls.TextBox.EnterKey.String;
            this.txtroom_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtroom_no.Location = new System.Drawing.Point(563, 93);
            this.txtroom_no.Name = "txtroom_no";
            this.txtroom_no.Size = new System.Drawing.Size(103, 25);
            this.txtroom_no.TabIndex = 65;
            this.txtroom_no.Text = "Room No";
            // 
            // txtstart_time
            // 
            this.txtstart_time.EnterKeys = Design.Controls.TextBox.EnterKey.String;
            this.txtstart_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtstart_time.Location = new System.Drawing.Point(672, 93);
            this.txtstart_time.Name = "txtstart_time";
            this.txtstart_time.Size = new System.Drawing.Size(103, 25);
            this.txtstart_time.TabIndex = 65;
            this.txtstart_time.Text = "Start Time";
            // 
            // txtend_time
            // 
            this.txtend_time.EnterKeys = Design.Controls.TextBox.EnterKey.String;
            this.txtend_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtend_time.Location = new System.Drawing.Point(781, 93);
            this.txtend_time.Name = "txtend_time";
            this.txtend_time.Size = new System.Drawing.Size(103, 25);
            this.txtend_time.TabIndex = 65;
            this.txtend_time.Text = "End  Time";
            // 
            // cboselect_shift
            // 
            this.cboselect_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboselect_shift.FormattingEnabled = true;
            this.cboselect_shift.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Everning"});
            this.cboselect_shift.Location = new System.Drawing.Point(890, 93);
            this.cboselect_shift.Name = "cboselect_shift";
            this.cboselect_shift.Size = new System.Drawing.Size(134, 24);
            this.cboselect_shift.Source = null;
            this.cboselect_shift.TabIndex = 64;
            this.cboselect_shift.Text = "  Select Shift";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditRows = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Khmer OS Siemreap", 9F);
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 159);
            this.dataGridView1.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Image = global::School_Management_System.Properties.Resources.Trash_25px;
            this.button2.Location = new System.Drawing.Point(984, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 43);
            this.button2.TabIndex = 67;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(938, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 43);
            this.button1.TabIndex = 68;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "List Examination";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "List Examination";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(1043, 40);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 70;
            this.toolBar1.TextBoxText = "";
            this.toolBar1.TextResult = "";
            this.toolBar1.VisibleSearch = false;
            this.toolBar1.VisibleTlabel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Examination Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sms_setExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtend_time);
            this.Controls.Add(this.txtstart_time);
            this.Controls.Add(this.txtroom_no);
            this.Controls.Add(this.cboselect_subject);
            this.Controls.Add(this.cboselect_shift);
            this.Controls.Add(this.cboselect_code);
            this.Controls.Add(this.cboselect_day);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sms_setExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sms_setExamination";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Design.Controls.DateTimePicker dtpdate;
        private Design.Controls.ComboBox cboselect_day;
        private Design.Controls.ComboBox cboselect_code;
        private Design.Controls.ComboBox cboselect_subject;
        private Design.Controls.TextBox txtroom_no;
        private Design.Controls.TextBox txtstart_time;
        private Design.Controls.TextBox txtend_time;
        private Design.Controls.ComboBox cboselect_shift;
        private Design.Controls.DataGridView dataGridView1;
        private Design.Controls.Button button2;
        private Design.Controls.Button button1;
        private Design.Controls.Label label1;
        private Design.Controls.Label label2;
        private Design.Controls.ToolBar toolBar1;
        private Design.Controls.Label label3;
    }
}
namespace School_Management_System
{
    partial class sms_setexamgrade
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
            this.groupBox1 = new Design.Controls.GroupBox();
            this.cbograde_name = new Design.Controls.ComboBoxLabel();
            this.txtgrade_point = new Design.Controls.TextBoxLabel();
            this.numericUpDownLabel3 = new Design.Controls.NumericUpDownLabel();
            this.numericUpDownLabel2 = new Design.Controls.NumericUpDownLabel();
            this.label1 = new Design.Controls.Label();
            this.toolBar1 = new Design.Controls.ToolBar();
            this.toolStrip1 = new Design.Controls.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbograde_name);
            this.groupBox1.Controls.Add(this.txtgrade_point);
            this.groupBox1.Controls.Add(this.numericUpDownLabel3);
            this.groupBox1.Controls.Add(this.numericUpDownLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 265);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Information";
            // 
            // cbograde_name
            // 
            this.cbograde_name.BackColor = System.Drawing.Color.Transparent;
            this.cbograde_name.BoxWidth = 565;
            this.cbograde_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbograde_name.Item = null;
            this.cbograde_name.LabelText = "Grade Name :";
            this.cbograde_name.Location = new System.Drawing.Point(7, 36);
            this.cbograde_name.Margin = new System.Windows.Forms.Padding(4);
            this.cbograde_name.Name = "cbograde_name";
            this.cbograde_name.Size = new System.Drawing.Size(621, 26);
            this.cbograde_name.TabIndex = 5;
            // 
            // txtgrade_point
            // 
            this.txtgrade_point.BackColor = System.Drawing.Color.Transparent;
            this.txtgrade_point.BoxWidth = 565;
            this.txtgrade_point.LabelText = "Grade Point :";
            this.txtgrade_point.Location = new System.Drawing.Point(7, 70);
            this.txtgrade_point.Margin = new System.Windows.Forms.Padding(4);
            this.txtgrade_point.Name = "txtgrade_point";
            this.txtgrade_point.PasswordChar = '\0';
            this.txtgrade_point.ReadOnly = false;
            this.txtgrade_point.Size = new System.Drawing.Size(680, 30);
            this.txtgrade_point.TabIndex = 4;
            this.txtgrade_point.TextBoxText = "";
            // 
            // numericUpDownLabel3
            // 
            this.numericUpDownLabel3.BoxWidth = 569;
            this.numericUpDownLabel3.LabelText = "To Sroce :";
            this.numericUpDownLabel3.Location = new System.Drawing.Point(7, 143);
            this.numericUpDownLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownLabel3.Name = "numericUpDownLabel3";
            this.numericUpDownLabel3.numericControlReadOnly = false;
            this.numericUpDownLabel3.Size = new System.Drawing.Size(680, 27);
            this.numericUpDownLabel3.TabIndex = 3;
            // 
            // numericUpDownLabel2
            // 
            this.numericUpDownLabel2.BoxWidth = 569;
            this.numericUpDownLabel2.LabelText = "From Sroce :";
            this.numericUpDownLabel2.Location = new System.Drawing.Point(7, 108);
            this.numericUpDownLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownLabel2.Name = "numericUpDownLabel2";
            this.numericUpDownLabel2.numericControlReadOnly = false;
            this.numericUpDownLabel2.Size = new System.Drawing.Size(694, 27);
            this.numericUpDownLabel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Give The Grade Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.toolBar1.Size = new System.Drawing.Size(817, 37);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 52;
            this.toolBar1.TextBoxText = "";
            this.toolBar1.TextResult = "";
            this.toolBar1.VisibleSearch = false;
            this.toolBar1.VisibleTlabel = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 37);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(817, 29);
            this.toolStrip1.TabIndex = 56;
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
            // sms_setexamgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 365);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolBar1);
            this.Name = "sms_setexamgrade";
            this.Text = "sms_setexamgrade";
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.Label label1;
        private Design.Controls.ToolBar toolBar1;
        private Design.Controls.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private Design.Controls.TextBoxLabel txtgrade_point;
        private Design.Controls.NumericUpDownLabel numericUpDownLabel3;
        private Design.Controls.NumericUpDownLabel numericUpDownLabel2;
        private Design.Controls.ComboBoxLabel cbograde_name;
    }
}
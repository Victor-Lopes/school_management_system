namespace School_Management_System
{
    partial class sms_user_account
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
            this.tabControl1 = new Design.Controls.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new Design.Controls.GroupBox();
            this.txtstaff_name = new Design.Controls.SearchButtonBox();
            this.txtconfirm_password = new Design.Controls.TextBoxLabel();
            this.txtnew_password = new Design.Controls.TextBoxLabel();
            this.cbobranche = new Design.Controls.ComboBoxLabel();
            this.cboschool = new Design.Controls.ComboBoxLabel();
            this.cborole = new Design.Controls.ComboBoxLabel();
            this.txtuser_name = new Design.Controls.TextBoxLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Add New User Account";
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
            this.toolBar1.Size = new System.Drawing.Size(1060, 40);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1060, 29);
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 379);
            this.tabControl1.TabIndex = 57;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtstaff_name);
            this.groupBox1.Controls.Add(this.txtconfirm_password);
            this.groupBox1.Controls.Add(this.txtnew_password);
            this.groupBox1.Controls.Add(this.cbobranche);
            this.groupBox1.Controls.Add(this.cboschool);
            this.groupBox1.Controls.Add(this.cborole);
            this.groupBox1.Controls.Add(this.txtuser_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 347);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Account Information";
            // 
            // txtstaff_name
            // 
            this.txtstaff_name.BackColor = System.Drawing.Color.Transparent;
            this.txtstaff_name.Datasource = null;
            this.txtstaff_name.EnableClear = true;
            this.txtstaff_name.EnablePop = true;
            this.txtstaff_name.GridWidth1 = 100;
            this.txtstaff_name.GridWidth2 = 200;
            this.txtstaff_name.Id = null;
            this.txtstaff_name.isSearch = false;
            this.txtstaff_name.LabelText = "Staff Name :";
            this.txtstaff_name.Location = new System.Drawing.Point(7, 43);
            this.txtstaff_name.Margin = new System.Windows.Forms.Padding(4);
            this.txtstaff_name.name = null;
            this.txtstaff_name.Name = "txtstaff_name";
            this.txtstaff_name.ResultText = "";
            this.txtstaff_name.Size = new System.Drawing.Size(713, 33);
            this.txtstaff_name.SQL = null;
            this.txtstaff_name.TabIndex = 8;
            this.txtstaff_name.TableName = null;
            this.txtstaff_name.TextBoxText = "";
            // 
            // txtconfirm_password
            // 
            this.txtconfirm_password.BackColor = System.Drawing.Color.Transparent;
            this.txtconfirm_password.BoxWidth = 372;
            this.txtconfirm_password.LabelText = "Confirm Password :";
            this.txtconfirm_password.Location = new System.Drawing.Point(7, 278);
            this.txtconfirm_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirm_password.Name = "txtconfirm_password";
            this.txtconfirm_password.PasswordChar = '\0';
            this.txtconfirm_password.ReadOnly = false;
            this.txtconfirm_password.Size = new System.Drawing.Size(713, 33);
            this.txtconfirm_password.TabIndex = 7;
            this.txtconfirm_password.TextBoxText = "";
            // 
            // txtnew_password
            // 
            this.txtnew_password.BackColor = System.Drawing.Color.Transparent;
            this.txtnew_password.BoxWidth = 372;
            this.txtnew_password.LabelText = "New Password :";
            this.txtnew_password.Location = new System.Drawing.Point(7, 237);
            this.txtnew_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtnew_password.Name = "txtnew_password";
            this.txtnew_password.PasswordChar = '\0';
            this.txtnew_password.ReadOnly = false;
            this.txtnew_password.Size = new System.Drawing.Size(696, 33);
            this.txtnew_password.TabIndex = 6;
            this.txtnew_password.TextBoxText = "";
            // 
            // cbobranche
            // 
            this.cbobranche.BackColor = System.Drawing.Color.Transparent;
            this.cbobranche.BoxWidth = 372;
            this.cbobranche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbobranche.Item = null;
            this.cbobranche.LabelText = "Branche :";
            this.cbobranche.Location = new System.Drawing.Point(7, 200);
            this.cbobranche.Margin = new System.Windows.Forms.Padding(4);
            this.cbobranche.Name = "cbobranche";
            this.cbobranche.Size = new System.Drawing.Size(657, 29);
            this.cbobranche.TabIndex = 5;
            // 
            // cboschool
            // 
            this.cboschool.BackColor = System.Drawing.Color.Transparent;
            this.cboschool.BoxWidth = 372;
            this.cboschool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboschool.Item = null;
            this.cboschool.LabelText = "School :";
            this.cboschool.Location = new System.Drawing.Point(7, 159);
            this.cboschool.Margin = new System.Windows.Forms.Padding(4);
            this.cboschool.Name = "cboschool";
            this.cboschool.Size = new System.Drawing.Size(706, 33);
            this.cboschool.TabIndex = 4;
            // 
            // cborole
            // 
            this.cborole.BackColor = System.Drawing.Color.Transparent;
            this.cborole.BoxWidth = 372;
            this.cborole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cborole.Item = null;
            this.cborole.LabelText = "Role :";
            this.cborole.Location = new System.Drawing.Point(7, 119);
            this.cborole.Margin = new System.Windows.Forms.Padding(4);
            this.cborole.Name = "cborole";
            this.cborole.Size = new System.Drawing.Size(673, 32);
            this.cborole.TabIndex = 3;
            // 
            // txtuser_name
            // 
            this.txtuser_name.BackColor = System.Drawing.Color.Transparent;
            this.txtuser_name.BoxWidth = 372;
            this.txtuser_name.LabelText = "User Name :";
            this.txtuser_name.Location = new System.Drawing.Point(7, 83);
            this.txtuser_name.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser_name.Name = "txtuser_name";
            this.txtuser_name.PasswordChar = '\0';
            this.txtuser_name.ReadOnly = false;
            this.txtuser_name.Size = new System.Drawing.Size(846, 34);
            this.txtuser_name.TabIndex = 1;
            this.txtuser_name.TextBoxText = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sms_user_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolBar1);
            this.Name = "sms_user_account";
            this.Text = "sms_user_account";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Design.Controls.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.SearchButtonBox txtstaff_name;
        private Design.Controls.TextBoxLabel txtconfirm_password;
        private Design.Controls.TextBoxLabel txtnew_password;
        private Design.Controls.ComboBoxLabel cbobranche;
        private Design.Controls.ComboBoxLabel cboschool;
        private Design.Controls.ComboBoxLabel cborole;
        private Design.Controls.TextBoxLabel txtuser_name;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
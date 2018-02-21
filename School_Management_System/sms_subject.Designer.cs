namespace School_Management_System
{
    partial class sms_subject
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
            this.groupBox1 = new Design.Controls.GroupBox();
            this.label1 = new Design.Controls.Label();
            this.rdono = new Design.Controls.RadioButton();
            this.rdoyes = new Design.Controls.RadioButton();
            this.txtdescription = new Design.Controls.TextBoxLabel();
            this.txtsubject_name = new Design.Controls.TextBoxLabel();
            this.toolBar1 = new Design.Controls.ToolBar();
            this.label2 = new Design.Controls.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchButtonBoxClass = new Design.Controls.SearchButtonBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(420, 29);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.searchButtonBoxClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdono);
            this.groupBox1.Controls.Add(this.rdoyes);
            this.groupBox1.Controls.Add(this.txtdescription);
            this.groupBox1.Controls.Add(this.txtsubject_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1004, 331);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(122, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Optional Subject :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdono
            // 
            this.rdono.AutoSize = true;
            this.rdono.Location = new System.Drawing.Point(327, 138);
            this.rdono.Name = "rdono";
            this.rdono.Size = new System.Drawing.Size(44, 20);
            this.rdono.TabIndex = 4;
            this.rdono.Text = "No";
            this.rdono.UseVisualStyleBackColor = true;
            // 
            // rdoyes
            // 
            this.rdoyes.AutoSize = true;
            this.rdoyes.Checked = true;
            this.rdoyes.Location = new System.Drawing.Point(262, 138);
            this.rdoyes.Name = "rdoyes";
            this.rdoyes.Size = new System.Drawing.Size(50, 20);
            this.rdoyes.TabIndex = 4;
            this.rdoyes.TabStop = true;
            this.rdoyes.Text = "Yes";
            this.rdoyes.UseVisualStyleBackColor = true;
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.Transparent;
            this.txtdescription.BoxWidth = 500;
            this.txtdescription.LabelText = "Description :";
            this.txtdescription.Location = new System.Drawing.Point(7, 104);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.PasswordChar = '\0';
            this.txtdescription.ReadOnly = false;
            this.txtdescription.Size = new System.Drawing.Size(924, 32);
            this.txtdescription.TabIndex = 2;
            this.txtdescription.TextBoxText = "";
            // 
            // txtsubject_name
            // 
            this.txtsubject_name.BackColor = System.Drawing.Color.Transparent;
            this.txtsubject_name.BoxWidth = 297;
            this.txtsubject_name.LabelText = "Subject Name :";
            this.txtsubject_name.Location = new System.Drawing.Point(7, 70);
            this.txtsubject_name.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubject_name.Name = "txtsubject_name";
            this.txtsubject_name.PasswordChar = '\0';
            this.txtsubject_name.ReadOnly = false;
            this.txtsubject_name.Size = new System.Drawing.Size(654, 33);
            this.txtsubject_name.TabIndex = 1;
            this.txtsubject_name.TextBoxText = "";
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
            this.toolBar1.Size = new System.Drawing.Size(1004, 40);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 66;
            this.toolBar1.TextBoxText = "";
            this.toolBar1.TextResult = "";
            this.toolBar1.VisibleSearch = false;
            this.toolBar1.VisibleTlabel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Subject Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // searchButtonBoxClass
            // 
            this.searchButtonBoxClass.BackColor = System.Drawing.Color.Transparent;
            this.searchButtonBoxClass.Datasource = null;
            this.searchButtonBoxClass.EnableClear = true;
            this.searchButtonBoxClass.EnablePop = true;
            this.searchButtonBoxClass.GridWidth1 = 60;
            this.searchButtonBoxClass.GridWidth2 = 130;
            this.searchButtonBoxClass.Id = "";
            this.searchButtonBoxClass.isSearch = false;
            this.searchButtonBoxClass.LabelText = "Class* :";
            this.searchButtonBoxClass.Location = new System.Drawing.Point(7, 31);
            this.searchButtonBoxClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButtonBoxClass.name = null;
            this.searchButtonBoxClass.Name = "searchButtonBoxClass";
            this.searchButtonBoxClass.ResultText = "";
            this.searchButtonBoxClass.Size = new System.Drawing.Size(713, 32);
            this.searchButtonBoxClass.SQL = null;
            this.searchButtonBoxClass.TabIndex = 6;
            this.searchButtonBoxClass.TableName = null;
            this.searchButtonBoxClass.TextBoxText = "";
            this.searchButtonBoxClass.Visible = false;
            this.searchButtonBoxClass.ButtonSeachClick += new System.EventHandler(this.searchButtonBoxClass_ButtonSeachClick);
            // 
            // sms_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "sms_subject";
            this.Text = "sms_subject";
            this.Load += new System.EventHandler(this.sms_subject_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.TextBoxLabel txtsubject_name;
        private Design.Controls.Label label1;
        private Design.Controls.RadioButton rdono;
        private Design.Controls.RadioButton rdoyes;
        private Design.Controls.TextBoxLabel txtdescription;
        private Design.Controls.ToolBar toolBar1;
        private Design.Controls.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Design.Controls.SearchButtonBox searchButtonBoxClass;
    }
}
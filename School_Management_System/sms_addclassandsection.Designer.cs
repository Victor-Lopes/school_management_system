namespace School_Management_System
{
    partial class sms_addclassandsection
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
            this.toolBar1 = new Design.Controls.ToolBar();
            this.label1 = new Design.Controls.Label();
            this.groupBox1 = new Design.Controls.GroupBox();
            this.comboBoxLabel1 = new Design.Controls.ComboBoxLabel();
            this.textBoxLabel5 = new Design.Controls.TextBoxLabel();
            this.textBoxLabel3 = new Design.Controls.TextBoxLabel();
            this.textBoxLabel2 = new Design.Controls.TextBoxLabel();
            this.textBoxLabel1 = new Design.Controls.TextBoxLabel();
            this.toolStrip1 = new Design.Controls.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolBar1.Size = new System.Drawing.Size(1059, 37);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 18;
            this.toolBar1.TextBoxText = "";
            this.toolBar1.TextResult = "";
            this.toolBar1.VisibleSearch = false;
            this.toolBar1.VisibleTlabel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add New Class Section ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxLabel1);
            this.groupBox1.Controls.Add(this.textBoxLabel5);
            this.groupBox1.Controls.Add(this.textBoxLabel3);
            this.groupBox1.Controls.Add(this.textBoxLabel2);
            this.groupBox1.Controls.Add(this.textBoxLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 263);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Information";
            // 
            // comboBoxLabel1
            // 
            this.comboBoxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxLabel1.BoxWidth = 344;
            this.comboBoxLabel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLabel1.Item = null;
            this.comboBoxLabel1.LabelText = "Student Capacity In a Section :";
            this.comboBoxLabel1.Location = new System.Drawing.Point(13, 157);
            this.comboBoxLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLabel1.Name = "comboBoxLabel1";
            this.comboBoxLabel1.Size = new System.Drawing.Size(769, 26);
            this.comboBoxLabel1.TabIndex = 5;
            // 
            // textBoxLabel5
            // 
            this.textBoxLabel5.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLabel5.BoxWidth = 344;
            this.textBoxLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel5.LabelText = "Class Code :";
            this.textBoxLabel5.Location = new System.Drawing.Point(13, 196);
            this.textBoxLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabel5.Name = "textBoxLabel5";
            this.textBoxLabel5.PasswordChar = '\0';
            this.textBoxLabel5.ReadOnly = false;
            this.textBoxLabel5.Size = new System.Drawing.Size(783, 33);
            this.textBoxLabel5.TabIndex = 4;
            this.textBoxLabel5.TextBoxText = "";
            // 
            // textBoxLabel3
            // 
            this.textBoxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLabel3.BoxWidth = 344;
            this.textBoxLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel3.LabelText = "Class Section :";
            this.textBoxLabel3.Location = new System.Drawing.Point(13, 114);
            this.textBoxLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabel3.Name = "textBoxLabel3";
            this.textBoxLabel3.PasswordChar = '\0';
            this.textBoxLabel3.ReadOnly = false;
            this.textBoxLabel3.Size = new System.Drawing.Size(783, 35);
            this.textBoxLabel3.TabIndex = 2;
            this.textBoxLabel3.TextBoxText = "";
            // 
            // textBoxLabel2
            // 
            this.textBoxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLabel2.BoxWidth = 344;
            this.textBoxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel2.LabelText = "Class Group :";
            this.textBoxLabel2.Location = new System.Drawing.Point(13, 73);
            this.textBoxLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabel2.Name = "textBoxLabel2";
            this.textBoxLabel2.PasswordChar = '\0';
            this.textBoxLabel2.ReadOnly = false;
            this.textBoxLabel2.Size = new System.Drawing.Size(769, 33);
            this.textBoxLabel2.TabIndex = 1;
            this.textBoxLabel2.TextBoxText = "";
            // 
            // textBoxLabel1
            // 
            this.textBoxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLabel1.BoxWidth = 344;
            this.textBoxLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel1.LabelText = "Cource/Class Title :";
            this.textBoxLabel1.Location = new System.Drawing.Point(13, 33);
            this.textBoxLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabel1.Name = "textBoxLabel1";
            this.textBoxLabel1.PasswordChar = '\0';
            this.textBoxLabel1.ReadOnly = false;
            this.textBoxLabel1.Size = new System.Drawing.Size(798, 32);
            this.textBoxLabel1.TabIndex = 0;
            this.textBoxLabel1.TextBoxText = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 37);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1059, 29);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::School_Management_System.Properties.Resources.Add_Row_30px;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 26);
            this.toolStripButton1.Text = "New Record";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::School_Management_System.Properties.Resources.Save_Row_30px;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(103, 26);
            this.toolStripButton2.Text = "Save Record";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::School_Management_System.Properties.Resources.Refresh_30px;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 26);
            this.toolStripButton3.Text = "Refresh";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::School_Management_System.Properties.Resources.Cancel_30px;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(115, 26);
            this.toolStripButton4.Text = "Cancel Record";
            // 
            // sms_addclassandsection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 347);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolBar1);
            this.Name = "sms_addclassandsection";
            this.Text = "sms_addclassandsection";
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.Controls.ToolBar toolBar1;
        private Design.Controls.Label label1;
        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.TextBoxLabel textBoxLabel5;
        private Design.Controls.TextBoxLabel textBoxLabel3;
        private Design.Controls.TextBoxLabel textBoxLabel2;
        private Design.Controls.TextBoxLabel textBoxLabel1;
        private Design.Controls.ComboBoxLabel comboBoxLabel1;
        private Design.Controls.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}
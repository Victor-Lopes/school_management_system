namespace School_Management_System
{
    partial class sms_teacher_report
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
            this.label1 = new Design.Controls.Label();
            this.toolBar1 = new Design.Controls.ToolBar();
            this.groupBox3 = new Design.Controls.GroupBox();
            this.dataGridView1 = new Design.Controls.DataGridView();
            this.groupBox1 = new Design.Controls.GroupBox();
            this.btnprint = new Design.Controls.Button();
            this.btnexport = new Design.Controls.Button();
            this.cbosearch_by = new Design.Controls.ComboBoxLabel();
            this.txtsearch = new Design.Controls.TextBoxLabel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Teacher Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.toolBar1.Size = new System.Drawing.Size(1093, 40);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 67;
            this.toolBar1.TextBoxText = "";
            this.toolBar1.TextResult = "";
            this.toolBar1.VisibleSearch = false;
            this.toolBar1.VisibleTlabel = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1093, 366);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teacher Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditRows = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.btnexport);
            this.groupBox1.Controls.Add(this.cbosearch_by);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 71);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Information";
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnprint.Location = new System.Drawing.Point(958, 19);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(126, 30);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnexport.Location = new System.Drawing.Point(827, 19);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(125, 30);
            this.btnexport.TabIndex = 2;
            this.btnexport.Text = "Export to Excel";
            this.btnexport.UseVisualStyleBackColor = true;
            // 
            // cbosearch_by
            // 
            this.cbosearch_by.BackColor = System.Drawing.Color.Transparent;
            this.cbosearch_by.BoxWidth = 150;
            this.cbosearch_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbosearch_by.Item = null;
            this.cbosearch_by.LabelText = "Search By :";
            this.cbosearch_by.Location = new System.Drawing.Point(6, 19);
            this.cbosearch_by.Name = "cbosearch_by";
            this.cbosearch_by.Size = new System.Drawing.Size(352, 30);
            this.cbosearch_by.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Transparent;
            this.txtsearch.BoxWidth = 223;
            this.txtsearch.LabelText = "";
            this.txtsearch.Location = new System.Drawing.Point(165, 19);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.ReadOnly = false;
            this.txtsearch.Size = new System.Drawing.Size(437, 30);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextBoxText = "";
            // 
            // sms_teacher_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolBar1);
            this.Name = "sms_teacher_report";
            this.Text = "sms_teacher_report";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.Controls.Label label1;
        private Design.Controls.ToolBar toolBar1;
        private Design.Controls.GroupBox groupBox3;
        private Design.Controls.DataGridView dataGridView1;
        private Design.Controls.GroupBox groupBox1;
        private Design.Controls.Button btnexport;
        private Design.Controls.ComboBoxLabel cbosearch_by;
        private Design.Controls.TextBoxLabel txtsearch;
        private Design.Controls.Button btnprint;
    }
}
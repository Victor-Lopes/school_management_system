namespace School_Management_System
{
    partial class sms_student_list
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
            this.groupBox1 = new Design.Controls.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbosearch_by = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnnew_student = new Design.Controls.Button();
            this.btnexport = new Design.Controls.Button();
            this.toolBar1 = new Design.Controls.ToolBar();
            this.groupBox3 = new Design.Controls.GroupBox();
            this.dataGridView1 = new Design.Controls.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.btnnew_student);
            this.groupBox1.Controls.Add(this.btnexport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 71);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbosearch_by);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 38);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By :";
            // 
            // cbosearch_by
            // 
            this.cbosearch_by.FormattingEnabled = true;
            this.cbosearch_by.Location = new System.Drawing.Point(217, 9);
            this.cbosearch_by.Name = "cbosearch_by";
            this.cbosearch_by.Size = new System.Drawing.Size(165, 21);
            this.cbosearch_by.TabIndex = 6;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(388, 8);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(180, 24);
            this.txtsearch.TabIndex = 7;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(993, 19);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(95, 36);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "&Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnnew_student
            // 
            this.btnnew_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnew_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnnew_student.Location = new System.Drawing.Point(731, 18);
            this.btnnew_student.Name = "btnnew_student";
            this.btnnew_student.Size = new System.Drawing.Size(125, 37);
            this.btnnew_student.TabIndex = 2;
            this.btnnew_student.Text = "New Student";
            this.btnnew_student.UseVisualStyleBackColor = true;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnexport.Location = new System.Drawing.Point(862, 19);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(125, 37);
            this.btnexport.TabIndex = 2;
            this.btnexport.Text = "Export to Excel";
            this.btnexport.UseVisualStyleBackColor = true;
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
            this.toolBar1.Size = new System.Drawing.Size(1100, 40);
            this.toolBar1.SQL = null;
            this.toolBar1.TabIndex = 25;
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
            this.groupBox3.Location = new System.Drawing.Point(0, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1100, 391);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lists Staff Information";
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
            this.dataGridView1.Size = new System.Drawing.Size(1094, 371);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student List Information";
            // 
            // sms_student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.groupBox3);
            this.Name = "sms_student_list";
            this.Text = "sms_student_list";
            this.Load += new System.EventHandler(this.sms_student_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.Controls.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbosearch_by;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnprint;
        private Design.Controls.Button btnnew_student;
        private Design.Controls.Button btnexport;
        private Design.Controls.ToolBar toolBar1;
        private Design.Controls.GroupBox groupBox3;
        private Design.Controls.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;


    }
}
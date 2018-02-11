namespace School_Management_System
{
    partial class sms_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sms_login));
            this.errorProvider1 = new Design.Controls.ErrorProvider();
            this.btnexit = new Design.Controls.PictureBox();
            this.pictureBox1 = new Design.Controls.PictureBox();
            this.btnlogin = new Design.Controls.Button();
            this.txtpassword = new Design.Controls.TextBox();
            this.txtusername = new Design.Controls.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Image = global::School_Management_System.Properties.Resources.Close_Window_48px;
            this.btnexit.Location = new System.Drawing.Point(273, 5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(25, 25);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 8;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.sms_logo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnlogin.Image = global::School_Management_System.Properties.Resources.Enter_35px;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(182, 383);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(93, 38);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "&Login";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.EnterKeys = Design.Controls.TextBox.EnterKey.String;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.txtpassword, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtpassword.Location = new System.Drawing.Point(31, 343);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(244, 28);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // txtusername
            // 
            this.txtusername.EnterKeys = Design.Controls.TextBox.EnterKey.String;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.txtusername, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtusername.Location = new System.Drawing.Point(31, 306);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(244, 28);
            this.txtusername.TabIndex = 5;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // sms_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::School_Management_System.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(299, 476);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sms_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Information";
            this.Load += new System.EventHandler(this.sms_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sms_login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Design.Controls.ErrorProvider errorProvider1;
        private Design.Controls.PictureBox btnexit;
        private Design.Controls.PictureBox pictureBox1;
        private Design.Controls.Button btnlogin;
        private Design.Controls.TextBox txtpassword;
        private Design.Controls.TextBox txtusername;
    }
}
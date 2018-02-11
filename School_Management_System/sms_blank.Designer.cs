namespace School_Management_System
{
    partial class sms_blank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sms_blank));
            this.panel1 = new Design.Controls.Panel();
            this.button1 = new Design.Controls.Button();
            this._SbApaccount = new Design.Controls.SearchButtonBox();
            this._SbRecievedBy = new Design.Controls.SearchButtonBox();
            this._SbSuplier = new Design.Controls.SearchButtonBox();
            this.txtInvoiceNo = new Design.Controls.TextBoxLabel();
            this._SbVendor = new Design.Controls.SearchButtonBox();
            this.CboCurrency = new Design.Controls.ComboBoxLabel();
            this.dateTimePurchaseDate = new Design.Controls.DateTimePIckerLabel();
            this.buttonGroup1 = new Design.Controls.ButtonGroup();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this._SbApaccount);
            this.panel1.Controls.Add(this._SbRecievedBy);
            this.panel1.Controls.Add(this._SbSuplier);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this._SbVendor);
            this.panel1.Controls.Add(this.CboCurrency);
            this.panel1.Controls.Add(this.dateTimePurchaseDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 243);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(706, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _SbApaccount
            // 
            this._SbApaccount.BackColor = System.Drawing.Color.Transparent;
            this._SbApaccount.Datasource = null;
            this._SbApaccount.EnableClear = true;
            this._SbApaccount.EnablePop = true;
            this._SbApaccount.GridWidth1 = 100;
            this._SbApaccount.GridWidth2 = 200;
            this._SbApaccount.Id = null;
            this._SbApaccount.isSearch = true;
            this._SbApaccount.LabelText = "A/P Acount :";
            this._SbApaccount.Location = new System.Drawing.Point(109, 207);
            this._SbApaccount.name = null;
            this._SbApaccount.Name = "_SbApaccount";
            this._SbApaccount.ResultText = "";
            this._SbApaccount.Size = new System.Drawing.Size(713, 29);
            this._SbApaccount.SQL = null;
            this._SbApaccount.TabIndex = 6;
            this._SbApaccount.TableName = null;
            this._SbApaccount.TextBoxText = "";
            // 
            // _SbRecievedBy
            // 
            this._SbRecievedBy.BackColor = System.Drawing.Color.Transparent;
            this._SbRecievedBy.Datasource = null;
            this._SbRecievedBy.EnableClear = true;
            this._SbRecievedBy.EnablePop = true;
            this._SbRecievedBy.GridWidth1 = 100;
            this._SbRecievedBy.GridWidth2 = 200;
            this._SbRecievedBy.Id = null;
            this._SbRecievedBy.isSearch = true;
            this._SbRecievedBy.LabelText = "Recieved by :";
            this._SbRecievedBy.Location = new System.Drawing.Point(109, 172);
            this._SbRecievedBy.name = null;
            this._SbRecievedBy.Name = "_SbRecievedBy";
            this._SbRecievedBy.ResultText = "";
            this._SbRecievedBy.Size = new System.Drawing.Size(713, 29);
            this._SbRecievedBy.SQL = null;
            this._SbRecievedBy.TabIndex = 5;
            this._SbRecievedBy.TableName = null;
            this._SbRecievedBy.TextBoxText = "";
            // 
            // _SbSuplier
            // 
            this._SbSuplier.BackColor = System.Drawing.Color.Transparent;
            this._SbSuplier.Datasource = null;
            this._SbSuplier.EnableClear = true;
            this._SbSuplier.EnablePop = true;
            this._SbSuplier.GridWidth1 = 100;
            this._SbSuplier.GridWidth2 = 200;
            this._SbSuplier.Id = null;
            this._SbSuplier.isSearch = true;
            this._SbSuplier.LabelText = "Suplier :";
            this._SbSuplier.Location = new System.Drawing.Point(109, 137);
            this._SbSuplier.name = null;
            this._SbSuplier.Name = "_SbSuplier";
            this._SbSuplier.ResultText = "";
            this._SbSuplier.Size = new System.Drawing.Size(713, 29);
            this._SbSuplier.SQL = null;
            this._SbSuplier.TabIndex = 4;
            this._SbSuplier.TableName = null;
            this._SbSuplier.TextBoxText = "";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.txtInvoiceNo.BoxWidth = 223;
            this.txtInvoiceNo.LabelText = "Invoice No :";
            this.txtInvoiceNo.Location = new System.Drawing.Point(109, 5);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.ReadOnly = false;
            this.txtInvoiceNo.Size = new System.Drawing.Size(419, 26);
            this.txtInvoiceNo.TabIndex = 0;
            this.txtInvoiceNo.TextBoxText = "";
            // 
            // _SbVendor
            // 
            this._SbVendor.BackColor = System.Drawing.Color.Transparent;
            this._SbVendor.Datasource = null;
            this._SbVendor.EnableClear = true;
            this._SbVendor.EnablePop = true;
            this._SbVendor.GridWidth1 = 100;
            this._SbVendor.GridWidth2 = 200;
            this._SbVendor.Id = null;
            this._SbVendor.isSearch = false;
            this._SbVendor.LabelText = "Vendor :";
            this._SbVendor.Location = new System.Drawing.Point(109, 102);
            this._SbVendor.name = null;
            this._SbVendor.Name = "_SbVendor";
            this._SbVendor.ResultText = "";
            this._SbVendor.Size = new System.Drawing.Size(713, 29);
            this._SbVendor.SQL = null;
            this._SbVendor.TabIndex = 3;
            this._SbVendor.TableName = null;
            this._SbVendor.TextBoxText = "";
            // 
            // CboCurrency
            // 
            this.CboCurrency.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.CboCurrency.BackColor = System.Drawing.Color.Transparent;
            this.CboCurrency.BoxWidth = 223;
            this.CboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CboCurrency.Item = null;
            this.CboCurrency.LabelText = "Currency :";
            this.CboCurrency.Location = new System.Drawing.Point(109, 70);
            this.CboCurrency.Name = "CboCurrency";
            this.CboCurrency.Size = new System.Drawing.Size(419, 26);
            this.CboCurrency.TabIndex = 2;
            // 
            // dateTimePurchaseDate
            // 
            this.dateTimePurchaseDate.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePurchaseDate.BoxWidth = 223;
            this.dateTimePurchaseDate.EnableDate = true;
            this.dateTimePurchaseDate.FormatDateTime = Utils.Form.DateTimeFormat.DdMmMyyyy;
            this.dateTimePurchaseDate.LabelText = "Purchase Date :";
            this.dateTimePurchaseDate.Location = new System.Drawing.Point(109, 38);
            this.dateTimePurchaseDate.Name = "dateTimePurchaseDate";
            this.dateTimePurchaseDate.Size = new System.Drawing.Size(422, 24);
            this.dateTimePurchaseDate.TabIndex = 1;
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup1.DrownImage = ((System.Drawing.Image)(resources.GetObject("buttonGroup1.DrownImage")));
            this.buttonGroup1.ImageShowDetail = Design.Controls.ButtonGroup.Arrow.Down;
            this.buttonGroup1.Location = new System.Drawing.Point(0, 0);
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Owner = this.panel1;
            this.buttonGroup1.Size = new System.Drawing.Size(1062, 28);
            this.buttonGroup1.TabIndex = 2;
            this.buttonGroup1.Title = "Purchase Information";
            this.buttonGroup1.TitleColor = System.Drawing.Color.Red;
            // 
            // sms_blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGroup1);
            this.Name = "sms_blank";
            this.Text = "sms_blank";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Design.Controls.Panel panel1;
        private Design.Controls.Button button1;
        private Design.Controls.SearchButtonBox _SbApaccount;
        private Design.Controls.SearchButtonBox _SbRecievedBy;
        private Design.Controls.SearchButtonBox _SbSuplier;
        private Design.Controls.TextBoxLabel txtInvoiceNo;
        private Design.Controls.SearchButtonBox _SbVendor;
        private Design.Controls.ComboBoxLabel CboCurrency;
        private Design.Controls.DateTimePIckerLabel dateTimePurchaseDate;
        private Design.Controls.ButtonGroup buttonGroup1;
    }
}
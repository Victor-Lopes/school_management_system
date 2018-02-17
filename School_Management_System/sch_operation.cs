using School_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace School_Management_System
{
    class sch_operation
    {
        public SqlConnection sqlcon;
        public SqlCommand sqlcmd;
        public SqlDataReader sqldr;
        public SqlDataAdapter objda;
        public DataTable objdt;
        public Int32 id;
        //public Int32 idp;
        public sch_operation() { }
        List<string> fileLines = new List<string>();
        public void readFile()
        {
            string line;
            var fileStream = new FileStream(@"SCH.ini", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    fileLines.Add(line);
                }
            }
        }


        public void setConnection()
        {
            readFile();
            string conStr;
            conStr = "Data Source='" + fileLines[0] + "'; Initial Catalog='" + fileLines[1] + "';User ID='" + fileLines[2] + "';Password='" + fileLines[3] + "'";
            try
            {
                sqlcon = new SqlConnection(conStr);
                sqlcon.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //public void runSQL(string sql, SqlTransaction t = null)
        //{
        //    try
        //    {
        //        sqlCmd.Connection = sqlCon;
        //        if (t != null) sqlCmd.Transaction = t;
        //        sqlCmd.CommandType = CommandType.StoredProcedure;
        //        sqlCmd.CommandText = "dbo.spRunSQL";
        //        sqlCmd.Parameters.AddWithValue("@sql", sql);
        //        sqlCmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
        //        sqlCmd.ExecuteNonQuery();
        //        sqlCmd.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void putDataIntoComboBox(string sql, ComboBox cbo)
        {
            try
            {
                setConnection();
                sqlcmd = new SqlCommand("dbo.spRunSQL", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@sql", sql);
                sqldr = sqlcmd.ExecuteReader();
                cbo.Items.Clear();
                while (sqldr.Read())
                {
                    cbo.Items.Add(sqldr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //sqlDR.Close();
            sqlcon.Close();
        }
        public void putDataIntoComboBox_ID(string sql, ComboBox cbo, string name, string id)
        {
            try
            {
                setConnection();
                sqlcmd = new SqlCommand("dbo.spRunSQL", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@sql", sql);
                sqldr = sqlcmd.ExecuteReader();
                cbo.Items.Clear();
                while (sqldr.Read())
                {
                    cbo.Items.Add(sqldr.GetString(0));

                    cbo.DisplayMember = name;
                    cbo.ValueMember = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //sqlDR.Close();
            sqlcon.Close();
        }

        public void fillDataTable(string sql)
        {
            try
            {
                setConnection();
                sqlcmd = new SqlCommand("dbo.spRunSQL", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@sql", sql);
                //Initialize the DataAdapter object 
                //and set the SelectCommand property
                objda = new SqlDataAdapter();
                objda.SelectCommand = sqlcmd;
                //Initialize the DataTable object
                objdt = new DataTable();
                //Populate the DataTable
                objda.Fill(objdt);
                objda.Dispose();
                objda = null;
                sqlcmd.Dispose();
                sqlcmd = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void bindComboBox(ComboBox cbo, String sql,
                    string DisplayField, string ValueField)
        {
            fillDataTable(sql);
            cbo.DisplayMember = DisplayField;
            cbo.ValueMember = ValueField;
            cbo.DataSource = objdt;
            sqlcon.Close();
        }

        public void bindListBox(ListBox Lst, String sql,
                    string DisplayField, string ValueField)
        {
            fillDataTable(sql);
            Lst.DisplayMember = DisplayField;
            Lst.ValueMember = ValueField;
            Lst.DataSource = objdt;
            sqlcon.Close();
        }

        public void displayRecord(string sql, params Control[] ctr)
        {
            try
            {
                int n = ctr.GetUpperBound(0);
                setConnection();
                //sqlcmd = new SqlCommand(sql, sqlcon);
                sqlcmd = new SqlCommand("dbo.spRunSql", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.Read())
                {
                    for (int i = 0; i <= n; i++)
                    {
                        ctr[i].Text = sqldr[i].ToString();
                    }
                }
                sqldr.Close();
                sqlcmd.Dispose();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
            }
        }

        public void enabledControls(Form frm, bool b)
        {
            foreach (Control ctrl in frm.Controls)
                if (ctrl is TextBox || ctrl is DateTimePicker
                    || ctrl is MaskedTextBox || ctrl is RichTextBox)
                    if (ctrl.Tag == null) ctrl.Enabled = b;
        }

        public void enabledControls(Panel pnl, bool b)
        {
            foreach (Control ctrl in pnl.Controls)
                if (ctrl is TextBox || ctrl is DateTimePicker
                    || ctrl is MaskedTextBox || ctrl is RichTextBox)
                    if (ctrl.Tag == null) ctrl.Enabled = b;
        }

        public void enabledControls(GroupBox frm, bool b)
        {
            foreach (Control ctrl in frm.Controls)
                if (ctrl is TextBox || ctrl is DateTimePicker
                    || ctrl is MaskedTextBox || ctrl is RichTextBox)
                    if (ctrl.Tag == null) ctrl.Enabled = b;
        }

        public void enabledButtons(Form frm, bool b)
        {
            foreach (Control ctrl in frm.Controls)
                if (ctrl is Button)
                    if (ctrl.Tag == null) ctrl.Enabled = false;
        }



        public bool checkEmpty(System.Windows.Forms.ErrorProvider ep,
                    params Control[] ctr)
        {
            int n = ctr.GetUpperBound(0);
            bool b = false;
            for (int i = 0; i <= n; i++)
            {
                if (ctr[i].Text == "")
                {
                    ep.SetError(ctr[i], "សូមបញ្ចូលតំលៃរបស់ " +
                        ctr[i].Name.Substring(3, ctr[i].Name.Length - 3));
                    b = true;
                }
               
            }
            return (b);
        }

        public void clearCtr(params Control[] ctr)
        {
            int n = ctr.GetUpperBound(0);
            for (int i = 0; i <= n; i++)
                ctr[i].Text = "";
        }

        public void clearControls(Form frm)
        {
            foreach (Control ctr in frm.Controls)
                if (ctr is TextBox || ctr is ComboBox ||
                        ctr is MaskedTextBox)
                    if (ctr.Tag == null) ctr.Text = "";
        }

        public void clearControls(Panel frm)
        {
            foreach (Control ctr in frm.Controls)
                if (ctr is TextBox || ctr is ComboBox ||
                        ctr is MaskedTextBox)
                    if (ctr.Tag == null) ctr.Text = "";
        }

        public void clearControls(GroupBox frm)
        {
            foreach (Control ctr in frm.Controls)
                if (ctr is TextBox || ctr is ComboBox ||
                        ctr is MaskedTextBox)
                    if (ctr.Tag == null) ctr.Text = "";
        }

        public void clearControls(TabControl tbc)
        {
            foreach (Control ctr in tbc.Controls)
                if (ctr is TextBox || ctr is ComboBox ||
                    ctr is MaskedTextBox)
                    if (ctr.Tag == null) ctr.Text = "";
        }

        public void clearControlInGroupBox(GroupBox gbox)
        {
            foreach (Control ctr in gbox.Controls)
                if (ctr is TextBox || ctr is ComboBox ||
                    ctr is MaskedTextBox)
                if (ctr.Tag == null) ctr.Text = "";
        }

        public void closeForm(Form frm)
        {
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult ans;
            ans = MessageBox.Show("តើអ្នកចង់បិទ Form ដែរឬទេ?", "បិទ Form", btn, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes) frm.Close();

        }
        public void headerListView(string hrd, ListView Lv)
        {
            string colName;
            int w;
            Lv.Columns.Clear();
            string[] col = hrd.Split('|');
            foreach (string str in col)
            {
                string[] colHead = str.Split(';');
                colName = colHead[0];
                w = Int16.Parse(colHead[1]);
                Lv.Columns.Add(colName, w);
            }
            Lv.View = View.Details;
            Lv.GridLines = true;
            Lv.FullRowSelect = true;
            Lv.Font = new System.Drawing.Font(Lv.Font.FontFamily, 10);
        }

        public void bindListView(ListView LV, string sql, params string[] data)
        {
            LV.Items.Clear();
            int n = data.GetUpperBound(0);
            setConnection();
            //sqlCmd = new SqlCommand(sql, sqlCon);
            sqlcmd = new SqlCommand("dbo.spRunSQL", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;

            sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {


                ListViewItem item = new ListViewItem(sqldr[data[0]].ToString());
                for (int i = 1; i <= n; i++)
                {
                    item.SubItems.Add(sqldr[data[i]].ToString());
                }
                LV.Items.Add(item);
            }
            sqldr.Close();
            sqlcmd.Dispose();

        }

        public void addItemListView(ListView LV, params string[] data)
        {
            ListViewItem item = new ListViewItem(data);
            LV.Items.Add(item);
        }

        public bool checkInListView(string data, ListView LV, Int16 col)
        {
            bool b = false;
            string temp = "";
            data = data.ToUpper();
            foreach (ListViewItem Lvi in LV.Items)
            {
                temp = Lvi.SubItems[col].Text.ToUpper();
                if (data == temp)
                {
                    b = true;
                    break;
                }
            }
            return (b);
        }

        

        public bool checkInListView_ID(string data, ListView LV, Int16 col)
        {
            bool b = false;
            string temp = "";
            data = data.ToUpper();
            foreach (ListViewItem Lvi in LV.Items)
            {
                temp = Lvi.SubItems[col].Text.ToUpper();
                if (data == temp)
                {
                    b = true;
                    break;
                }
            }
            return (b);
        }
        public void removeRowInListView(ListView LV)
        {
            foreach (ListViewItem Lvi in LV.Items)
            {
                if (Lvi.Selected == true || Lvi.Checked == true)
                    Lvi.Remove();
            }
        }

        public float sumDataInListView(ListView LV, Int16 col)
        {
            float t = 0;
            foreach (ListViewItem Lvi in LV.Items)
            {
                string a = Lvi.SubItems[col].Text;
                Int16 n = Int16.Parse(a.Length.ToString());
                if (a.Substring(0, 1) == "$")
                    t = t + float.Parse(a.Substring(1, n - 1));
                else
                    t = t + float.Parse(a);
            }
            return (t);
        }

       
        public string sumDataInGrindView(DataGridView DGV, Int16 col)
        {
            double sum = 0;
            for (int i = 0; i < DGV.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGV.Rows[i].Cells[col].Value);
            }            
            return (sum.ToString());
        }

        public void bindGridView(DataGridView Gv, string sql)
        {
            setConnection();
            sqlcmd = sqlcon.CreateCommand();
            sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandType = CommandType.Text;

            objda = new SqlDataAdapter(sql, sqlcon);
            objdt = new DataTable();
            objda.Fill(objdt);
            Gv.DataSource = objdt;
        }

        public void bindGridView(DataGridView Gv, string sql,string status)
        {
            setConnection();
            sqlcmd = new SqlCommand(sql, sqlcon);
            sqldr = sqlcmd.ExecuteReader();
            try{
            
                    int i = 0;
                    while (sqldr.Read())
                    {
                        Gv.Rows[i].Cells["Education"].Value = sqldr["education"].ToString();
                        Gv.Rows[i].Cells["EducationName"].Value = sqldr["education_name"].ToString();
                        Gv.Rows[i].Cells["StartYear"].Value = sqldr["start_year"].ToString();
                        Gv.Rows[i].Cells["EndYear"].Value = sqldr["end_year"].ToString();
                        Gv.Rows[i].Cells["Description"].Value = sqldr["description"].ToString();
                        i++;
                    }
                  //What to write here while my DataGridView Name is ufGView and it has 
                  //4 column. Names are Id, IdNo{TextBox}, Status{CheckBox}, Action{HyperLink}
               
            }
            catch (Exception exp)
            {
                   MessageBox.Show(exp.Message.ToString(), "Exception in CheckFamilyMembers");
            }
        }

        internal void autoSizeModeDataGrind(DataGridView dataGridView1)
        {
            try
            {

                foreach (DataGridViewColumn GrindCol in dataGridView1.Columns)
                {
                    for (int i = 0; i < GrindCol.DataGridView.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ërror");
            }
        }


        public static void savetocsv(DataGridView DGV,string file)
        {
            try
            {
                string filename = "";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = file+".csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(filename))
                    {
                        try
                        {
                            File.Delete(filename);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    int columnCount = DGV.ColumnCount;
                    string columnNames = "";
                    string[] output = new string[DGV.RowCount + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += DGV.Columns[i].Name.ToString() + ",";
                    }
                    output[0] += columnNames;
                    for (int i = 1; (i - 1) < DGV.RowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                    }
                    System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                    MessageBox.Show("Data will be exported and you will be notified when it is ready.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void bindComboBoxFilter(DataGridView dataGridView1,ComboBox cbo)
        {
            for (var i = 0; i < dataGridView1.ColumnCount; i++)
            {
                var name = dataGridView1.Columns[i].HeaderText;
                cbo.Items.Add(name);
            }
        }
         
        // count rows from table sql server 
        public string cuntRows(string sql)
        {
            setConnection();
            //sqlCmd = new SqlCommand(sql, sqlCon);
            sqlcmd = new SqlCommand("dbo.spRunSQL", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
            int count = 0;
            sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
            {
                count++;
            }
            return count.ToString();
        }

        public void cuntStock(string sql,params Control[] ctr)
        {
            try
            {
                int n = ctr.GetUpperBound(0);
                setConnection();
                //sqlCmd = new SqlCommand(sql, sqlCon);
                sqlcmd = new SqlCommand("dbo.spRunSQL", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@sql", SqlDbType.NText).Value = sql;
                sqldr = sqlcmd.ExecuteReader();
                if (sqldr.Read())
                {
                    for (int i = 0; i <= n; i++)
                    {
                        ctr[i].Text = sqldr.GetValue(i).ToString();
                    }
                }
                //sqlDR.Close();
                sqlcmd.Dispose();
            }
            catch (Exception ex)
            { //MessageBox.Show(ex.Message); 
            }            
        }
        

        public static void set2Kh()
        {
            //if (Application.CurrentInputLanguage.Culture.Name != "km-KH")
            //    SendKeys.Send("+%");
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
        }

        public static void set2En()
        {
            //if (Application.CurrentInputLanguage.Culture.Name != "us-US")
            //    SendKeys.Send("+%");
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
        }


        public static void setMaskNumber(TextBox txt)
        {
            string tmp = txt.Text;
            string num = "";
            foreach (char k in tmp)
            {
                if (char.IsDigit(k))
                {
                    num += k;
                }
            }
            txt.Text = num;
        }

        public void saveUserlog(string sid,string snm,string dt,string des)
        {            
            try
            {
                setConnection();
                sqlcmd = sqlcon.CreateCommand();
                sqlcmd.CommandText = "sp_pos_userlog";
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("StaffID", sid);
                sqlcmd.Parameters.AddWithValue("StaffName", snm);
                sqlcmd.Parameters.AddWithValue("UserlogDate", dt);
                sqlcmd.Parameters.AddWithValue("Description", des); 
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Commit Exception Type: " + ex.GetType(), "Commit Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("  Message: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void superMessage(string msg,string title)
        {
            MessageBox.Show(msg,title);
        }

        public void saveProperties(string us, string ps, string sid, string snm, string pos)
        {
            Settings.Default.Username = us;
            Settings.Default.Password = ps;
            Settings.Default.StaffID = sid;
            Settings.Default.StaffName = snm;
            Settings.Default.Position = pos;
            Settings.Default.Save();
        }

        public void clearProperties()
        {
            Settings.Default.Username = "";
            Settings.Default.Password = "";
            Settings.Default.StaffID = "";
            Settings.Default.StaffName = "";
            Settings.Default.Position = "";
            Settings.Default.Save();
        }

        public void Set2Kh()
        {
            //if (Application.CurrentInputLanguage.Culture.Name != "km-KH")
            //    SendKeys.Send("+%");
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
        }
        public void Set2En()
        {
            //if (Application.CurrentInputLanguage.Culture.Name != "us-US")
            //    SendKeys.Send("+%");
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
        }
    }
}

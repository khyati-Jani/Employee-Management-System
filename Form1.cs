using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Employee_Management
{
    public partial class Form1 : Form
    {
        string connectionString = "User Id=system;Password=Khyati;Data Source=localhost:1521;";
        OracleConnection oracleConnection;

        OracleDataAdapter oracleDataAdapter;

        public object AddProfile { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDesignation()
        {
            try
            {

                string Desquery = "select des_id,des_name from designation";
                OracleCommand cmd = new OracleCommand(Desquery, oracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader);
                cmbdesignation.DisplayMember = "des_name";
                cmbdesignation.ValueMember = "des_id";
                cmbdesignation.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
        private void LoadCountry()
        {
            try
            {
                string Desquery = "select country_id,country_name from country";
                OracleCommand cmd = new OracleCommand(Desquery, oracleConnection);
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader);
                cmbcountry.DisplayMember = "country_name";
                cmbcountry.ValueMember = "country_id";
                cmbcountry.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                oracleConnection = new OracleConnection(connectionString);
                oracleConnection.Open();
                LoadDesignation();
                LoadCountry();

                string query = "select * from emp";
                OracleCommand cmd = new OracleCommand(query, oracleConnection);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //add column for adding image
                dt.Columns.Add("PROFILE_IMAGE", typeof(Image));

                //dataGridView1.DataSource = dt;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["profile"] != DBNull.Value)
                    {
                        //        //IMAGE = FIELD NAMES
                        string path = row["profile"].ToString();
                        if (File.Exists(path))
                        {
                            row["PROFILE_IMAGE"] = Image.FromFile(path);
                        }
                    }
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["profile"].Visible = false;

                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridView1.Columns["PROFILE_IMAGE"];
                imgCol.HeaderText = "Profile";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.RowTemplate.Height = 60;

               
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnEdit";
                btn.HeaderText = "action";
                btn.Text = "edit";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);

                // oracleConnection.Close();
                DataGridViewButtonColumn btnd = new DataGridViewButtonColumn();
                btnd.Name = "btndel1";
                btnd.HeaderText = "action delete";
                btnd.Text = "delete";
                btnd.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (oracleConnection.State == ConnectionState.Closed)
                //oracleConnection.Open();
                string imagePath = pictureBox1.Tag == null ? "" : pictureBox1.Tag.ToString();
                string insertquery = $@"insert into emp values('{txtid.Text}','{txtname.Text}',TO_DATE('{dtpdoj.Value:yyyy-MM-dd}','YYYY-MM-DD'),{cmbdesignation.SelectedValue},TO_DATE('{dtpdob.Value:yyyy-MM-dd}','YYYY-MM-DD'),{cmbcountry.SelectedValue},{cmbstate.SelectedValue},{cmbcity.SelectedValue},'{imagePath}')";

                OracleCommand cmd = new OracleCommand(insertquery, oracleConnection);
                cmd.ExecuteNonQuery();
               // oracleConnection.Close();
                MessageBox.Show("Data Inserted SuccessFully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmbcountry_DropDownClosed(object sender, EventArgs e)
        {
            //if (oracleConnection.State == ConnectionState.Closed)
            //    oracleConnection.Open();
            oracleDataAdapter = new OracleDataAdapter("select state_id,state_name from state where country_id=" + cmbcountry.SelectedValue, oracleConnection);
            DataTable dtstate = new DataTable();
            oracleDataAdapter.Fill(dtstate);
            cmbstate.ValueMember = "state_id";
            cmbstate.DisplayMember = "state_name";
            cmbstate.DataSource = dtstate;
        }

        private void cmbcity_DropDownClosed(object sender, EventArgs e)
        {
            oracleDataAdapter = new OracleDataAdapter("select city_id,city_name from city where state_id=" + cmbstate.SelectedValue, oracleConnection);
            DataTable dtcity = new DataTable();
            oracleDataAdapter.Fill(dtcity);
            cmbcity.ValueMember = "city_id";
            cmbcity.DisplayMember = "city_name";
            cmbcity.DataSource = dtcity;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["eid"].Value.ToString();
                txtname.Text = row.Cells["ename"].Value.ToString();
                dtpdob.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                dtpdoj.Value = Convert.ToDateTime(row.Cells["DOJ"].Value);
                cmbcountry.SelectedValue = row.Cells["country_id"].Value;

                // Load States Again (important)
                cmbcountry_DropDownClosed(null, null);

                //  Set State
                cmbstate.SelectedValue = row.Cells["state_id"].Value;

                // Load Cities Again (important)
                cmbcity_DropDownClosed(null, null);
                // Set City
                cmbcity.SelectedValue = row.Cells["city_id"].Value;

                string path = row.Cells["profile"].Value.ToString();

                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                    pictureBox1.Tag = path;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btndel1")
            {
                DialogResult result = MessageBox.Show("are you sure you want to delete this record?", "confirm delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["eid"].Value.ToString();
                  //  DeleteEmployee(id);
                    //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["profile"].Value);

                    DeleteEmployee(id); //call delete method
                }
            }
        }

        private void DeleteEmployee(string id)
        {
            try
            {
                string query = "delete from emp where eid='" + id+"'";
                OracleCommand cmd = new OracleCommand(query, oracleConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted successfully");
                // LoadData();   //refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select the profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.Tag = filePath;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection(connectionString);
          //  connection.Open();
            string query = $@"delete from emp where eid='{txtid.Text}'";
            try
            {
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection(connectionString);
           // connection.Open();
            string query = $@"update emp set ename='{txtname.Text}' where eid={txtid.Text}";
            try
            {
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string query = "select * from emp";
            OracleCommand cmd = new OracleCommand(query, oracleConnection);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns.Add("PROFILE_IMAGE", typeof(Image));

            foreach (DataRow row in dt.Rows)
            {
                if (row["profile"] != DBNull.Value && !string.IsNullOrEmpty(row["profile"].ToString()))
                {
                    string path = row["profile"].ToString();
                    if (File.Exists(path))
                    {
                        row["PROFILE_IMAGE"] = Image.FromFile(path);
                    }
                }
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["profile"].Visible = false;
        }
    }
}




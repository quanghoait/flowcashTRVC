using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace flowcashTRVC
{
    public partial class Code : Form
    {
        public Code()
        {
            InitializeComponent();

        }


        
      
        private void Code_Load(object sender, EventArgs e)
        {

            string host = "localhost";
            int port = 3306;
            string database = "ManagerFlowMonneyTrad";
            string username = "root";
            string password = "Trad99999";

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string request = "SELECT * FROM CodeTable";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewCode.DataSource = dataTable;
                }

            }

        }
        private void btnInsertcode_Click(object sender, EventArgs e)
        {

            string host = "localhost";
            int port = 3306;
            string database = "ManagerFlowMonneyTrad";
            string username = "root";
            string password = "Trad99999";

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('"+txtS_code.Text+ "','"+txtAccount_No.Text+ "','"+txtItemName.Text+ "','"+txtKind.Text+ "','"+txtBank.Text+ "','"+txtType.Text + "')"; 
            string request = "INSERT INTO CodeTable(S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('" + txtS_code.Text + "','" + txtF.Text + "','" + txtItemName.Text + "','" + txtKind.Text + "','" + txtAccount_No.Text + "','" + txtBank.Text + "','" + txtType.Text + "')";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Read_Data();
                    txtItemName.Text = String.Empty;


                }

            }
        }
        private void Read_Data()
        {
            string host = "localhost";
            int port = 3306;
            string database = "ManagerFlowMonneyTrad";
            string username = "root";
            string password = "Trad99999";

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string request = "SELECT * FROM CodeTable";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewCode.DataSource = dataTable;
                    connection.Close();
                }

            }

            txtNo.Text = String.Empty;
            txtS_code.Text = String.Empty;
            txtItemName.Text = String.Empty;
            txtKind.Text = String.Empty;
            txtAccount_No.Text = String.Empty;
            txtBank.Text = String.Empty;
            txtType.Text = String.Empty;

        }
        private void dataGridViewCode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewCode.CurrentRow.Index;
            txtNo.Text = dataGridViewCode.Rows[i].Cells[0].Value.ToString();
            txtS_code.Text = dataGridViewCode.Rows[i].Cells[1].Value.ToString();
            txtF.Text = dataGridViewCode.Rows[i].Cells[2].Value.ToString();
            txtItemName.Text = dataGridViewCode.Rows[i].Cells[3].Value.ToString();
            txtKind.Text = dataGridViewCode.Rows[i].Cells[4].Value.ToString();
            txtAccount_No.Text = dataGridViewCode.Rows[i].Cells[5].Value.ToString();
            txtBank.Text = dataGridViewCode.Rows[i].Cells[6].Value.ToString();
            txtType.Text = dataGridViewCode.Rows[i].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            int port = 3306;
            string database = "ManagerFlowMonneyTrad";
            string username = "root";
            string password = "Trad99999";

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //  string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('" + txtS_code.Text + "','" + txtAccount_No.Text + "','" + txtItemName.Text + "','" + txtKind.Text + "','" + txtBank.Text + "','" + txtType.Text + "')";
            string request = "UPDATE CodeTable SET S_code = '" + txtS_code.Text + "',F = '" + txtF.Text + "',ItemName = '" + txtItemName.Text + "',the_kind = '" + txtKind.Text + "',Account_No = '" + txtAccount_No.Text + "',Bank = '" + txtBank.Text + "',Type = '" + txtType.Text + "' WHERE ID = '" + txtNo.Text + "';";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Read_Data();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            int port = 3306;
            string database = "ManagerFlowMonneyTrad";
            string username = "root";
            string password = "Trad99999";

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //  string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('" + txtS_code.Text + "','" + txtAccount_No.Text + "','" + txtItemName.Text + "','" + txtKind.Text + "','" + txtBank.Text + "','" + txtType.Text + "')";
            string request = "DELETE FROM CodeTable WHERE ID = '" + txtNo.Text + "'";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Read_Data();

                }
            }
        }

        private void cbbCode_DropDown(object sender, EventArgs e)
        {

            cbbCode.Items.Clear();
            cbbCode.Items.Add("S_code");
            cbbCode.Items.Add("F");
            cbbCode.Items.Add("ItemName");
            cbbCode.Items.Add("the_kind");
            cbbCode.Items.Add("Account_No");
            cbbCode.Items.Add("Bank");
            cbbCode.Items.Add("Type");

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if (cbbCode.Text == "S_code")
            {
                string host = "localhost";
                int port = 3306;
                string database = "ManagerFlowMonneyTrad";
                string username = "root";
                string password = "Trad99999";

                string connString = "Server=" + host + ";Database=" + database
           + ";port=" + port + ";User Id=" + username + ";password=" + password;
                string request = "SELECT * FROM CodeTable where S_code like '%" + txtSeachcode.Text.Trim() + "%' ";
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(request, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCode.DataSource = dataTable;
                        connection.Close();

                    }
                }
            }
            else if (cbbCode.Text == "the_kind")
            {
                string host = "localhost";
                int port = 3306;
                string database = "ManagerFlowMonneyTrad";
                string username = "root";
                string password = "Trad99999";

                string connString = "Server=" + host + ";Database=" + database
           + ";port=" + port + ";User Id=" + username + ";password=" + password;
                string request = "SELECT * FROM CodeTable where the_kind like '%" + txtSeachcode.Text.Trim() + "%' ";
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(request, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCode.DataSource = dataTable;
                        connection.Close();

                    }
                }
            }
        }

        private void txtSeachcode_TextChanged(object sender, EventArgs e)
        {
            if (cbbCode.Text == "S_code")
            {
                string host = "localhost";
                int port = 3306;
                string database = "ManagerFlowMonneyTrad";
                string username = "root";
                string password = "Trad99999";

                string connString = "Server=" + host + ";Database=" + database
           + ";port=" + port + ";User Id=" + username + ";password=" + password;
                string request = "SELECT * FROM CodeTable where S_code like '%" + txtSeachcode.Text.Trim() + "%' ";
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(request, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCode.DataSource = dataTable;
                        connection.Close();

                    }
                }
            }
            else if (cbbCode.Text == "the_kind")
            {
                string host = "localhost";
                int port = 3306;
                string database = "ManagerFlowMonneyTrad";
                string username = "root";
                string password = "Trad99999";

                string connString = "Server=" + host + ";Database=" + database
           + ";port=" + port + ";User Id=" + username + ";password=" + password;
                string request = "SELECT * FROM CodeTable where the_kind like '%" + txtSeachcode.Text.Trim() + "%' ";
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(request, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCode.DataSource = dataTable;
                        connection.Close();

                    }
                }
            }
        }
        public delegate void getData(string data);
        public getData myData;
        public delegate void getData1(string data1);
        public getData1 myData1;
        //public getData myData1;
        private void btnChoose_Click(object sender, EventArgs e)
        {

              myData(txtS_code.Text);
              myData1(txtF.Text);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNo.Text = String.Empty;
            txtF.Text = String.Empty;
            txtS_code.Text = String.Empty;
            txtItemName.Text = String.Empty;
            txtKind.Text = String.Empty;
            txtAccount_No.Text = String.Empty;
            txtBank.Text = String.Empty;
            txtType.Text = String.Empty;
        }
    }
}

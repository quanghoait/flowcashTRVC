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
            string request = "INSERT INTO CodeTable( S_code) VALUES ('"+txtS_code.Text+"')"; 
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

        }
        private void dataGridViewCode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewCode.CurrentRow.Index;
            txtS_code.Text = dataGridViewCode.Rows[i].Cells[1].Value.ToString();
            txtF.Text = dataGridViewCode.Rows[i].Cells[2].Value.ToString();
            txtItemName.Text = dataGridViewCode.Rows[i].Cells[3].Value.ToString();
            txtKind.Text = dataGridViewCode.Rows[i].Cells[4].Value.ToString();
            txtAccount_No.Text = dataGridViewCode.Rows[i].Cells[5].Value.ToString();
            txtBank.Text = dataGridViewCode.Rows[i].Cells[6].Value.ToString();
            txtType.Text = dataGridViewCode.Rows[i].Cells[7].Value.ToString();
        }
    }
}


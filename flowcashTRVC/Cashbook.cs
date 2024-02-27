
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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

//using Word = Microsoft.Office.Interop.Word;
//using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Office.Interop.Excel;
using System.Security.Policy;

namespace flowcashTRVC
{
    public partial class Cashbook : Form
    {
        string strNhan;



        string host = "localhost";
        int port = 3306;
        string database = "ManagerFlowMonneyTrad";
        string username = "root";
        string password = "Trad99999";

        public Cashbook()
        {
            InitializeComponent();

           // ExcelApp.Application excelApp = new ExcelApp.Application();
           // ExcelApp.Workbook excelBook = excelApp.Workbooks.Open("D:\\hoa\\test_1.xlsx");

            //DateTime dateTime = dateTimePickerCash.Value;
            //MessageBox.Show(""+dateTime.Year);
        }
        public Cashbook(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
            lbMaCode.Text = strNhan;
        }




        private void label8_TextChanged(object sender, EventArgs e)
        {
            //string a = maCash.Text;
            //string kind_cash = comboKindcash.Text;
            ////string passWord = txtPassword.Text;
            //string connString = "Server=" + host + ";Database=" + database
            // + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //string request = "SELECT MaCash FROM MaCashTable where NameMa ='" + kind_cash + "' ";
            //using (MySqlConnection connection = new MySqlConnection(connString))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand(request, connection))
            //    {
            //        connection.Open();
            //        MySqlDataReader reader = cmd.ExecuteReader();
            //        StringBuilder sb = new StringBuilder();
            //        while (reader.Read())
            //        {
            //            //MessageBox.Show(reader.GetString(0));
            //            // MessageBox.Show("dang nhap thanh cong");
            //            //sb.Append(reader.GetInt32(0).ToString());

            //            maCash.Text = sb.ToString();

            //        }
            //    }
            //}
            }

        private void maCash_Click(object sender, EventArgs e)
        {

            //string kind_cash = "H15-795-011595";
            //string connString = "Server=" + host + ";Database=" + database
            // + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //string request = "SELECT MaCash FROM MaCashTable where NameMa ='" + kind_cash + "'";
            //using (MySqlConnection connection = new MySqlConnection(connString))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand(request, connection))
            //    {
            //        connection.Open();
            //        MySqlDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            MessageBox.Show(reader["MaCash"].ToString());
            //        }
            //    }
            //}
        }

        private void comboKindcash_DropDown(object sender, EventArgs e)
        {
            cbbKindCach.Items.Clear();
            cbbKindCach.Items.Add("Cash");
            cbbKindCach.Items.Add("VND (VIETCOMBANK)");
            cbbKindCach.Items.Add("H15-795-011595");
            cbbKindCach.Items.Add("F15-795-011587");
            cbbKindCach.Items.Add("F15-795-011919");
        }

        private void cbbKindCach_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerCash.Value;
            //MessageBox.Show("" + dateTime.Year);
            //MessageBox.Show("" + dateTime.Month);

            //MessageBox.Show(""+cbbKindCach.SelectedItem.ToString());
            string kind_cash = cbbKindCach.SelectedItem.ToString();
            string connString = "Server=" + host + ";Database=" + database
             + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string request = "SELECT MaCash FROM MaCashTable where NameMa ='" + kind_cash + "'";
           
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string textdisplayKindCash = reader["MaCash"].ToString()+ ""+dateTime.Year+""+dateTime.Month;
                        //MessageBox.Show(reader["MaCash"].ToString());
                        //displayKindCash.Text = reader["MaCash"].ToString();
                        displayKindCash.Text = textdisplayKindCash;
                        //DateTime dateTime = dateTimePickerCash.Value;
                        //MessageBox.Show("" + dateTime.Year);

                    }
                }
            }
        }
       
        private void insertCashBook_Click(object sender, EventArgs e)
        {
            //string kind_cash = cbbKindCach.SelectedItem.ToString();
            // string kind_cash = cbbKindCach.SelectedItem.ToString();
            //string connString = "Server=" + host + ";Database=" + database
            // + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //string request = "SELECT Balance   FROM CashBook where ID_CashBook = (SELECT max(ID_CashBook)  FROM CashBook);";

            //using (MySqlConnection connection = new MySqlConnection(connString))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand(request, connection))
            //    {
            //        connection.Open();
            //        MySqlDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {

            //            displayBalance.Text = reader["Balance"].ToString();


            //        }
            //    }
            //}
            string host = "localhost";
            int port = 3306;
            string database = "ManagerFlowMonneyTrad";
            string username = "root";
            string password = "Trad99999";

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string request = "SELECT * FROM MaCashTable where NameMa = Cash";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string textdisplayKindCash = reader["ID_Cash"].ToString();
                        //MessageBox.Show(reader["MaCash"].ToString());
                        //displayKindCash.Text = reader["MaCash"].ToString();
                        displayKindCash.Text = textdisplayKindCash;
                        //DateTime dateTime = dateTimePickerCash.Value;
                        //MessageBox.Show("" + dateTime.Year);

                    }
                }
            }
            //string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('"+txtS_code.Text+ "','"+txtAccount_No.Text+ "','"+txtItemName.Text+ "','"+txtKind.Text+ "','"+txtBank.Text+ "','"+txtType.Text + "')"; 
            //string request = "INSERT INTO CashBook( ID_Cash,ID,Date_Cash,Decscription,Income,Payment,Balance) VALUES ('"++"',2,'2008-11-11',\"Receive money from debit note 2310-02- Tax receivable from Takasago\",5000,3000,19000);";
            //using (MySqlConnection connection = new MySqlConnection(connString))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand(request, connection))
            //    {
            //        connection.Open();
            //        cmd.ExecuteNonQuery();
            //        connection.Close();
            //       // Read_Data();
            //        //txtItemName.Text = String.Empty;


            //    }

            //}
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {

            Excel.Application objXL = null;
            Excel._Workbook objWB = null;
            objXL = new Excel.Application();
            objXL.Visible = true;
            var newWB = objXL.Workbooks.Open("file:///D:\\hoa\\C#\\flowcashTRVC\\CashBook.xlsx");
            var newSheet = newWB.Worksheets;
            //newSheet.Name = "CashBook";
            //newSheet.Cells.InsertRows(1, 2);

        }

        private void cbbKindCach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cashbook_Load(object sender, EventArgs e)
        {

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string request = "SELECT * FROM CashBook";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dataViewCashBook.DataSource = dataTable;
                }

            }

        }
        public void getValue(string value)
        {
            lbMaCode.Text = value;
        }

        private void bynshowCode_Click(object sender, EventArgs e)
        {
            Code code = new Code();
            code.myData = new Code.getData(getValue);
            code.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    txtNo.Text = String.Empty;
        //    txtS_code.Text = String.Empty;
        //    txtItemName.Text = String.Empty;
        //    txtKind.Text = String.Empty;
        //    txtAccount_No.Text = String.Empty;
        //    txtBank.Text = String.Empty;
        //    txtType.Text = String.Empty;
        }
    }
    }


       
    


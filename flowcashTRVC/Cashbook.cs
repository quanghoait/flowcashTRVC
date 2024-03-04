
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
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Mysqlx.Resultset;

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
                        string textdisplayKindCash = reader["MaCash"].ToString() + "" + dateTime.Year + "" + dateTime.Month;
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

            DateTime dateTime = dateTimePickerCash.Value;
            string connString = "Server=" + host + ";Database=" + database
      + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('"+txtS_code.Text+ "','"+txtAccount_No.Text+ "','"+txtItemName.Text+ "','"+txtKind.Text+ "','"+txtBank.Text+ "','"+txtType.Text + "')"; 
            string request = "INSERT INTO CashBook( Ma,Date_Cash,Decscription,Income,Payment,Balance,SupplierCode,SupplierName) VALUES ('" + displayKindCash.Text + "','" + dateTime.ToShortDateString() + "','" + textDecscription.Text + "','" + txtIncome.Text + "','" + txtPayment.Text + "','" + displayBalance.Text + "','" + lbMaCode.Text + "','" + lbNameCode.Text + "');";
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

        

        private void Cashbook_Load(object sender, EventArgs e)
        {

            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            // string request = "SELECT * FROM CashBook";
            string request = "SELECT * FROM CashBook where  Month(Date_Cash)='" + cbbMonth.Text + "'";
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
        public void getValue1(string value)
        {
            lbNameCode.Text = value;
        }

        private void bynshowCode_Click(object sender, EventArgs e)
        {
            Code code = new Code();
            code.myData = new Code.getData(getValue);
            code.myData1 = new Code.getData1(getValue1);
            code.Show();
        }





        private void txtPayment_TextChanged(object sender, EventArgs e)
        {


            if (txtPayment.Text == "")
            {
                txtPayment.Text="";
            }
            else
            {
                string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
                string request = "SELECT Balance   FROM CashBook where ID_CashBook = (SELECT max(ID_CashBook)  FROM CashBook);";

                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(request, connection))
                    {
                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            float Balace = float.Parse(reader["Balance"].ToString());
                            float sumBalace = Balace + float.Parse(txtIncome.Text) - float.Parse(txtPayment.Text);
                            displayBalance.Text = sumBalace.ToString();


                        }

                    }


           
                }
            }
        }



        private void dataViewCashBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateTime = dateTimePickerCash.Value;
            int i;
            i = dataViewCashBook.CurrentRow.Index;
            displayKindCash.Text = dataViewCashBook.Rows[i].Cells[1].Value.ToString();
            dateTimePickerCash.Text = dataViewCashBook.Rows[i].Cells[2].Value.ToString();
            textDecscription.Text = dataViewCashBook.Rows[i].Cells[3].Value.ToString();
            txtIncome.Text = dataViewCashBook.Rows[i].Cells[4].Value.ToString();
            txtPayment.Text = dataViewCashBook.Rows[i].Cells[5].Value.ToString();
            displayBalance.Text = dataViewCashBook.Rows[i].Cells[6].Value.ToString();
            lbMaCode.Text = dataViewCashBook.Rows[i].Cells[7].Value.ToString();
            lbNameCode.Text = dataViewCashBook.Rows[i].Cells[8].Value.ToString();
            txtNocashbook.Text = dataViewCashBook.Rows[i].Cells[0].Value.ToString();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            displayKindCash.Text = String.Empty;
            dateTimePickerCash.Text = String.Empty;
            textDecscription.Text = String.Empty;
            txtIncome.Text = "";
            txtPayment.Text = "";
            lbMaCode.Text = String.Empty;
            lbNameCode.Text = String.Empty;
            displayBalance.Text = string.Empty;
        }
        // Edit 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerCash.Value;
            string connString = "Server=" + host + ";Database=" + database
      + ";port=" + port + ";User Id=" + username + ";password=" + password;
            // string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('" + txtS_code.Text + "','" + txtAccount_No.Text + "','" + txtItemName.Text + "','" + txtKind.Text + "','" + txtBank.Text + "','" + txtType.Text + "')";
            string request = "UPDATE CashBook SET Ma = '" + displayKindCash.Text + "', Date_Cash = '" + dateTime.ToShortDateString() + "',Decscription = '" + textDecscription.Text + "',Income = '" + txtIncome.Text + "',Payment = '" + txtPayment.Text + "',SupplierCode = '" + lbMaCode.Text + "',SupplierName = '" + lbNameCode.Text + "' WHERE ID_CashBook = '" + txtNocashbook.Text + "';";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Read_Data();
                    displayKindCash.Text = String.Empty;
                    dateTimePickerCash.Text = String.Empty;
                    textDecscription.Text = String.Empty;
                    txtIncome.Text = "0";
                    txtPayment.Text = "0";
                    lbMaCode.Text = String.Empty;
                    lbNameCode.Text = String.Empty;
                    txtNocashbook.Text = String.Empty;
                }
            }
        }
        // Delete
        private void btnDeleteCashBook_Click(object sender, EventArgs e)
        {
            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //  string request = "INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ('" + txtS_code.Text + "','" + txtAccount_No.Text + "','" + txtItemName.Text + "','" + txtKind.Text + "','" + txtBank.Text + "','" + txtType.Text + "')";
            string request = "DELETE FROM CashBook WHERE ID_CashBook = '" + txtNocashbook.Text + "'";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(request, connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Read_Data();
                    displayKindCash.Text = String.Empty;
                    dateTimePickerCash.Text = String.Empty;
                    textDecscription.Text = String.Empty;
                    txtIncome.Text = "0";
                    txtPayment.Text = "0";
                    lbMaCode.Text = String.Empty;
                    lbNameCode.Text = String.Empty;
                    txtNocashbook.Text = String.Empty;
                }
            }
        }

        private void btnSeachCashbook_Click(object sender, EventArgs e)
        {
                DateTime dateTime = dateTimePickerCash.Value;
                string connString = "Server=" + host + ";Database=" + database
  + ";port=" + port + ";User Id=" + username + ";password=" + password;
                string request = "SELECT * FROM CashBook where  Month(Date_Cash)='"+cbbMonth.Text+"'";
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

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerCash.Value;
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Workbook wb;
            Worksheet ws;
            object misValue = System.Reflection.Missing.Value;
            wb = excelApp.Workbooks.Add(misValue);

            ws = (Worksheet)wb.Worksheets[1];

            ws.Name = "export_month";
            int row = 1;
            string fontName = "Times New Roman";
            int fontSizeTieuDe = 18;
            int fontSizeTenTruong = 14;
            int fontSizeNoiDung = 12;
            //Range row1_TieuDe_ThongKeSanPham = ws.get_Range("A1", "E1");
            //row1_TieuDe_ThongKeSanPham.Merge();
            //row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
            //row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
            //row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //row1_TieuDe_ThongKeSanPham.Value2 = "Thống kê sản phẩm";

            //No
            Range row23_STT = ws.get_Range("A7", "A8");//Cột A dòng 2 và dòng 3
            row23_STT.Merge();
            row23_STT.Font.Size = fontSizeTenTruong;
            row23_STT.Font.Name = fontName;
            row23_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row23_STT.Value2 = "No";
            row23_STT.ColumnWidth = 4;
            //Ma
            Range row23_maCode = ws.get_Range("B7", "B8");//Cột A dòng 2 và dòng 3
            row23_maCode.Merge();
            row23_maCode.Font.Size = fontSizeTenTruong;
            row23_maCode.Font.Name = fontName;
            row23_maCode.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_maCode.Value2 = "Ma";
            row23_maCode.ColumnWidth = 10;
            //Date
            Range row23_date = ws.get_Range("C7", "C8");//Cột A dòng 2 và dòng 3
            row23_date.Merge();
            row23_date.Font.Size = fontSizeTenTruong;
            row23_date.Font.Name = fontName;
            row23_date.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_date.Value2 = "Date";
            row23_date.ColumnWidth = 15;
            //Decscription
            Range row23_Decscription = ws.get_Range("D7", "D8");//Cột A dòng 2 và dòng 3
            row23_Decscription.Merge();
            row23_Decscription.Font.Size = fontSizeTenTruong;
            row23_Decscription.Font.Name = fontName;
            row23_Decscription.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_Decscription.Value2 = "Decscription";
            row23_Decscription.ColumnWidth = 25;
            //Income
            Range row23_inCome = ws.get_Range("E7", "E8");//Cột A dòng 2 và dòng 3
            row23_inCome.Merge();
            row23_inCome.Font.Size = fontSizeTenTruong;
            row23_inCome.Font.Name = fontName;
            row23_inCome.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_inCome.Value2 = "Income";
            row23_inCome.ColumnWidth = 8;
            //Payment
            Range row23_payMent = ws.get_Range("F7", "F8");//Cột A dòng 2 và dòng 3
            row23_payMent.Merge();
            row23_payMent.Font.Size = fontSizeTenTruong;
            row23_payMent.Font.Name = fontName;
            row23_payMent.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_payMent.Value2 = "payMent";
            row23_payMent.ColumnWidth = 10;
            //Blance
            Range row23_Blance = ws.get_Range("G7", "G8");//Cột A dòng 2 và dòng 3
            row23_Blance.Merge();
            row23_Blance.Font.Size = fontSizeTenTruong;
            row23_Blance.Font.Name = fontName;
            row23_Blance.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_Blance.Value2 = "Blance";
            row23_Blance.ColumnWidth = 10;
            //SupplierCode
            Range row23_SupplierCode = ws.get_Range("H7", "H8");//Cột A dòng 2 và dòng 3
            row23_SupplierCode.Merge();
            
            row23_SupplierCode.Font.Name = fontName;
            row23_SupplierCode.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_SupplierCode.Value2 = "SupplierCode";
            row23_SupplierCode.ColumnWidth = 15;
            //suppierName
            Range row23_suppierName = ws.get_Range("I7", "I8");//Cột A dòng 2 và dòng 3
            row23_suppierName.Merge();
            row23_suppierName.Font.Size = fontSizeTenTruong;
            row23_suppierName.Font.Name = fontName;
            row23_suppierName.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            // row23_suppierName.Value2 = "suppierName";
            row23_suppierName.ColumnWidth = 22;
            //Draw clo
            Range row23_CotTieuDe = ws.get_Range("A7", "I7");
            row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.DarkGray);
            Range row23_sum = ws.get_Range("A9", "I9");
            row23_sum.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            row23_sum.Font.Size = 13;

            //export header
            for (int i = 1; i < dataViewCashBook.ColumnCount; i++)
            {
                ws.Cells[7, i + 1] = dataViewCashBook.Columns[i].HeaderText;
            }
            //expoert content
            //Range row23_Blance1 = ws.get_Range("G10", "G10");//Cột A dòng 2 và dòng 3
            //row23_Blance1.Merge();
            //row23_Blance1.Font.Size = fontSizeTenTruong;
            //row23_Blance1.Font.Name = fontName;
            //row23_Blance1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            //row23_Blance1.Value2 = "payMent";
            int dem = -1;
            for (int i = 0; i < dataViewCashBook.RowCount; i++)
            {
                for (int j = 1; j < dataViewCashBook.ColumnCount; j++)
                {
                    ws.Cells[i + 10, j + 1] = dataViewCashBook.Rows[i].Cells[j].Value;
                   
                }
                dem++;
            }

            Range row23_Blance2 = ws.get_Range("A7", "I8");
            BorderAround(row23_Blance2);
            int sum = 10 + dem;
            Range row23_Blance3 = ws.get_Range("A9", "I"+sum);
            int sum1 = sum - 1;
            int sum2 = sum + 4;
            BorderAround(row23_Blance3);
            ws.get_Range("A10").Value2 = 1;
            ws.get_Range("A11").Formula = "=A10+1";
            Range row23_Blance33 = ws.get_Range("A11", "A15");
            ws.get_Range("E9").Formula = "=Sum(E10:E"+sum+")";
            ws.get_Range("F9").Formula = "=Sum(F10:F" + sum + ")";
            ws.get_Range("G9").Formula = "=G" + sum1 ;
            //Manager
            Range row_manager = ws.get_Range("A"+sum2, "B"+sum2);//Cột A dòng 2 và dòng 3
            row_manager.Merge();
            row_manager.Font.Size = fontSizeTenTruong;
            row_manager.Font.Name = fontName;
            row_manager.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row_manager.Value2 = "Manager";
            //Manager
            Range row_manager1 = ws.get_Range("C" + sum2, "D" + sum2);//Cột A dòng 2 và dòng 3
            row_manager1.Merge();
            row_manager1.Font.Size = fontSizeTenTruong;
            row_manager1.Font.Name = fontName;
            row_manager1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row_manager1.Value2 = "General Director";
            //Manager
            Range row_manager2 = ws.get_Range("E" + sum2, "F" + sum2);//Cột A dòng 2 và dòng 3
            row_manager2.Merge();
            row_manager2.Font.Size = fontSizeTenTruong;
            row_manager2.Font.Name = fontName;
            row_manager2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row_manager2.Value2 = "Checked by";
            //Manager
            Range row_manager3 = ws.get_Range("H" + sum2, "I" + sum2);//Cột A dòng 2 và dòng 3
            row_manager3.Merge();
            row_manager3.Font.Size = fontSizeTenTruong;
            row_manager3.Font.Name = fontName;
            row_manager3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row_manager3.Value2 = "Prepared by";
            ws.Cells[1, 1] = "TM";
            ws.Cells[2, 1] = "VD";
            ws.Cells[3, 1] = "MD";
            ws.Cells[4, 1] = "MU";
            ws.Cells[5, 1] = "MD";
            ws.Cells[6, 1] = "MY";
           // ws.Cells[7, 1] = "MF";
            ws.Cells[1,2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws.Cells[2, 2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            ws.Cells[3, 2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Beige);
            ws.Cells[4, 2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.BlanchedAlmond);
            ws.Cells[5, 2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            ws.Cells[6, 2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.DarkViolet);
            Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[1, 3];
            float Left = (float)((double)oRange.Left);
            float Top = (float)((double)oRange.Top);
            const float ImageSize = 34;
            ws.Shapes.AddPicture("D:\\hoa\\C#\\flowcashTRVC\\logoTrad.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
            //ws.Cells[7, 2].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);

            //ws.Cells[2, 4] = ws.Shapes.AddPicture("D:\\hoa\\C#\\flowcashTRVC\\logoTrad.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 10, 10, 64, 64);
            ws.Cells[4,3] = "T.RAD (Vietnam) Co.,Ltd";
            ws.Cells[5, 3] = "CASH FLOW 2024";
            ws.Cells[9, 4] = "Blance";
            ws.Cells[6, 3]=dateTime.ToShortDateString().ToString();
        }

        private void BorderAround(Range range)
    {
        Borders borders = range.Borders;
        borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
        borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
        borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
        borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
        borders.Color = Color.Black;
        borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
        borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
        borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
        borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
    }

    private void cbbMonth_DropDown(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerCash.Value;
            cbbMonth.Items.Clear();
            
            cbbMonth.Items.Add(dateTime.Month);
           // cbbMonth.Items.Add("VND (VIETCOMBANK)");
            //cbbMonth.Items.Add("H15-795-011595");
            //cbbMonth.Items.Add("F15-795-011587");
            //cbbMonth.Items.Add("F15-795-011919");
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    


       
    


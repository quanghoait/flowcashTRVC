﻿using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace flowcashTRVC
{
    public partial class Cashbook : Form
    {

        string host = "localhost";
        int port = 3306;
        string database = "ManagerFlowMonneyTrad";
        string username = "root";
        string password = "Trad99999";

        public Cashbook()
        {
            InitializeComponent();

           
            DateTime dateTime = dateTimePickerCash.Value;
            MessageBox.Show(""+dateTime.Year);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //string request = "SELECT MaCash FROM MaCashTable where NameMa ='"+ kind_cash +"'";
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
                        //MessageBox.Show(reader["MaCash"].ToString());
                        displayKindCash.Text = reader["MaCash"].ToString();
                        //DateTime dateTime = dateTimePickerCash.Value;
                        //MessageBox.Show("" + dateTime.Year);

                    }
                }
            }
        }

        private void insertCashBook_Click(object sender, EventArgs e)
        {
            //string kind_cash = cbbKindCach.SelectedItem.ToString();
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
                        
                        displayBalance.Text = reader["Balance"].ToString();
                        //DateTime dateTime = dateTimePickerCash.Value;
                        //MessageBox.Show("" + dateTime.Year);

                    }
                }
            }
        }
    }

}

       
    


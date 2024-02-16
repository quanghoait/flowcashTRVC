using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;


namespace flowcashTRVC
{
    internal class data
    {
        string host = "localhost";
        int port = 3306;
        string database = "ManagerFlowMonneyTrad";
        string username = "root";
        string password = "Trad99999";
        public void connect()
        {
            string connString = "Server=" + host + ";Database=" + database
       + ";port=" + port + ";User Id=" + username + ";password=" + password;
            string request = "SELECT * FROM CodeTable";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                
                }
                
            }
        }
    }
      


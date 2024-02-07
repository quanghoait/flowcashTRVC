using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace flowcashTRVC
{
    internal class model
    {
        MySqlConnection Conn;
       MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        
       string strconn = "Server = localhost; Database = ManagerFlowMonneyTrad; UId = root; Pwd = Trad99999; Pooling=false;Character Set=utf8";
        public void connect()
        {
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
            }
            catch (MySqlException)

            {

                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}

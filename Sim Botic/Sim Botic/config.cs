using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sim_Botic
{
    internal class config
    {
        public SqlConnection con;
        public string str;

        public config()
        {
            str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Downloads\Sim Botic Game friday\Sim Botic Game\Sim Botic Game\Sim Botic\Sim Botic\simbotic_db.mdf;Integrated Security=True";

            try
            {
                con = new SqlConnection(str);
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

    }

}


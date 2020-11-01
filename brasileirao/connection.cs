using System;
using MySql.Data.MySqlClient;

namespace brasileirao
{
    class connection
    {
        public string conec = "server=localhost; port=3306; database=brasileirao; uid=root; pwd=";
        public MySqlConnection con = null;
        
        public void OpenConn()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
                throw;
            }
        }
        public void CloseConn()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
                throw;
            }
        }

    }
}

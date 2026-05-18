using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    internal class DisconnectedArc
    {

        public static void Main()
        {
            string connectionString = "Data Source=DESKTOP-CUO3FKB;Initial Catalog=ConnectionTestDB;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //Get Data
            SqlDataAdapter da = new SqlDataAdapter("select * from tblStudent", connection);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds,"Students");
            DataTable table = ds.Tables["Students"];

            Console.WriteLine("---- Original Data ----");
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["Id"]}, {row["Name"]}, {row["Gender"]},{row["Address"]}");
            }

            //Insert Data
            //SqlCommand cmd = new SqlCommand("insert into tblStudent values(@name,@gender,@address)", connection);
            //cmd.Parameters.AddWithValue("@name", "Mukesh");
            //cmd.Parameters.AddWithValue("@gender", "Male");
            //cmd.Parameters.AddWithValue("@address", "Mumbai");
            //cmd.ExecuteNonQuery();


            //Console.WriteLine("Connection is live");
            connection.Close();
        }
    }
}

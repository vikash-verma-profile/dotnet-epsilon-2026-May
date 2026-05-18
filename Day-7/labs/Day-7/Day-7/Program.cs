using System.Data.SqlClient;

namespace Day_7
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-CUO3FKB;Initial Catalog=ConnectionTestDB;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //Get Data
            //SqlCommand cmd = new SqlCommand("select * from tblStudent",connection);
            //SqlDataReader reader=cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader["Id"]}-{reader["Name"]}-{reader["Address"]}");
            //}

            //Insert Data
            SqlCommand cmd = new SqlCommand("insert into tblStudent values(@name,@gender,@address)", connection);
            cmd.Parameters.AddWithValue("@name", "Mukesh");
            cmd.Parameters.AddWithValue("@gender", "Male");
            cmd.Parameters.AddWithValue("@address", "Mumbai");
            cmd.ExecuteNonQuery();

           
            //Console.WriteLine("Connection is live");
            connection.Close();
        }
    }
}

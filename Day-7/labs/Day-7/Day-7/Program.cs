using System.Data;
using System.Data.SqlClient;

namespace Day_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=DESKTOP-CUO3FKB;Initial Catalog=SampleDb5;Integrated Security=True;";

            // CONNECTION
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            // DATA ADAPTER
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("SELECT * FROM sample", con);

            // IMPORTANT
            SqlCommandBuilder builder =
                new SqlCommandBuilder(sqlDataAdapter);

            // DATASET
            DataSet ds = new DataSet();

            sqlDataAdapter.Fill(ds, "sample");

            Console.WriteLine("==== Existing Data ====");

            foreach (DataRow item in ds.Tables["sample"].Rows)
            {
                Console.WriteLine($"{item["id"]} | {item["text"]}");
            }

            // NEW ROW
            DataRow row = ds.Tables["sample"].NewRow();

            row["id"] = 8;
            row["text"] = "Ram";

            ds.Tables["sample"].Rows.Add(row);

            // UPDATE DATABASE
            sqlDataAdapter.Update(ds, "sample");

            Console.WriteLine("==== Data Added ====");

            foreach (DataRow item in ds.Tables["sample"].Rows)
            {
                Console.WriteLine($"{item["id"]} | {item["text"]}");
            }

            con.Close();
        }
    }
}
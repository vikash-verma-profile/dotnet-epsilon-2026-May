using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Class4
    {
        public static void Main()
        {

            //created a connection
            SqlConnection con=new 
                SqlConnection("Data Source=DESKTOP-CUO3FKB;Initial Catalog=SampleDb5;Integrated Security=True;");
            //open the connection
            con.Open();
            //query to run
            //SqlCommand sqlCommand= new 
            //    SqlCommand("select * from sample",con);
            ////get data from database
            //SqlDataReader rd=sqlCommand.ExecuteReader();

            //while (rd.Read())
            //{
            //    Console.WriteLine($"{rd[0]}, {rd[1]}");
            //}

            SqlCommand sqlCommand= new 
                SqlCommand("insert into sample values(@id,@name)",con);
            int Id = Convert.ToInt16(Console.ReadLine());
            sqlCommand.Parameters.AddWithValue("@id",Id);
            sqlCommand.Parameters.AddWithValue("@name", Console.ReadLine());
            sqlCommand.ExecuteNonQuery();
            //closing the connection
            con.Close();
        }
    }
}

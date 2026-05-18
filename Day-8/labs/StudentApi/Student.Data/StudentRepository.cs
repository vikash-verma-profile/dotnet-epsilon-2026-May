using Student.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Student.Data;

public class StudentRepository
{
    string connectionString = "";
    public StudentRepository(IConfiguration connection)
    {
        connectionString = connection.GetConnectionString("DbConnection");
    }

    public List<Students> GetStudents()
    {
        List<Students> students = new List<Students>();
        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        SqlCommand cmd = new SqlCommand("select * from tblstudent", connection);
        SqlDataReader datareader = cmd.ExecuteReader();
        while (datareader.Read())
        {
            students.Add(new Students() { Id = Convert.ToInt32(datareader["id"]), Age = Convert.ToInt32(datareader["age"]), Gender = Enum.Parse<Gender>(datareader["gender"].ToString()), Name = datareader["name"].ToString() });
        }
        connection.Close();
        return students;
    }
}

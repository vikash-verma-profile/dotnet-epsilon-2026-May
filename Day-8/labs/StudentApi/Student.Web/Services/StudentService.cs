using Student.Web.Models;
using System.Text.Json;

namespace Student.Web.Services
{
    public class StudentService : IStudentService
    {
        HttpClient client;
        public StudentService(HttpClient _client)
        {
            client= _client;
        }
        public List<Students> GetStudents()
        {
           var result= client.GetAsync("/api/student/get-all-students");
            if (result.Result.IsSuccessStatusCode)
            {
                var data=result.Result.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<List<Students>>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                return  new List<Students>() { };
            }
        }
    }
}

using Student.Web.Models;

namespace Student.Web.Services
{
    public interface IStudentService
    {
        public List<Students> GetStudents();
    }
}

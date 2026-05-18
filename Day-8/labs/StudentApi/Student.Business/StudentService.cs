using Student.Data;
using Student.Data.Models;

namespace Student.Business
{
    public class StudentService
    {
        StudentRepository studentRepository;

        public StudentService(StudentRepository _studentRepository) 
        {

            studentRepository = _studentRepository;
        }

        public List<Students> GetStudents()
        {
            return studentRepository.GetStudents();
        }
    }
}

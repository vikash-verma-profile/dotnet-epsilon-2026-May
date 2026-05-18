using StudentApi.Models;
using Moq;
using StudentApi.Controllers;

namespace Sudent.TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockLogger = new Mock<ConnectionTestDbContext>();
            var controller = new StudentsController(mockLogger.Object);
            var result = controller.GetTblStudents();
            Assert.Null(result);

        }
    }
}
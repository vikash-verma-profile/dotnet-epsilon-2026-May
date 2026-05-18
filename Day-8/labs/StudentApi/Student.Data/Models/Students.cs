using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Data.Models;

public class Students
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public int Age { get; set; }
}

public enum Gender
{
    Male = 0,
    Female = 1,
    Other = 2
}

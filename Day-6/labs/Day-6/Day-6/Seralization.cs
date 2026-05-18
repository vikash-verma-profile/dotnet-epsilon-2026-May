using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Day_6
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Seralization
    {
        public static void Main4()
        {
            var json=JsonSerializer.Serialize(new Employee { Id = 1, Name = "vikash" });
            Console.WriteLine(json);

            XmlSerializer xmlSerializer=new XmlSerializer(typeof(Employee));
            using FileStream fs = new FileStream("xmlFile.xml",FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fs,new Employee { Id = 1, Name = "vikash" });
            
        }
    }
}

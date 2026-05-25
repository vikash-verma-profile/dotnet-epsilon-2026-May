using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;

namespace Day_5
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
    }

    internal class JsonSer
    {
        public static void Main()
        {
            Book book = new Book() { Id = 101, BookName = "Vikash" };
            //var json=JsonSerializer.Serialize(book);
            //Console.WriteLine(json);
            //var newBook = JsonSerializer.Deserialize<Book>(json);
            //Console.WriteLine(newBook.Id+"=="+newBook.BookName);

           XmlSerializer xl = new XmlSerializer(typeof(Book));
           StringWriter stringWriter = new StringWriter();
            xl.Serialize(stringWriter,book);
            Console.WriteLine(stringWriter.ToString());
            StringReader xmlReader = new StringReader(stringWriter.ToString());
            var newBook = (Book)xl.Deserialize(xmlReader);
            Console.WriteLine(newBook.Id + "==" + newBook.BookName);
        }
    }
}

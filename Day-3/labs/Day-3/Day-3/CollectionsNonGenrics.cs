using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    
    internal class CollectionsNonGenrics
    {
        public static void Main4()
        {
            ArrayList array=new ArrayList();
            array.Capacity = 2;
            array.Add(1);
            array.Add(1);
            //array.Add("Vikash");
            //array.Add(1.67);
            Console.WriteLine(array.Capacity);
            Console.WriteLine(array.Contains("Vikash"));
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=============Sorted List");

            SortedList sortedList = new SortedList();
            sortedList.Add(3,"C#");
            sortedList.Add(2,"Java");
            sortedList.Add(1, "Python");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }

            Console.WriteLine("=============Stack List");

            Stack stack = new Stack();
            stack.Push("C#");
            stack.Push("Java");
            stack.Push("Python");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("=============Queue List");

            Queue queue = new Queue();
            queue.Enqueue("C#");
            queue.Enqueue("Java");
            queue.Enqueue("Python");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine($"{item}");
            }


        }
    }
}

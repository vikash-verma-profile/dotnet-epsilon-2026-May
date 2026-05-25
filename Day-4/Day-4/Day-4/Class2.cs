using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    /// <summary>
    /// List<T>
    /// Queue<T>
    ///SortedList<T>
    ///Stack<T>
    ///SortedSet<T>
    ///LinkedList<T>
    ///Dictionary<TKey, TValue>
    /// </summary>
    internal class Class2
    {
        public static void Main3()
        {
            List<int> lists=new List<int>();
            lists.Add(1);
            lists.Add(2);
            lists.Add(3);
            lists.Remove(1);

            lists.Clear();
            lists.Add(1);
            lists.Add(2);
            lists.Add(3);
            if (lists.Contains(1))
            {
                Console.WriteLine("Element found");
            }
            foreach (int item in lists)
            {
                Console.WriteLine(item);
            }

            Queue<string> langs = new Queue<string>();
            langs.Enqueue("C#");
            langs.Enqueue("JAVA");
            langs.Enqueue("KAFKA");

            Console.WriteLine(langs.Dequeue());
            Console.WriteLine(langs.Dequeue());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public interface IDrawable
    {
        void Draw();
    }
    public interface IColor
    {
        void Draw();
    }

    public class Circle : IDrawable, IColor
    {

        void IColor.Draw()
        {
            Console.WriteLine("Hello");
        }

        void IDrawable.Draw()
        {
            throw new NotImplementedException();
        }
    }
    internal class Class1
    {
        public static void Main2()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 4");

            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            date = DateTime.UtcNow;
            Console.WriteLine(date);
            Console.WriteLine(DateTime.MinValue);


            Console.ReadLine();
        }
    }
}

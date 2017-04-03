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
            date = DateTime.Now;
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfWeek);
            date = new DateTime(2016, 03, 05, 14, 54, 01);
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(DateTime.Now - date);

            date = DateTime.Parse("04/05/99 14:54");
            Console.WriteLine(date);


            Console.ReadLine();
        }
    }
}

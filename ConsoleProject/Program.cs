using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1990);
            oyears.Add(1991);
            oyears.Add(1993);
            oyears.Add(2000);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);

            //Print The List Of Integers

            IEnumerable<int> item = oyears;
            foreach(int i in item)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

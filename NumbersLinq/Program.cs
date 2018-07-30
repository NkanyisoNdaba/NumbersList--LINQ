using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NumbersLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbersList = new List<Numbers>
            {
               new Numbers{Number = 2},
                new Numbers{Number = 5},
                new Numbers{Number = 2},
                new Numbers{Number = 5},
                new Numbers{Number = 7},
                new Numbers{Number = 2},           
            };

            // var findNumbers = from Numbers in numbersList where Numbers.Number <= 9 && Numbers.Number>0 && Numbers.Number%2==0 select Numbers.Number;
           // var findNumbers = from Numbers in numbersList where Numbers.Number <= 9 && Numbers.Number > 0 && Numbers.Number*Numbers.Number>20 select new {Number=Numbers.Number,Square= Numbers.Number * Numbers.Number};          
            //var joinNumbers = string.Join("\n", findNumbers);

            var findNumbers = (from Numbers in numbersList
                where Numbers.Number.Equals(Numbers.Number)
                select Numbers.Number).Count();

            Console.WriteLine(findNumbers);
            Console.ReadLine();
        }
    }
}

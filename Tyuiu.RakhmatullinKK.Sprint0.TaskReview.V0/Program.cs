using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RakhmatullinKK.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(x+y+z)*5, x=3, y=2, z=4");
            Console.WriteLine(DataService.Calc(3, 2, 4));
            Console.ReadKey();
        }
    }
}

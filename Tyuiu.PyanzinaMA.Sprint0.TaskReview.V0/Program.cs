using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PyanzinaMA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 25;
            int Num2 = 16;
            int Num3 = 8;
            int result = DataService.Calc(Num1, Num2, Num3);

            Console.WriteLine($"({Num1} + {Num2} + {Num3}) * 5 = {result}");
            Console.ReadKey();
        }
    }
}

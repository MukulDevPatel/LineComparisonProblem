
using System;
namespace LineComparisonProblem2
{
    class program
    {
        static void Main(string[] args)     //Entry of the code
        {
            Console.WriteLine("Welcome to line comparison Problem");
            Console.WriteLine("Value of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength calculateLength1 = new CalculateLength(x1, x2, y1, y2);
            double line1 = calculateLength1.Calculate();
            CalculateLength calculateLength2 = new CalculateLength(1, 3, 4, 5);
            double line2 = calculateLength2.Calculate();
            calculateLength2.CheckEqulity(line1, line2);
            calculateLength2.CompareLines(line1, line2);
        }
    }
}

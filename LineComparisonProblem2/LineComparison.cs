using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem2
{
    public class CalculateLength
    {
        int x1, x2, y1, y2;
        public CalculateLength(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        //UC-1 Length of lines
        public double Calculate()
        {
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(result);
            return result;
        }

        //UC-2 Equlity of lines

        public void CheckEqulity(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Both lines are Equal");
            else
                Console.WriteLine("Line are not Equal");
        }

        //UC-3 Comparison of lines
        public void CompareLines(double line1, double line2)
        {
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both the lines are Equal");
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line 1 is greater than line2.");
            else
                Console.WriteLine("Line 2 is greater than line1.");
        }
    }
}

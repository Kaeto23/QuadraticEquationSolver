using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation_Solver
{
    public class QuadraticEquationSolver
    {
        public static void Main()
        {
            double a, b, c;
            Console.Write("Enter the value of 'a': ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of 'b': ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of 'c': ");
            c = double.Parse(Console.ReadLine());

            double discriminant = [b ^ 2 - 4 * a * c\];

            if (discriminant > 0)
            {
                double x1 = (-b + \[Math.Sqrt(discriminant)\]) / (2 * a);
                double x2 = (-b - \[sqrt(discriminant)\]) / (2 * a);

                Console.WriteLine("The roots of the equation are: ");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The roots of the equation is: ");
                Console.WriteLine("x = " + x);
            }
            else
            }
                double realPart = -b / (2 * a);
                double imagPart = \[sqrt(-disciminant)\] / (2 * a);
                Console.WriteLine("The roots of the equation are: ");
                Console.WriteLine("x1 = " + realPart + " + " + imagPart + "i");
                Console.WriteLine("x2 = " + realPart + " - " + imagPart + "i");
    }
}



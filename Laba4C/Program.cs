using System;

namespace Laba4C
{
    class Program
    {
        static void Main(string[] args)
        {
            double x2, xi,x1;

            Console.WriteLine("Возняк Софiя IС-01, 7 варiант");
            Console.Write("input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            x1 = 1;
            x2 = 0.3;
            if (n < 1)
            {
                Console.WriteLine("ERROR input n > 0");
            }
            else if (n == 1)
            {
                Console.WriteLine("x1 = {0}", x1);
            }
            else if (n >= 2)
            {
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
                for (int i = 3; i <= n; i++)
                {
                    xi = (i + 1)*x1;
                    Console.WriteLine("x{0} = {1}", i, xi); 
                    x1 = x2;
                    x2 = xi;
                }
            }
        }
    }
}

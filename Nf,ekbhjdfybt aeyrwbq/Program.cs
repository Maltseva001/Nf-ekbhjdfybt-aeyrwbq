using System;

namespace Nf_ekbhjdfybt_aeyrwbq
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double pi = Math.PI;
            for (double x = 0.1; x == 2.5; x += 0.2)
            {
                y = Math.Pow(x, 2) + 2 * pi * Math.Cos(pi * x);
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}

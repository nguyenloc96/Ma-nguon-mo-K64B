using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 0.0;
            int n;
            for(n = 1;(1.0/(n*n))>= 0.000001; n++)
            {
                S += (1.0 / (n*n));
            }
            Console.WriteLine(" S = {0}", S);
            Console.WriteLine(" N = {0}", n);
            Console.WriteLine(" PI = {0}", Math.Sqrt(6*S));
            Console.ReadKey();
        }
    }
}

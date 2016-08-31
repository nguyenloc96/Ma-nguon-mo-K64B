using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    class Program
    {

        static void Main(string[] args)
        {
            double a, b, c;
            string sa, sb, sc;
            Console.Write(" Nhap gia tri a = ");
            sa = Console.ReadLine();
            Console.Write(" Nhap gia tri b = ");
            sb = Console.ReadLine();
            Console.Write(" Nhap gia tri c = ");
            sc = Console.ReadLine();
            a = double.Parse(sa);
            b = double.Parse(sb);
            c = double.Parse(sc);
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine(" Day la 3 canh cua tam giac!");
                if ((c * c == a * a + b * b) || (a * a == b * b + c * c) || (b * b == a * a + c * c))
                {
                    if ((a == b) || (b == c) || (c == a))
                    {
                        Console.WriteLine(" Day la tam giac vuong can!");
                    }
                    else
                    {
                        Console.WriteLine(" Day la tam giac vuong thuong!");
                    }

                }
                else
                {
                    if ((a == b) && (b == c))
                    {
                        Console.WriteLine(" Day la tam giac deu!");
                    }
                    else
                    {
                        if ((a == b) || (b == c) || (c == a))
                        {
                            Console.WriteLine(" Day la tam giac can!");
                        }
                        else
                        {
                            Console.WriteLine(" Day la tam giac thuong!");
                        }
                    }
                }
            }
            else Console.WriteLine(" Day khong phai la 3 canh cua tam giac!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double A, B, C;
            Console.WriteLine("Nhập A: ");
            A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập B: ");
            B = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập C: ");
            C = Double.Parse(Console.ReadLine());

            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        Console.WriteLine("Phương trình vô số nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                }
                else
                {
                    double x = -C / B;
                    Console.WriteLine("Phương trình có một nghiệm: x = " + x);
                }
            }
            else
            {
                double delta = B * B - 4 * A * C;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    double x = -B / (2 * A);
                    Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = " + x);
                }
                else
                {
                    double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                    double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt: x1 = " + x1 + ", x2 = " + x2);
                }
            }
        }
    }
}

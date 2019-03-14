using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_2.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            if (Prime(num1))
            {
                int num2 = int.Parse(Console.ReadLine());
                if (Prime(num2))
                {
                    int num3 = int.Parse(Console.ReadLine());
                    if (Prime(num3))
                        num1 = num1 + num2 + num3;
                }
            }
        }
            static bool Prime(int N)
            {
                for (int i = 2; i <= N; i++)
                {
                    if (N % i == 0)
                        if (i == N)
                        {
                            return true;
                        }
                        else
                            Console.WriteLine("Not Primary Numbers!");
                            return false;

                }
                return true;
            }
        
    }
}

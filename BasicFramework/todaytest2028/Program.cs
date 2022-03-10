using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todaytest0228
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 알파벳 출력
            Console.WriteLine("1. 알파벳 출력");
            for (int i = 0; i < 26; i++)
            {
                Console.Write("{0} ", Convert.ToChar(65 + i));
            }
            Console.WriteLine("\n");

            //2. 1~100 10행/렬
            Console.WriteLine("2. 1~100 10행/렬");
            for (int n = 1; n <= 100; n++)
            {
                Console.Write($"\t {n}");
                if (n % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine();

            //3. 주사위 2개 합 6
            Console.WriteLine("3. 주사위 2개 합 6");
            for (int a = 1; a < 6; a++)
            {
                Console.WriteLine($"첫 번째 주사위가 '{a}' 일 때, 두 번재 주사위는 '{6 - a}'");
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0228
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("역삼각형");
            //역삼각형
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n트리");
            //트리
            int a; //line
            int b; //blank
            int k; //*

            for (a = 1; a <= 5; a++)
            {
                for (b = 0; b < 5 - a; b++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k < a * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
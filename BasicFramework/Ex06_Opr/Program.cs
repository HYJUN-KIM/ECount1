using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Opr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(100 + 100); //숫자 : 산술
            Console.WriteLine("100" + "100"); //문자열 : 결합

            int i = 10; //지역변수 항상 초기화
            int j;
            j = i++; //후치증가
            Console.WriteLine($"i: {i}, j: {j}");

            j = ++i; //전치증가
            Console.WriteLine($"i: {i}, j: {j}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //제어문 & 연산자
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 2; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (i == j) break;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 2; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (i == j) continue; //skip 해라 아래문장을
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int result;
            Console.Write("숫자값을 입력하시오: ");
            result = int.Parse(Console.ReadLine()); //정수값으로 변환

            switch (result)
            {
                case 1: Console.WriteLine(result);
                    break;
                case 2: Console.WriteLine(result);
                    break;
                case 3: Console.WriteLine(result);
                    break;
                default: Console.WriteLine("nothing");
                    break;
            }

            //1부터 100까지 합 / while문 사용
            int n = 1;
            int n_sum = 0; //지역변수는 사용 전에 반드시 초기화!!
            while (n <= 100)
            {
                n_sum += n;
                //while문은 반드시 내부에서 증가감 처리!!
                n++;
            }
            Console.WriteLine($"누적 합: {n_sum}, n: {n}\n");

            //1부터 100까지 홀수 합 / while문 사용
            int odd = 1;
            int odd_sum = 0; //지역변수는 사용 전에 반드시 초기화!!
            while (odd <= 100)
            {
                if (odd % 2 == 1) {odd_sum += odd;}
                odd++;
            }
            Console.WriteLine($"홀수 누적 합: {odd_sum}, odd: {odd}\n");

            //Q. 지정된 계정: admin / 암호: 1234
            //두 값을 console에서 받아서 모두 일치하는 경우 "성공" 출력
            //불일치, "넌 누구냐" 출력 (if 사용)
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("PWD: ");
            string pwd = Console.ReadLine();

            if (id == "admin" && pwd == "1234")
            {
                Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("넌 누구냐");
            }
            */
            //삼항연산자 ~= if 문
            int p2 = 10;
            int k2 = -10;

            int result2 = (p2 == k2) ? p2 : k2;
            Console.WriteLine($"result2: {result2}");

            //if 문
            if (p2 == k2) { Console.WriteLine(p2); }
            else { Console.WriteLine(k2); }

            //비트 연산
            int x1 = 3;
            int x2 = 5;
            Console.WriteLine("x1 & x2: {0}, x1 | x2: {1}", x1 & x2, x1 | x2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            //간단 학점 계산기
            //판단1. A, B, C
            //판단2. >=5: +, <5: -
            while(true)
            {
                Console.Write("점수 입력(0: 종료): ");
                int score = Convert.ToInt32(Console.ReadLine());
                string grade = ""; // 문자열 초기화

                if (score == 100) { Console.WriteLine("A+"); }
                else if (score >= 90 && score < 100)
                {
                    if (score % 10 < 5) { Console.WriteLine("A-"); }
                    else { Console.WriteLine("A+"); }
                }
                else if (score >= 80 && score < 90)
                {
                    grade = (score >= 85) ? ("B+") : ("B-");
                    Console.WriteLine(grade);
                }
                else if (score >= 70 && score < 80)
                {
                    grade = "C";
                    grade = (score % 10 >= 5) ? (grade += '+') : (grade += '-');
                    Console.WriteLine(grade);
                }
                //else if (score < 70 && score >0) { Console.WriteLine('F'); 
                else if (score == 0) {break;}
                else { Console.WriteLine('F'); }
            }




        }
    }
}

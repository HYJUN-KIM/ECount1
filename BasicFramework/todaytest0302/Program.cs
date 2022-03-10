using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todaytest0302
{
    class Program
    {
        static void Main(string[] args)
        {
            //순서도 이해하기
            int unit = 10000;
            int num;
            int sw = 0;

            Console.Write("Money 입력: ");
            
            int money = int.Parse(Console.ReadLine());

            while (true)
            {
                num = (int)(money / unit);
                Console.WriteLine($"Unit : {unit}\t Num : {num}개");

                if (unit > 1)
                {
                    money -= unit * num;

                    if (sw == 0)
                    {
                        unit /= 2;
                        sw = 1;
                    }
                    else
                    {
                        unit /= 5;
                        sw = 0;
                    }
                }
                else break;

            }
        }
    }
}

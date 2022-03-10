using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todaytest0304
{
    public class Cinema
    {

        private static string[,] seats; // 좌석 번호
        private static string[,] reservedNumber; //예약 번호

        public Cinema(string[,] tickets1)

        {
            seats = tickets1;

            // 초기화 코드 필요
            // seats 사이즈 가지고 예약 번호 초기화
        }

        public static void ticketing()

        {
            //예매 조회 코드
            //예매 번호 입력하고 예매
            //예매 가능 여부 체크 
        }

        public static string check(string ticketNumber)
        {
            return "";
        }

        public static string cancel(string ticketNumber)

        {
            return "";
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("좌석을 선택해주세요. 예)1-1 ");
                Console.Write("\n이미 예매된 좌석은 \"예매\"라고 표시됩니다.\n");
                string inputseats = Console.ReadLine();
                string[] seats = inputseats.Split('-');

                if (seats.Length == 2)
                {
                    Console.WriteLine($"입력하신 좌석은 {seats[0]}-{seats[1]} 입니다. 예매하시겠습니까?");
                    Console.Write("네(1), 아니오(2), 초기화면(0) 중 하나를 입력해주세요.\n");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine("예매가 완료되었습니다.");
                        Console.WriteLine($"예매한 좌석번호: [{seats[0]}-{seats[1]}]/");
                        Console.WriteLine("감사합니다.");
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine($"입력하신 좌석 {seats[0]}-{seats[1]} 은(는) 이미 예약된 좌석입니다. 다른 좌석을 선택해주세요");
                    }
                    else
                    {

                    }
                }

                /*
                foreach (var seat in seats)
                {
                    System.Console.Write($"{seat}");
                }
                */

            }
        }
    }
}
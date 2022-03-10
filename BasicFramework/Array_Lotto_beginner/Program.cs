using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Lotto_beginner
{
    class Program
    {
        /*
        *1. 1~45까지의 난수를 발생시켜 6개의 배열에 담으세요
            lotto[0] = 44 , lotto[1] = 1 .... lotto[5] = 33
        *2. 배열에 담긴 6개의 배열값은 중복값이 나오면 안되요 (중복값 검증 :별찍기 비슷)
        *3. 배열에 있는 6개의 값은 낮은 순으로 정렬 시키세요 (정렬 : 자리바꿈, sort 사용X)
        *4. 위 결과를 담고 있는 배열을 출력하세요 (화면 출력)
        */
        static void Main(string[] args)
        {
            int[] LottoNum = new int[6];
            Random rand = new Random();

            bool CheckSame(int index, int value)
            {
                for (int i = 0; i < index; i++)
                {
                    if (value == LottoNum[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            //int 배열의 크기만큼 for문 돌려서 배열에 값 넣기
            for (int i = 0; i < LottoNum.Length; i++)
            {
                int LottoBall = rand.Next(1, 46);

                if (true == CheckSame(i, LottoBall))
                {
                    LottoNum[i] = LottoBall;
                }
                else
                {
                    i--; //중복값 방지
                }
            }

            //로또 결과
            Console.Write("이번주 로또 번호는 ");
            int temp; //값 비교 후 자리 교체를 위해 비어있는 int형 변수 생성

            for (int i = 0; i < LottoNum.Length; i++)
            {
                int low = i; //i를 직접 비교하며 교체되지 않기 위해 i 역할 대행

                for (int j = i + 1; j < LottoNum.Length; j++)
                {
                    if (LottoNum[j] < LottoNum[low])
                    {
                        low = j;
                    }
                }

                temp = LottoNum[low];
                LottoNum[low] = LottoNum[i];
                LottoNum[i] = temp;

                Console.Write(LottoNum[i] + " ");
            }
            Console.WriteLine("입니다.");
        }


    }
}
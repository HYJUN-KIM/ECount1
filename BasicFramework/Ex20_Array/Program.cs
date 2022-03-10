using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열은 객체다
            //1. new 를 통해서 생성
            //2. heap 메모리에 생성
            //3. 고정배열(정적배열) : 배열의 크기가 한 번 설정되면 변경 불가
            //4. 자료구조의 기본

            int[] arr = new int[5]; //방의 값은 default 값으로 초기화
            //Console.WriteLine(arr[0]);
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 }; //원하는 값으로 초기화
            //Console.WriteLine(arr2[0]);
            int[] arr3 = new int[] { 10, 20, 30, 40, 50 };
            //Console.WriteLine(arr3[0]);
            //컴파일러 너에게 맡긴다... new int[] 알아서 생성
            int[] arr4 = { 10, 20, 30, 40, 50 };
            //Console.WriteLine(arr4[0]);
            //궁합 : for문
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }

            Console.WriteLine("foreach");
            foreach (int item in arr4)
            { //나열된 자원에 접근, 순차적으로 데이터 추출 논리
                Console.WriteLine("arr4 : {0}", item);
            }

            //배열의 할당
            int[] ar = { 1, 3, 5, 7, 9 };
            int[] ar2 = ar; //주소값 할당 #동거
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.WriteLine(ar2[i]);
                ar2[i] += 3;
            }

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("ar : {0}", ar[i]);
            }
            Console.WriteLine("#######################");
            //2차원 배열 [행, 렬]
            int[,] arr5 = new int[3,2];
            //arr5[0, 0] = 1;
            Console.WriteLine("2차원 배열 : {0}", arr5[0,0]);

            int[,] arr6 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; //2차원 배열 초기화
            

            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    Console.WriteLine("arr[{0}, {1}]={2}", i, j, arr6[i, j]);
                }
            }
            //좌석배치(영화관), 경도 위도, 바둑판 ...
        }

    }
}

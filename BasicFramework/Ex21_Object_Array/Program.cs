using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Object_Array
{
    //class 생성
    class Ani
    {
        private string dogname;

        public Ani() { }
        public Ani(string dogname)
        {
            this.dogname = dogname;
        }

        public void aniDisplay()
        {
            Console.WriteLine("이름 : {0}", this.dogname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Ani[] arr = new Ani[3]; //heap 메모리에 방 3개 생성 (방 타입은 Ani) : 방의 값 null
            //각각의 방에 값을 넣으세요 = 각각의 방에 Ani 타입을 갖는 주소를 넣어라
            Ani a = new Ani("멍멍이");
            Ani a1 = new Ani("발발이");
            Ani a2 = new Ani("순돌이");

            arr[0] = a; //주소값 전달 (Ani 타입)
            arr[1] = a1; //주소값 전달 (Ani 타입)
            arr[2] = a2; //주소값 전달 (Ani 타입)

            arr[0].aniDisplay();
            arr[1].aniDisplay();
            arr[2].aniDisplay();
            */

            Ani[] arr = new Ani[3];
            arr[0] = new Ani("멍");
            arr[1] = new Ani("발");
            arr[2] = new Ani("순");

            Ani[] arr2 = new Ani[] { new Ani("멍"), new Ani("발"), new Ani("순") };
            Ani[] arr3 = { new Ani("멍"), new Ani("발"), new Ani("순") };

            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i].aniDisplay();
            }
            Console.WriteLine("\nforeach문");
            foreach (Ani obj in arr3)
            { //나열된 자원에 접근, 순차적으로 데이터 추출 논리
                obj.aniDisplay();
            }
        }
    }
}

using System; //using = import(java)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Basic //namespace = package ~= url : 논리적인 묶음의 단위 (클래스간 충돌 방지)
{
    //클래스는 설계도 == 클래스는 타입
    //java, c# : 클래스 만들기 : class 이름을 붙이면 설계도 : 객체 생성가능
    //클래스 2가지 : Main 있는 클래스 (exe) : Main 없는 클래스 (dll)
    //원칙적인 방법 : 모든 클래스는 new 연산자를 통해서 heap 메모리에 로드 : 그래야 사용 가능
    //Program p = new Program();

    class Car {  //dll

    }
        class Test
    {
        public int data;
    }
    class Program //exe
    {
        static void Main(string[] args) //함수(method) > 가능 > static(독자적 메모리) > 이름이 Main() > 실행 가능(stack)
        {
            //Console.WriteLine("hello world");

            //데이터 타입과 변수
            char c; //2byte //한글, 한자 : 2byte, 영문자, 특수문자, 공백 : 1byte >> 약속 >> 한문자 : 2byte
            c = 'A';
            char d;
            d = '나';
            //https://cafe.naver.com/eount/76
            Console.WriteLine("c:{0}, d:{1}", c, d);

            //지역변수는 반드시 '초기화'를 통해 사용한다.
            short s;
            s = 10000;
            Console.WriteLine(s);

            int i = 100000;
            Console.WriteLine(i);

            //1.12 실수 리터럴의 기본형: double
            float f = 1.12f; //접미사 = 8리터 컵에 들어있는 물을 4리터 컵에 담기 위해서 바로 X, 4리터 컵에 옮긴 후 담기
            Console.WriteLine(f);

            double dd = 3.1415926535;
            Console.WriteLine(dd);

            bool b = true;  //논리적인 구조 (제어구조에서 논리 판단할 때 사용)

            //증명하기
            //aa 값, value type 증명해보시오
            int aa = 100;
            int bb = aa;
            bb = 200;
            Console.WriteLine("------------aa값 {0}", aa);

            Test t = new Test();
            Console.WriteLine(t.GetHashCode());
            t.data = 100;

            Test t2 = t; //할당 (주소값)
            t2.data = 1111;
            Console.WriteLine("t객체의 data 변수값은 : {0}", t.data);
            Console.WriteLine(t == t2);
            Console.WriteLine("{0}-{1}", t.GetHashCode(), t2.GetHashCode());
        }
    }
}

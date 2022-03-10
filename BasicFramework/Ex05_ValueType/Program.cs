using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ValueType
{
    #region +값 타입 : 구조체 : 작은 타입을 모아서 의미있는 집합
    struct Book
    {
        public string name;
        public int price;
        public Book(string _name, int _price) //생성자 함수 //Book 이 가지는 member 를 초기화
        {
            name = _name;
            price = _price;
        }
    }
    #endregion

    #region +열거형 : 하나의 값 타입
    enum mycolor { black, white, red, green, blue}; //열거 타입 //내부적으로 상수값 0 ++1 자동 설정
    enum week { mon, tue = 101, sat, sun}; //명시적으로 상수값 설정

    #endregion
    class Car
    {
        public string name;
        public int price;
        public Car(string _name, int _price) //생성자 함수 member 를 초기화
        {
            name = _name;
            price = _price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //value type
            int i = 100;
            float f = 3.14f;
            
            //예외) 구조체에서 new 는 객체를 생성하는 연산자가 아니고, 단지 초기화(생성자)만 담당
            Book book = new Book("홍길동전", 10000);
            //Book 구조체가 값 타임을 증명하시오
            Book book2 = book;

            book2.name = "NEW";
            book2.price = 2000;

            Console.WriteLine("book {0}, {1}", book.name, book.price);
            Console.WriteLine("book2 {0}, {1}", book2.name, book2.price);

            //클래스에서 new 는 객체를 생성하는 연산자 (new 를 통해서 만들어진 객체는 heap 에 생성) #오피스텔 형제 동거
            Car car = new Car("GV80", 1000);

            Car car2 = car; //car2 와 car 를 같은 객체로 본다.
            car2.name = "NEW_CAR";
            car2.price = 6000;

            Console.WriteLine("car {0}, {1}", car.name, car.price);
            Console.WriteLine("car2 {0}, {1}", car2.name, car2.price);

            //열거타입
            mycolor m;
            m = mycolor.black;
            Console.WriteLine(m);
            Console.WriteLine((int)m); //casting

            //시스템이 제공하는 열거타입
            Console.BackgroundColor = ConsoleColor.Magenta;

            week w;
            w = week.sat; //개발자는 문자열 형태로 코드 해석 편하게 작업 가능
            Console.WriteLine($"{w}, {(int)w}");

            //형변환
            int num = 1234;
            long lon = num; //long은 int 크기가 크다
            //long lon = (long)num; //내부적으로 컴파일러가 수행 (암시적 형변환)

            //명시적 형변환 (개발자가 의도를 가지고 실제 코드로 작업)
            long lon2 = 100000;
            //int num2 = lon2; //** 값으로 보지 말고 가지고 있는 타입으로 봐야 함.
            int num2 = (int)lon2;
            Console.WriteLine(num2); //다행히도 형변환한 값이 int 범위라면 손실없이 값을 가질 수 있다.

            //epdlxj thstlf
            long lon3 = 100000000000;
            int num3 = (int)lon3; //int -21억 ~ +21억
            Console.WriteLine(num3); //쓰레기 값 발생... 손실...

            // 결론. 큰 타입을 작은 타입으로 넣는 것은 (형변환) 손실을 감안하여야 한다.

            int x = 254;
            byte y = (byte)x; //byte 0~255
            Console.WriteLine(y);
        }
    }
}

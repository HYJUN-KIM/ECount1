using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Class
{
    //클래스 == 설계도 == 데이터 타입 / 클래스 안에는 변수, 함수만 사용가
    class Person //설계라고 정의 : 최소 : 속성 + 기능 : 너 설계도 부르고... 객체 생성
                 //속성(정보를 담는 그룻 : 크기 + 이름 > 변수)
    {
        int num; //클래스가 가지는 변수 : instance variable : 생성되는 객체마다 가지는 변수
                 //Person p = new Person();     Person p2 = new Person();
                 //p.num != p2.num
                 //기본적인 접근자를 가지고 있다
                 //아무것도 명시하지 않으면 'private' int num 으로 처리
                 //객체지향 언어의 특징
                 //캡슐화, 은닉화 >> 자원을 보호, 구현하는 기술 : private
                 //1. private : 클래스 내부에서는 모두 같은 식구, 객체 입장에서는 다른 식구(= 볼 수 없음)
                 //2. public : 클래스 내부, 객체 모두 볼 수 있음
                 //3. private 사용하면서 객체가 사용할 수 있게...
                 //3.1 함수 생성 : public : 캡슐화된 자원에 대해 read, write 할 수 있게 (간접할당)

        private int k; //==int k;
        public int y;

        private string ename;


        public int getK()
        {   //보호된 자원 값을 return == 읽기전용
            return k;
        }
        
        public void setK(int data)
        {   //보호된 자원 값 사용 == 쓰기전용
            //설계자 의도 반영 가능
            if (data < 0) { k = 0; }
            else { k = data; }
        }

        //property : private member field 에 대해서 간접적인 데이터 처리 목적 : 캡슐화된 자료에 read, write 할 수 있음.
        //int num > property > get, set > read, write 구현

        //MS에서는 smart field 라고 부르기도 함. = property
        public int Num //property는 함수와 달리 이름 뒤에 () 안들어감
        {
            get { return num; }
            set { num = value; }
        }

        //ename의 property
        public string Ename;

    }

    class Apt
    {
        private string aptname;
        private string aptcolor;

        //함수 이용
        //특수한 목적의 함수 (사용방법은 member field 의 초기화)
        //설계 약속 : 함수 명 == 클래스 명
        public Apt()
        {   //원칙적으로 함수는 public void  or  public int  or  public string
            //생성자 함수(constructor) >> 객체가 생성될 때 호출되는 함수
            //Apt apt = new Apt();
            //member field 가 먼저 memory 올라가고 생성자 함수가 실행.
            aptname = "삼성";
            aptcolor = "red";
        }
        public Apt(string aptname, string aptcolor)
        {   //생성자 함수 //overloading (함수의 이름은 같은데, parameter의 개수와 타입을 다르게)
            this.aptname = aptname;
            this.aptcolor = aptcolor;
        }

        public string Aptname
        {
            get { return aptname; }
        }
        public string Aptcolor
        {
            get { return aptcolor; }
        }
    }
    //요구사항
    //아파트를 만들 때 특별한 요구사항이 없으면 이름과 색상은 기본 설정을 한다. 그리고 필요시 강제로 이름, 색상을 넣을 수 있게 한다.
    //Apt apt = new Apt(); null, null

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person();
            //p.num = 100; p라는 변수가 직접적으로 num 변수 접근을 막는다.
            p.y = 100; //직접할당
            p2.y = 200; //직접할당
            //y라는 변수에 양수값만! >> 하지만 직접할당이 가능하기 때문에 음수값 입력도 가능... 문제!!
            p.y = -100;

            p.setK(-100);
            Console.WriteLine(p.getK());

            p.Num = 555; //set { num = value; } 동작
            Console.WriteLine("get{0}", p.Num); //get { return num; } 동작

            p.Ename = "김형준";
            Console.WriteLine("get ename : {0}", p.Ename);

            Apt apt = new Apt();
            Console.WriteLine("apt.name:{0}", apt.Aptname);
            Console.WriteLine("apt.color:{0}", apt.Aptcolor);

            Apt apt2 = new Apt("LG", "yellow"); //객체를 생성하면서 바로 초기화 가능
            Console.WriteLine("apt2.name:{0}", apt2.Aptname);
            Console.WriteLine("apt2.color:{0}", apt2.Aptcolor);

            #region +정리
            /*
            1. 클래스 == 설계도 == 데이터 타입
            2. 클래스 가장 기본적인 구성 요소 > 속성(정보):member filed + 기능(함수):method
            3. 클래스 요소 중 속성(instance variable, member field)
            3.1 private 접근자를 통해서 캡슐화
            3.2 객체 입장에서 read, write X (= 직접할당 불가)
            3.3 별도의 함수를 public 통해서 get, set 구현
            3.4 전용 (read, write) : property
            3.5 member field property 구현함으로써 간접적인 데이터 처리 가능
             */
            #endregion
        }
    }
}

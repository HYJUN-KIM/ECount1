using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RefType
{
    //수업용 하나의 namespace 안에 여러개 클래스 만들어서 놀기
    //원칙적인 방법은 별도의 Lib 생성해서 사용하는 것이 원칙! Ex03_EmpLib 처럼
    class Test
    {
        public int i; //member field (instance variable), 변수i는 클래스 내에서는 유효하다.

        public void print()
        {
            int data = 100; //local variable
            Console.WriteLine("data : {0}", data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.print();

            Test test2 = new Test();
            test2.print();

            Test test3 = new Test();
            test3.print();

            //test, test2, test3 는 '참조 타입'으로, 변수가 주소를 갖고 있다.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Abstract_Class
{
    /*
    1. 추상 클래스 (미완성 클래스)
    1.1 미완성 (완성+미완성) >> 함수를 구현 > { 실행 블럭 } 있음... 구현X > { 실행 블럭 } 없음...
    2. 목적 : 상속관계에서 [강제구현] 하도록, method 를
    3. 특징 : 1. 스스로 객체 생성 X
            2. 상속관계에서 구현
            3. abstract method 반드시 구현해야 한다.
            4. abstract method (자동 virtual) 반드시 override 구현 (재정의)
            5. abstract property {get; set;} 구현은 추상함수 동일
     */
    abstract class AbstractClass
    {
        public void print()
        {
            Console.WriteLine("완성된 코드...");
        }
        public abstract void abMethod(); //{ 실행 블럭 } 없음 >> 상속관계에서 강제구현을 목적
    }

    class Dummy : AbstractClass
    {
        public override void abMethod() //강제구현 = {실행 블럭 만들기}
        {
            Console.WriteLine("추상 메서드 구현");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.abMethod();
            dummy.print();
        }
    }
}

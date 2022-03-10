using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ToString_Override
{
    //1. 사용자가 모든 클래스는 기본적으로 Object 상속 받는다
    //2. FrameWork 제공하는 수많은 클래스도 Object 상속 받고, 필요에 따라서 재정의 구현하고 있다

    class Person : Object
    {
        public string Name { get; set; }
        public int Age { get; set; }

        
        public override string ToString()
        {
            //return base.ToString();)
            return "Person : " + Name + "-" + Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Smith", Age = 12 };
            //Console.WriteLine(person.ToString()); //Ex10_ToString_Override.Person >> Object의 ToString() 그대로
            //Console.WriteLine(person); //Ex10_ToString_Override.Person

            Console.WriteLine(person.ToString()); //Person : Smith-12 >> 개발자가 목적에 따른 출력(재정의)
            Console.WriteLine(person); //Person : Smith-12
        }
    }
}

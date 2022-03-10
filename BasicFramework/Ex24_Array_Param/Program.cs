using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Array_Param
{
    class Person
    {

    }
    class Test
    {
        public void method(int i) { //함수의 parameter 로 1.값타임 2.참조타임 (사용자 클래스, 배열)
        
        }
        public void method2(Person p) { //Person 객체의 주소를 받겠다. 
        
        }
        public void method3(int[] arr) { //배열의 주소를 받겠다.
        
        }
        public Person method4(int[] arr) { //Person 객체의 주소를 리턴하겠다.
            Person p = new Person();
            return p; //주소값 리턴
        }
    }

    class paramArray
    {
        public int[] CopyArray(int[] source)
        {
            int[] target = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
               target[i] = source[i] + 1;
            }
            return target;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            paramArray pa = new paramArray();

            int[] p = new int[] { 100, 200, 300, 400, 500 };
            int[] so = pa.CopyArray(p); //주소값 전달
            foreach (int item in so)
            {
                Console.WriteLine("so Array:{0}", item);
            }
        }
    }
}

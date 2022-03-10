﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_User_Provider
{
    /*
    객체 간 관계
    상속 : 포함

    --포함--
    user : 사용자 (어떤 클래스...)
    provider : 제공자 (어떤 클래스...)

    class A{}
    class B{}
    두 클래스 간 관계 : A는 B를 사용합니다

    1. 상속 : class A : B {}
    2. 포함 : A라는 class 안에서 Member field B를 사용 >> class A { B b; }
    2.1 부분포함 & 전체포함 (생성과 소멸 같이 할거냐... 같이 안할거냐) 

    class B{}

    class A{
        B b; //포함 (A는 B를 사용합니다)
        A() { //생성자 A}
        A(){
            b = new B();
        }
    }
    >> 1. B는 독자적으로 생성된 것이 아니고, A객체가 생성될 때 B도 같이 생성
    >> ex) A a = new A(); // 운명 공동체 (= 전체)

    ----------------------------------------------------
    class B{}

    class A{
        B b; //포함 (A는 B를 사용합니다)
        A() { //생성자 A}
        A(B b){
            this.b = b;
        }
        void method(B b) {
            this.b = b;
        }
    }
    >> Main() { B b = new B(); A a = new A(b);  }
    >> 서로 다른 운명 // (부분) (lifecycle 이 다르다)

    ----------------------------------------------------
    의존관계(dependency) //함수를 기반으로(함수 안에서 생성, 전달...)
    class B {}
    class A {
        //member field 로 B타입 변수를 가지지 않는 것
        B print(B b){
            B b = new B();
            return b;
        }
    }

    활용사례
    interface Icall{ void m(); }

    class C : ICall{
        //반드시 재정의
        public void m(){}
    }
    class D : ICall{
        //반드시 재정의
        public void m(){}
    }

    * 현대적인 프로그램 방식은 : 유연한, 대충 하는 것
    class E {
        void method(Icall ic){ //좋은 코드
            Icall 를 구현한 C 또는 D 올 수 있다
        } 
        void method2(C c){ //C객체의 주소만
        }
        void method3(D d){ //D객체의 주소만
        }
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

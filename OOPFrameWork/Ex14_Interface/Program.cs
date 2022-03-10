using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Interface
{
    //일상 생활
    //UI/UX
    /*
     * 인터페이스 : 표준, 약속, 규칙, 규약을 만드는 행위
     * 1. 소프트웨어 설계 최상위 단계
     * 2. 게임 >> run() 달린다, move(int x, int y) 표준
     * 
     * * 초급 개발자 *
     * 1. 인터페이스를 [다형성] 입장에서 접근 사용 (Interface 부모타입)
     * 2. 서로 연관성이 없는 클래스를 하나로 묶어주는 기능 (같은 부모를 가지게 한다)
     * 3. C# 이 제공하는 수많은 API (Collection) >> 인터페이스 활용 >> 사용 방법
     * 4. I~ ... ~able : 수리할 수 있는, 날 수 있는... 의미 접근
     * 5. 객체 간 연결 고리 (객체 간 소통) >> [다형성]
     * 
     * * 문법 *
     * 1. 인터페이스는 모든 멤버가 구현부를 가지지 않는다.
     * 2. 인터페이스는 상속을 통한 강제구현을 목적으로 한다.
     * 3. 모든 접근자는 public... 코드에서 사용할 필요가 없다 => 생략
     * 4. 멤버필드를 가지지 않는다.
     * 5. 유일하게 다중상속 지원 (여러 개의 약속을 강제 구현... 인터페이스는 작은 단위로 설계... 유지보수 good)
     */

    interface Iable //I~ ... ~able (관용적 표현), default 가 public 이라 생략
    {
        void m(); //자동 public virtual
        int Count //자동 public virtual, 강제로 property get 구현하도록
        {
            get;
        }
    }
    interface Ib
    {
        void m2();
    }
    abstract class Abclass
    {
        public void run() { } //완성된 자원 + 미완성 자원
        public abstract void move(); //미완성 자원
    }
    class Child : Abclass, Iable, Ib
    {
        public override void move() //추상 클래스 추상 함수 구현
        {
            Console.WriteLine("Abclass.move()");
        }
        public int Count //Iable 추상 property, override 붙이지 X, 어차피 구현하기 때문에
        {
            get { return 100; }
        }
        public void m() //override 붙이지 X, 어차피 구현하기 때문에
        {
            Console.WriteLine("Iable.m()");
        }
        public void m2() //override 붙이지 X, 어차피 구현하기 때문에
        {
            Console.WriteLine("Ib.m2()");
        }
    }
// ---------------------------------------------------------
    interface Irepairable { }
    class Unit
    {
        public int hitpoint; //기본 에너지
        public readonly int MAXHP;
        public Unit(int hp)
        {
            this.MAXHP = hp;
        }
    }
    //지상 유닛
    class GroundUnit : Unit
    {
        public GroundUnit(int hp) : base(hp) //Unit  생성자 호출(부모)
        {
            
        }
    }
    //공중 유닛
    class AirUnit : Unit
    {
        public AirUnit(int hp) : base(hp) //Unit  생성자 호출(부모)
        {

        }
    }
    //건물
    class CommandCenter : Irepairable
    {

    }
    class Tank : GroundUnit, Irepairable
    {
        public Tank() : base(50) { }
        public override string ToString()
        {
            return "Tank";
        }
    }
    class Marine : GroundUnit
    {
        public Marine() : base(40) { }
        public override string ToString()
        {
            return "Marine";
        }
    }
    class Scv : GroundUnit, Irepairable
    {
        public Scv() : base(20) { }
        public override string ToString()
        {
            return "Scv";
        }
        public void repair(Tank t)
        {
            if (t.hitpoint != t.MAXHP)
            {
                t.hitpoint += 5;
            }
        }
        public void repair(Scv s)
        {
            if (s.hitpoint != s.MAXHP)
            {
                s.hitpoint += 5;
            }
        }

        public void repair(CommandCenter c)
        {

        }
        /*
        1. Unit 개수가 증가하면 repair, 함수의 개수도 같이 증가
        2. 한 개의 repair, 모든 수리를 하고 싶다
        ex) public void repair(Unit unit) {  } //Marine repair 대상이 아닌데...
            public void repair(GroundUnit unit) {  } //Marine repair 대상이 아닌데...

        Marine, Scv, Tank, CommandCenter 서로 연관성이 없어야 한다
        서로 연관성이 없는 자원들을 묶어주기
        수리 가능한, 수리할 수 있는 (~able) : interface >> inerface Irepairable { }
         */
        public void repair(Irepairable repairunit) //Irepairable 부모타입 : CommandCenter, Scv, Tank
        {
            //코드의 문제는 repairunit >> CommandCenter
            Unit unit = (Unit)repairunit; //downcasting
            if (unit.hitpoint != unit.MAXHP)
            {
                unit.hitpoint += 5;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.m();
            child.m2();
            child.move();
            Console.WriteLine(child.Count);
        }
    }
}

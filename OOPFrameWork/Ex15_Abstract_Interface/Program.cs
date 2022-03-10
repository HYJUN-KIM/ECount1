using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Abstract_Interface
{
    /*
     * 추상 클래스와 인터페이스
     * 공통점
     * 1. 강제적 구현
     * 2. 상속을 목적으로 한다.
     * 3. 객체 생성 불가 = 자립 X
     * 4. 다형성 (캐스팅)
     * 
     * 차이점(추상클래스              인터페이스)
     * 일반 함수를 가질 수 있다.      -
     * 멤버 필드를 가질 수 있다.      없다.
     * 단일 상속                      다중 상속
     * -                              구현 코드를 가지지 않는다.
     * 
     */

    /*
     게임(unit)
    unit 공통기능 (이동좌표, 이동, 멈춘다) : 추상화, 일반화
    unit 이동 방법은 다르다 (unit 마다 별도 강제구현)
     */

    abstract class Unit
    {
        public int x, y;
        public void stop()
        {
            Console.WriteLine("Unit Stop");
        }

        //이동
        public abstract void move(int x, int y);
    }

    class Tank : Unit
    {
        public override void move(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Tank 이동\t : " + this.x + ", " + this.y);
        }
        //Tank 특수화, 구체화
        public void changeMode()
        {
            Console.WriteLine("Tank 변환 모드");
        }
    }
    class Marine : Unit
    {
        public override void move(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Marine 이동\t : " + this.x + ", " + this.y);
        }
        //Marine 특수화, 구체화
        public void stop()
        {
            Console.WriteLine("정지");
        }
        public void stimpack()
        {
            Console.WriteLine("스팀팩 기능");
        }

    }
    class DropShip : Unit
    {
        public override void move(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("DropShip 이동\t : " + this.x + ", " + this.y);
        }
        // DropShip 특수화, 구체화
        public void load()
        {
            Console.WriteLine("Unit load...");
        }
        public void unload()
        {
            Console.WriteLine("Unit Unload...");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tank tank = new Tank();
            tank.move(1, 2);
            tank.changeMode();
            Console.WriteLine();
            Marine marine = new Marine();
            marine.move(200, 500);
            marine.stop();
            marine.stimpack();
            */

            //Tank 3대를 만들고 [같은 좌표]로 이동 시키세요 //객체 배열
            //여러 개의 Unit (Tank, Marine, DropShip) 만들고 [같은 좌표]로 이동 시키세요 //다형성, 전자제품 매장 ( buy(Product p) )
            /* 아마추어 방법
            Tank tank1 = new Tank();
            tank1.move(1, 2);
            Tank tank2 = new Tank();
            tank2.move(1, 2);
            Tank tank3 = new Tank();
            tank3.move(1, 2);

            Tank tank = new Tank(); 
            tank.move(3, 3);
            Marine marine = new Marine();
            marine.move(3, 3);
            DropShip dropship = new DropShip();
            dropship.move(3, 3);
            */

            Tank[] tanklist = {new Tank(), new Tank(), new Tank() }; //배열 사용
            foreach (Tank t in tanklist)
            {
                t.move(123, 456);
            }
            Unit[] unitlist = {new Tank(), new Marine(), new DropShip() };
            foreach (Unit u in unitlist)
            {
                u.move(111, 222);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //추가

namespace Ex10_Thread_lock_wroom
{
    class Wroom
    {
        public void opendoor(string name)
        {
            lock(this){
                Console.WriteLine(name + " 님 화장실 입장을 환영합니다!!");
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(name + " 사용중 : " + i);
                    if (i == 10)
                    {
                        Console.WriteLine(name + " 님 끙 ~~~");
                    }
                    Console.WriteLine("시원하시죠? ^^");
                }
            }
        }
    }
    class User
    {
        Wroom wroom;
        string who;
        public User(Wroom wroom, string who)
        {
            this.who = who;
            this.wroom = wroom;
        }
        public void run()
        {
            wroom.opendoor(this.who);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //한강 둔치
            Wroom wroom = new Wroom();

            //사람들
            User kim = new User(wroom, "김씨");
            User lee = new User(wroom, "이씨");
            User park = new User(wroom, "박씨");

            //배가 아파요
            //각각 Thread
            Thread kimT = new Thread(new ThreadStart(kim.run));
            Thread leeT = new Thread(new ThreadStart(lee.run));
            Thread parkT = new Thread(new ThreadStart(park.run));

            kimT.Start();
            leeT.Start();
            parkT.Start();

        }
    }
}

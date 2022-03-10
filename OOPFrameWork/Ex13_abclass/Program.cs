using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_abclass
{
    abstract class EmptyCan
    {
        public int count; //member field
        public abstract int Count //강제구현(property)
        {
            get; //return 구현
            set; //value parameter 사용 구현
        }
        public void speak()
        {
            Console.WriteLine("speak!!");
        }
        public abstract void sound(); //강제구현
        public abstract void who(); //강제구현
    }
    class BeerCan : EmptyCan
    {
        public override int Count //추상 property 구현
        {
            get { return this.count; }
            set { this.count = value; }
        }
        public override void sound()
        {
            Console.WriteLine("깡깡깡");
        }
        public override void who()
        {
            Console.WriteLine("홍길동");
        }
    }
    class CiderCan : EmptyCan
    {
        public override int Count //추상 property 구현
        {
            get { return this.count; }
            set { this.count = value; }
        }
        public override void sound()
        {
            Console.WriteLine("위위윙");
        }
        public override void who()
        {
            Console.WriteLine("아무개");
        }
        public void where()
        {
            Console.WriteLine("공원에서");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BeerCan beerCan = new BeerCan();
            beerCan.speak();
            beerCan.sound();
            beerCan.who();
            Console.WriteLine("\n");
            CiderCan ciderCan = new CiderCan();
            ciderCan.speak();
            ciderCan.sound();
            ciderCan.who();
            ciderCan.where();

        }
    }
}

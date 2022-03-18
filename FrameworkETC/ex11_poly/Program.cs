using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_poly
{
    /*    
    [클라이언트 요구사항]
    가전제품은 제품의 가격 , 제품의 포인트 정보를 공통적으로 가지고 있습니다
    각각의 가전제품은 제품별 고유한 이름을 가지고 있다

    ex)
    각각의 전자제품은 이름을 가지고 있다(ex: Tv , Audio , Computer)
    각각의 전자제품은 다른 가격을 가지고 있다(Tv:5000, Audio:6000 ....)
    제품의 포인트는 가격의 10% 적용한다
    

    시뮬레이션 시나리오

    구매자 : 제품을 구매하기 위한 금액정보 , 포인트 정보를 가지고 있다 
    예를 들면 : 10만원 , 포인트 0
    구매자는 제품을 구매할 수 있다, 구매행위를 하게되면 가지고 있는 돈은 감소하고 포인트는 올라간다
    구매자는 처음 초기 금액을 가질 수 있다
    */
    class Product : Object
    {
        public int price;
        public int bounspoint;
        public Product() { }
        public Product(int price)
        {
            this.price = price;
            this.bounspoint = (int)(this.price / 10.0);
        }
    }
    class Tv : Product
        {
            public Tv() : base(500) { }
            public override string ToString()
            {
                return "Tv";
            }
        }
    class Audio : Product
    {
        public Audio() : base(100) { }
        public override string ToString()
        {
            return "Audio";
        }
    }
    class NoteBook : Product
    {
        public NoteBook() : base(150) { }
        public override string ToString()
        {
            return "NoteBook";
        }
    }
    //구매자
    class Buyer
    {
        private int money = 1000;
        private int bounspoint;
        public void Buy(Product n)
        {
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다. " + this.money);
                return;
            }
            this.money -= n.price;
            this.bounspoint += n.bounspoint;
            Console.WriteLine("구매한 물건은 : " + n.ToString());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //매장
            Tv tv = new Tv();
            Audio audio = new Audio();
            NoteBook notebook = new NoteBook();

            //고객 생성
            Buyer buyer = new Buyer();

            //구매 행위
            buyer.Buy(tv);
            buyer.Buy(audio);
            buyer.Buy(audio);
            buyer.Buy(notebook);
            buyer.Buy(notebook);
            buyer.Buy(audio);

        }
    }
}

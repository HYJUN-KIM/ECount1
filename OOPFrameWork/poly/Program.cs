﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Poly_Quiz
{
    /*

    시나리오(요구사항)

    저희는 가전제품 매장 솔루션을 개발하는 사업팀입니다
    A라는 전자제품 매장이 오픈되면 

    [클라이언트 요구사항]

    가전제품은 제품의 가격 , 제품의 포인트 정보를 공통적으로 가지고 있습니다
    각각의 가전제품은 제품별 고유한 이름을 가지고 있다

    ex)

    각각의 전자제품은 이름을 가지고 있다(ex: Tv , Audio , Computer)
    각각의 전자제품은 다른 가격을 가지고 있다(Tv:5000, Audio:6000 ....)
    제품의 포인트는 가격의 10% 적용한다

​

    시뮬레이션 시나리오

    구매자 : 제품을 구매하기 위한 금액정보 , 포인트 정보를 가지고 있다 
    예를 들면 : 10만원 , 포인트 0
    구매자는 제품을 구매할 수 있다 , 구매행위를 하게되면 가지고 있는 돈은 감소하고 포인트는 올라간다
    구매자는 처음 초기 금액을 가질 수 있다

*/
    class Product : Object
    {
        public int price;
        public int bonuspoint;
        public Product() { }
        public Product(int price)
        {
            this.price = price;
            this.bonuspoint = (int)(this.price / 10.0);
        }
    }

    class KtTv : Product
    {
        public KtTv() : base(500)  //상위 생성자를 호출하는  base
        {

        }

        public override string ToString()  //Object 가지는 public virtual 자원 
        {
            return "KtTv";
        }

    }


    class Audio : Product
    {
        public Audio() : base(100)
        {

        }

        public override string ToString()
        {
            return "Audio";
        }
    }


    class NoteBook : Product
    {
        public NoteBook() : base(150)
        {

        }

        public override string ToString()
        {
            return "NoteBook";
        }
    }

    //구매자
    class Buyer
    {
        private int money = 1000;
        private int bonuspoint;

        //구매자 구매행위 (기능)
        //구매행위 (잔액 - 제품의 가격 , 포인트 정보 갱신)
        //*************구매자는 매장에 있는 모든 물건을 구매할 수 있다 ***************

        //각각의 제품을 구매할 수 있는 함수 제공 ^^
        /*
        public void KttvBuy(KtTv n) //Tv 객체의 주소를 받아요 
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }

        public void AudioBuy(Audio n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }

        public void NoteBookBuy(NoteBook n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }
        */

        //팀장 : 휴가 .... 하와이 ....
        //......놀고 ...

        //물건(전자제품) : 1000개 추가  >> POS >> 매장
        //사장님 >> 행사 >> 난리가 ... 
        //이 시스템 3개 구매 .... 나머지 997 구매 >> 처리하는 함수
        //팀장 >> 전화 >> 재영 >> PC >> 함수 997개 >> 제품마다 구매할 수 있는 함수 >> 문제 ...

        //1. 어떠한 제품이 들어와도 구매가 가능 하도록 ...
        //단) 모든 제품은 Product 를 상속한다는 조건  ..함수의 로직은 동일 
        //Quiz : Buyer 클래스의 어떠한 부문을 수정해서 처리 ...

        //hint)
        //오버로딩 개념
        //다형성 개념

        /*
        public void Buy(NoteBook n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }
        */

        //모든 전자제품의 부모는  Product  (다형성)
        //Product product = new Audio();
        //Product product = new KtTv();
        //Product product = new NoteBook();
        //단 product 는 자신의 자원 볼 수 있다 (

        public void Buy(Product n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //매장  제품 3개배치
            KtTv tv = new KtTv();
            Audio audio = new Audio();
            NoteBook notebook = new NoteBook();
            //고객 생성
            Buyer buyer = new Buyer();

            //구매 행위
            /*
            buyer.AudioBuy(audio);
            buyer.NoteBookBuy(notebook);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);
            */

            buyer.Buy(audio);
            buyer.Buy(notebook);
            buyer.Buy(tv);
            buyer.Buy(tv);
        }
    }
}
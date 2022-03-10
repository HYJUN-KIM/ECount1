using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Override
{
    /*
    overloading : 하나의 이름으로 여러 가지 기능
    성능과 무관// 개발자의 편의를 위해 사용

    상속의 진정한 의미: 재사용성 (부모)

    var는 데이터 타입 변경X, dynamic은 가능
    */
    /*
     * [상속관계] 에서 override : 상속관계에서 자식이 부모의 자원을 재정의 (member field, method)
     * 상속관계에서 자식 class가 부모 class의 method(함수)의 [내용]만 변경
     * 재정의 : 틀의 변화는 없고 (내용만) {안쪽... 수정} >> 함수의 이름이나 타입을 바꾸는 것이 아니다.
     * 
     * 1. 부모함수 이름 동일
     * 2. 부모함수 parameter 동일
     * 3. 부모함수 return type 형식 동일
     * 4. 결국 { 실행 블럭 안 코드만 변경 }
     
    overriding : 상속관계에서 자식이 부모의 자원을 재정의
    - new ( 상위자원 무시) : 거의 안씀
    - virtual (재정의 해주었으면 좋겠어 : 강한 의지)
    - override (재정의)

    상속관계에서 부모가 먼저 heap 올라가고 이를 따라서 자식도 heap 올라감
    child 타입은 heap에 있는 Father, Child 두 객체 모두 접근 가능 왜? 상속관계니까
    그런데, 부모가 가지는 함수를 자식이 재정의 했다면!! >> child 타입은 재정의한 자원만(Child) 접근 가능
    >> * 다형성 *
    부모타입은 자식타입의 주소를 가질 수 있다

    Father f = child; //자식이 가지고 있는 주소를 부모 타입의 f변수에 할당 (단, 상속관계)

    부모타입으로 접근 하더라도 재정의가 되어있다면 자식쪽으로 넘겨 버린다 : override

    상속관계에서 재정의한 부모함수를 부르는 유일한 방법 >> base( ) : 상속관계에서 this( )
    // base => 자바에서는 super
    // base.Vprint( ); //상위자원으로 가서 함수 호출     
     */

    class Point2
    { //한 점을 가지는 클래스
        public int x = 4;
        public int y = 5;

        public virtual string getPosition()
        {
            return this.x + ":" + this.y;
        }
    }

    class Point3D : Point2
    {
        public int z = 6;

        //안좋은 방법 (상속관계)
        /*
        string getPosition3D()
        {
            return this.x + ":" + this.y + ":" + this.z;
        }
        */
        //권장하는 방법.. 추가 내용에 대한 출력...
        public override string getPosition()
        {
            return this.x + ":" + this.y + ":" + this.z; //base.getPosition();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

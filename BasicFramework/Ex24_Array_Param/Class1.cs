using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Array_Param
{
    class Lotto
    {
        private int[] nums;
        private Random random;

        public lotto()
        { //member field 초기화가 목적인 생성자에서 처리하자!!
            nums = new int[6]; //배열의 초기화 (최초 값을 가지는 것)
            random = new Random(); //초기화
        }

        public void getReadLottoNums()
        {

        }

        public void displayLottoNums()
        {

        }
    }
        static void Main(string[] args)
        {
            lotto lotto = new lotto();
            lotto.getReadLottoNums();
            lotto.displayLottoNums();

        }       
}

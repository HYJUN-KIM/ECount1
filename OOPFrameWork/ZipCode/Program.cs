using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Zipcode
{
    // [A-Za-z0-9]: 영어나 숫자로 시작해야 하며 하이픈(-)으로 끝나면 안된다.
    // [A-Za-z0-9-]{1,61}: 영문자(A~Z), 숫자(0~9) 또는 하이픈(-)조합으로만 가능하며 영문자의 대·소문자 구별이 없다.
    // (.[A-Za-z]{2,}){1,}: 최상위 도메인으로, co.kr 같은 경우도 고려하여 1회 이상으로 설정하였다. 
    /*
    우편번호: 2015년 8월 이후, 현재 도로명 주소를 기반으로 구역을 정하여 번호를 부여한 국가기초구역번호를 사용
    총5자리로 앞 두 자리를 통해 '특별시(광역시) ~ 도' 구분 가능
    첫 번째 자리: 0~6
    두 ~다섯 번째 자리: 0~9
    ^[0-6]\d{4}$ 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("우편번호 입력: ");
            string zipcode = Console.ReadLine();

            if (Regex.IsMatch(zipcode, @"^[0-6]\d{4}$"))
            {
                Console.WriteLine("입력하신 우편번호 {0} 은(는) 있는 우편번호입니다.", zipcode);
            }
            else
            {
                Console.WriteLine("입력하신 우편번호 {0} 은(는) 없는 우편번호입니다.", zipcode);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Try_Catch
{
    //예외처리 : 개발자가 코드를 통해서 문제 발생
    //개선의 여지가 있다
    //내가 만든 코드가 문제가 있을까, 문제 없어 확신...

    //try ~ catch ~ finally
    //코드를 수정하는 것이 아니고 프로그램이 강제로 죽는 것 방지...
    //문제를 인지하고 추후에 코드는 수정해야 한다.

    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = null;
            Console.WriteLine(str.ToString()); //예외가 발생 >> System.NullReferenceException >> 프로그램 강제 종료
            Console.WriteLine("성공 종료^^");
            */
            /*
            처리되지 않은 예외: System.NullReferenceException: 개체 참조가 개체의 인스턴스로 설정되지 않았습니다.
            위치: Ex06_Try_Catch.Program.Main(String[] args) 파일 C:\ECount\Labs\OOPFrameWork\Ex06_Try_Catch\Program.cs:줄 22
             */

            string str = null;
            try
            {
                Console.WriteLine(str.ToString());
                //내부적으로.. 예외를 담을 수 있는 객체가 자동 생성... 그 객체에 문제를 담고... 그 주소를 Exception ex 전달
                //NullReferenceException

                //1. 계층 구조
                //상속 >> Object ->  Exception -> SystemException -> NullReferenceException
                //2. 부모 타입의 변수는 자식 타입의 주소를 받을 수 있다.(다형성)
                //3. Exception ex = new NullReferenceException("문제 발생 코드")
                //try 문제가 생기면... 자동으로 그 문제에 대한 객체를 생성한다.
                //4. 그런데 catch(Exception ex) 코드를 생성... catch(NullReferenceException ex) 로 하지 않았을까
                //5. 결국 무슨 예외가 발생할 지 모름... 그래서 모든 예외의 부모를 가지고 받아서 처리
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                //1. log 파일에 정보 기록 >> 수정 인지 = 문제 해결X
                //2. 메일 시스템 연동 문제... 관리자(담당자) 메일 >> 수정 인지 = 문제 해결X
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("성공 종료^^");
        }
    }
}

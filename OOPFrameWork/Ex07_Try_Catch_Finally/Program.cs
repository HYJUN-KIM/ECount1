using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //예외를 강제로 던지기
                throw new IndexOutOfRangeException("배열 문제 발생");
            }
            catch (Exception ex)
            {
                //throw 발생한 예외 확인
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine("***"+ex.StackTrace);
                Console.WriteLine("---"+ex.ToString());
            }
            finally
            {
                //강제로 실행 블럭
                Console.WriteLine("Power Off ");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Property_Object
{
    //생성자가 없어요
    //property 를 통해서 객체 생성 시 초기화 작업 가능
    //객체를 생성할 때
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "홍길동",
                Birthday = new DateTime(1650, 2, 12)
            };

            Console.WriteLine("Name: {0}", birth.Name);
            Console.WriteLine("Birthday: {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age: {0}", birth.Age);
        }
    }
}

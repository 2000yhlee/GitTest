using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250320_GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력해주세요 : ");
            string input = Console.ReadLine();

            Console.WriteLine("당신의 이름은 {0}입니다.", input);
            Console.WriteLine("새로운 기능 추가!");
        }
    }
}

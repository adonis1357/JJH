using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("생년월일을 입력하세요 (예: 1995 5 25): ");
            string[] input = Console.ReadLine().Split(' ');
            int year = int.Parse(input[0]);
            //int month = int.Parse(input[1]);
            //int day = int.Parse(input[2]);

            string[] animals = {"쥐", "소", "범", "토끼", "용", "뱀", "말", "양", "원숭이", "닭", "개", "돼지" };
            int zodiacIndex = (year % 12) - 4;
            if (zodiacIndex < 0)
            {
                zodiacIndex += 12;
            }
            string zodiac = animals[zodiacIndex];

            Console.WriteLine($"{year}년의 십이지신은 {zodiac}입니다.");
        }
    }
}

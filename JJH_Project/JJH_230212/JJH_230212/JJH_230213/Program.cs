using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230213
{
    class Program
    {
        static void Main(string[] args)
        {
            //2월 13일
            //나이에 해당하는 띠를 출력해주는 클래스 만들기.
            //- 1 나이를 입력받는다.
            //- 2 해당하는 띠를 출력해준다.
            //- 3 나이도 출력해준다.

            //zodiac birth = new zodiac();
            //string birthday;
            //System.Console.WriteLine("생년월일을 입력해주세요");
            //birthday = System.Console.ReadLine();
            //int birthday2 = Convert.ToInt32(birthday);
            //birth.birthdayInput(birthday2);

            //계산기 클래스를 제작한다.
            //- 1 숫자2개와 기호 하나를 입력받는다.
            //- 2 연산에 해당하는 결과값을 출력한다.

            //System.Console.WriteLine("첫번째 값을 입력해주세요");
            //int num1 = int.Parse(Console.ReadLine());

            //System.Console.WriteLine("연산자를 입력해주세요 예시(+, -, *, /, %):");
            //string op = System.Console.ReadLine();

            //System.Console.WriteLine("두번째 값을 입력해주세요");
            //int num2 = int.Parse(Console.ReadLine());

            //Calculator cal = new Calculator();

            //cal.calculate(num1, num2, op);

            System.Console.WriteLine("계산할 값을 입력해주세요 (예시: 5 + 10)");

            string input = System.Console.ReadLine();
            string[] inputs = input.Split(' ');

            int value1 = int.Parse(inputs[0]);
            string secondValue = inputs[1];
            int value2 = int.Parse(inputs[2]);

            Calculator cal = new Calculator();

            cal.calculate(value1, value2, secondValue);

        }
    }
    class Calculator
    {
        public void calculate(int a, int b, string c)
        {
            int result = 0;
            switch(c)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "%":
                    result = a % b;
                    break;
                default:
                    Console.WriteLine("잘못된 연산자입니다.");
                    return;
            }
            System.Console.WriteLine($"= {a} {c} {b} = {result}");
                
        }
    }

    class zodiac
    {
        public string[] zodiacs;
        public void birthdayInput(int birthdayData)
        {
            int zodiacData = (birthdayData - 4) % 12;
            zodiacs = new string[] {"쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양", "원숭이", "닭", "개", "돼지" };
            string zodiac = zodiacs[zodiacData];
            System.Console.WriteLine($"{zodiac}띠 입니다.");
            System.Console.WriteLine(DateTime.Now.Year - birthdayData + "살 입니다.");
            //if (zodiacData == 0)
            //{
            //    System.Console.WriteLine("쥐띠 입니다.");
            //}
            //else if (zodiacData == 1)
            //{
            //    System.Console.WriteLine("소띠 입니다.");
            //}
            //else if (zodiacData == 2)
            //{
            //    System.Console.WriteLine("호랑이띠 입니다.");
            //}
            //else if (zodiacData == 3)
            //{
            //    System.Console.WriteLine("토끼띠 입니다.");
            //}
            //else if (zodiacData == 4)
            //{
            //    System.Console.WriteLine("용띠 입니다.");
            //}
            //else if (zodiacData == 5)
            //{
            //    System.Console.WriteLine("뱀띠 입니다.");
            //}
            //else if (zodiacData == 6)
            //{
            //    System.Console.WriteLine("말띠 입니다.");
            //}
            //else if (zodiacData == 7)
            //{
            //    System.Console.WriteLine("양띠 입니다.");
            //}
            //else if (zodiacData == 8)
            //{
            //    System.Console.WriteLine("원숭이띠 입니다.");
            //}
            //else if (zodiacData == 9)
            //{
            //    System.Console.WriteLine("닭띠 입니다.");
            //}
            //else if (zodiacData == 10)
            //{
            //    System.Console.WriteLine("개띠 입니다.");
            //}
            //else if (zodiacData == 11)
            //{
            //    System.Console.WriteLine("돼지띠 입니다.");
            //}
            //else
            //{
            //    System.Console.WriteLine("잘못된 값입니다.");
            //}

        }
    }

}

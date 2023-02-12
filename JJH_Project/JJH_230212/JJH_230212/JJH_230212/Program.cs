using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230212
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #을 while문으로 방향키 이동
            //ConsoleKeyInfo cski;

            //int x = 10;
            //int y = 10;

            //while(true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("#");

            //    cski = Console.ReadKey(true);

            //    switch(cski.Key)
            //        {
            //        case ConsoleKey.LeftArrow:
            //            x--;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x++;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            y--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;

            //        }
            #endregion

            #region region활용벙법 01

            #endregion

            #region region활용방법 02

            #endregion

            //1. 산술 이항 하나씩 쓰기 (+ - * / %) , 출력하기 5줄
            int a = 15;
            int b = 5;
            System.Console.WriteLine("a = 15, b = 5");

            System.Console.WriteLine("a + b = " + (a + b));
            a = 15; b = 5;
            System.Console.WriteLine("a - b = " + (a - b));
            a = 15; b = 5;
            System.Console.WriteLine("a * b = " + (a * b));
            a = 15; b = 5;
            System.Console.WriteLine("a / b = " + (a / b));
            a = 15; b = 5;
            System.Console.WriteLine("a % b = " + (a % b));


            //2. 할당 (+=, -=, ...), 출력하기 5줄
            a = 15; b = 5;
            System.Console.WriteLine("a += b " + (a += b));
            a = 15; b = 5;
            System.Console.WriteLine("a -= b " + (a -= b));
            a = 15; b = 5;
            System.Console.WriteLine("a *= b " + (a *= b));
            a = 15; b = 5;
            System.Console.WriteLine("a /= b " + (a /= b));
            a = 15; b = 5;
            System.Console.WriteLine("a %= b " + (a %= b));

            //3. 증감 (++, --) 앞뒤로 4줄
            a = 15;
            System.Console.WriteLine("++a " + (++a));
            System.Console.WriteLine("a++ " + (a++));
            System.Console.WriteLine("--a " + (--a));
            System.Console.WriteLine("a-- " + (a--));


            //4. 2개 숫자 입력후 A가 짝수 이고 B가 5보다 큰가를 If문으로
            string AA;
            string BB;

            System.Console.WriteLine("A의 값을 입력해주세요");
            AA = System.Console.ReadLine();
            System.Console.WriteLine("B의 값을 입력해주세요");
            BB = System.Console.ReadLine();
            int A = Convert.ToInt32(AA);
            int B = Convert.ToInt32(BB);

            //9. 위에 했던 4, 5, 6, 7, 8을 메소드로 뽑아서 실행하기
            int C = D(A, B);
            
            System.Console.WriteLine("C = " + (C));

            //10. for문안에서 숫자를 계속 입력받는다.
                //-1. 숫자가 짝수인 경우 continue로 넘김.
                //-2. 숫자가 10인경우 break로 for문 종료.
                //-3. 그 외의 숫자인 경우 "다음 숫자 입력"을 출력

            for(;;)
            {
                string EE;
                System.Console.WriteLine("다음 숫자 입력");
                EE = System.Console.ReadLine();
                int E = Convert.ToInt32(EE);
                if(E == 10)
                {
                    System.Console.WriteLine("E는 10입니다");
                    break; 
                }
                else if(E % 2 == 0)
                {
                    System.Console.WriteLine("E는 10이 아닌 짝수입니다");
                    continue;
                }
                else
                {
                    System.Console.WriteLine("E는 홀수입니다");
                }
            }
            System.Console.WriteLine("for문을 종료합니다.");
        }
        private static int D(int A, int B)
        {
            if (A % 2 == 0 && B > 5)
            {
                System.Console.WriteLine("A는 짝수이고 B는 5보다 큽니다");
            }

            //5. 2개 숫자 입력후 A가 홀수 B가 3보다 작은가를 elseIf문으로
            else if (A % 2 != 0 && B < 3)
            {
                System.Console.WriteLine("A는 홀수이고 B는 3보다 작습니다 ");
            }

            //6. else 문으로 없음 출력하기
            else
            {
                System.Console.WriteLine("없음");
            }

            //7. 숫자 입력받은거 만큼 문장 출력(while)
            System.Console.WriteLine("A숫자 만큼 와일 출력");
            while (A > 0)
            {
                System.Console.Write(A);
                System.Console.WriteLine("와일");
                A--;
            }

            //8. 숫자 입력받은거 만큼 문장 출력(for)
            System.Console.WriteLine("B숫자 만큼 포 출력");
            for (; B > 0; B--)
            {
                System.Console.Write(B);
                System.Console.WriteLine("포");
            }

            return 0;
        }

    }
}

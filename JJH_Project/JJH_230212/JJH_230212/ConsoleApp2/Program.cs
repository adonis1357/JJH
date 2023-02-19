using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerone = 0;
            int playertwo = 0;
            string playerLeft = "";
            string playerRight = "";
            bool i = true;
            System.Console.WriteLine("왼손값을 입력해 주세요.(예시 - 1. 가위, 2. 바위, 3. 보)");
            while (i)
            {
                string left = System.Console.ReadLine();
                if (left == "1")
                {
                    playerone = 0;
                    playerLeft = "가위";
                    i = false;
                }
                else if (left == "2")
                {
                    playerone = 1;
                    playerLeft = "바위";
                    i = false;
                }
                else if (left == "3")
                {
                    playerone = 2;
                    playerLeft = "보";
                    i = false;
                }
                else
                {
                    System.Console.WriteLine("잘못입력하셨습니다.");
                }
            }
            bool ii = true;
            System.Console.WriteLine("오른손 값을 입력해 주세요.(예시 - 1. 가위, 2. 바위, 3. 보)");
            while (ii)
            {
                string right = System.Console.ReadLine();
                if (right == "1")
                {
                    playertwo = 0;
                    playerRight = "가위";
                    ii = false;
                }
                else if (right == "2")
                {
                    playertwo = 1;
                    playerRight = "바위";
                    ii = false;
                }
                else if (right == "3")
                {
                    playertwo = 2;
                    playerRight = "보";
                    ii = false;
                }
                else
                {
                    System.Console.WriteLine("잘못입력하셨습니다.");
                }
            }

            Random rand = new Random();
            int randomInt = rand.Next(0, 2);
            int randomInt2 = rand.Next(0, 2);
            string one = "", two = "";
            int re = 0, ree = 0;
            switch (randomInt)
            {
                case 0:
                    one = "가위";
                    re = 0;
                    break;
                case 1:
                    one = "바위";
                    re = 1;
                    break;
                case 2:
                    one = "보";
                    re = 2;
                    break;
            }

            switch (randomInt2)
            {
                case 0:
                    two = "가위";
                    ree = 0;
                    break;
                case 1:
                    two = "바위";
                    ree = 1;
                    break;
                case 2:
                    two = "보";
                    ree = 2;
                    break;
            }
            Console.WriteLine("컴퓨터가 낸 것은");
            Console.WriteLine($"왼  손: {one}");
            Console.WriteLine($"오른손: {two}");

            Console.WriteLine("플레이어가 낸 것은");
            Console.WriteLine($"왼  손: {playerLeft}");
            Console.WriteLine($"오른손: {playerRight}");

            int randomInt3 = rand.Next(0, 2);
            int comResult = 0;
            switch (randomInt3)
            {
                case 0:
                    comResult = re;
                    break;
                case 1:
                    comResult = ree;
                    break;
            }

            int PlayerResult2 = 0;
            bool iii = true;
            while (iii)
            {
                System.Console.WriteLine("왼손과 오른손 중 어느 손을 고르시겠습니까?(1. 왼손, 2. 오른손)");
                string PlayerResult = System.Console.ReadLine();
                if (PlayerResult == "1")
                {
                    PlayerResult2 = playerone;
                    iii = false;
                }
                else if (PlayerResult == "2")
                {
                    PlayerResult2 = playertwo;
                    iii = false;
                }
                else
                {
                    System.Console.WriteLine("잘못 입력하셨습니다.");
                }
            }

            string comResult2 = "";
            
            switch (comResult)
            {
                case 0:
                    comResult2 = "가위";
                    break;
                case 1:
                    comResult2 = "바위";
                    break;
                case 2:
                    comResult2 = "보";
                    break;
            }

            string PlayerResult3 = "";
            switch (PlayerResult2)
            {
                case 0:
                    PlayerResult3 = "가위";
                    break;
                case 1:
                    PlayerResult3 = "바위";
                    break;
                case 2:
                    PlayerResult3 = "보";
                    break;
            }
            System.Console.WriteLine("========<결과>========");
            System.Console.WriteLine($"플레이어({comResult2}) VS 컴퓨터({PlayerResult3})");

            if (comResult == PlayerResult2)
            {
                System.Console.WriteLine("비겼습니다.");
            }
            else if (comResult == 0 && PlayerResult2 == 1)
            {
                System.Console.WriteLine("플레이어가 이겼습니다.");
            }
            else if (comResult == 0 && PlayerResult2 == 2)
            {
                System.Console.WriteLine("플레이어가 졌습니다.");
            }
            else if (comResult == 1 && PlayerResult2 == 0)
            {
                System.Console.WriteLine("플레이어가 졌습니다.");
            }
            else if (comResult == 1 && PlayerResult2 == 2)
            {
                System.Console.WriteLine("플레이어가 이겼습니다.");
            }
            else if (comResult == 2 && PlayerResult2 == 0)
            {
                System.Console.WriteLine("플레이어가 이겼습니다.");
            }
            else if (comResult == 2 && PlayerResult2 == 1)
            {
                System.Console.WriteLine("플레이어가 졌습니다.");
            }
            else
            {
                System.Console.WriteLine("잘못된 값이 들어왔습니다.");
            }
        }

    }
}

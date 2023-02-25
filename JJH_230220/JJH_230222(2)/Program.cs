using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.TreatControlCAsInput = true;        // Ctrl+C를 일반 키 입력으로 처리
        int user = 10;                              // 유저
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;
        int x = 30;
        int y = (windowHeight - 1) / 2;
        int win = 0;
        int tie = 0;
        Console.SetCursorPosition(x, y);
        Console.Write(user);

        Random random = new Random();
        int newY = random.Next(10, windowHeight - 10);
        int newX = windowWidth - 30;
        List<int> monsters = new List<int>();
        List<int> monsterrTimers = new List<int>();

        while (true)
        {
            if (x == newX && y == newY)
            {
                if (user > monsters[0])
                {
                    user = user + (user - monsters[0]);
                    win++;
                }
                else if (user == monsters[0])
                {
                    user = user / 2;
                    tie++;
                }
                else
                {
                    break;
                }
                monsters.RemoveAt(0);
                monsterrTimers.RemoveAt(0);
                newX = windowWidth - 30;
                newY = random.Next(10, windowHeight - 10);
            }

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(user);

            // 새로운 숫자 생성
            for (int j = 0; j < monsters.Count; j++)
            {
                monsterrTimers[j]++;
                if (newX < 30 || monsterrTimers[j] >= 100) // 생성된 지 20초가 지나거나, 화면을 벗어나면 삭제
                {
                    monsters.RemoveAt(j);
                    monsterrTimers.RemoveAt(j);
                    j--;
                }
            }

            if (monsterrTimers.Count == 0 || monsterrTimers[monsterrTimers.Count - 1] >= 5)
            {
                monsters.Add(user + random.Next(-3, 7));
                monsterrTimers.Add(0);
            }

            for (int j = 0; j < monsters.Count; j++)
            { 
                Console.SetCursorPosition(windowWidth - 30 + (monsters.Count - j - 1) * 5, random.Next(10, windowHeight - 10));
                Console.Write(monsters[j]);
            }

            newX--;

            Thread.Sleep(10);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (y > 0)
                    {
                        y--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (y < windowHeight - 1)
                    {
                        y++;
                    }
                }
            }
        }

        Console.Clear();
        int gameoverY = windowHeight / 2;
        int gameoverX = (windowWidth - 45) / 2;
        Console.SetCursorPosition(gameoverX, gameoverY);
        Console.WriteLine("게임오버");
        Console.WriteLine($"                                   승    리: {win} 승");
        Console.WriteLine($"                                   무 승 부: {tie} 무");
        Console.WriteLine($"                                   최종점수: {user} 점");
        Console.WriteLine(@"


");
    }
}


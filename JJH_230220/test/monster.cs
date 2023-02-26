using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    public class monster
    {
        int user = 0;
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;
        int x = 30;
        int y = 50;

        int WidthVelue = 45;
        int Y_Info = 10;
        int X_Info = 30;

        int Y = 0;
        int X = 0;

        int perfect = 0;
        int win = 0;
        int tie = 0;
        int Out = 0;

        int monsterPower = 0;
        int monsterX = 0;
        Random random = new Random();

        int LifeVelue = 10;

        bool keyDown = false;
        ConsoleKeyInfo keyInfo;

        public void MonsterRegenStart(int WidthStart)

        {
            Y = random.Next(12, windowWidth - 13);
            X = windowWidth - WidthStart;
        }

        public void MonsterPower(int user)
        {
            monsterPower = user + random.Next(-3, 7);
        }

        public void MonsterRegenPlay(int x)
        {
            if (x < 30)
            {
                int Y = random.Next(12, windowWidth - 13);
                int X = windowWidth - WidthVelue;
                MonsterPower(user);
                Out++;
                LifeVelue--;
            }
        }

        public void crash(int user, int x, int y)
        {
            if (X == x && Y == y)
            {
                if (user > this.monsterPower)
                {
                    if (user == monsterPower + 1)
                    {
                        int RandomVelue = random.Next(3, 9);
                        user = user + RandomVelue;
                        Console.SetCursorPosition(X_Info, Y_Info);
                        Console.Write($"각성하여 유저 {RandomVelue} Level 증가               ");
                        Thread.Sleep(200);
                        perfect++;
                    }
                    int RandomVelue2 = random.Next(1, 3);
                    user = user + RandomVelue2;
                    Console.SetCursorPosition(X_Info, Y_Info);
                    Console.Write($"승리하여 유저 {RandomVelue2} Level 증가               ");

                    Thread.Sleep(100);
                    win++;
                }
                else if (user == monsterPower)
                {
                    int RandomVelue3 = random.Next(1, 3);
                    user = user - RandomVelue3;
                    Console.SetCursorPosition(X_Info, Y_Info);
                    Console.Write($"무승부로 유저 -{RandomVelue3} Level 감소               ");
                    Thread.Sleep(100);
                    tie++;
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"당신은 죽었습니다. 유저[{user} Level] 몬스터[{monsterPower} Level]");
                    Thread.Sleep(1000);
                    monsterX = monsterPower;
                }
            }
        }

        public void userMove()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(user);
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (!keyDown)
                    {
                        if (y > 12)
                        {
                            y--;
                            keyDown = true;
                        }
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (!keyDown)
                    {
                        if (y < 16)
                        {
                            y++;
                            keyDown = true;
                        }
                    }
                }
                else
                {
                    keyDown = false;
                }
            }
            else
            {
                keyDown = false;
            }
        }

        internal void crash(object user, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}

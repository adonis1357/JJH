using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JJH_230305
{
    class NexusDefense
    {
        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {
                gameinfo gameInfo = new gameinfo();

                Console.TreatControlCAsInput = true;        // Ctrl+C를 일반 키 입력으로 처리
                int Character = 0;
                Random random = new Random();
                int windowWidth = Console.WindowWidth;
                int windowHeight = Console.WindowHeight;

                int x = 30;
                int y = (windowHeight - 1) / 2;
                int dieX = (windowWidth - 20) / 2;
                int dieY = (windowHeight - 1) / 2;
                int perfect = 0;
                int win = 0;
                int tie = 0;
                int Out = 0;
                int start = 40;
                int NexusHP = 10;

                string GameOverVelue = "";

                int monsterLastVelue = 0;

                int Y_Info = 10;
                int X_Info = 30;
                string combo = "";
                int comboVelue = 0;

                monsterRegen[] monsters = monsterRegen.monsterRegenVelue(Character, random, windowWidth, windowHeight);

                Console.Clear();
                while (true)
                {
                    if (Character >= 10)
                    {
                        start = monsterRegen.GetStartValue(Character, start);
                    }

                    gameGroundUI gameGroundUI = new gameGroundUI(NexusHP);
                    gameGroundUI.DrawgameGroundUI();

                    Console.SetCursorPosition(x, y);
                    Console.Write(Character);

                    bool CharacterDead = false;
                    for (int i = 0; i < 5; i++)
                    {
                        if (monsters[i].MonsterRegenX < 24)
                        {
                            string monsterattack = Convert.ToString(monsters[i].MonsterPower);
                            Console.SetCursorPosition(monsters[i].MonsterRegenX, monsters[i].MonsterRegenY);
                            Console.Write(monsterattack = "☆");
                            Thread.Sleep(50);
                            gameGroundUI.DrawgameGroundUI2();
                        }
                        if (monsters[i].MonsterRegenX < 24)
                        {
                            monsters[i] = new monsterRegen();
                            monsters[i].MonsterPower = Character + random.Next(-3, 7);
                            monsters[i].MonsterRegenX = windowWidth - start;
                            monsters[i].MonsterRegenY = random.Next(12, windowHeight - 13);
                            Out++;
                            NexusHP--;

                            for (int j = 0; j < 5; j++)
                            {
                                if (i != j)
                                {
                                    if (monsters[i].MonsterRegenX == monsters[j].MonsterRegenX && monsters[i].MonsterRegenY == monsters[j].MonsterRegenY)
                                    {
                                        if (monsters[i].MonsterPower < 10)
                                        {
                                            monsters[i].MonsterRegenX = monsters[i].MonsterRegenX + 4;
                                        }
                                        else if (monsters[i].MonsterPower < 100)
                                        {
                                            monsters[i].MonsterRegenX = monsters[i].MonsterRegenX + 5;
                                        }
                                        else if (monsters[i].MonsterPower < 1000)
                                        {
                                            monsters[i].MonsterRegenX = monsters[i].MonsterRegenX + 6;
                                        }
                                        else if (monsters[i].MonsterPower < 10000)
                                        {
                                            monsters[i].MonsterRegenX = monsters[i].MonsterRegenX + 7;
                                        }
                                        else
                                        {
                                            monsters[i].MonsterRegenX = monsters[i].MonsterRegenX + 8;
                                        }
                                    }
                                }
                            }
                        }
                        if (x == monsters[i].MonsterRegenX && y == monsters[i].MonsterRegenY)
                        {
                            if (Character > monsters[i].MonsterPower)
                            {
                                if (Character == monsters[i].MonsterPower + 1)
                                {
                                    int RandomVelue = random.Next(3, 9);
                                    Character = Character + RandomVelue;
                                    Console.SetCursorPosition(X_Info, Y_Info);
                                    Console.Write($"각성하여 캐릭터 {RandomVelue} Level 증가               ");
                                    Thread.Sleep(10);
                                    perfect++;
                                    if (NexusHP <= 50)
                                    {
                                        NexusHP = NexusHP + 3;
                                        if (NexusHP > 50)
                                        {
                                            NexusHP = 50;
                                        }
                                    }
                                }
                                int RandomVelue2 = random.Next(1, 3);
                                Character = Character + RandomVelue2;
                                Console.SetCursorPosition(X_Info, Y_Info);
                                Console.Write($"승리하여 캐릭터 {RandomVelue2} Level 증가               ");
                                Thread.Sleep(10);
                                win++;
                                if (NexusHP <= 50)
                                {
                                    NexusHP = NexusHP + 1;
                                    if (NexusHP > 50)
                                    {
                                        NexusHP = 50;
                                    }
                                }
                            }
                            else if (Character == monsters[i].MonsterPower)
                            {
                                int RandomVelue3 = random.Next(1, 3);
                                Character--;
                                Console.SetCursorPosition(X_Info, Y_Info);
                                Console.Write($"무승부로 캐릭터 -1 Level 감소               ");
                                Thread.Sleep(10);
                                tie++;
                            }
                            else
                            {
                                Console.SetCursorPosition(x - 2, y);
                                Console.Write($"{Character}~~                 ");
                                Thread.Sleep(50);
                                Console.SetCursorPosition(x - 4, y);
                                Console.Write($"{Character}~~~                   ");
                                Thread.Sleep(40);
                                Console.SetCursorPosition(x - 6, y);
                                Console.Write($"{Character}~~~~                    ");
                                Thread.Sleep(30);
                                Console.SetCursorPosition(x - 9, y);
                                Console.Write($"{Character}~~~~~                       ");
                                Thread.Sleep(100);
                                Console.SetCursorPosition(x - 10, y);
                                Console.Write($"☆~                       ");
                                Thread.Sleep(100);
                                gameGroundUI gameGroundUI2 = new gameGroundUI(NexusHP);
                                gameGroundUI2.DrawgameGroundUI3();
                                Thread.Sleep(250);
                                gameGroundUI2.DrawgameGroundUI4();
                                Thread.Sleep(250);
                                gameGroundUI2.DrawgameGroundUI5();
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.SetCursorPosition(x, y);
                                Console.WriteLine($"캐릭터가 사망하였습니다 캐릭터[{Character} Level] 몬스터[{monsters[i].MonsterPower} Level]");
                                Thread.Sleep(1000);
                                monsterLastVelue = monsters[i].MonsterPower;
                                CharacterDead = true;
                                GameOverVelue = "캐릭터가 사망하였습니다.";
                                break;
                            }
                            monsters[i] = new monsterRegen();
                            monsters[i].MonsterPower = Character + random.Next(-3, 7);
                            monsters[i].MonsterRegenX = windowWidth - start;
                            monsters[i].MonsterRegenY = random.Next(12, windowHeight - 13);
                        }
                        monsters[i].MonsterRegenX--;
                        Console.SetCursorPosition(monsters[i].MonsterRegenX, monsters[i].MonsterRegenY);
                        Console.Write(monsters[i].MonsterPower);

                        //if (Character >= 5) // 캐릭터 레벨업에 따른 몬스터 속도 증가
                        //{
                        //    monsters[i].MonsterRegenX--;
                        //}

                        //if (Character >= 5) // 캐릭터 레벨업에 따른 몬스터 속도 증가 보정
                        //{
                        //    Thread.Sleep(20);
                        //}

                        //if (i == 1 || i == 2 || i == 3) //몬스터 속도 차등
                        //{
                        //    monsters[i].MonsterRegenX--;
                        //}
                        //else if (i == 4)
                        //{
                        //    monsters[i].MonsterRegenX -= 2;
                        //}

                    }
                    if (CharacterDead)
                    {
                        break;
                    }

                    if (NexusHP <= 0)
                    {
                        Console.SetCursorPosition(X_Info, Y_Info);
                        Console.Write($"넥서스가 파괴 되었습니다.               ");
                        gameGroundUI gameGroundUI2 = new gameGroundUI(NexusHP);
                        gameGroundUI2.DrawgameGroundUI();
                        Thread.Sleep(100);
                        gameGroundUI2.DrawgameGroundUI3();
                        Thread.Sleep(250);
                        gameGroundUI2.DrawgameGroundUI4();
                        Thread.Sleep(250);
                        gameGroundUI2.DrawgameGroundUI5();
                        Thread.Sleep(300);
                        Console.Clear();
                        Console.SetCursorPosition(X_Info+10, Y_Info+5);
                        Console.WriteLine($"넥서스가 파괴 되었습니다 캐릭터[{Character} Level]");
                        Thread.Sleep(1000);
                        GameOverVelue = "넥서스가 파괴 되었습니다.";
                        break;
                    }

                    Movement.MoveCharacter(ref x, ref y);
                    Thread.Sleep(50);
                }


                Console.Clear();

                var gameOverUI = new GameOverUI(GameOverVelue, Character, perfect, win, tie, Out, monsterLastVelue); // 게임오버UI
                gameOverUI.Print();

                bool play2 = true;
                while (play2)
                {
                    Console.Write("                                       게임을 다시 하시겠습니까?(y / n): ");
                    
                    switch (Console.ReadLine().Trim().ToLower())
                    {
                        case "y":
                            play2 = false;
                            break;
                        case "n":
                            play = false;
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("                                        ㄴ잘못 입력 하셨습니다.");
                            break;
                    }
                }
            }
            Console.Clear();
        }
    }
}

using System;
using System.Threading;
using test;


class Program
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
            int NexusHP = 0;
            string NexusHPchange = "";
            string GameOverVelue = "";

            int monsterLastVelue = 0;
            bool keyDown = false;
            ConsoleKeyInfo keyInfo;

            int Y_Info = 10;
            int X_Info = 30;

            //int AwakeningSleep = 200;
            //int WiningSleep = 200;
            //int TieSleep = 100;

            int Nexus = 10;

            monsterRegen[] monsters = monsterRegen.monsterRegenVelue(Character, random, windowWidth, windowHeight);

            Console.Clear();
            while (true)
            {
                //if(LifeVelue < 1) // 라이프 모드(구상중)
                //{
                //    break;
                //}

                Console.SetCursorPosition(X_Info, Y_Info + 9);
                Console.WriteLine($"넥서스 내구도: {Nexus}                   ");
                Console.SetCursorPosition(X_Info, Y_Info + 10);
                Console.WriteLine($"넥서스 내구도 {NexusHP} {NexusHPchange}");
                Console.WriteLine("                                    /\\");
                Console.WriteLine("                                   /  \\");
                Console.WriteLine("                                  /    \\");
                Console.WriteLine("                                 /______\\");
                Console.WriteLine("                                 |내구도|");
                Console.WriteLine("                                 |M A X |");
                Console.WriteLine("                                 |( 50 )|");
                Console.WriteLine("                                 |______|");

                if (Character >= 10)
                {
                    start = monsterRegen.GetStartValue(Character, start);
                }

                gameGround gameGround = new gameGround();

                Console.SetCursorPosition(x, y);
                Console.Write(Character);

                bool CharacterDead = false;
                for (int i = 0; i < 5; i++)
                {
                    if (monsters[i].MonsterRegenX < 30)
                    {
                        monsters[i] = new monsterRegen();
                        monsters[i].MonsterPower = Character + random.Next(-3, 7);
                        monsters[i].MonsterRegenX = windowWidth - start;
                        monsters[i].MonsterRegenY = random.Next(12, windowHeight - 13);
                        Out++;
                        Nexus--;

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
                                Console.SetCursorPosition(X_Info, Y_Info - 2);
                                Console.Write($"각성하여 캐릭터 {RandomVelue} Level 증가               ");
                                Thread.Sleep(10);
                                perfect++;
                                if (Nexus <= 50)
                                {
                                    Nexus = Nexus + 3;
                                    NexusHP = 3;
                                    NexusHPchange = "수리";
                                    if (Nexus > 50)
                                    {
                                        Nexus = 50;
                                        NexusHP = 0;
                                        NexusHPchange = "최대치";
                                    }
                                }
                            }
                            int RandomVelue2 = random.Next(1, 3);
                            Character = Character + RandomVelue2;
                            Console.SetCursorPosition(X_Info, Y_Info - 1);
                            Console.Write($"승리하여 캐릭터 {RandomVelue2} Level 증가               ");
                            Thread.Sleep(10);
                            win++;
                            if (Nexus <= 50)
                            {
                                Nexus = Nexus + 2;
                                NexusHP = 1;
                                NexusHPchange = "수리";
                                if (Nexus > 50)
                                {
                                    Nexus = 50;
                                    NexusHP = 0;
                                    NexusHPchange = "최대치";
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
                            if (Nexus <= 50)
                            {
                                Nexus = Nexus + 1;
                                if (Nexus > 50)
                                {
                                    Nexus = 50;
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(500);
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine($"캐릭터가 사망하였습니다 캐릭터[{Character} Level] 몬스터[{monsters[i].MonsterPower} Level]");
                            Thread.Sleep(1000);
                            monsterLastVelue = monsters[i].MonsterPower;
                            CharacterDead = true;
                            GameOverVelue = "캐릭터가 사망하였습니다.";
                            break;
                        }
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
                    //else if(i == 4)
                    //{
                    //    monsters[i].MonsterRegenX -= 2;
                    //}

                }
                if (CharacterDead)
                {
                    break;
                }

                if(Nexus <= 0)
                {
                    Console.SetCursorPosition(X_Info, Y_Info + 9);
                    Console.WriteLine($"넥서스 내구도: {Nexus}                   ");
                    GameOverVelue = "넥서스가 파괴 되었습니다.";
                    Thread.Sleep(500);
                    Console.WriteLine($"넥서스가 파괴 되었습니다 캐릭터[{Character} Level");
                    Thread.Sleep(1000);
                    break;
                }

                Movement.MoveCharacter(ref x, ref y);
                Thread.Sleep(50);

            }


            Console.Clear();

            int gameoverY = (windowHeight - 17) / 2;
            int gameoverX = (windowWidth - 45) / 2;
            Console.SetCursorPosition(gameoverX, gameoverY);
            Console.WriteLine("            <게임오버>");
            Console.WriteLine("");
            Console.WriteLine($"                                          {GameOverVelue}");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              캐 릭 터: {Character} Level");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              각    성: {perfect} 회");
            Console.WriteLine($"                                              승    리: {win} 승");
            Console.WriteLine($"                                              무 승 부: {tie} 무");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              미 충 돌: {Out} 마리");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              몬 스 터: {monsterLastVelue} Level");
            Console.WriteLine("                                            ---------------------");

            bool play2 = true;
            while (play2)
            {
                string yn = "";
                Console.Write("                                       게임을 다시 하시겠습니까?(y / n): ");
                yn = Console.ReadLine();
                if (yn == "y" || yn == "Y")
                {
                    play2 = false;
                }

                else if (yn == "n" || yn == "N")
                {
                    play = false;
                    break;
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                          잘못입력 하셨습니다.");
                }
            }
        }
        Console.Clear();
    }
}



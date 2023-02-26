using System;
using System.Threading;
using test;

class Program
{
    private static object user;
    private static int x;
    private static int y;

    static void Main(string[] args)
    {
        bool play = true;
        while (play)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                         <게임설명>");
            Console.WriteLine("");
            Console.WriteLine("         1. 상하 방향키를 이용하여 자신의 숫자를 이동시킬 수 있습니다.");
            Console.WriteLine("         2. 유저는 경기장을 벗어나면 죽습니다(수정) -> 경기장을 벗어날 수 없습니다.");
            Console.WriteLine("         3. 자신보다 낮은 숫자와 충돌하면 1~3 레벨 업 됩니다.");
            Console.WriteLine("         4. 자신보다 1 낮은 숫자와 충돌하면 각성하여 추가로 3~9 레벨 업 됩니다.");
            Console.WriteLine("         5. 자신과 동일한 숫자와 충돌하면 -1~-3 레벨 다운 됩니다.");
            Console.WriteLine("         6. 자신보다 높은 숫자와 충돌하면 죽습니다.");
            Console.WriteLine("         7. 유저 레벨이 올라갈 수록 가까운 곳에서 몬스터가 리젠됩니다.");
            Console.WriteLine("         8. 7번으로 인해 몬스터 숫자가 겹쳐서 보일 수 있습니다 알아 볼 수 없는 몬스터는 피하십시오.");
            Console.WriteLine("");
            Console.WriteLine("                    (엔터치면 시작합니다.)");
            Console.ReadLine();


            //Console.TreatControlCAsInput = true;        // Ctrl+C를 일반 키 입력으로 처리
            //int user = 0;                               // 유저
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            //int x = 30;
            //int y = (windowHeight - 1) / 2;
            //int dieX = (windowWidth - 20) / 2;
            //int dieY = (windowHeight - 1) / 2;
            int perfect = 0;
            int win = 0;
            int tie = 0;
            int Out = 0;
            //int start = 45;
            //int GSy = 13;

            monster monster = new monster();

            monster.MonsterRegenStart(60);
            monster.MonsterPower(0);
            monster.MonsterRegenStart(50);
            monster.MonsterPower(0);
            monster.MonsterRegenStart(40);
            monster.MonsterPower(0);
            monster.MonsterRegenStart(30);
            monster.MonsterPower(0);
            monster.MonsterRegenStart(20);
            monster.MonsterPower(0);

            //Random random = new Random();
            //int Y_01 = random.Next(12, windowHeight - GSy); // 몬스터_01 리젠
            //int X_01 = windowWidth - 60;
            //int monster_01 = user + random.Next(-3, 7);

            //int Y_02 = random.Next(12, windowHeight - GSy); // 몬스터_02 리젠
            //int X_02 = windowWidth - 50;
            //int monster_02 = user + random.Next(-3, 7);

            //int Y_03 = random.Next(12, windowHeight - GSy); // 몬스터_03 리젠
            //int X_03 = windowWidth - 40;
            //int monster_03 = user + random.Next(-3, 7);

            //int Y_04 = random.Next(12, windowHeight - GSy); // 몬스터_04 리젠
            //int X_04 = windowWidth - 30;
            //int monster_04 = user + random.Next(-3, 7);

            //int Y_05 = random.Next(12, windowHeight - GSy); // 몬스터_05 리젠
            //int X_05 = windowWidth - 20;
            //int monster_05 = user + random.Next(-3, 7);

            int monsterX = 0;
            bool keyDown = false;
            ConsoleKeyInfo keyInfo;

            int Y_Info = 10;
            int X_Info = 30;

            int AwakeningSleep = 200;
            int WiningSleep = 100;
            int TieSleep = 100;

            int LifeVelue = 10;

            Console.Clear();
            while (true)
            {
                //if(LifeVelue < 1) // 라이프 모드(구상중)
                //{
                //    break;
                //}

                //Console.Clear();

                //Console.SetCursorPosition(0, 15);
                //Console.Write("                                                     ");
                //Console.Write("                                                     ");
                //Console.Write("                                                     ");
                //Console.Write("                                                     ");


                //if (user > 10) // 유저 레벨이 높아질 수록 몬스터가 가까운 곳에서 리젠됨
                //{
                //    start = 50;
                //    if (user > 20)
                //    {
                //        start = 55;
                //        if (user > 30)
                //        {
                //            start = 60;
                //            if (user > 50)
                //            {
                //                start = 65;
                //                if (user > 70)
                //                {
                //                    start = 70;
                //                    if (user > 100)
                //                    {
                //                        start = 75;
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}

                Console.SetCursorPosition(0, 0); // 게임 판
                Console.Write(@"








");
                //Console.WriteLine($"                            생명력: {LifeVelue}"); // 라이프 모드(구상중)
                Console.Write(@"

                            =======================================================================
                            |                                                                     |
                            |                                                                     |
                            |                                                                     |
                            |                                                                     |
                            |                                                                     |
                            =======================================================================");
                //Console.SetCursorPosition(x, y);
                //Console.Write(user);

                // 경기장 밖으로 이동할 수 없도록 막아서 게임 오버가 되는 구문 주석처리
                //if (y < 12 || y > 16)   // 라인을 넘으면 게임오버
                //{
                //    Console.Clear();
                //    Console.SetCursorPosition(x, y);
                //    Console.WriteLine("라인아웃!");
                //    Thread.Sleep(1000);
                //    break;
                //}

                //if (X_01 < 30)
                //{
                //    Y_01 = random.Next(12, windowHeight - GSy);
                //    X_01 = windowWidth - start;
                //    monster_01 = user + random.Next(-3, 7);
                //    Out++;
                //    LifeVelue--;
                //}

                monster.crash(user, x, y);

                //if (x == X_01 && y == Y_01)
                //{
                //    if (user > monster_01)
                //    {
                //        if (user == monster_01 + 1)
                //        {
                //            int RandomVelue = random.Next(3, 9);
                //            user = user + RandomVelue;
                //            Console.SetCursorPosition(X_Info, Y_Info);
                //            Console.Write($"각성하여 유저 {RandomVelue} Level 증가               ");
                //            Thread.Sleep(AwakeningSleep);
                //            perfect++;
                //        }
                //        int RandomVelue2 = random.Next(1, 3);
                //        user = user + RandomVelue2;                       
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"승리하여 유저 {RandomVelue2} Level 증가               ");

                //        Thread.Sleep(WiningSleep);
                //        win++;
                //    }
                //    else if (user == monster_01)
                //    {
                //        int RandomVelue3 = random.Next(1, 3);
                //        user = user - RandomVelue3;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"무승부로 유저 -{RandomVelue3} Level 감소               ");
                //        Thread.Sleep(TieSleep);
                //        tie++;
                //    }
                //    else
                //    {
                //        Console.Clear();
                //        Console.SetCursorPosition(x, y);
                //        Console.WriteLine($"당신은 죽었습니다. 유저[{user} Level] 몬스터[{monster_01} Level]");
                //        Thread.Sleep(1000);
                //        monsterX = monster_01;
                //        break;
                //    }
                //}
                //X_01--;
                //Console.SetCursorPosition(X_01, Y_01);
                //Console.Write(monster_01);

                //if (X_02 < 30)
                //{
                //    Y_02 = random.Next(12, windowHeight - GSy);
                //    X_02 = windowWidth - start;
                //    monster_02 = user + random.Next(-3, 7);
                //    Out++;
                //    LifeVelue--;
                //}

                //if (x == X_02 && y == Y_02)
                //{
                //    if (user > monster_02)
                //    {
                //        if (user == monster_02 + 1)
                //        {
                //            int RandomVelue = random.Next(3, 9);
                //            user = user + RandomVelue;
                //            Console.SetCursorPosition(X_Info, Y_Info);
                //            Console.Write($"각성하여 유저 {RandomVelue} Level 증가               ");
                //            Thread.Sleep(AwakeningSleep);
                //            perfect++;
                //        }
                //        int RandomVelue2 = random.Next(1, 3);
                //        user = user + RandomVelue2;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"승리하여 유저 {RandomVelue2} Level 증가               ");
                //        Thread.Sleep(WiningSleep);
                //        win++;
                //    }
                //    else if (user == monster_02)
                //    {
                //        int RandomVelue3 = random.Next(1, 3);
                //        user = user - RandomVelue3;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"무승부로 유저 -{RandomVelue3} Level 감소               ");
                //        Thread.Sleep(TieSleep);
                //        tie++;
                //    }
                //    else
                //    {
                //        Console.Clear();
                //        Console.SetCursorPosition(x, y);
                //        Console.WriteLine($"당신은 죽었습니다. 유저[{user} Level] 몬스터[{monster_02} Level]");
                //        Thread.Sleep(1000);
                //        monsterX = monster_02;
                //        break;
                //    }
                //}
                //X_02--;
                //Console.SetCursorPosition(X_02, Y_02);
                //Console.Write(monster_02);

                //if (X_03 < 30)
                //{
                //    Y_03 = random.Next(12, windowHeight - GSy);
                //    X_03 = windowWidth - start;
                //    monster_03 = user + random.Next(-3, 7);
                //    Out++;
                //    LifeVelue--;
                //}

                //if (x == X_03 && y == Y_03)
                //{
                //    if (user > monster_03)
                //    {
                //        if (user == monster_03 + 1)
                //        {
                //            int RandomVelue = random.Next(3, 9);
                //            user = user + RandomVelue;
                //            Console.SetCursorPosition(X_Info, Y_Info);
                //            Console.Write($"각성하여 유저 {RandomVelue} Level 증가               ");
                //            Thread.Sleep(AwakeningSleep);
                //            perfect++;
                //        }
                //        int RandomVelue2 = random.Next(1, 3);
                //        user = user + RandomVelue2;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"승리하여 유저 {RandomVelue2} Level 증가               ");
                //        Thread.Sleep(WiningSleep);
                //        win++;
                //    }
                //    else if (user == monster_03)
                //    {
                //        int RandomVelue3 = random.Next(1, 3);
                //        user = user - RandomVelue3;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"무승부로 유저 -{RandomVelue3} Level 감소               ");
                //        Thread.Sleep(TieSleep);
                //        tie++;
                //    }
                //    else
                //    {
                //        Console.Clear();
                //        Console.SetCursorPosition(x, y);
                //        Console.WriteLine($"당신은 죽었습니다. 유저[{user} Level] 몬스터[{monster_03} Level]");
                //        Thread.Sleep(1000);
                //        monsterX = monster_03;
                //        break;
                //    }
                //}
                //X_03--;
                //Console.SetCursorPosition(X_03, Y_03);
                //Console.Write(monster_03);

                //if (X_04 < 30)
                //{
                //    Y_04 = random.Next(12, windowHeight - GSy);
                //    X_04 = windowWidth - start;
                //    monster_04 = user + random.Next(-3, 7);
                //    Out++;
                //    LifeVelue--;
                //}

                //if (x == X_04 && y == Y_04)
                //{
                //    if (user > monster_04)
                //    {
                //        if (user == monster_04 + 1)
                //        {
                //            int RandomVelue = random.Next(3, 9);
                //            user = user + RandomVelue;
                //            Console.SetCursorPosition(X_Info, Y_Info);
                //            Console.Write($"각성하여 유저 {RandomVelue} Level 증가               ");
                //            Thread.Sleep(AwakeningSleep);
                //            perfect++;
                //        }
                //        int RandomVelue2 = random.Next(1, 3);
                //        user = user + RandomVelue2;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"승리하여 유저 {RandomVelue2} Level 증가               ");
                //        Thread.Sleep(WiningSleep);
                //        win++;
                //    }
                //    else if (user == monster_04)
                //    {
                //        int RandomVelue3 = random.Next(1, 3);
                //        user = user - RandomVelue3;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"무승부로 유저 -{RandomVelue3} Level 감소               ");
                //        Thread.Sleep(TieSleep);
                //        tie++;
                //    }
                //    else
                //    {
                //        Console.Clear();
                //        Console.SetCursorPosition(x, y);
                //        Console.WriteLine($"당신은 죽었습니다. 유저[{user} Level] 몬스터[{monster_04} Level]");
                //        Thread.Sleep(1000);
                //        monsterX = monster_04;
                //        break;
                //    }
                //}
                //X_04--;
                //Console.SetCursorPosition(X_04, Y_04);
                //Console.Write(monster_04);

                //if (X_05 < 30)
                //{
                //    Y_05 = random.Next(12, windowHeight - GSy);
                //    X_05 = windowWidth - start;
                //    monster_05 = user + random.Next(-3, 7);
                //    Out++;
                //    LifeVelue--;
                //}

                //if (x == X_05 && y == Y_05)
                //{
                //    if (user > monster_05)
                //    {
                //        if (user == monster_05 + 1)
                //        {
                //            int RandomVelue = random.Next(3, 9);
                //            user = user + RandomVelue;
                //            Console.SetCursorPosition(X_Info, Y_Info);
                //            Console.Write($"각성하여 유저 {RandomVelue} Level 증가               "); ;
                //            Thread.Sleep(AwakeningSleep);
                //            perfect++;
                //        }
                //        int RandomVelue2 = random.Next(1, 3);
                //        user = user + RandomVelue2;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"승리하여 유저 {RandomVelue2} Level 증가               ");
                //        Thread.Sleep(WiningSleep);
                //        win++;
                //    }
                //    else if (user == monster_05)
                //    {
                //        int RandomVelue3 = random.Next(1, 3);
                //        user = user - RandomVelue3;
                //        Console.SetCursorPosition(X_Info, Y_Info);
                //        Console.Write($"무승부로 유저 -{RandomVelue3} Level 감소               ");
                //        Thread.Sleep(TieSleep);
                //        tie++;
                //    }
                //    else
                //    {
                //        Console.Clear();
                //        Console.SetCursorPosition(x, y);
                //        Console.WriteLine($"당신은 죽었습니다. 유저[{user} Level] < 몬스터[{monster_05} Level]");
                //        Thread.Sleep(1000);
                //        monsterX = monster_05;
                //        break;
                //    }
                //}

                //X_05--;
                //Console.SetCursorPosition(X_05, Y_05);
                //Console.Write(monster_05);

                Thread.Sleep(50);

                monster.userMove();
                //if (Console.KeyAvailable)
                //{
                //    keyInfo = Console.ReadKey(true);

                //    if (keyInfo.Key == ConsoleKey.UpArrow)
                //    {
                //        if (!keyDown)
                //        {
                //            if (y > 12)
                //            {
                //                y--;
                //                keyDown = true;
                //            }
                //        }
                //    }
                //    else if (keyInfo.Key == ConsoleKey.DownArrow)
                //    {
                //        if (!keyDown)
                //        {
                //            if (y < 16)
                //            {
                //                y++;
                //                keyDown = true;
                //            }
                //        }
                //    }
                //    else
                //    {
                //        keyDown = false;
                //    }
                //}
                //else
                //{
                //    keyDown = false;
                //}
            }


            Console.Clear();

            int gameoverY = (windowHeight - 17) / 2;
            int gameoverX = (windowWidth - 45) / 2;
            Console.SetCursorPosition(gameoverX, gameoverY);
            Console.WriteLine("            <게임오버>");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              유    저: {user} Level");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              각    성: {perfect} 회");
            Console.WriteLine($"                                              승    리: {win} 승");
            Console.WriteLine($"                                              무 승 부: {tie} 무");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              미 충 돌: {Out} 마리");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              몬 스 터: {monsterX} Level");
            Console.WriteLine("                                            ---------------------");

            bool play2 = true;
            while (play2)
            {
                string yn = "";
                Console.Write("                                      게임을 다시 하시겠습니까?(y / n): ");
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



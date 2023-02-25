using System;
using System.Threading;

class Program
{
    const int MaxX = 80;
    const int MaxY = 25;
    const int GameOverX = (MaxX - 45) / 2;
    const int GameOverY = (MaxY - 10) / 2;
    const int MonsterCount = 5;
    const int MinMonsterValue = -3;
    const int MaxMonsterValue = 3;
    const int GrowthOnWin = 1;
    const int MaxGrowthOnWin = 3;
    const int GrowthOnPerfect = 1;
    const int MaxGrowthOnPerfect = 3;
    const int GrowthOnTie = -1;

    static Random random = new Random();

    static void Main(string[] args)
    {
        // 이전 출력을 덮어쓰는 예시 코드
        Console.Write("이전 출력입니다.");

        // 출력을 지우지 않고 새로운 출력으로 덮어쓰기 위해 이전 출력의 길이와 같은 길이의 공백을 출력합니다.
        Console.Write(new string(' ', Console.WindowWidth - "이전 출력입니다.".Length));
        Console.Clear();
        // 이어서 새로운 출력을 출력합니다.
        Console.Write("새로운 출력입니다.");

    }
}


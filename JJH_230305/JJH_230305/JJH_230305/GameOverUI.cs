using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230305
{
    class GameOverUI
    {
            public GameOverUI(string GameOverValue, int Character, int Perfect, int Win, int Tie, int Out, int MonsterLastValue, int MaxCombo)
            {
            Console.SetCursorPosition(37, 6);
            Console.WriteLine("            <게임오버>");
            Console.WriteLine();
            Console.WriteLine($"                                          {GameOverValue}");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              캐 릭 터: {Character} Level");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              각    성: {Perfect} 회");
            Console.WriteLine($"                                              승    리: {Win} 승");
            Console.WriteLine($"                                              무 승 부: {Tie} 무");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              미 충 돌: {Out} 마리");
            Console.WriteLine($"                                              최대콤보: {MaxCombo} 회");
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              몬 스 터: {MonsterLastValue} Level");
            Console.WriteLine("                                            ---------------------");
        }

        
    }

}

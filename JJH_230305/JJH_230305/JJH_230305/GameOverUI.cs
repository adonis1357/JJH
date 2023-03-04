using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230305
{
    class GameOverUI
    {
        private int cursorLeft = 37;  // 콘솔 창에서 출력 위치의 왼쪽 좌표
        private int cursorTop = 6;    // 콘솔 창에서 출력 위치의 위쪽 좌표

        // 게임 오버 화면에 출력할 정보를 저장하는 프로퍼티들
        private string GameOverValue { get; set; }   // 게임 오버 메시지
        private int Character { get; set; }       // 캐릭터 이름과 레벨
        private int Perfect { get; set; }            // 각성 회수
        private int Win { get; set; }                // 승리 횟수
        private int Tie { get; set; }                // 무승부 횟수
        private int Out { get; set; }                // 미충돌 몬스터 수
        private int MonsterLastValue { get; set; }   // 마지막 몬스터 레벨

        // 생성자로 각 정보를 전달받아 저장
        public GameOverUI(string gameOverValue, int character, int perfect, int win, int tie, int @out, int monsterLastValue)
        {
            GameOverValue = gameOverValue;
            Character = character;
            Perfect = perfect;
            Win = win;
            Tie = tie;
            Out = @out;
            MonsterLastValue = monsterLastValue;
        }

        // 게임 오버 화면을 출력하는 메소드
        public void Print()
        {
            Console.SetCursorPosition(cursorLeft, cursorTop);
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
            Console.WriteLine("                                            ---------------------");
            Console.WriteLine($"                                              몬 스 터: {MonsterLastValue} Level");
            Console.WriteLine("                                            ---------------------");
        }
    }

}

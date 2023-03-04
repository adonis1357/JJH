using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class gameinfo
    {
        public gameinfo()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                         <게임설명>");
            Console.WriteLine("");
            Console.WriteLine("         1. 상하 방향키를 이용하여 자신의 숫자를 이동시킬 수 있습니다.");
            Console.WriteLine("         2. 캐릭터는 경기장을 벗어날 수 없습니다.");
            Console.WriteLine("         3. 자신보다 낮은 숫자와 충돌하면 1~3 레벨 업 되고, 넥서스 내구도+1이 수리 됩니다.");
            Console.WriteLine("         4. 자신보다 1 낮은 숫자와 충돌하면 각성하여 추가로 3~9 레벨 업 되고, 넥서스 내구도+3이 수리 됩니다.");
            Console.WriteLine("         5. 자신과 동일한 숫자와 충돌하면 -1 레벨 다운 됩니다.");
            Console.WriteLine("         6. 자신보다 높은 숫자와 충돌하면 게임오버 됩니다.");
            Console.WriteLine("         7. 캐릭터 레벨이 올라갈 수록 가까운 곳에서 몬스터가 리젠됩니다.");
            Console.WriteLine("         8. 충돌하지 않은 몬스터는 넥서스 내구도를 -1 시키고, 넥서스 내구도가 0이되면 게임오버 됩니다.");
            Console.WriteLine("");
            Console.WriteLine("                    (엔터치면 시작합니다.)");
            Console.ReadLine();
        }
    }
}

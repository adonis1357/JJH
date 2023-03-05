using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230305
{
    class monsterRegen
    {
        public int MonsterPower;
        public int MonsterRegenX;
        public int MonsterRegenY;
        public static monsterRegen[] monsterRegenVelue(int Character, Random random, int windowWidth, int windowHeight)
        {
            int RegenStar = -70;
            monsterRegen[] monsterRegen = new monsterRegen[5];

            for (int i = 0; i < 5; i++)
            {
                RegenStar += 10;
                monsterRegen[i] = new monsterRegen();
                monsterRegen[i].MonsterPower = Character + random.Next(-3, 7);
                monsterRegen[i].MonsterRegenX = windowWidth + RegenStar;
                monsterRegen[i].MonsterRegenY = random.Next(12, windowHeight - 13);
            }
            return monsterRegen;
        }
        public static int GetStartValue(int Character, int start) // 캐릭터 성장에 따라 몬스터가 가까운 곳에서 리젠
        {
            if (Character >= 10)
            {
                start = 46;
                if (Character >= 20)
                {
                    start = 51;
                    if (Character >= 30)
                    {
                        start = 57;
                        if (Character >= 50)
                        {
                            start = 62;
                            if (Character >= 70)
                            {
                                start = 68;
                                if (Character >= 100)
                                {
                                    start = 74;
                                }
                            }
                        }
                    }
                }
            }
            return start;
        }
    }
}

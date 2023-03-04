using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class monsterRegen
    {
        public int MonsterPower;
        public int MonsterRegenX;
        public int MonsterRegenY;
        public monsterRegen()
        {
            MonsterPower = 0;
            MonsterRegenX = 0;
            MonsterRegenY = 0;
        }
        public static monsterRegen[] monsterRegenVelue(int user, Random random, int windowWidth, int windowHeight)
        {
            int RegenStar = -70;
            monsterRegen[] monsterRegen = new monsterRegen[5];

            for (int i = 0; i < 5; i++)
            {
                RegenStar += 10;
                monsterRegen[i] = new monsterRegen();
                monsterRegen[i].MonsterPower = user + random.Next(-3, 7);
                monsterRegen[i].MonsterRegenX = windowWidth + RegenStar;
                monsterRegen[i].MonsterRegenY = random.Next(12, windowHeight - 13);
            }
            return monsterRegen;
        }
        public static int GetStartValue(int user, int start)
        {
            if (user >= 10)
            {
                start = 46;
                if (user >= 20)
                {
                    start = 51;
                    if (user >= 30)
                    {
                        start = 57;
                        if (user >= 50)
                        {
                            start = 62;
                            if (user >= 70)
                            {
                                start = 68;
                                if (user >= 100)
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




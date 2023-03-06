using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JJH_230305
{
    class NexusCollapsingMotion
    {
        public NexusCollapsingMotion(int NexusHP)
        {
            gameGroundUI gameGroundUI2 = new gameGroundUI(NexusHP);
            gameGroundUI2.DrawgameGroundUI();
            Thread.Sleep(100);
            gameGroundUI2.DrawgameGroundUI3();
            Thread.Sleep(250);
            gameGroundUI2.DrawgameGroundUI4();
            Thread.Sleep(250);
            gameGroundUI2.DrawgameGroundUI5();
            Thread.Sleep(500);
        }
    }
}

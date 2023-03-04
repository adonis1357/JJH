using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230305
{
    class Movement
    {
        public static void MoveCharacter(ref int x, ref int y)
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (y > 12)
                    {
                        y--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (y < 16)
                    {
                        y++;
                    }
                }
            }
        }
    }
}

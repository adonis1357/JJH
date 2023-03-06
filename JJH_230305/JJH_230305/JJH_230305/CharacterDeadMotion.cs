using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JJH_230305
{
    class CharacterDeadMotion
    {
        public CharacterDeadMotion(int Character, int x, int y)
        {            
            Console.SetCursorPosition(x - 1, y);
            Console.Write("☆                       ");
            Thread.Sleep(100);
            Console.SetCursorPosition(x - 2, y);
            Console.Write($"{Character}~~                 ");
            Thread.Sleep(50);
            Console.SetCursorPosition(x - 4, y);
            Console.Write($"{Character}~~~                   ");
            Thread.Sleep(40);
            Console.SetCursorPosition(x - 6, y);
            Console.Write($"{Character}~~~~                    ");
            Thread.Sleep(30);
            Console.SetCursorPosition(x - 9, y);
            Console.Write($"{Character}~~~~~                       ");
            Thread.Sleep(100);
            Console.SetCursorPosition(x - 10, y);
            Console.Write("☆~                       ");
            Thread.Sleep(100);
        }  
    }
}

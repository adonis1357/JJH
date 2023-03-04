using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230305
{
    class NexusUI
    {
        private int nexusHP;
        private string nexusHPchange;

        public NexusUI(int nexusHP, string nexusHPchange)
        {
            this.nexusHP = nexusHP;
            this.nexusHPchange = nexusHPchange;
        }

        public void Draw()
        {
            Console.SetCursorPosition(30, 19);
            Console.WriteLine($"넥서스 내구도: {nexusHP} {nexusHPchange}                ");
            Console.WriteLine("");
            Console.WriteLine("                                    /\\");
            Console.WriteLine("                                   /  \\");
            Console.WriteLine("                                  /    \\");
            Console.WriteLine("                                 /______\\");
            Console.WriteLine("                                 |내구도|");
            Console.WriteLine($"                                 |M A X |");
            Console.WriteLine($"                                 |( 50 )|");
            Console.WriteLine($"                                 |______|");

        }
    }
}

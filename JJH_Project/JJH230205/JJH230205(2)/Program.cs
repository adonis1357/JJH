using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH230205_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int row = 0; row < i; row++)
                {
                    System.Console.Write("★");
                }
                System.Console.WriteLine("");
            }

            System.Console.WriteLine("");

            for (int ii = 5; ii > 0; ii--)
            {
                for (int row2 = 0; row2 < ii; row2++)
                {
                    System.Console.Write("★");
                }
                System.Console.WriteLine("");
            }

            System.Console.WriteLine("");

            for (int iii= 5; iii > 0; iii--)
            {
                for (int row3 = 0; row3 < iii; row3++)
                {
                    System.Console.Write("★");
                }

                System.Console.WriteLine("");
                for (int iii2 = 6; iii2 > iii; iii2--)
                {
                    System.Console.Write("  ");
                }
            }

            System.Console.WriteLine("");


            for (int iiii = 0; iiii < 6; iiii++)
            {
                for (int row4 = 0; row4 < iiii; row4++)
                {
                    System.Console.Write("★");
                }

                System.Console.WriteLine("");
                for (int iiii2 = 4; iiii2 > iiii; iiii2--)
                {
                    System.Console.Write("  ");
                }

            }

            System.Console.WriteLine("");

            for (int iiiii = 0; iiiii < 6; iiiii++)
            {
                for (int row5 = 0; row5 < iiiii; row5++)
                {
                    System.Console.Write("★");
                    System.Console.Write("  ");
                }

                System.Console.WriteLine("");
                for (int iiiii2 = 4; iiiii2 > iiiii; iiiii2--)
                {
                    System.Console.Write("  ");
                }

            }

            System.Console.WriteLine("");

            for (int iiiiii = 5; iiiiii > 0; iiiiii--)
            {
                for (int row6 = 0; row6 < iiiiii; row6++)
                {
                    System.Console.Write("★");
                    System.Console.Write("  ");
                }

                System.Console.WriteLine("");
                for (int iiiiii2 = 6; iiiiii2 > iiiiii; iiiiii2--)
                {
                    System.Console.Write("  ");
                }

            }

            System.Console.WriteLine("");

        }
    }
}

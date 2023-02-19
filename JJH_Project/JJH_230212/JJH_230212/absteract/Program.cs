using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Player play = new Player();

            Zombie zom = new Zombie();
            Ghoul gho = new Ghoul();


            System.Console.WriteLine("");
            zom.AttackPlayer(play);
            System.Console.WriteLine("");
            gho.AttackPlayer(play);
        }
    }

    class Player
    {
        int hp = 100;
        public void HitfromMonster(int AttackValue)
        {
            hp = hp - AttackValue;
            System.Console.WriteLine($"Player : I'm Hit! my Hp is {hp}");
        }
    }
    abstract class DarKMonster
    {
        int attckValue = 10;

        public abstract void AttackPlayer(Player player);

    }

    class Zombie : DarKMonster
    {
        public override void AttackPlayer(Player player)
        {
            System.Console.WriteLine("Monster : Player Bleeding");
        }
    }

    class Ghoul : DarKMonster
    {
        public override void AttackPlayer(Player player)
        {
            System.Console.WriteLine("Monster(Ghoul) : Player Curse!");
        }
    }
}

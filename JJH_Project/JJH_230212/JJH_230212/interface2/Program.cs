using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            DarkMonster dark = new DarkMonster();
            LightMonster Light = new LightMonster();

            player.AttackMonster(dark);
            player.AttackMonster(Light);
        }
    }

    interface monster
    {
        void HitFromPlayer(int damage);
    }

    class DarkMonster : monster
    {
        int hp = 100;

        public void HitFromPlayer(int damage)
        {
            hp = hp - damage;
            System.Console.WriteLine($"Monster : I'm Hit! my Hp is {hp}");
        }
    }

    class LightMonster : monster
    {
        int hp = 100;
        public void HitFromPlayer(int damage)
        {
            hp = hp - (damage / 2);
            System.Console.WriteLine($"LightMonster : I'm Hit! but half, my hp is {hp}");
        }
    }

    class Player
    {
        int AttackDamage = 15;

        public void AttackMonster(monster monster)
        {
            System.Console.WriteLine("Player : I'm Attacking Monster!");
            monster.HitFromPlayer(AttackDamage);
        }

    }
}

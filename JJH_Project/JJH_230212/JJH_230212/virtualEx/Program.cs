using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace virtualEx
{



    class Program
    {
        static void Main(string[] args)
        {
            //1. 생명체 인터페이스 생성evasion
            //2. 생명체에는 공격하기, 공격 받기, 회피하기, 피해받기 가 있음.
            //3. 생명체는 플레이어와 몬스터 2개를 상속받는다.
            //4. 플레이어와 몬스터가 둘중 하나가 죽을때 까지 계속 공격하고 공격 받고를 주고받는다.
            //5. 공격하면 공격한다고 출력하고, 공격 받으면 공격 받는다고 출력
            //6. 공격 받는 대상은 확률(랜덤)로 회피 또는 피해받기를 실행한다.
            //7. 플레이어와 몬스터 둘다 이렇게 진행된다.
            Player player = new Player();
            Monster monster = new Monster();

            while (player.hp != 0 && monster.hp != 0)
            {

                System.Console.WriteLine();
                monster.Attack(player);
                Thread.Sleep(500);
                if (player.hp == 0)
                {
                    System.Console.WriteLine("플레이어가 죽었습니다.");
                    break;
                }
                player.Attack(monster);
                Thread.Sleep(500);
                if (monster.hp == 0)
                {
                    System.Console.WriteLine("몬스터가 죽었습니다.");
                    break;
                }
            }
        }
    }

    class Entity
    {
        public virtual void Attack(Entity entity) // 공격하기
        {

        }
        public virtual void TakeDamge() // 공격받기
        {

        }
        public virtual void Avoid() // 회피하기
        {

        }
        public virtual void ReduceHP() //
        {

        }
    }

    class Player : Entity
    {
        public int hp = 3;
        public override void Attack(Entity entity)
        {
            entity.TakeDamge();
        }
        public override void Avoid()
        {
            System.Console.WriteLine("플레이어가 회피함!");
        }
        public override void ReduceHP()
        {
            hp--;
            System.Console.WriteLine($"플레이어가 데미지를 입음! 플레이어 체력 : {hp}");
        }
        public override void TakeDamge()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0) // 0인 경우 공격 실패
            {
                Avoid();
            }
            else            // 1인 경우 공격성공
            {
                ReduceHP();
            }
        }
    }

    class Monster : Entity
    {
        public int hp = 3;
        public override void Attack(Entity entity)
        {
            entity.TakeDamge();
            System.Console.WriteLine("");
        }
        public override void Avoid()
        {
            System.Console.WriteLine("몬스터가 회피함!");
        }
        public override void ReduceHP()
        {
            hp--;
            System.Console.WriteLine($"몬스터가 데미지를 입음! 몬스터 체력 : {hp}");
        }
        public override void TakeDamge()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0) // 0인 경우 공격 실패
            {
                Avoid();
            }
            else            // 1인 경우 공격성공
            {
                ReduceHP();
            }
        }
    }
}

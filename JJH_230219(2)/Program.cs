using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum thePlayerState
{
    idle,
    walk,
    run
}


namespace JJH_230219_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 랜덤 예시
            //Random rand = new Random();
            //int randomInt = rand.Next(0, 10);
            //Console.WriteLine("0~10사이 랜덤 : " + randomInt);


            ////enum 사용 법 상단에 정의
            //thePlayerState myState = thePlayerState.idle;
            //switch(myState)
            //{
            //    case thePlayerState.idle:
            //        System.Console.WriteLine("나는 서있다.");
            //        break;
            //    case thePlayerState.walk:
            //        System.Console.WriteLine("나는 걷고있다.");
            //        break;
            //    case thePlayerState.run:
            //        System.Console.WriteLine("나는 뛰고있다.");
            //        break;
            //}

        }
    }
}

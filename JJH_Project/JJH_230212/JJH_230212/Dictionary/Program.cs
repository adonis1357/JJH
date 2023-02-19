using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> myDic = new Dictionary<string, string>()
            //{
            //    {"originKey", "originValue" },
            //    {"originKey2", "originValue2" }
            //};

            //myDic.Add("addKey", "addValue");
            //myDic["theKey"] = "theValue";

            //Console.WriteLine(myDic["originKey"]);
            //Console.WriteLine(myDic["originKey2"]);
            //Console.WriteLine(myDic["addKey"]);
            //Console.WriteLine(myDic["theKey"]);

            Dictionary<string, Monster> myDic = new Dictionary<string, Monster>();

            Monster zombie = new Monster();

            zombie.name = "zombie";

            myDic["zombie"] = zombie;

            zombie.introduceMonster();

            zombie.name = "좀비";

            zombie.introduceMonster();

            myDic["zombie"].introduceMonster();

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            myDictionary["name"] = "제 이름은 정진호입니다.";
            myDictionary["age"] = "제 나이는 39살 입니다.";
            myDictionary["job"] = "제 직업은 게임기획자 입니다.";

            System.Console.WriteLine("검색할 내용을 입력하세요! :");
            string searchValue = System.Console.ReadLine();

            System.Console.WriteLine(myDictionary[searchValue]);

        }
    }

    class Monster
    {
        public string name;

        public void introduceMonster()
        {
            System.Console.WriteLine($"몬스터 이름은 {name}");
        }
    }
}

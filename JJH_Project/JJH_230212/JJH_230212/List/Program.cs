using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3]; // 배열이 리스트보다 가볍다

            List<int> IntList = new List<int>() { 6, 2, 4, 6 }; // 리스트는 배열보다 사용이 편하다. 

            IntList.Add(7); //배열 추가가 자유롭다
            IntList.Add(91);

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            System.Console.WriteLine("");
            IntList.Remove(2);

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            System.Console.WriteLine("");
            IntList.Insert(3, 9);

            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            System.Console.WriteLine("");
            IntList.Clear();
            System.Console.WriteLine("초기화");
            for (int index = 0; index < IntList.Count; index++)
            {
                Console.WriteLine(IntList[index]);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("string List");

            List<string> StringList = new List<string>() { "일", "이", "삼", "사", "오" };

            System.Console.WriteLine("");
            for (int index = 0; index < StringList.Count; index++)
            {
                Console.WriteLine(StringList[index]);
            }


            System.Console.WriteLine("");
            System.Console.WriteLine("floatList");

            List<float> FloatList = new List<float>() { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };

            System.Console.WriteLine("");
            for (int index = 0; index < FloatList.Count; index++)
            {
                Console.WriteLine(FloatList[index]);
            }

            List<City> cityList = new List<City>();

            City Seoul = new City();
            Seoul.name = "서울";
            City city1 = new City();
            city1.name = "도쿄";
            City city2 = new City();
            city2.name = "나이로비";
            City city3 = new City();
            city3.name = "댐버";
            City city4 = new City();
            city4.name = "베이징";

            cityList.Add(Seoul);
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            cityList.Add(city4);

            for (int i = 0; i < cityList.Count; i++)
            {
                cityList[i].IntroduceCity();
            }
        }
    }

    class City
    {
        public string name;
        public void IntroduceCity()
        {
            System.Console.WriteLine($"This city is {name}");
        }
    }
}

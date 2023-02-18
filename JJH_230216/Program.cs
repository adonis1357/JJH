using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230216
{
    class Program
    {
        static void Main(string[] args)
        {

            //2월 15일
            //식당 클래스를 상속받는 한식 / 양식 / 중식

            //식당 클래스가 전체적으로 가질 정보들을 갖는다(돈 받기 / 주문한 음식 주기 )
            //각각 식당들은 메뉴가 모두 다르다.
            //한식은 삼계탕 1만원 등등 다르다.
            //가고싶은 식당을 입력받고, 메뉴를 모두 띄워준다.
            //유저는 메뉴를 입력하고, 내야할 가격, 고른 메뉴를 띄워준다.


            KoreanRestaurant koreanRestaurant = new KoreanRestaurant("한식당");
            WesternRestaurant westernRestaurant = new WesternRestaurant("양식당");
            ChineseRestaurant chineseRestaurant = new ChineseRestaurant("중식당");

            Console.WriteLine("어느 식당에 가시겠습니까?");
            Console.WriteLine("1. 한식당");
            Console.WriteLine("2. 양식당");
            Console.WriteLine("3. 중식당");
            int choice = int.Parse(Console.ReadLine());

            // 선택한 식당에 따라 메뉴 출력
            switch(choice)
            {
                case 1:
                    koreanRestaurant.PrintMenu();
                    break;
                case 2:
                    westernRestaurant.PrintMenu();
                    break;
                case 3:
                    chineseRestaurant.PrintMenu();
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    return;
            }

            // 메뉴 선택
            Console.WriteLine("메뉴를 선택해주세요.");
            string menuName = Console.ReadLine();
            Restaurant res = new Restaurant("메뉴");
            res.Order(menuName, choice);


        }
    }
    class Restaurant
    {
        protected string name; // 식당 이름
        protected Dictionary<string, int> menu = new Dictionary<string, int>(); // 메뉴와 가격

        // 생성자
        public Restaurant(string name)
        {
            this.name = name;
        }

        // 메뉴 추가
        public void AddMenu(string menuName, int price)
        {
            menu.Add(menuName, price);
        }

        // 메뉴 출력
        public void PrintMenu()
        {
            Console.WriteLine("메뉴");
            foreach (KeyValuePair<string, int> item in menu)
            {
                Console.WriteLine("{0} ({1}원)", item.Key, item.Value);
            }
        }

        // 주문
        public void Order(string menuName, int choise)
        {
            string choiseMenu = "미정";
            if(choise == 1)
            { 
                if (menuName == "비빔밥")
                {
                    choiseMenu = "비빔밥 7000원";
                }
                else if (menuName == "김치전골")
                {
                    choiseMenu = "김치전골 17000원";
                }
                else if (menuName == "불고기")
                {
                    choiseMenu = "불고기 28000원";
                }
                else
                {
                    choiseMenu = "잘못 입력하셨습니다.";
                }
            }
            else if(choise == 2)
            {
                if (menuName == "파스타")
                {
                    choiseMenu = "파스타 13500원";
                }
                else if (menuName == "피자")
                {
                    choiseMenu = "피자 21000원";
                }
                else if (menuName == "스테이크")
                {
                    choiseMenu = "스테이크 32500원";
                }
                else
                {
                    choiseMenu = "잘못 입력하셨습니다.";
                }
            }
            else if (choise == 3)
            {
                if (menuName == "짜장면" || menuName == "자장면")
                {
                    choiseMenu = "짜장면 6500원";
                }
                else if (menuName == "짬뽕")
                {
                    choiseMenu = "짬뽕 9000원";
                }
                else if (menuName == "탕수육")
                {
                    choiseMenu = "탕수육 23000원";
                }
                else
                {
                    choiseMenu = "잘못 입력하셨습니다.";
                }
            }
            else
            {
                choiseMenu = "잘못 입력하셨습니다.";
            }
            Console.WriteLine("");
            Console.WriteLine("선택하신 메뉴와 가격은");
            Console.WriteLine(choiseMenu+"입니다.");
            //int price;
            //if(menu.TryGetValue(menuName, out price))
            //{
            //    Console.WriteLine("{0}를 선택하셨습니다.", menuName);
            //    Console.WriteLine("가격은 {0}원 입니다.", price);
            //}
            //else
            //{
            //    Console.WriteLine("해당 메뉴가 존재하지 않습니다.");

            //}

        }

    }

    // 한식 클래스
    class KoreanRestaurant : Restaurant
    {
        public KoreanRestaurant(string name) : base(name)
        {
            AddMenu("비빔밥", 7000);
            AddMenu("김치전골", 17000);
            AddMenu("불고기", 28000);
        }
    }

    // 양식 클래스
    class WesternRestaurant : Restaurant
    {
        public WesternRestaurant(string name) : base(name)
        {
            AddMenu("파스타", 13500);
            AddMenu("피자", 21000);
            AddMenu("스테이크", 32500);
        }
    }

    // 중식 클래스
    class ChineseRestaurant : Restaurant
    {
        public ChineseRestaurant(string name) : base(name)
        {
            AddMenu("짜장면", 6500);
            AddMenu("짬뽕", 9000);
            AddMenu("탕수육", 23000);
        }
    }
}

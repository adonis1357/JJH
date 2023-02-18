using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230212_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //나이에 해당하는 띠를 출력해줄 클래스를 만든다.
            //탄생년도를 입력하면 해당하는 띠를 출력한다.
            //출력할때 만 나이도 같이 계산되어 출력된다.

            //age inputage = new age();

            //inputage.InputAge();

            //게임들을 보유하고 있는 게임 클래스를 제작한다.
            //게임을 입력하면 배열에 값이 있는지 비교해서 있는지 없는지 출력해준다.

            //GameClass gg = new GameClass();
            //gg.SearchGame();

            //public    - 외부에서 자유롭게 사용
            //private   - 나만 쓸 수 있다
            //protected - 상속받은 자식이 쓸 수 있다

            //Classes myNewClass = new Classes();
            //myNewClass.WriteSchoolInfo("신곡초등학교");

            //1. 예능 클래스를 상속받는
            //SBS / KBS / MBC

            //예능 클래스가 전체적으로
            //가질 정보들을 갖는다
            //( 몇번 채널인가 )
            //각각 채널들은 채널번호가 모두 다르다

            //채널을 입력받으면 각 방송사가 틀어줄 수 있는 예능들을 띄워준다
            //특정 예능을 입력하면 몇번채널 어느 방송사 어느 예능을 보는 중이라고 띄워준다.


            //2. 식당 클래스를 상속받는 한식 / 양식 / 중식

            //식당 클래스가 전체적으로
            //가질 정보들을 갖는다
            //( 돈 받기 / 주문한 음식 주기 )

            //각각 식당들은 메뉴가 모두 다르다.
            //한식은 삼계탕 1만원 등등 다르다.
            //가고싶은 식당을 입력받고, 메뉴를 모두 띄워준다.
            //유저는 메뉴를 입력하고, 내야할 가격, 고른 메뉴를 띄워준다.

            Korean koreanFood = new Korean();
            koreanFood.MenuSetting();
            koreanFood.ShowMenu();

            System.Console.WriteLine();
            System.Console.Write("먹을 음식은 몇번? : ");
            int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            koreanFood.OderMenu(inputMenu);

            chinese chineseFood = new chinese();
            chineseFood.MenuSetting();
            chineseFood.ShowMenu();
            System.Console.WriteLine();
            System.Console.Write("먹을 음식은 몇번? : ");
            int inputMenu2 = Convert.ToInt32(System.Console.ReadLine()) - 1;
            chineseFood.OderMenu(inputMenu2);

            //Western WesternFood = new Western();
            //WesternFood.MenuSetting();
            //WesternFood.ShowMenu();
            //System.Console.WriteLine();
            //System.Console.Write("먹을 음식은 몇번? : ");
            //int inputMenu3 = Convert.ToInt32(System.Console.ReadLine()) - 1;
            //WesternFood.OderMenu(inputMenu3);

            //9. 서점 클래스에 제목, 지은이, 출판사 를 입력받아 책 데이터를 쌓는다.

            //특정 키를 입력받을때 까지 지속되며, 특정 키 입력을 받으면
            //제목을 입력받고 제목에 맞는 지은이, 출판사를 순서대로 출력해준다.

            //Library library = new Library();

            //int countBookNumber = 0;
            //do
            //{
            //    library.InputBooksData(countBookNumber);
            //    countBookNumber++;
            //} while (library.AskKeepPutData());
            //library.searchTitle();

            //12. 학생 클래스를 만들고
            //Classes 란 클래스를 만들어서
            //학생들의 이름과 반을 입력받아 배열로 저장한다.

            //Classes 클래스에서 숫자를 입력하면
            //입력숫자와 같은 반에 들어간 모든 학생을 출력해준다.(이름만)
            //Classes classes = new Classes();

            //int count = 0;
            //do
            //{
            //    classes.InputStudentsData(count);
            //    count++;
            //} while (classes.AskKeepPutData2());
            //classes.searchTitle2();

        }
    }


    class student
    {
        public string name;
        public string ClassNum;
    }

    class Classes
    {
        student[] students = new student[99];

        public void InputStudentsData(int StudentCount)
        {
            students[StudentCount] = new student();

            System.Console.Write("이름: ");
            students[StudentCount].name = System.Console.ReadLine();

            System.Console.Write("반: ");
            students[StudentCount].ClassNum = System.Console.ReadLine();

            System.Console.WriteLine("--------------------------");
        }
        public bool AskKeepPutData2()
        {
            System.Console.Write("계속 입력할까요? (y/n) : ");
            string studentAnser = System.Console.ReadLine();

            if (studentAnser == "Y" || studentAnser == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void searchTitle2()
        {
            System.Console.Write("찾고싶은 반 : ");
            string studentAnser = System.Console.ReadLine();

            for (int indexNum = 0; indexNum < students.Count(); indexNum++)
            {
                if (students[indexNum] == null)
                {
                    System.Console.WriteLine("모두 찾았습니다.");
                    break;
                }

                else if (students[indexNum].ClassNum == studentAnser)
                {
                    System.Console.WriteLine($"이름 : {students[indexNum].name}");
                }
            }
        }

    }
    class book
    {
        public string title;
        public string Author;
        public string publisher;
    }

    class Library
    {
        book[] books = new book[99];

        public void InputBooksData(int BookCount)
        {
            books[BookCount] = new book();

            System.Console.Write("제목 : ");
            books[BookCount].title = System.Console.ReadLine();

            System.Console.Write("지은이 : ");
            books[BookCount].Author = System.Console.ReadLine();

            System.Console.Write("출판사 : ");
            books[BookCount].publisher = System.Console.ReadLine();

            System.Console.WriteLine("--------------------------");
        }

        public bool AskKeepPutData()
        {
            System.Console.Write("계속 입력할까요? (y/n) : ");
            string userAnser = System.Console.ReadLine();

            if (userAnser == "Y" || userAnser == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void searchTitle()
        {
            System.Console.Write("찾고싶은 제목 입력 : ");
            string userAnser = System.Console.ReadLine();

            for (int indexNum = 0; indexNum < books.Count(); indexNum++)
            {
                if (books[indexNum] == null)
                {
                    System.Console.WriteLine("못찾았습니다.");
                    break;
                }

                else if (books[indexNum].title == userAnser)
                {
                    System.Console.WriteLine($"제목 : {books[indexNum].title}");
                    System.Console.WriteLine($"지은이 : {books[indexNum].Author}");
                    System.Console.WriteLine($"출판사 : {books[indexNum].publisher}");
                    break;
                }
            }
        }
    }

    class Rest
    {
        protected string[] menus;       // 밥       국
        protected int[] menusPrice;     // 1000     8000

        public void TakeMoney(int money)
        {
            System.Console.WriteLine($"돈 내기 : {money}");
        }

        public void OderMenu(int number)
        {
            System.Console.WriteLine($"주문 : {menus[number]}");
            TakeMoney(menusPrice[number]);
        }

        public void ShowMenu()
        {
            System.Console.Write($"종류 :");
            for (int index = 0; index < menus.Count(); index++)
            {
                System.Console.Write($"{menus[index]} ");
            }
        }
    }
    class Korean : Rest
    {
        public void MenuSetting()
        {
            menus = new string[2];
            menus[0] = "1. 밥";
            menus[1] = "2. 국";

            menusPrice = new int[2];
            menusPrice[0] = 1000;
            menusPrice[1] = 8000;
        }
    }

    class chinese : Rest
    {
        public void MenuSetting()
        {
            menus = new string[2];
            menus[0] = "1. 짜장면";
            menus[1] = "2. 짬뽕";

            menusPrice = new int[2];
            menusPrice[0] = 6500;
            menusPrice[1] = 8500;
        }
    }

    class Western : Rest
    {
        public void MenuSetting()
        {
            menus = new string[2];
            menus[0] = "1. 피자";
            menus[1] = "2. 파스타";

            menusPrice = new int[2];
            menusPrice[0] = 25000;
            menusPrice[1] = 13500;
        }
    }

    class entertainment
    {

    }

    class Broadcaststations : entertainment
    {

    }
    class School
    {
        protected string SchoolName;
        private string TeacherName;
        protected void WriteSchoolName()
        {
            System.Console.WriteLine($"학교 이름 : {SchoolName}");
        }
    }

    //class Classes : School
    //{
    //    private string ClassName = "3반";

    //    public void WriteSchoolInfo(string _schoolName)
    //    {
    //        SchoolName = _schoolName;

    //        WriteSchoolName();
    //        System.Console.WriteLine($"내 반은 {ClassName}");
    //    }
    //}

    //class GameClass
    //{
    //    public string[] Games = new string[3] {"a", "b", "C" };

    //    public void SearchGame()
    //    {
    //        string searchGameName = System.Console.ReadLine();

    //        for(int index = 0; index < 3; index++)
    //        {
    //            if(Games[index] == searchGameName)
    //            {
    //                System.Console.WriteLine("있습니다.");
    //                break;
    //            }

    //            if (Games[index] == 2)
    //            {
    //                System.Console.WriteLine("없습니다.");
    //                break;
    //            }
    //        }
    //    }
    //}

    class age
    {
        public void InputAge()
        {
            string birth = System.Console.ReadLine();
            int birth2 = Convert.ToInt32(birth);
            int zodiac = birth2 % 12;

            if (zodiac == 0)
            {
                System.Console.WriteLine("원숭이띠 입니다");
            }
            else if (zodiac == 1)
            {
                System.Console.WriteLine("닭띠 입니다");
            }
            else if (zodiac == 2)
            {
                System.Console.WriteLine("개띠 입니다");
            }
            else if (zodiac == 3)
            {
                System.Console.WriteLine("돼지띠 입니다");
            }
            else if (zodiac == 4)
            {
                System.Console.WriteLine("쥐띠 입니다");
            }
            else if (zodiac == 5)
            {
                System.Console.WriteLine("소띠 입니다");
            }
            else if (zodiac == 6)
            {
                System.Console.WriteLine("호랑이띠 입니다");
            }
            else if (zodiac == 7)
            {
                System.Console.WriteLine("토끼띠 입니다");
            }
            else if (zodiac == 8)
            {
                System.Console.WriteLine("용띠 입니다");
            }
            else if (zodiac == 9)
            {
                System.Console.WriteLine("뱀띠 입니다");
            }
            else if (zodiac == 10)
            {
                System.Console.WriteLine("말띠 입니다");
            }
            else if (zodiac == 11)
            {
                System.Console.WriteLine("양띠 입니다");
            }
            System.Console.WriteLine((2023 - birth2) + "살 입니다.");

        }



    }
}


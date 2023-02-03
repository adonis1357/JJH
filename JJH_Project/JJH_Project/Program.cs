using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");
            //System.Console.WriteLine("내 이름은 정진호 입니다.");
            //System.Console.WriteLine("나는 38살 입니다.");
            //System.Console.WriteLine("나는 SBS 게임 아카데미 학생입니다.");
            //System.Console.WriteLine("나는 현재 부천에 거주하고 있습니다.");
            //System.Console.WriteLine("나의 본가는 수원에 있습니다.");

            //System.Console.WriteLine("이건 WriteLine");

            ////10줄
            ////Write, WriteLine 쓰는 법

            //System.Console.Write("1. ");
            //System.Console.WriteLine("첫번째줄");
            //System.Console.Write("2. ");
            //System.Console.WriteLine("두번째줄");
            //System.Console.Write("3. ");
            //System.Console.WriteLine("세번째줄");
            //System.Console.Write("4. ");
            //System.Console.WriteLine("네번째줄");
            //System.Console.Write("5. ");
            //System.Console.WriteLine("다섯번째줄");

            ////5줄만 보이게

            ////System.Console.Write("여섯번째줄"); 주석은 보이지 않는다.


            //System.Console.Write("Write 쓰는 법");

            ////데이터 형 - String
            //String MyName;
            //String MyAge;
            //String MyAddress;


            //MyName = "JinHo";
            //MyAge = "38살";
            //MyAddress = "경기도 부천시 송내동";

            //int ii;

            //ii = 1 + 2;

            //System.Console.WriteLine(MyName);
            //System.Console.WriteLine(MyAge);
            //System.Console.WriteLine(MyAddress);


            //// ReadLine();

            //string MyName2;
            //string MyAddress2; 
            //string MyAge2;
            //string MyGender;

            //System.Console.WriteLine("이름을 입력해 주세요 : ");
            //MyName2 = System.Console.ReadLine();

            //System.Console.Write("당신의 이름은 : ");
            //System.Console.Write(MyName2);
            //System.Console.WriteLine(" 입니다.");

            //System.Console.Write("당신의 주소를 입력해 주세요 : ");
            //MyAddress2 = System.Console.ReadLine();

            //System.Console.Write("당신의 주소는 : ");
            //System.Console.Write(MyAddress2);
            //System.Console.WriteLine(" 입니다.");

            //System.Console.Write("당신의 나이를 입력해주세요 : ");
            //MyAge2 = System.Console.ReadLine();

            //System.Console.Write("당신의 나이는 : ");
            //System.Console.Write(MyAge2);
            //System.Console.WriteLine(" 입니다.");

            //System.Console.Write("당신의 성별을 입력해주세요 : ");
            //MyGender = System.Console.ReadLine();

            //System.Console.Write("당신의 성별은 : ");
            //System.Console.Write(MyGender);
            //System.Console.WriteLine(" 입니다.");

            //System.Console.WriteLine($"당신의 이름은 {MyName2} 이고, 당신의 나이는 {MyAge2} 입니다.");
            //System.Console.Write("당신의 이름은 {0} 이고, 당신의 나이는 {1} 입니다.", MyName2, MyAge2);

            //int MyAge = 5;
            //string MyName = "JInHo";
            //float ToDay = 1.29f;

            //System.Console.WriteLine(int.MaxValue);
            //System.Console.WriteLine(int.MinValue);

            //int MyNumber = 2147483647;
            //System.Console.WriteLine(MyNumber + 1);

            //string MyName = "JinHo";

            //System.Console.WriteLine(MyName);

            //string MyAge = "3";

            //String MMM = MyName + MyAge;

            //System.Console.Write(MMM);

            //string kk = null;
            //String BirthYear;

            //System.Console.Write("태어난 연도를 입려해주세요 : ");
            //BirthYear = System.Console.ReadLine();

            //int MyAgeNumber = Convert.ToInt32(BirthYear);

            // NowAge = (2023 - MyAgeNumber).ToString();

            //System.Console.Write("당신의 현재 나이는 ");
            //System.Console.Write(NowAge);
            //System.Console.WriteLine("살 입니다.");

            //            System.Console.WriteLine(@"


            //              ㅁ
            //            ㅁㅁㅁ
            //          ㅁㅁㅁㅁㅁ
            //        ㅁㅁㅁㅁㅁㅁㅁ
            //      ㅁㅁㅁㅁㅁㅁㅁㅁㅁ


            //"

            //                );

            //1. 변수형 종류 주석으로 작성후, 각 변수형들의 최대값 최소값 출력하기

            //int
            //            System.Console.WriteLine("int 최대 값은");
            //            System.Console.WriteLine(int.MaxValue);
            //            System.Console.WriteLine("입니다.");
            //            System.Console.WriteLine("");

            //            System.Console.WriteLine("int 최소 값은");
            //            System.Console.WriteLine(int.MinValue);
            //            System.Console.WriteLine("입니다.");
            //            System.Console.WriteLine("");

            //            //float
            //            System.Console.WriteLine("float 최대 값은");
            //            System.Console.WriteLine(float.MaxValue);
            //            System.Console.WriteLine("입니다.");
            //            System.Console.WriteLine("");

            //            System.Console.WriteLine("float 최소 값은");
            //            System.Console.WriteLine(float.MinValue);
            //            System.Console.WriteLine("입니다.");
            //            System.Console.WriteLine("");

            //            //double
            //            System.Console.WriteLine("double 최대 값은");
            //            System.Console.WriteLine(double.MaxValue);
            //            System.Console.WriteLine("입니다.");
            //            System.Console.WriteLine("");

            //            System.Console.WriteLine("double 최소 값은");
            //            System.Console.WriteLine(double.MinValue);
            //            System.Console.WriteLine("입니다.");
            //            System.Console.WriteLine("");

            //            //2. string으로 이름 나이 입력 받고, 출력하기
            //            //나이는 출생년도로만 입력받기
            //            string BirthYear;

            //            System.Console.WriteLine("당신의 출생년도를 입력해주세요 : ");
            //            BirthYear = System.Console.ReadLine();
            //            int MyAge = Convert.ToInt32(BirthYear);
            //            System.Console.Write("당신의 나이는 ");
            //            System.Console.Write(2023 - MyAge);
            //            System.Console.Write("살 입니다.");
            //            System.Console.WriteLine("");
            //            System.Console.WriteLine("");


            //            //3. @사용 해서 별 그리기
            //            System.Console.WriteLine(@"
            //@를 이용해서 별을 그려보세요

            //           ☆
            //         ☆☆☆
            //       ☆☆☆☆☆
            //☆☆☆☆☆☆☆☆☆☆☆☆☆
            //  ☆☆☆☆☆☆☆☆☆☆☆
            //    ☆☆☆☆☆☆☆☆☆
            //  ☆☆☆☆☆☆☆☆☆☆☆
            //☆☆☆☆☆☆☆☆☆☆☆☆☆
            //       ☆☆☆☆☆
            //         ☆☆☆
            //           ☆  
            //");
            //            //4. int값을 float로 캐스팅하기
            //            System.Console.WriteLine("int값 12을 float로 +0.12하여 캐스팅합니다.");
            //            int ii;

            //            ii = 12;

            //            float ff = (float)ii;

            //            System.Console.WriteLine(ff + 0.12);
            //            System.Console.WriteLine("");

            //            //3.12 를 int값으로 캐스팅하기

            //            float fff;

            //            fff = 3.12f;
            //            System.Console.WriteLine(fff);

            //            int iii = Convert.ToInt32(fff);
            //            System.Console.WriteLine("float 3.12를 int값으로 캐스팅합니다.");
            //            System.Console.WriteLine(iii);
            //            System.Console.WriteLine("");

            //            //이름을 입력받는다.
            //            //입력받은 이름의 길이를 숫자로 바꾸고
            //            //받은 숫자를 출력한다.
            //            string MyName2;

            //            System.Console.WriteLine("이름을 입력하세요");
            //            MyName2 = System.Console.ReadLine();

            //            int NameSize = MyName2.Length;

            //            System.Console.WriteLine("");
            //            System.Console.Write("당신의 이름은 ");
            //            System.Console.Write(NameSize);
            //            System.Console.WriteLine("글자 입니다.");
            //            System.Console.WriteLine(@"

            //");

            //string MyName = "정진호";
            //int ii = 3;
            //float fff = 3.12f;

            ////값을 가져올껀데 int, string, char 형인지 모를때
            //var MyNameis = "정진호";
            //var iii = 3;
            //var ffff = 3.12f;


            //int kk = 1;
            //int kk2 = 4;
            //int kk4 = 8;

            //int[] iii = new int[3];

            //// kkk -> 0, 1, 2, 3
            //// lang -> C, C++, C#

            //int[] kkk = new int[4] { 0, 1, 2, 3 };
            //System.Console.WriteLine(kkk[2]);

            //string[] lang = new string[3] { "C", "C++", "C#" };
            //System.Console.WriteLine(lang[2]);

            //long[] lolo = new long[1] { 2 };


            //System.Console.WriteLine("============================");

            //// int 형 배열 5칸짜리 5개
            //// string 형 qoduf 5칸짜리 5개 만들기

            //int[] ii0004 = new int[5] { 0, 1, 2, 3, 4 };
            //int[] ii0509 = new int[5] { 5, 6, 7, 8, 9 };
            //int[] ii1014 = new int[5] { 10, 11, 12, 13, 14 };
            //int[] ii1519 = new int[5] { 15, 16, 17, 18, 19 };
            //int[] ii2024 = new int[5] { 20, 21, 22, 23, 24 };

            //System.Console.WriteLine(ii0004[0]);
            //System.Console.WriteLine(ii0509[1]);
            //System.Console.WriteLine(ii1014[2]);
            //System.Console.WriteLine(ii1519[3]);
            //System.Console.WriteLine(ii2024[4]);

            //string[] str01 = new string[5] { "하나", "둘", "셋", "넷", "다섯" };
            //string[] str02 = new string[5] { "여섯", "일곱", "여덜", "아홉", "열" };
            //string[] str03 = new string[5] { "열하나", "열둘", "열셋", "열넷", "열다섯" };
            //string[] str04 = new string[5] { "열여섯", "열일곱", "열여덜", "열아홉", "스물" };
            //string[] str05 = new string[5] { "스물하나", "스물둘", "스물셋", "스물넷", "스물다섯" };

            //System.Console.WriteLine(str01[0]);
            //System.Console.WriteLine(str02[1]);
            //System.Console.WriteLine(str03[2]);
            //System.Console.WriteLine(str04[3]);
            //System.Console.WriteLine(str05[4]);


            //System.Console.WriteLine("============================");


            //int[] LaterArray;

            //System.Console.WriteLine("배열의 크기는?");
            //string ArraySize;
            //ArraySize = System.Console.ReadLine();

            //LaterArray = new int[Convert.ToInt32(ArraySize)];


            //string[] _lang = new string[3];
            //_lang[0] = "C";
            //_lang[1] = "C++";
            //_lang[2] = "C#";

            //System.Console.WriteLine($"0번 값은 {_lang[0]}입니다.");
            //_lang[0] = "C를 변경할꺼야";

            //System.Console.WriteLine($"0번 값은 {_lang[0]}입니다.");

            //// 식당에 음식이 떡볶이, 김밥, 라면, 라볶이가 있다.
            //// 이중에 숫자를 입력받으면
            //// 입력받은 값은 비어있게 된다.

            //// 최초 음식들과
            //// 숫자를 입력받았을때 음식을 출력하고

            //// 비어있게 되었다라는 결과값도 출력하라

            //string[] Memu = new string[4] { "떡볶이", "김밥", "라면", "라볶이" };
            //string MemuNumber;

            //System.Console.WriteLine("선택할 메뉴 넘버를 입력해주세요");

            //MemuNumber = System.Console.ReadLine();
            //int MemuNumber2 = Convert.ToInt32(MemuNumber);

            //System.Console.WriteLine($"메뉴는 {Memu[0]}, {Memu[1]}, {Memu[2]}, {Memu[3]} 입니다.");
            //System.Console.WriteLine($"선택한 메뉴는 {Memu[MemuNumber2]} 입니다.");

            //Memu[MemuNumber2] = "   ";
            //System.Console.Write("남은 메뉴는");
            //System.Console.WriteLine($"{Memu[0]}, {Memu[1]}, {Memu[2]}, {Memu[3]} 입니다.");


            //1월 30일 숙제 Wirte, WriteLine 10줄을 활용하여 자기소개 작성하기
            //System.Console.Write("제 이름은 ");
            //System.Console.Write("정진호 ");
            //System.Console.WriteLine("입니다.");

            //System.Console.Write("제 나이는 ");
            //System.Console.WriteLine("마흔살 입니다.");

            //System.Console.Write("현재 ");
            //System.Console.Write("부천에서 ");
            //System.Console.WriteLine("거주하고 있습니다.");

            //System.Console.Write("저는 게임아카데미 ");
            //System.Console.WriteLine(" 학생입니다.");

            //2월 1일 숙제  자기소개를 입력받아 출력하기
            //string Name;
            //string BirthYearRead;
            //string Address;
            //string Gender;
            //string AboutMe;
            //string Year = System.DateTime.Now.ToString("yyyy");

            //System.Console.WriteLine("당신의 이름을 입력해주세요");
            //Name = System.Console.ReadLine();

            //System.Console.WriteLine("당신의 출생년도를 입력해주세요");
            //BirthYearRead = System.Console.ReadLine();

            //System.Console.WriteLine("당신의 주소를 입력해주세요");
            //Address = System.Console.ReadLine();

            //System.Console.WriteLine("당신의 성별을 입력해주세요");
            //Gender = System.Console.ReadLine();

            //System.Console.WriteLine("자기소개를 입력해주세요");
            //AboutMe = System.Console.ReadLine();

            //System.Console.WriteLine("");
            //System.Console.WriteLine("");
            //System.Console.WriteLine("");

            //System.Console.Write("당신의 이름은 ");
            //System.Console.Write(Name);
            //System.Console.WriteLine("입니다.");

            //System.Console.WriteLine("");

            //System.Console.Write("당신의 나이는 ");
            //int BirthYear = Convert.ToInt32(BirthYearRead);
            //int NowYear = Convert.ToInt32(Year);
            //int MyAge = NowYear - BirthYear;
            //System.Console.Write(MyAge);
            //System.Console.WriteLine("입니다.");

            //System.Console.WriteLine("");

            //System.Console.Write("당신의 주소는 ");
            //System.Console.Write(Address);
            //System.Console.WriteLine("입니다.");

            //System.Console.WriteLine("");

            //System.Console.Write("당신의 성별은 ");
            //System.Console.Write(Gender);
            //System.Console.WriteLine("입니다.");

            //System.Console.WriteLine("");

            //System.Console.Write(Name);
            //System.Console.WriteLine("님의 자기소개 입니다.");
            //System.Console.WriteLine(AboutMe);

            //System.Console.WriteLine("");
            //System.Console.WriteLine("이상입니다.");

            //2월 3일 숙제
            //1. string (문장)형식의 배열을 만든다. 변수의 이름은 Foods 로 한다. (string[] Foods)
            string[] Foods;

            //2. 떡볶이, 김밥, 만두, 튀김 이라는 4개의 원소를 넣는다 (Foods = new string[4] {"떡볶...)
            Foods = new string[4] { "떡볶이", "김밥", "만두", "튀김" };

            //3. 숫자를 하나 입력받는다.
            System.Console.WriteLine(@"
<메뉴판>
1. 떡볶이
2. 김밥
3. 만두
4. 튀김
먹고싶은 메뉴의 번호를 입력해주세요");
            string ReadNumber = System.Console.ReadLine();
            int Number = Convert.ToInt32(ReadNumber);

            //4. 입력받은 음식을 먹었다 라는 내용을 띄운다(wrtieline)
            System.Console.Write(Foods[Number - 1]);
            System.Console.WriteLine("(을)를 먹었습니다.");

            System.Console.WriteLine("");

            //5. 다시 Foods에 남은 음식을 보여준다(먹은음식은 비어있다)
            System.Console.WriteLine("메뉴판 새로고침");
            Foods[Number - 1] = "Sold Out";
            System.Console.Write("1. ");
            System.Console.WriteLine(Foods[0]);
            System.Console.Write("2. ");
            System.Console.WriteLine(Foods[1]);
            System.Console.Write("3. ");
            System.Console.WriteLine(Foods[2]);
            System.Console.Write("4. ");
            System.Console.WriteLine(Foods[3]);



        }
    }
}

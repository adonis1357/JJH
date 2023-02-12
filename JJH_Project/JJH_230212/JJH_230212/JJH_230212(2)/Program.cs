using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230212_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student AStudent = new Student();
            //AStudent.name = "정진호";
            //AStudent.age = 39;

            //AStudent.WritelineStudentInfo();
            ////System.Console.WriteLine($"A학생의 이름은 {AStudent.name}");
            ////System.Console.WriteLine($"A학생의 나이는 {AStudent.age}");

            //Student BStudent = new Student();
            //BStudent.name = "정은하";
            //BStudent.age = 34;

            //BStudent.WritelineStudentInfo();
            ////System.Console.WriteLine($"B학생의 이름은 {BStudent.name}");
            ////System.Console.WriteLine($"B학생의 나이는 {BStudent.age}");

            ////1. 학생클래스를 만들어서 학생 하나의 정보를 입력받는다(Readline)
            //Student CStudent = new Student();

            //System.Console.WriteLine("C학생의 이름을 입력해주세요");
            //CStudent.name = System.Console.ReadLine();
            //System.Console.WriteLine("C학생의 나이를 입력해주세요");
            //string ageInput = System.Console.ReadLine();
            //CStudent.age = Convert.ToInt32(ageInput);


            //2. 학생클래스를 만들어서 메소드로 학생 하나의 정보를 입력받는다.
            //Student AStudent = new Student();

            //AStudent.InputStudentInfoData();
            //AStudent.WritelineStudentInfo();
            //3. 학생 클래스를 만들어서 for문으로 학생 여럿을 입력받는다.
            //Student[] students = new Student[2];

            //for (int i = 0; i < 2; i++)
            //{
            //    students[i] = new Student();
            //    students[i].InputStudentInfoData();
            //}

            //4. 먹을 것 클래스를 만들어서 음식을 여러개 입력받습니다.(Readlin())
            //-1. 5개의 음식을 입력 받습니다.
            //-2. 추가로 음식을 입력받는데, 5개의 음식중 이미 있는 음식이면 제외됩니다.
            //예) a,b,c,d,e 가 있는데 추가로 b가 입력됨
            //  -> a,c,d,e 가 된다.

            foods[] menus = new foods[5];
            System.Console.WriteLine("메뉴 5개를 입력해주세요");
            for (int i = 0; i < 5; i++)
            {
                System.Console.Write("메뉴");
                System.Console.WriteLine(i+1);
                menus[i] = new foods();
                menus[i].Inputmenu();
            }
            
            for (int i = 0; i < 5; i++)
            {
                menus[i].Outputmenu();
            }
            System.Console.WriteLine("");
            foods menus2 = new foods();
            menus2.Inputmenu2();

            for (int i = 0; i < 5; i++)
            {
                if(menus[i].menu == menus2.menu)
                {
                    menus[i].menu = " ";
                }
            }

            for (int i = 0; i < 5; i++)
            {
                menus[i].Outputmenu();
            }

        }
    }

    class Student
    {
        public string name;
        public int age;

        public void WritelineStudentInfo()
        {
            System.Console.WriteLine($"학생의 이름은 {name}");
            System.Console.WriteLine($"학생의 나이는 {age}");
        }
        public void InputStudentInfoData()
        {
            System.Console.WriteLine("학생의 이름을 입력해주세요");
            name = System.Console.ReadLine();
            System.Console.WriteLine("학생의 나이를 입력해주세요");
            string ageInput = System.Console.ReadLine();
            age = Convert.ToInt32(ageInput);

            WritelineStudentInfo();
        }
    }
    class foods
    {
        public string menu;

        public void Inputmenu()
        {           
            menu = System.Console.ReadLine();
        }

        public void Outputmenu()
        {
            System.Console.Write(menu + ", ");
        }
        public void Inputmenu2()
        {
            System.Console.WriteLine("추가 메뉴를 입력해주세요");
            menu = System.Console.ReadLine();
        }

    }

}

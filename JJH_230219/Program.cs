using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJH_230219
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 통장 클래스 제작
            //2. 본 통장 클래스에는 잔고(int)가 있음.
            //3. 입금 / 출금 / 이체 메소드를 보유하고 있다.
            System.Console.WriteLine("현재 잔고");
            System.Console.WriteLine("입금할 금액을 입력해주세요?");

            //4. 통장 클래스를 가지고 2개의 인스턴스를 만든다(A통장/B통장)
            bank Dep = new bank();
            bank Dep2 = new bank();
            
            //5. 수중에 100만원을 가지고 있는 것으로 시작한다.(int)
            int MyMoney = 1000000;

            //6. Main에서 선택지를 띄운다. While문을 이용해서 특정 키가 들어올 때까지 반복한다.
            //   선택지는 1. 입금 2. 출금 3. 이체 3개가 있다.
            //   여기서 선택지는 항상 A통장 기준이다.
            bool q = true;
            while (q)
            {
                string QA;
                System.Console.WriteLine("다음 항목중 선택해주세요");
                System.Console.WriteLine("1. 입금  2. 출금  3. 이체  4. 종료");
                QA = System.Console.ReadLine();
                int qa = Convert.ToInt32(QA);

                //7. 입금을 선택하고 금액을 입력하면, 수중의 돈이 줄어들고 A통장은 금액이 추가된다.
                //   A통장의 잔액이 출력된다.
                if (qa == 1)
                {
                    System.Console.WriteLine("입금할 금액을 입력해주세요");
                    string deposit;
                    deposit = System.Console.ReadLine();
                    int deposit2 = Convert.ToInt32(deposit);
                    Dep.Deposit(deposit2);
                }
                //8. 출금을 선택하고 금액을 입력하면, 수중의 돈이 늘어나고 A통장의 금액이 줄어든다.
                //   A통장의 잔액이 출력된다.
                else if(qa == 2)
                {
                    System.Console.WriteLine("출금할 금액을 입력해주세요");
                    string withdraw;
                    withdraw = System.Console.ReadLine();
                    int withdraw2 = Convert.ToInt32(withdraw);
                    Dep.Withdraw(withdraw2);
                }
                //9. 이체를 선택하고 금액을 입력하면, A통장의 금액이 줄어들고, B통장의 금액이 늘어난다.
                //   A통장과 B통장의 잔액을 출력한다.
                else if (qa == 3)
                {
                    System.Console.WriteLine("이체할 금액을 입력해주세요");
                    string withdraw;
                    withdraw = System.Console.ReadLine();
                    int withdraw2 = Convert.ToInt32(withdraw);
                    Dep.Withdraw(withdraw2);
                }
                else if (qa == 4)
                {
                    q = false;
                }
                else
                {
                    System.Console.WriteLine("잘못 입력하셨습니다.");
                }
            }
        }
    }

    class bank
    {
        public int BankBook;

        public void Deposit(int deposit)
        {
            BankBook = BankBook + deposit;
            System.Console.WriteLine($"고객님의 잔액은 {BankBook} 원 입니다.");
        }
        
        public void Withdraw(int withdraw)
        {
            BankBook = BankBook - withdraw;
            System.Console.WriteLine($"고객님의 잔액은 {BankBook} 원 입니다.");
        }

        public void Transfer(int transfer)
        {
            BankBook = BankBook - transfer;
        }
        
    }
}

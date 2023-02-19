using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IInterfaceTest
    {
        void TestInterfaceMethod();
    }

    class InterfaceTestClassFirst : IInterfaceTest
    {
        public void TestInterfaceMethod()
        {
            System.Console.WriteLine("hollo");
        }
    }
    class InterfaceTestClassSecond : IInterfaceTest
    {
        public void TestInterfaceMethod()
        {
            System.Console.WriteLine("bye");
        }
    }
}

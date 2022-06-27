using System;

namespace day14_01
{
    class Program
    {
        delegate void dele(string str);
        class A
        {
            public void Prints(string str)
            {
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            //1번 방법
            A p01 = new A();
            dele D1 = new dele(p01.Prints);
            D1("kang");

            //2번 방법
            dele D2 = p01.Prints;
            D2("hi");

        }
    }
}

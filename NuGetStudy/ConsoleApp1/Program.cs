using ClassStandardLibrary;
using NuGetStudy;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var version = MyConsole.GetVersion();
            Console.WriteLine(string.Format("Hello World!{0}", version));

            var time= MyClass.GetDate();
            Console.WriteLine("当前时间为{0}",time.ToString());
        }
    }
}

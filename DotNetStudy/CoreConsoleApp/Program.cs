using System;
using CoreConsoleApp.协变和逆变研究;
using FaNo= CoreConsoleApp.设计模式.Facade外观模式.NoPattern;
using FaUse = CoreConsoleApp.设计模式.Facade外观模式.UsePattern;

namespace CoreConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ////1. 调用逆变协变的逻辑。
            //Client.index();

            //2. 调用门面模式的逻辑
            FaNo.Client.Index();

            FaUse.Client.Index();
        }
    }
}

using System;
using CoreConsoleApp.协变和逆变研究;
using FaNo= CoreConsoleApp.设计模式.Facade外观模式.NoPattern;
using FaUse = CoreConsoleApp.设计模式.Facade外观模式.UsePattern;
using RF= CoreConsoleApp.设计模式.Factory工厂模式.ReflectFactory反射工厂;

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

            //3. 调用反射工厂的逻辑
            RF.Client.Index();
        }
    }
}

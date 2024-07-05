// 文件名：Program.cs
// 版权：山东润拓{currentYear}

using System;
using BdNo = CoreConsoleApp.设计模式.Builder构造器模式.NoPattern;
using FaNo = CoreConsoleApp.设计模式.Facade外观模式.NoPattern;
using FaUse = CoreConsoleApp.设计模式.Facade外观模式.UsePattern;
using RF = CoreConsoleApp.设计模式.Factory工厂模式.ReflectFactory反射工厂;
using PSO = CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式;
using FSM = CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式;

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

            //4. 调用创建者模式的逻辑
            BdNo.Client.Index();

            //5. 调用发布订阅模式的逻辑
            PSO.Client.Index();

            FSM.Client.Index();
        }
    }
}

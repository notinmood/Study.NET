// 文件名：Program.cs
// 版权：山东润拓{currentYear}

using System;
using EB = CoreConsoleApp.事件研究._3.框架标准事件;
using ES = CoreConsoleApp.事件研究._4.基于事件的订阅退订的例子;
using FaNo = CoreConsoleApp.设计模式.Facade外观模式.NoPattern;
using FaUse = CoreConsoleApp.设计模式.Facade外观模式.UsePattern;
using FSM = CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式;
using PSO = CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式;
using RF = CoreConsoleApp.设计模式.Factory工厂模式.ReflectFactory反射工厂;
using SB = CoreConsoleApp.设计模式.State状态模式.UsePatternBetter;
using SN = CoreConsoleApp.设计模式.State状态模式.NoPattern;
using SU = CoreConsoleApp.设计模式.State状态模式.UsePattern;
using SS = CoreConsoleApp.设计模式.State状态模式.X.请假流程的示例;
using PU = CoreConsoleApp.设计模式.Prototype原型模式.UsePattern;
using STU = CoreConsoleApp.设计模式.Strategy策略模式.UsePattern;


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
            Console.WriteLine(">>> 3. 调用反射工厂的逻辑");
            RF.Client.Index();

            //4. 调用创建者模式的逻辑
            设计模式.Builder构造器模式.场景1.NoPattern.Client.Index();
            设计模式.Builder构造器模式.场景2.X.对象构建示例.UsePattern.Client.Index();

            //5. 调用发布订阅模式的逻辑
            PSO.Client.Index();
            FSM.Client.Index();

            //6. 调用事件模型的逻辑
            EB.BetterClient.Index();
            ES.Client.Index();

            //7. 调用状态模式的逻辑
            SN.Client.Index();
            SU.Client.Index();
            SB.Client.Index();
            SS.Client.Index();

            //8. 调用原型模式的逻辑
            PU.Client.Index();

            //9. 调用策略模式的逻辑
            STU.Client.Index();

            //10. 调用责任链模式
            设计模式.ChainOfResponsibility责任链模式.NoPattern.Client.Index();
            设计模式.ChainOfResponsibility责任链模式.UsePattern.Client.Index();
        }
    }
}

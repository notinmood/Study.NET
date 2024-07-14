﻿// 文件名：Program.cs
// 版权：山东润拓{currentYear}

using System;



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
            Console.WriteLine("Hello World!以下是测试结果：");

            ////1. 调用逆变协变的逻辑。
            //Client.index();

            ////2. 调用门面模式的逻辑
            //设计模式.Facade外观模式.NoPattern.Client.Index();
            //设计模式.Facade外观模式.UsePattern.Client.Index();

            ////3. 调用反射工厂的逻辑
            //Console.WriteLine(">>> 3. 调用反射工厂的逻辑");
            //设计模式.Factory工厂模式.ReflectFactory反射工厂.Client.Index();

            ////4. 调用创建者模式的逻辑
            //设计模式.Builder构造器模式.场景1.NoPattern.Client.Index();
            //设计模式.Builder构造器模式.场景2.X.对象构建示例.UsePattern.Client.Index();

            ////5. 调用发布订阅模式的逻辑
            //设计模式.PublishSubcribe发布订阅模式.管理订阅对象的方式.Client.Index();
            //设计模式.PublishSubcribe发布订阅模式.管理订阅方法的方式.Client.Index();

            ////6. 调用事件模型的逻辑
            //事件研究._3.框架标准事件.BetterClient.Index();
            //事件研究._4.基于事件的订阅退订的例子.Client.Index();

            ////7. 调用状态模式的逻辑
            //设计模式.State状态模式.NoPattern.Client.Index();
            //设计模式.State状态模式.UsePattern.Client.Index();
            //设计模式.State状态模式.UsePatternBetter.Client.Index();
            //设计模式.State状态模式.X.请假流程的示例.Client.Index();

            ////8. 调用原型模式的逻辑
            //设计模式.Prototype原型模式.UsePattern.Client.Index();

            ////9. 调用策略模式的逻辑
            //设计模式.Strategy策略模式.UsePattern.Client.Index();

            ////10. 调用责任链模式
            //设计模式.ChainOfResponsibility责任链模式.NoPattern.Client.Index();
            //设计模式.ChainOfResponsibility责任链模式.UsePattern.Client.Index();
            //设计模式.ChainOfResponsibility责任链模式.UsePatternBetter.Client.Index();

            ////11. 调用Provider 模式
            //设计模式.Provider提供者模式.X.Sample.Client.Index();

            ////12. 调用装饰器模式
            //设计模式.Decorator装饰者.NoPattern.Client.Index();
            //设计模式.Decorator装饰者.UsePattern.Client.Index();

            ////13. 调用模板方法模式
            //设计模式.TemplateMethod模板方法模式.NoPattern.Client.Index();
            //设计模式.TemplateMethod模板方法模式.UsePattern.Client.Index();



            //// 20. 调用自定义配置节点的逻辑
            //配置文件中自定义内容.最简方式.Client.Index();

            ////21. 扩展方法研究的逻辑
            //扩展方法研究.Client.Index();

            //22. Linq使用研究的逻辑
            Linq使用研究.Clinet.Select投影();
            Linq使用研究.Clinet.Where过滤();
            Linq使用研究.Clinet.SelectMany投影();
            Linq使用研究.Clinet.OrderBy排序();
            Linq使用研究.Clinet.OrderByDescending排序();
            Linq使用研究.Clinet.ThenBy排序();
            Linq使用研究.Clinet.ThenByDescending排序();
            Linq使用研究.Clinet.Reverse逆转排序();
            Linq使用研究.Clinet.Join连接();  
        }
    }
}

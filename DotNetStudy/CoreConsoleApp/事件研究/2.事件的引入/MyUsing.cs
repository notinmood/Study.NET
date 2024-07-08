

using System;

/**
 * @file   : MyUsing.cs
 * @date   : 2024/7/6 9:33:29
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.事件研究._2.事件的引入
{
    internal class MyUsing
    {
        public MyUsing()
        {


        }

        public static void Index()
        {
            //1. 普通委托的实例，可以赋值为null，并且是采用的赋值符号（=）
            MyDefine.MyDelegate myd = null;
            myd = DoSomething;

            //2. 事件不能赋值（不能使用=），应该使用订阅/退订符号（+=/-=）
            MyDefine my = new MyDefine();
            my.MyEventHandler += null;
            my.MyEventHandler += DoSomething;

            ////以下采用赋值操作符（=），会报错。
            //my.MyEventHandler = this.DoSomething;

        }


        public static int DoSomething(string message)
        {
            Console.WriteLine($"hello, {message}");
            return message.Length;
        }
    }
}

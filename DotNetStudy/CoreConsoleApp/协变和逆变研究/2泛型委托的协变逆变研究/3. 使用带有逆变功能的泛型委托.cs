/**
 * @file   : _3.cs
 * @date   : 2024/7/21 17:34:26
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using CoreConsoleApp.协变和逆变研究.Biz;

#pragma warning disable
namespace CoreConsoleApp.协变和逆变研究.泛型委托的协变逆变研究
{
    /// <summary>
    /// 支持逆变的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="param"></param>
    public delegate void MyActionIn<in T>(T param);

    internal static class 使用带有逆变功能的泛型委托
    {
        public static void Index()
        {
            Console.WriteLine("start!");

            // 3.A. 以下演示实例化委托
            MyActionIn<B> myActionInB = null;
            MyActionIn<A> myActionInA = new MyActionIn<A>(Utils.DealInput);
            MyActionIn<C> myActionInC = new MyActionIn<C>(Utils.DealInput);

            //3.A.1. 尝试交叉赋值
            myActionInB = myActionInA;
            //myActionInB = myActionInC; // 本句不成立


            //3.A.2. 执行
            myActionInB(new B());
            myActionInB(new C());//因为李氏替换，此句也没有问题
        }
    }
}

/**
 * @file   : _4.cs
 * @date   : 2024/7/21 17:52:42
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
    /// 支持协变的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public delegate T MyActionOut<out T>();

    internal static class 使用带有协变功能的泛型委托
    {
        public static void Index()
        {
            Console.WriteLine("start!");

            //1. 实例化泛型委托为非泛型委托
            MyActionOut<B> myActionOutB = null;
            MyActionOut<A> myActionOutA = new(Utils.DealOutput<A>);
            MyActionOut<C> myActionOutC = new(Utils.DealOutput<C>);


            //2. 尝试交叉赋值
            myActionOutB = myActionOutC;
            // 以下赋值会出现编译无法通过问题
            //myActionOutB = myActionOutA;

            //3. 执行方法
            B b = myActionOutB();
            Console.WriteLine($"返回值为：{b}");
            A a = myActionOutB();
            Console.WriteLine($"返回值为：{a}");

            //C c = myActionOutB();//本句不满足李氏替换，无法通过编译
        }
    }
}

/**
 * @file   : _5.cs
 * @date   : 2024/7/21 18:01:58
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
    /// 同时支持协变和逆变的泛型委托
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <param name="input"></param>
    /// <returns></returns>
    public delegate T MyActionInOut<in P, out T>(P input);

    internal static class 使用带有协变和逆变功能的泛型委托
    {
        public static void Index()
        {
            Console.WriteLine("start!");

            //1. 实例化委托
            MyActionInOut<B, B> myActionInOutBB = null;
            MyActionInOut<A, A> myActionInOutAA = new(Utils.DealInputOutput<A, A>);
            MyActionInOut<A, C> myActionInOutAC = new(Utils.DealInputOutput<A, C>);
            MyActionInOut<C, C> myActionInOutCC = new(Utils.DealInputOutput<C, C>);
            MyActionInOut<C, A> myActionInOutCA = new(Utils.DealInputOutput<C, A>);

            //2. 尝试交叉赋值
            myActionInOutBB = myActionInOutAC;

            // //以下都无法编译通过
            //myActionInOutBB = myActionInOutAA;
            //myActionInOutBB = myActionInOutCA;
            //myActionInOutBB = myActionInOutCC;


            //3. 方法调用
            B bb = myActionInOutBB(new B());
            Console.WriteLine($"返回值为：{bb}");
            A aa = myActionInOutBB(new C());
            Console.WriteLine($"返回值为：{aa}");

            //// 以下类型不兼容，无法编译通过
            //myActionInOutBB(new A());
            //C cc= myActionInOutBB(new C());

        }
    }
}

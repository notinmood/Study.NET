/**
 * @file   : BaseOperator.cs
 * @date   : 2024/7/21 15:52:06
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

#pragma warning disable
namespace CoreConsoleApp.协变和逆变研究._3泛型类型不支持协变逆变
{
    internal class BaseOperator<T>
    {
        public virtual void DealInput(T input)
        {
            Console.WriteLine("目前在Base类中执行...");
            Console.WriteLine(input.ToString());
        }

        public virtual T DealOutput()
        {
            Console.WriteLine("目前在Base类中执行...");
            return default(T);
        }
    }

    ////在定义类的时候，为其泛型参数指定in/out关键字，编译器会报错
    //internal class OtherOperator<in T>
    //{ }
}

/**
 * @file   : Sub.cs
 * @date   : 2024/7/21 15:59:25
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.协变和逆变研究._3泛型类型不支持协变逆变
{
    internal class SubOperator<T> : BaseOperator<T>
    {
        public override void DealInput(T input)
        {
            Console.WriteLine("目前在子类中执行...");
            Console.WriteLine(input.ToString());
        }

        public override T DealOutput()
        {
            Console.WriteLine("目前在子类中执行...");
            return default(T);
        }
    }
}

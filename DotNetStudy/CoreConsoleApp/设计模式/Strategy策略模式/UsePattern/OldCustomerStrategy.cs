/**
 * @file   : OldCustomerStrategy.cs
 * @date   : 2024/7/8 7:13:24
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Strategy策略模式.UsePattern
{
    /**
 * 具体算法实现，为老客户计算应报的价格
*/
    public class OldCustomerStrategy : IStrategy
    {
        public double CalcPrice(double goodsPrice)
        {
            Console.WriteLine("对于老客户，统一折扣5%");
            return goodsPrice * (1 - 0.05);
        }
    }

}

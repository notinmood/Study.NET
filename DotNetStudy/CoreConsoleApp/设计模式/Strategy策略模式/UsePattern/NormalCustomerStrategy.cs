/**
 * @file   : NormalCustomerStrategy.cs
 * @date   : 2024/7/8 7:12:09
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
using System;

namespace CoreConsoleApp.设计模式.Strategy策略模式.UsePattern
{
    /**
 * 具体算法实现，为新客户或者是普通客户计算应报的价格
 */
    public class NormalCustomerStrategy : IStrategy
    {
        public double CalcPrice(double goodsPrice)
        {
            Console.WriteLine("对于新客户或者是普通客户，没有折扣");
            return goodsPrice;
        }
    }
}

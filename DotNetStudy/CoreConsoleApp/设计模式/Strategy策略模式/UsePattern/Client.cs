/**
 * @file   : Client.cs
 * @date   : 2024/7/8 7:17:37
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;


namespace CoreConsoleApp.设计模式.Strategy策略模式.UsePattern
{
    public static class Client
    {
        public static void Index()
        {
            //1：选择并创建需要使用的策略对象
            IStrategy strategy = new LargeCustomerStrategy();
            //2：创建上下文
            PriceContext ctx = new PriceContext(strategy);

            //3：计算报价
            double quote = ctx.Quote(1000);
            Console.WriteLine("向客户报价：" + quote);
        }
    }

}

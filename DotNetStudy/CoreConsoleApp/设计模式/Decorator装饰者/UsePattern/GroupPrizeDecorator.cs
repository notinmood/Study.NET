/**
 * @file   : GroupPrizeDecorator.cs
 * @date   : 2024/7/11 18:18:32
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using CoreConsoleApp.设计模式.Decorator装饰者.Biz;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoreConsoleApp.设计模式.Decorator装饰者.UsePattern
{
    /** 
     * 装饰器对象，计算当月团队业务奖金 
     */
    public class GroupPrizeDecorator : Decorator
    {
        public GroupPrizeDecorator(IComponent c) : base(c)
        {
            //super(c);
        }
        public override double CalcPrize(string user, DateTime begin, DateTime end)
        {
            //1：先获取前面运算出来的奖金  
            double money = c.CalcPrize(user, begin, end);
            //2：然后计算当月团队业务奖金，先计算出团队总的业务额，然后再乘以1%  
            //假设都是一个团队的  
            double group = 0.0;
            foreach (double d in TempDB.mapMonthSaleMoney.Values)
            {
                group += d;
            }
            double prize = group * 0.01;
            Console.WriteLine(user + "当月团队业务奖金" + prize);
            return money + prize;
        }
    }

}

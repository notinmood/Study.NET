/**
 * @file   : SumPrizeDecorator.cs
 * @date   : 2024/7/11 18:16:58
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoreConsoleApp.设计模式.Decorator装饰者.UsePattern
{
    /** 
   * 装饰器对象，计算累计奖金 
   */
    public class SumPrizeDecorator : Decorator
    {
        public SumPrizeDecorator(IComponent c) : base(c)
        {

        }
        public override double CalcPrize(string user, DateTime begin, DateTime end)
        {
            //1：先获取前面运算出来的奖金  
            double money = c.CalcPrize(user, begin, end);
            //2：然后计算累计奖金,其实应按人员去获取累计的业务额，然后再乘以0.1%  
            //简单演示一下，假定大家的累计业务额都是1000000元  
            double prize = 1000000 * 0.001;
            Console.WriteLine(user + "累计奖金" + prize);
            return money + prize;
        }
    }

}

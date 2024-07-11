/**
 * @file   : MonthPrizeDecorator.cs
 * @date   : 2024/7/11 18:16:01
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
     * 装饰器对象，计算当月业务奖金 
     */
    public class MonthPrizeDecorator : Decorator
    {
        public MonthPrizeDecorator(IComponent c) : base(c)
        {

        }
        public override double CalcPrize(string user, DateTime begin, DateTime end)
        {
            //1：先获取前面运算出来的奖金  
            double money = c.CalcPrize(user, begin, end);
            //2：然后计算当月业务奖金,按人员和时间去获取当月业务额，然后再乘以3%  
            double prize = TempDB.mapMonthSaleMoney[user] * 0.03;
            Console.WriteLine(user + "当月业务奖金" + prize);
            return money + prize;
        }
    }
}

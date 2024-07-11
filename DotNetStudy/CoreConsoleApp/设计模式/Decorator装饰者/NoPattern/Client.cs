/**
 * @file   : Client.cs
 * @date   : 2024/7/11 17:08:17
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Decorator装饰者.NoPattern
{
    public class Client
    {
        public static void Index()
        {
            //先创建计算奖金的对象  
            Prize p = new Prize();

            //日期对象都没有用上，所以传null就可以了  
            double zs = p.calcPrize("张三", DateTime.Now, DateTime.Now);
            Console.WriteLine("==========张三应得奖金：" + zs);
            double ls = p.calcPrize("李四", DateTime.Now, DateTime.Now);
            Console.WriteLine("==========李四应得奖金：" + ls);
            double ww = p.calcPrize("王五", DateTime.Now, DateTime.Now);
            Console.WriteLine("==========王经理应得奖金：" + ww);
        }
    }
}

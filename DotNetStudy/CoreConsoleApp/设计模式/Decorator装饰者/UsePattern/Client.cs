/**
 * @file   : Client.cs
 * @date   : 2024/7/11 18:22:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Decorator装饰者.UsePattern
{
    /** 
   * 使用装饰模式的客户端 
   */
    public class Client
    {
        public static void Index()
        {
            //先创建计算基本奖金的类，这也是被装饰的对象  
            IComponent c1 = new OriginComponent();

            //然后对计算的基本奖金进行装饰，这里要组合各个装饰  
            //说明，各个装饰者之间最好是不要有先后顺序的限制，  
            //也就是先装饰谁和后装饰谁都应该是一样的  

            //先组合普通业务人员的奖金计算  
            Decorator d1 = new MonthPrizeDecorator(c1);
            Decorator d2 = new SumPrizeDecorator(d1);

            //注意：这里只需使用最后组合好的对象调用业务方法即可，会依次调用回去  
            //日期对象都没有用上，所以传null就可以了  
            double zs = d2.CalcPrize("张三", DateTime.Now, DateTime.Now);
            Console.WriteLine("==========张三应得奖金：" + zs);
            double ls = d2.CalcPrize("李四", DateTime.Now, DateTime.Now);
            Console.WriteLine("==========李四应得奖金：" + ls);

            //如果是业务经理，还需要一个计算团队的奖金计算  
            Decorator d3 = new GroupPrizeDecorator(d2);
            double ww = d3.CalcPrize("王五", DateTime.Now, DateTime.Now);
            Console.WriteLine("==========王经理应得奖金：" + ww);
        }
    }

}

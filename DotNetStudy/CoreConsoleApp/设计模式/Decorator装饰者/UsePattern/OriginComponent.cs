/**
 * @file   : ConcreteComponent.cs
 * @date   : 2024/7/11 18:13:42
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoreConsoleApp.设计模式.Decorator装饰者.UsePattern
{
    /** 
   * 基本的实现计算奖金的类，也是被装饰器装饰的对象 
   */
    public class OriginComponent : IComponent
    {
      public override double CalcPrize(string user, DateTime begin, DateTime end)
    {
        //只是一个默认的实现，默认没有奖金  
        return 0;
    }
} 

}

/**
 * @file   : Decorator.cs
 * @date   : 2024/7/11 18:15:15
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoreConsoleApp.设计模式.Decorator装饰者.UsePattern
{
    /** 
     * 装饰器的接口，需要跟被装饰的对象实现同样的接口 
     */
    public abstract class Decorator : IComponent
    {
        /** 
         * 持有被装饰的组件对象 
         */
        protected IComponent c;
        /** 
         * 通过构造方法传入被装饰的对象 
         * @param c被装饰的对象 
         */
        public Decorator(IComponent c)
        {
            this.c = c;
        }
        public override double CalcPrize(string user, DateTime begin, DateTime end)
        {
            //转调组件对象的方法  
            return c.CalcPrize(user, begin, end);
        }
    }
}

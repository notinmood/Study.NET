/**
 * @file   : DepManager.cs
 * @date   : 2024/7/9 7:53:18
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    public class DepManager : Handler
    {
        public override object HandleRequest(RequestModel model)
        {
            return LocalHandleRequest(model, "Dep"); 

            
        }
    }

}

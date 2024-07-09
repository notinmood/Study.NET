/**
 * @file   : GeneralManager.cs
 * @date   : 2024/7/9 7:55:00
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    public class GeneralManager : Handler
    {
        public override object HandleRequest(RequestModel model)
        {
            return LocalHandleRequest(model, "General");
        }
    }

}

/**
 * @file   : ProjectFeeStrategy.cs
 * @date   : 2024/7/9 20:50:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    internal class GeneralFeeStrategy : ILocalHandleStrategy
    {
        public object LocalHandle(RequestModel model, Handler handler)
        {
            //先把通用的对象造型回来 
            FeeRequestModel frm = (FeeRequestModel)model;
            string str = "";
            //总经理的权限很大，只要请求到了这里，他都可以处理
            double fee = frm.getFee();
            string user = frm.getUser();

            if (fee >= 1000)
            {
                //为了测试，简单点，只同意小李的
                if ("小李" == (user))
                {
                    str = "总经理同意" + user + "聚餐费用" + fee + "元的请求";
                }
                else
                {
                    //其它人一律不同意
                    str = "总经理不同意" + user + "聚餐费用" + fee + "元的请求";
                }
                return str;
            }
            else
            {
                //如果还有后继的处理对象，继续传递
                if (handler.GetSuccessor() != null)
                {
                    return handler.GetSuccessor().HandleRequest(model);
                }
            }
            return str;
        }
    }
}

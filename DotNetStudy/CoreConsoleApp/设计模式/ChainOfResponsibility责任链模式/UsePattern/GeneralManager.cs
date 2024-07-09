/**
 * @file   : GeneralManager.cs
 * @date   : 2024/7/9 7:55:00
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePattern
{
    public class GeneralManager : Handler
    {
        public override string handleFeeRequest(string user, double fee)
        {
            string str = "";
            //总经理的权限很大，只要请求到了这里，他都可以处理
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
                if (this.successor != null)
                {
                    return successor.handleFeeRequest(user, fee);
                }
            }
            return str;
        }
    }

}

/**
 * @file   : ProjectManager.cs
 * @date   : 2024/7/9 7:51:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePattern
{
    public class ProjectManager : Handler
    {
        public override string handleFeeRequest(String user, double fee)
        {
            String str = "";
            //项目经理的权限比较小，只能在500以内
            if (fee < 500)
            {
                //为了测试，简单点，只同意小李的
                if ("小李"==(user))
                {
                    str = "项目经理同意" + user + "聚餐费用" + fee + "元的请求";
                }
                else
                {
                    //其它人一律不同意
                    str = "项目经理不同意" + user + "聚餐费用" + fee + "元的请求";
                }
                return str;
            }
            else
            {
                //超过500，继续传递给级别更高的人处理
                if (this.successor != null)
                {
                    return successor.handleFeeRequest(user, fee);
                }
            }
            return str;
        }
    }

}

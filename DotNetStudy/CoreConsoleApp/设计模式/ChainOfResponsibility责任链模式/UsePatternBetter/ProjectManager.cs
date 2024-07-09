/**
 * @file   : ProjectManager.cs
 * @date   : 2024/7/9 15:35:04
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    /**
 * 实现项目经理处理聚餐费用申请的对象
 */
    public class ProjectManager : Handler
    {
        public override Object handleRequest(RequestModel rm)
        {
            if (FeeRequestModel.FEE_TYPE == (rm.getType()))
            {
                //表示聚餐费用申请
                return handleFeeRequest(rm);
            }
            else
            {
                //其它的事由，项目经理暂时不想处理
                return base.handleRequest(rm);
            }
        }
        private Object handleFeeRequest(RequestModel rm)
        {
            //先把通用的对象造型回来 //非常不好！！！可以使用策略模式，分别实现
            FeeRequestModel frm = (FeeRequestModel)rm;
            String str = "";
            //项目经理的权限比较小，只能在500以内
            if (frm.getFee() < 500)
            {
                //为了测试，简单点，只同意小李的
                if ("小李" == (frm.getUser()))
                {
                    str = "项目经理同意" + frm.getUser() + "聚餐费用" + frm.getFee() + "元的请求";
                }
                else
                {
                    //其它人一律不同意
                    str = "项目经理不同意" + frm.getUser() + "聚餐费用" + frm.getFee() + "元的请求";
                }
                return str;
            }
            else
            {
                //超过500，继续传递给级别更高的人处理
                if (this.successor != null)
                {
                    return successor.handleRequest(rm);
                }
            }
            return str;
        }
    }

}

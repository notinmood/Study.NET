/**
 * @file   : ProjectFeeStrategy.cs
 * @date   : 2024/7/9 20:50:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    internal class DepFeeStrategy : ILocalHandleStrategy
    {
        public object LocalHandle(RequestModel model, Handler handler)
        {
            //先把通用的对象造型回来 
            FeeRequestModel frm = (FeeRequestModel)model;
            string str = "";
            //部门经理的权限只能在1000以内
            if (frm.getFee() < 1000)
            {
                //为了测试，简单点，只同意小李申请的
                if ("小李" == frm.getUser())
                {
                    str = "部门经理同意" + frm.getUser() + "聚餐费用" + frm.getFee() + "元的请求";
                }
                else
                {
                    //其它人一律不同意
                    str = "部门经理不同意" + frm.getUser() + "聚餐费用" + frm.getFee() + "元的请求";
                }
                return str;
            }
            else
            {
                //超过1000，继续传递给级别更高的人处理
                if (handler.GetSuccessor() != null)
                {
                    return handler.GetSuccessor().HandleRequest(model);
                }
            }

            return str;
        }
    }
}

/**
 * @file   : PredilectionAnalyzeVisitor.cs
 * @date   : 2024/8/1 15:43:30
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    /**
     * 具体的访问者，实现对客户的偏好分析
     */
    public class PredilectionAnalyzeVisitor : IVisitor
    {
        public void VisitEnterpriseCustomer(EnterpriseCustomer ec)
        {
            //根据过往购买的历史、潜在购买意向
            //以及客户所在行业的发展趋势、客户的发展预期等的分析
            Console.WriteLine("现在对企业客户" + ec.GetName() + "进行产品偏好分析");
        }

        public void VisitPersonalCustomer(PersonalCustomer pc)
        {
            Console.WriteLine("现在对个人客户" + pc.GetName() + "进行产品偏好分析");
        }
    }

}

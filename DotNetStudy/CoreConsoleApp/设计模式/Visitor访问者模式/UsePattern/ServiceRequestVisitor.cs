/**
 * @file   : ServiceRequestVisitor.cs
 * @date   : 2024/8/1 15:42:55
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    /**
     * 具体的访问者，实现客户提出服务请求的功能
     */
    public class ServiceRequestVisitor : IVisitor
    {
        public void VisitEnterpriseCustomer(EnterpriseCustomer ec)
        {
            //企业客户提出的具体服务请求
            Console.WriteLine(ec.GetName() + "企业提出服务请求");
        }

        public void VisitPersonalCustomer(PersonalCustomer pc)
        {
            //个人客户提出的具体服务请求
            Console.WriteLine("客户" + pc.GetName() + "提出服务请求");
        }
    }
}

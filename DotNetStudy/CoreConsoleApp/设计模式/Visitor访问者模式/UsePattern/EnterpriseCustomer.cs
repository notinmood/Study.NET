/**
 * @file   : EnterpriseCustomer.cs
 * @date   : 2024/8/1 15:40:13
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    public class EnterpriseCustomer : Customer
    {
        private String linkman;

        private String linkTelephone;

        private String registerAddress;

        public override void accept(IVisitor visitor)
        {
            //回调访问者对象的相应方法
            visitor.VisitEnterpriseCustomer(this);
        }
    }
}

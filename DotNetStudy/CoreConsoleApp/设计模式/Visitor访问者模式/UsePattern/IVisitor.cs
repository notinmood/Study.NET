/**
 * @file   : Visitor.cs
 * @date   : 2024/8/1 15:39:26
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    /**
     * 访问者接口
     */
    public interface IVisitor
    {
        /**
         * 访问企业客户，相当于给企业客户添加访问者的功能
         * @param ec 企业客户的对象
         */
        public void VisitEnterpriseCustomer(EnterpriseCustomer ec);
        /**
         * 访问个人客户，相当于给个人客户添加访问者的功能
         * @param pc 个人客户的对象
         */
        public void VisitPersonalCustomer(PersonalCustomer pc);
    }
}

/**
 * @file   : PersonalCustomer.cs
 * @date   : 2024/8/1 15:41:27
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    public class PersonalCustomer : Customer
    {
        private String telephone;

        private int age;

        public override void accept(IVisitor visitor)
        {
            //回调访问者对象的相应方法
            visitor.VisitPersonalCustomer(this);
        }
    }
}

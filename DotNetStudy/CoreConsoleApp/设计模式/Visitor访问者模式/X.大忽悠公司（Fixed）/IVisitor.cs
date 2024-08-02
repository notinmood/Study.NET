/**
 * @file   : CorporateSlaveVisitor.cs
 * @date   : 2024/8/2 11:03:28
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司Fixed
{
    public interface IVisitor
    {
        void Visit(ICorporateSlave slave);

        //void Visit(HumanResource humanResource);

        //void Visit(Sales sales);
    }
}

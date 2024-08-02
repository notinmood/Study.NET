/**
 * @file   : CorporateSlaveVisitor.cs
 * @date   : 2024/8/2 11:03:28
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司NG
{
    public interface IVisitor
    {
        ////为虚类CorporateSlave添加一个不会调用到的方法（仅仅为了编译通过）。
        void Visit(CorporateSlave slave);

        void Visit(Programmer programmer);

        void Visit(HumanResource humanResource);

        void Visit(Sales sales);
    }
}

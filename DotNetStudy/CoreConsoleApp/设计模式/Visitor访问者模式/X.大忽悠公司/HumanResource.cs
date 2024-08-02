/**
 * @file   : HumanResource.cs
 * @date   : 2024/8/2 11:06:47
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司
{
    public class HumanResource : ICorporateSlave
    {
        private readonly string name;

        public HumanResource(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

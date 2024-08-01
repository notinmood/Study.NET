/**
 * @file   : Customer.cs
 * @date   : 2024/8/1 15:37:55
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    public abstract class Customer
    {
        private string customerId;

        private string name;


        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        /**
        * 接受访问者的访问
        * @param visitor 访问者对象
        */
        public abstract void accept(IVisitor visitor);
    }
}

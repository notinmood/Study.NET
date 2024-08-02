/**
 * @file   : Tester.cs
 * @date   : 2024/8/2 11:05:46
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司
{
    public class Sales : ICorporateSlave
    {
        private readonly string name;

        public Sales(string name)
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

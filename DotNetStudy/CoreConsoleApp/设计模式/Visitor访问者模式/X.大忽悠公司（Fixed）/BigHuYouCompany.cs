/**
 * @file   : BigHuYouCompany.cs
 * @date   : 2024/8/2 11:08:49
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司Fixed
{
    public class BigHuYouCompany
    {
        private readonly List<ICorporateSlave> employees = new List<ICorporateSlave>();

        public BigHuYouCompany()
        {
            employees.Add(new Programmer("王二狗"));
            employees.Add(new HumanResource("上官无需"));
            employees.Add(new Sales("牛翠花"));
        }

        public void startProject(IVisitor visitor)
        {
            foreach (var employee in employees)
            {
                //employee.Accept(visitor);
                visitor.Visit(employee);
            }
        }
    }
}

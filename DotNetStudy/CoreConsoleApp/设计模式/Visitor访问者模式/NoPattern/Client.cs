/**
 * @file   : Client.cs
 * @date   : 2024/8/1 15:08:19
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.NoPattern
{
    public static class Client
    {
        public static void Index()
        {
            //准备点测试数据
            IList<Customer> customers = PreparedTestData();

            //循环对客户进行操作
            foreach (var item in customers)
            {
                //进行偏好分析
                item.predilectionAnalyze();
                //进行价值分析
                item.worthAnalyze();
            }
        }
        private static IList<Customer> PreparedTestData()
        {
            IList<Customer> colCustomer = new List<Customer>();
            //为了测试方便，准备点数据
            Customer cm1 = new EnterpriseCustomer();
            cm1.SetName("ABC集团");
            colCustomer.Add(cm1);

            Customer cm2 = new EnterpriseCustomer();
            cm2.SetName("CDE公司");
            colCustomer.Add(cm2);

            Customer cm3 = new PersonalCustomer();
            cm3.SetName("张三");
            colCustomer.Add(cm3);

            return colCustomer;
        }
    }
}

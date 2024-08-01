/**
 * @file   : PersonalCustomer.cs
 * @date   : 2024/8/1 15:07:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.NoPattern
{
    public class PersonalCustomer : Customer
    {
        private string telephone;

        private int age;

        public override void serviceRequest()
        {
            //个人客户提出的具体服务请求
            Console.WriteLine("客户" + this.GetName() + "提出服务请求");
        }

        /**
         * 个人客户对公司产品的偏好分析，示意一下
         */
        public override void predilectionAnalyze()
        {
            Console.WriteLine("现在对个人客户" + this.GetName() + "进行产品偏好分析》》》");
        }

        /**
         * 个人客户价值分析，示意一下
         */
        public override void worthAnalyze()
        {
            Console.WriteLine("现在对个人客户" + this.GetName() + "进行价值分析》》》");
        }
    }

}

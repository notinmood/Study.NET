/**
 * @file   : EnterpriseCustomer.cs
 * @date   : 2024/8/1 15:07:32
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.NoPattern
{
    public class EnterpriseCustomer : Customer
    {

        private string linkman;

        private string linkTelephone;

        private string registerAddress;

        public override void serviceRequest()
        {
            //企业客户提出的具体服务请求
            Console.WriteLine(this.GetName() + "企业提出服务请求");
        }

        /**
         * 企业客户对公司产品的偏好分析，示意一下
         */
        public override void predilectionAnalyze()
        {
            //根据过往购买的历史、潜在购买意向
            //以及客户所在行业的发展趋势、客户的发展预期等的分析
            Console.WriteLine("现在对企业客户" + this.GetName() + "进行产品偏好分析XXX");
        }

        /**
         * 企业客户价值分析，示意一下
         */
        public override void worthAnalyze()
        {
            //根据购买的金额大小、购买的产品和服务的多少、购买的频率等进行分析
            //企业客户的标准会比个人客户的高
            Console.WriteLine("现在对企业客户" + this.GetName() + "进行价值分析XXX");
        }
    }
}

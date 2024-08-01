/**
 * @file   : Customer.cs
 * @date   : 2024/8/1 15:06:48
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.NoPattern
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

        public abstract void serviceRequest();

        /**
         * 客户对公司产品的偏好分析，示意一下
         */
        public abstract void predilectionAnalyze();
        /**
         * 客户价值分析，示意一下
         */
        public abstract void worthAnalyze();
    }

}

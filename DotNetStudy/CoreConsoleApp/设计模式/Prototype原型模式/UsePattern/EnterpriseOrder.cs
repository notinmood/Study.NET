/**
 * @file   : EnterpriseOrder.cs
 * @date   : 2024/7/7 17:49:21
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Prototype原型模式.UsePattern
{
    /**
   * 企业订单对象
   */
    public class EnterpriseOrder : IOrder
    {
        /**
         * 企业名称
         */
        private string enterpriseName;
        /**
         * 产品编号
         */
        private string productId;
        /**
         * 订单产品数量
         */
        private int orderProductNum = 0;

        public int GetOrderProductNum()
        {
            return this.orderProductNum;
        }
        public void SetOrderProductNum(int num)
        {
            this.orderProductNum = num;
        }
        public string GetEnterpriseName()
        {
            return enterpriseName;
        }
        public void SetEnterpriseName(string enterpriseName)
        {
            this.enterpriseName = enterpriseName;
        }
        public string GetProductId()
        {
            return productId;
        }
        public void SetProductId(String productId)
        {
            this.productId = productId;
        }
        public override string ToString()
        {
            return "本企业订单的订购企业是=" + this.enterpriseName + "，订购产品是=" + this.productId + "，订购数量为=" + this.orderProductNum;
        }


        public IOrder Clone()
        {
            //创建一个新的订单，然后把本实例的数据复制过去
            EnterpriseOrder order = new EnterpriseOrder();
            order.SetEnterpriseName(this.enterpriseName);
            order.SetProductId(this.productId);
            order.SetOrderProductNum(this.orderProductNum);
            return order;
        }
    }
}

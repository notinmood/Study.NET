

using System.Reflection.Metadata.Ecma335;

/**
 * @file   : PersonalOrder.cs
 * @date   : 2024/7/7 17:48:33
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.Prototype原型模式.UsePattern
{
    /**
   * 个人订单对象
   */
    public class PersonalOrder : IOrder
    {
        /**
         * 订购人员姓名
         */
        private string customerName;
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
        public string GetCustomerName()
        {
            return customerName;
        }
        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        public string GetProductId()
        {
            return productId;
        }
        public void SetProductId(string productId)
        {
            this.productId = productId;
        }
        public override string ToString()
        {
            return "本个人订单的订购人是=" + this.customerName + "，订购产品是=" + this.productId + "，订购数量为=" + this.orderProductNum;
        }


        public IOrder Clone()
        {
            //创建一个新的订单，然后把本实例的数据复制过去
            PersonalOrder order = new PersonalOrder();
            order.SetCustomerName(this.customerName);
            order.SetProductId(this.productId);
            order.SetOrderProductNum(this.orderProductNum);

            return order;
        }
    }
}

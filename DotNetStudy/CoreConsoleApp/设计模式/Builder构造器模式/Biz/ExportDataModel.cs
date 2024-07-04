using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式.Biz
{
    /**
   * 描述输出数据的对象
   */
    public class ExportDataModel
    {
        /**
         * 产品编号
         */
        private string productId;
        /**
         * 销售价格
         */
        private double price;
        /**
         * 销售数量
         */
        private double amount;

        public string getProductId()
        {
            return productId;
        }
        public void setProductId(string productId)
        {
            this.productId = productId;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getAmount()
        {
            return amount;
        }
        public void setAmount(double amount)
        {
            this.amount = amount;
        }
    }
}

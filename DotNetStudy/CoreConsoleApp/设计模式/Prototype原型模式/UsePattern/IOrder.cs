/**
 * @file   : OrderApi.cs
 * @date   : 2024/7/7 17:47:37
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Prototype原型模式.UsePattern
{
    /**
   * 订单的接口
   */
    public interface IOrder
    {
        /**
         * 获取订单产品数量
         * @return 订单中产品数量
         */
        public int GetOrderProductNum();

        /**
         * 设置订单产品数量
         * @param num 订单产品数量
         */
        public void SetOrderProductNum(int num);


        public IOrder Clone();
       
        
    }

}

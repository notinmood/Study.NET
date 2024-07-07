﻿

using System;

/**
 * @file   : OrderBusiness.cs
 * @date   : 2024/7/7 17:50:22
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.Prototype原型模式.UsePattern
{
    /**
   * 处理订单的业务对象
   */
    public class OrderBusiness
    {
        /**
         * 创建订单的方法
         * @param order 订单的接口对象
         */
        public void DealOrder(IOrder order)
        {
            //根据业务要求，当订单预定产品数量超过1000时，就要把订单拆成两份订单
            //当然如果要做好，这里的1000应该做成常量，这么做是为了演示简单

            //1：判断当前的预定产品数量是否大于1000
            while (order.GetOrderProductNum() > 1000)
            {
                //1：判断当前的预定产品数量是否大于1000
                while (order.GetOrderProductNum() > 1000)
                {
                    //2：如果大于，还需要继续拆分
                    //2.1再新建一份订单，跟传入的订单除了数量不一样外，其它都相同
                    IOrder newOrder = order.Clone();
                    //然后进行赋值，产品数量为1000
                    newOrder.SetOrderProductNum(1000);

                    //2.2原来的订单保留，把数量设置成减少1000
                    order.SetOrderProductNum(order.GetOrderProductNum() - 1000);

                    //然后是业务功能处理，省略了，打印输出，看一下
                    Console.WriteLine("拆分生成订单==" + newOrder);
                }
                //3：不超过，那就直接业务功能处理，省略了，打印输出，看一下
                Console.WriteLine("订单==" + order);
                
            }
        }
    }
}
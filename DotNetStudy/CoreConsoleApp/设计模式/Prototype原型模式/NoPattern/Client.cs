﻿/**
 * @file   : Client.cs
 * @date   : 2024/7/7 17:58:26
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Prototype原型模式.NoPattern
{
    internal class Client
    {
        public static void Index()
        {
            //创建订单对象，这里为了演示简单，直接new了
            PersonalOrder op = new PersonalOrder();
            //设置订单数据
            op.SetOrderProductNum(2925);
            op.SetCustomerName("张三");
            op.SetProductId("P0001");

            //这里获取业务处理的类，也直接new了，为了简单，连业务接口都没有做
            OrderBusiness ob = new OrderBusiness();
            //调用业务来保存订单对象
            ob.DealOrder(op);
        }
    }
}

/**
 * @file   : Client.cs
 * @date   : 2024/7/22 11:21:10
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.配置文件中自定义内容.嵌套的复合节点
{
    internal static class Client
    {
        public static void Index()
		{
            OrdersSection config = (OrdersSection)ConfigurationManager.GetSection("orders");
            Console.WriteLine(config);
            Console.WriteLine(config.Orders);
            Console.WriteLine(config.Orders.Count);
            Console.WriteLine(config.Orders[0].Amount);
            Console.WriteLine(config.Orders[0].LineItems[0].Number);
        }
    }
}

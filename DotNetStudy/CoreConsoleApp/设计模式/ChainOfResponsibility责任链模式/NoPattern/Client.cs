/**
 * @file   : Client.cs
 * @date   : 2024/7/9 7:42:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.NoPattern
{
    public class Client
    {
        public static void Index()
        {
            FeeRequest request = new FeeRequest();

            //开始测试
            string ret1 = request.requestToProjectManager("小李", 300);
            Console.WriteLine("the ret=" + ret1);
            string ret2 = request.requestToProjectManager("小张", 300);
            Console.WriteLine("the ret=" + ret2);

            string ret3 = request.requestToProjectManager("小李", 600);
            Console.WriteLine("the ret=" + ret3);
            string ret4 = request.requestToProjectManager("小张", 600);
            Console.WriteLine("the ret=" + ret4);

            string ret5 = request.requestToProjectManager("小李", 1200);
            Console.WriteLine("the ret=" + ret5);
            string ret6 = request.requestToProjectManager("小张", 1200);
            Console.WriteLine("the ret=" + ret6);
        }
    }
}

/**
 * @file   : Client.cs
 * @date   : 2024/7/9 7:56:22
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePattern
{
    public class Client
    {
        public static void Index()
        {
            //先要组装职责链   
            Handler h1 = new GeneralManager();
            Handler h2 = new DepManager();
            Handler h3 = new ProjectManager();
            h3.setSuccessor(h2);
            h2.setSuccessor(h1);

            //开始测试
            String ret1 = h3.handleFeeRequest("小李", 300);
            Console.WriteLine("the ret1=" + ret1);
            String ret2 = h3.handleFeeRequest("小张", 300);
            Console.WriteLine("the ret2=" + ret2);

            String ret3 = h3.handleFeeRequest("小李", 600);
            Console.WriteLine("the ret3=" + ret3);
            String ret4 = h3.handleFeeRequest("小张", 600);
            Console.WriteLine("the ret4=" + ret4);

            String ret5 = h3.handleFeeRequest("小李", 1200);
            Console.WriteLine("the ret5=" + ret5);
            String ret6 = h3.handleFeeRequest("小张", 1200);
            Console.WriteLine("the ret6=" + ret6);
        }
    }

}



using System;

/**
 * @file   : Client.cs
 * @date   : 2024/7/9 22:53:21
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.ChainOfResponsibility责任链模式.UsePatternBetter
{
    internal class Client
    {
        public static void Index()
        {
            //先要组装职责链   
            Handler h1 = new GeneralManager();
            Handler h2 = new DepManager();
            Handler h3 = new ProjectManager();
            h3.SetSuccessor(h2);
            h2.SetSuccessor(h1);

            //开始测试
            FeeRequestModel frm1 = new FeeRequestModel("小李", 1000);
            object ret1 = h3.HandleRequest(frm1);
            Console.WriteLine(">>> the ret1=" + ret1);

            FeeRequestModel frm2 = new FeeRequestModel("小张", 300);
            object ret2 = h3.HandleRequest(frm2);
            Console.WriteLine(">>> the ret2=" + ret2);
        }
    }
}

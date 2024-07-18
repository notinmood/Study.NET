/**
 * @file   : Client.cs
 * @date   : 2024/7/12 7:27:02
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.NoPattern
{
    internal class Client
    {
        public static void Index()
        {
            NormalLoginModel normalLoginModel = new NormalLoginModel();
            normalLoginModel.SetUserId("1");
            normalLoginModel.SetPwd("123");

            NormalLogin normalLogin = new NormalLogin();
            bool normalResult = normalLogin.Login(normalLoginModel);
            if (normalResult)
            {
                Console.WriteLine("✔前端用户登录成功！");
            }
            else
            {
                Console.WriteLine("❌前端用户登录失败！");
            }

            WorkerLoginModel workerLoginModel = new WorkerLoginModel();
            workerLoginModel.SetWorkerId("1");
            workerLoginModel.SetPwd("worker1");

            WorkerLogin workerLogin = new WorkerLogin();
            bool workerResult = workerLogin.Login(workerLoginModel);
            if (workerResult)
            {
                Console.WriteLine("✔内部员工登录成功！");
            }
            else
            {
                Console.WriteLine("❌内部员工登录失败！");
            }
        }
    }
}

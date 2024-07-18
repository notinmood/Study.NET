/**
 * @file   : Client.cs
 * @date   : 2024/7/12 8:22:34
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.UsePattern
{
    public class Client
    {
        public static void Index()
        {
            //准备登录人的信息
            LoginModel lm = new LoginModel();
            lm.SetLoginId("admin");
            lm.SetPwd("workerpwd");

            //准备用来进行判断的对象
            LoginTemplate lt1 = new WorkerLogin();
            LoginTemplate lt2 = new NormalLogin();

            //进行登录测试
            bool flag = lt1.Login(lm);
            Console.WriteLine("可以登录工作平台=" + flag);

            bool flag2 = lt2.Login(lm);
            Console.WriteLine("可以进行普通人员登录=" + flag2);
        }
    }

}

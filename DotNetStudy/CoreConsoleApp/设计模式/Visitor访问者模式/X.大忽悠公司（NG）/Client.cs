

using System;

/**
 * @file   : Client.cs
 * @date   : 2024/8/2 11:21:25
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司NG
{
    public static class Client
    {
        public static void Index()
        {
            BigHuYouCompany bigHuYou = new BigHuYouCompany();
            //可以很轻松的更换Visitor，但是要求BigHuYouCompany的结构稳定
            Console.WriteLine("-----------------启动社交APP项目--------------------");
            bigHuYou.startProject(new SocialAppVisitor());
            Console.WriteLine("-----------------启动短视频APP项目--------------------");
            bigHuYou.startProject(new LiveAppVisitor());
        }
    }
}

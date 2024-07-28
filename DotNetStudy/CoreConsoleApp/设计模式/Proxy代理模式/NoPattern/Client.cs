/**
 * @file   : Client.cs
 * @date   : 2024/7/27 21:06:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using CoreConsoleApp.设计模式.Proxy代理模式.Biz;

namespace CoreConsoleApp.设计模式.Proxy代理模式.NoPattern
{
    public static class Client
    {
        public static void Index()
        {
            UserManager userManager = new UserManager();
            List<UserModel> col = userManager.getUserByDepId("0101");
            foreach (var item in col)
            {
                Console.WriteLine(item);
            }
        }
    }
}

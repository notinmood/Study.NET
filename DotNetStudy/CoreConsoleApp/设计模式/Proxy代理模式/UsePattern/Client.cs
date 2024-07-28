/**
 * @file   : Client.cs
 * @date   : 2024/7/28 10:53:45
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using CoreConsoleApp.设计模式.Proxy代理模式.Biz;

namespace CoreConsoleApp.设计模式.Proxy代理模式.UsePattern
{
    public static class Client
    {
        public static void Index()
        {
            UserManager userManager = new UserManager();
            IList<IUserModel> col = userManager.GetUserByDepId("0101");

            //如果只是显示用户名称，那么不需要重新查询数据库
            foreach (var item in col)
            {
                Console.WriteLine("用户编号：=" + item.GetUserId() + ",用户姓名：=" + item.GetName());
            }

            //如果访问用户所在部门名称的属性，那就会重新查询数据库
            foreach (var item in col)
            {
                Console.WriteLine("用户编号：=" + item.GetUserId() + ",用户姓名：=" + item.GetName() + ",所属部门：=" + item.GetDepName() + $" ({item.GetDepDesc()})");
            }
        }
    }

}

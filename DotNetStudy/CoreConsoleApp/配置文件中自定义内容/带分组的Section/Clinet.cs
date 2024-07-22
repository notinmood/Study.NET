/**
 * @file   : Clinet.cs
 * @date   : 2024/7/22 11:57:36
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

namespace CoreConsoleApp.配置文件中自定义内容.带分组的Section
{
    internal static class Clinet
    {
        public static void Index()
		{
            MyGroupedSection config = (MyGroupedSection)ConfigurationManager.GetSection("myGroup/myGroupedSection");
            Console.WriteLine("用户名:" + config.User.ToString() + "; 密码:" + config.PassWord.ToString() + "; 元素属性:" + config.Element.Element1.ToString() + config.Element.Element2.ToString());
        }
    }
}

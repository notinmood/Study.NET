/**
 * @file   : FileName.cs
 * @date   : 2024/7/10 17:48:53
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

namespace CoreConsoleApp.配置文件中自定义内容.最简方式
{
    internal class Client
    {
        public static void Index()
		{
            MySimpleSection myCustomConfig = ConfigurationManager.GetSection("MySimpleSection") as MySimpleSection;

            if (myCustomConfig != null)
            {
                Console.WriteLine("mySetting: " + myCustomConfig.MySetting);
            }
        }
    }
}

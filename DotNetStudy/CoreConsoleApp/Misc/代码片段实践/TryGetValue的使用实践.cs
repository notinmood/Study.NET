/**
 * @file   : TryGet.cs
 * @date   : 2024/7/28 16:34:50
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.Misc.代码片段实践
{
    internal static class TryGetValue的使用实践
    {
        public static void MyMethod()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["b"] = "beijing";
            dict["s"] = "shanghai";
            dict["q"] = "qingdao";

            if (!dict.TryGetValue("w", out string valueGotten))
            {
                valueGotten = default(string);
            }

            Console.WriteLine(valueGotten);
        }
    }
}

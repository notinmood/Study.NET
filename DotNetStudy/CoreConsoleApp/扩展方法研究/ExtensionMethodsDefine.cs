/**
 * @file   : ExtensionMethods.cs
 * @date   : 2024/7/14 16:38:50
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.扩展方法研究
{
    public static class ExtensionMethodsDefine
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

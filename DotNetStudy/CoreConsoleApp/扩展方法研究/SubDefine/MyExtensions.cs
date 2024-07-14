/**
 * @file   : MyExtensions.cs
 * @date   : 2024/7/14 16:48:53
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.扩展方法研究.SubDefine
{
    public static class MyExtensions
    {
         /// <summary>
         /// 通过出生年，计算年龄
         /// </summary>
         /// <param name="birthYear"></param>
         /// <returns></returns>
        public static int CalcAge(this int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }
    }
}

/**
 * @file   : Client.cs
 * @date   : 2024/7/14 16:56:39
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
//以下命名空间内定义了对int进行扩展的方法CalcAge(),
//如果不引入这个命名空间，下面代码中 birthYear.CalcAge()会无法通过编译。
using CoreConsoleApp.扩展方法研究.SubDefine;

namespace CoreConsoleApp.扩展方法研究
{
    internal class Client
    {
        public static void Index()
        {
            string sentence = "I love China。";
            Console.WriteLine(sentence.WordCount());

            int birthYear = 2008;
            Console.WriteLine(birthYear.CalcAge());
        }
    }
}

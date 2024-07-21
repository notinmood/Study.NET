/**
 * @file   : _1.cs
 * @date   : 2024/7/20 8:30:16
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.协变和逆变研究.泛型委托的协变逆变研究
{
    /// <summary>
    /// 非泛型委托
    /// </summary>
    /// <param name="input"></param>
    public delegate void MyActionNo(string input);

    internal static class 非泛型委托的使用
    {
        public static void Index()
        {
            Console.WriteLine("start!");

            //1.1. 实例化委托类型的变量
            //（方法就是委托类型的实例；因为方法的签名有 N 多，因此委托类型也有 N 多；
            //某一种签名的方法，就对应一种类型的委托类型。）
            MyActionNo myFunc = new MyActionNo(Utils.DisplayInformation);
            // 以下两种简写都可以
            //MyActionNo myFunc = new (Biz.DisplayInformation);
            //MyActionNo myFunc = Biz.DisplayInformation;

            //1.2. 调用
            myFunc("zhangsan");

            //以下无法编译通过。因为委托是什么类型的参数签名，就要给委托的实例方法传递什么类型的参数。
            //myFunc(123);
        }
    }
}

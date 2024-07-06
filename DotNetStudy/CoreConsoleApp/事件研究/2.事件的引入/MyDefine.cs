/**
 * @file   : 入门.cs
 * @date   : 2024/7/6 9:28:38
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.事件研究._2.事件的引入
{
    public class MyDefine
    {
        //1. 定义委托
        public delegate int MyDelegate(string s);

        //2. 使用委托和event关键字定义事件
        public event MyDelegate MyEventHandler;
    }
}

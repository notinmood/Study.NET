/**
 * @file   : Reader.cs
 * @date   : 2024/7/5 11:50:27
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Observer观察者模式.推模式
{
    public class Reader : IObserver
    {
        /**
         * 读者的姓名
         */
        private string name;

        public Reader(string name)
        {
            this.name = name;
        }

        public void Update(string content)
        {
            //这是采用推的方式
            Console.WriteLine(name + "收到报纸了，阅读先。内容是===" + content);
        }
        public string GetName()
        {
            return name;
        }
    }
}

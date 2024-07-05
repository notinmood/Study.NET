/**
 * @file   : Reader.cs
 * @date   : 2024/7/5 10:17:30
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Observer观察者模式.拉模式
{
    /**
     * 真正的读者，为了简单就描述一下姓名
     */
    public class Reader : Observer
    {
        /**
         * 读者的姓名
         */
        private string name;

        public Reader(string name)
        {
            this.name = name;
        }

        public void update(Subject subject)
        {
            //这是采用拉的方式
            Console.WriteLine(name + "收到报纸了，阅读先。内容是===" + ((NewsPaper)subject).getContent());
        }

        public string getName()
        {
            return name;
        }
    }
}

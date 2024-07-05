/**
 * @file   : Client.cs
 * @date   : 2024/7/5 10:22:16
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Observer观察者模式.拉模式
{
    public class Client
    {
        public static void main(String[] args)
        {
            //创建一个报纸，作为被观察者
            NewsPaper subject = new();

            //创建阅读者，也就是观察者
            Reader reader1 = new Reader("张三");
            Reader reader2 = new Reader("李四");
            Reader reader3 = new Reader("王五");

            //注册阅读者
            subject.Attach(reader1);
            subject.Attach(reader2);
            subject.Attach(reader3);

            //要出报纸啦
            subject.SetContent("本期内容是观察者模式");
        }
    }

}

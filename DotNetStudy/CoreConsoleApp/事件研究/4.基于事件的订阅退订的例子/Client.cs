/**
 * @file   : Client.cs
 * @date   : 2024/7/6 11:44:39
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.事件研究._4.基于事件的订阅退订的例子
{
    internal class Client
    {
        public static void Index()
        {
            Cat cat = new Cat();
            Console.WriteLine("=========原始做法：耦合性太强，猫类只是叫了一声，其他的动作与猫没有多大关系，不应该写在猫类里==========");
            {
                cat.Miao();
            }

            //使用委托，订阅者就可以使用 = 来对委托对象重新赋值（其它订阅者全部被取消订阅），甚至将其设置为null，甚至订阅者还可以直接调用委托，这些都是很危险的操作，广播者就失去了独享控制权
            Console.WriteLine("=========基于委托的做法： 基于委托实现，缺陷是：外部可以=null,不安全，将其他的订阅者消息给覆盖了===========");
            {
                //订阅事件
                cat.MiaoAction += new Mouse().run;
                cat.MiaoAction += new Dog().Wang;
                cat.MiaoAction += new Baby().cry;
                cat.MiaoAction += new Mom().clap;
                //触发事件
                cat.UseMiaoAct();
                Console.WriteLine("=========给委托赋值null，直接清空了观察者队列===========");
                cat.MiaoAction = null;
                cat.UseMiaoAct();
            }

            //事件有一系列规则和约束用以保证程序的安全可控，事件只有 += 和 -= 操作，这样订阅者只能有订阅或取消订阅操作，没有权限执行其它操作,事件保证了程序的安全性和健壮性
            Console.WriteLine("=========使用事件,推荐用法===========");
            {
                Baby baby = new Baby();
                Mom mom = new Mom();

                //订阅事件
                cat.MiaoEvent += new Mouse().run;
                cat.MiaoEvent += new Dog().Wang;
                cat.MiaoEvent += baby.cry;
                cat.MiaoEvent += mom.clap;
                //触发事件
                cat.UseMiaoEvent();
                Console.WriteLine("============取消订阅：-= new Baby().cry;-= new Mom().clap;=================");
                //取消订阅
                cat.MiaoEvent -= baby.cry;
                cat.MiaoEvent -= mom.clap;
                cat.UseMiaoEvent();
            }

            Console.Read();

        }
    }
}
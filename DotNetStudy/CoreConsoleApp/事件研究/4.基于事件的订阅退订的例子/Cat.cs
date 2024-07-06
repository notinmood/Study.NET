/**
 * @file   : Cat.cs
 * @date   : 2024/7/6 11:42:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.事件研究._4.基于事件的订阅退订的例子
{
    internal class Cat
    {
        /// <summary>
        /// 耦合性太强，猫类只是叫了一声，其他的动作与猫没有多大关系，不应该写在猫类里
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("小猫喵的一声....");
            new Mouse().run();
            new Dog().Wang();
            new Baby().cry();
            new Mom().clap();
        }

        public Action MiaoAction;
        /// <summary>
        /// 基于委托实现，缺陷是：外部可以=null,不安全，将其他的订阅者消息给覆盖了
        /// </summary>
        public void UseMiaoAct()
        {
            Console.WriteLine("小猫喵的一声....");
            if (MiaoAction != null)
            {
                MiaoAction.Invoke();
            }
        }

        public event Action MiaoEvent;
        /// <summary>
        /// 基于事件实现，最推荐的写法
        /// </summary>
        public void UseMiaoEvent()
        {
            Console.WriteLine("小猫喵的一声....");
            if (MiaoEvent != null)
            {
                MiaoEvent.Invoke();
            }
        }
    }
}

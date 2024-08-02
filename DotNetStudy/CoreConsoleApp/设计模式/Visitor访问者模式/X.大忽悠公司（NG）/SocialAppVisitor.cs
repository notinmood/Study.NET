/**
 * @file   : SocialApp.cs
 * @date   : 2024/8/2 11:18:18
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司NG
{
    public class SocialAppVisitor : IVisitor
    {
        public void Visit(CorporateSlave slave)
        {
            // do nothing;
        }

        public void Visit(Programmer programmer)
        {
            Console.WriteLine($"{programmer.getName()}: 给你一个月，先仿照微信搞个类似的APP出来,要能语音能发红包,将来公司上市了少不了你的，好好干...");
        }

        public void Visit(HumanResource humanResource)
        {
            Console.WriteLine($"{humanResource.getName()}: 咱现在缺人，你暂时就充当了陪聊吧，在程序员开发APP期间，你去发发软文，积攒点粉丝...");
        }

        public void Visit(Tester tester)
        {
            Console.WriteLine($"{tester.getName()}:  这是咱创业的第一炮，一定要打响，测试不能掉链子啊，不能让APP带伤上战场，以后给你多招点人，你就是领导了...");
        }
    }
}

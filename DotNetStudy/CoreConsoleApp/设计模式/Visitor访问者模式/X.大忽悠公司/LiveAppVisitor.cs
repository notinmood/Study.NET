/**
 * @file   : LiveApp.cs
 * @date   : 2024/8/2 11:19:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司
{
    public class LiveAppVisitor : IVisitor
    {
        public void Visit(Programmer programmer)
        {
            Console.WriteLine($"{programmer.GetName()}: 最近小视频很火啊，咱能不能抄袭下抖音，搞他一炮,将来公司上市了，你的身价至少也是几千万，甚至上亿...");
        }

        public void Visit(HumanResource humanResource)
        {
            Console.WriteLine($"{humanResource.GetName()}: 咱公司就数你长得靓，哪天化化妆，把你的事业线适当露一露，要是火了你在北京买房都不是梦...");
        }

        public void Visit(Sales sales)
        {
            Console.WriteLine($"{sales.GetName()}: 你也开个账户，边测试边直播，两不耽误...");
        }
    }
}

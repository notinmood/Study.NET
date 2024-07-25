/**
 * @file   : HouseOwner.cs
 * @date   : 2024/7/25 14:21:12
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.房屋中介的例子
{
    //具体同事类 房屋拥有者
    public class HouseOwner : Person
    {
        public HouseOwner(string name, IMediator mediator) : base(name, mediator)
        {

        }

        //与中介者联系
        public void Constact(string message)
        {
            mediator.Constact(message, this);
        }

        //获取信息
        public void GetMessage(string message)
        {
            Console.WriteLine("房主" + name + "获取到的信息：" + message);
        }
    }
}

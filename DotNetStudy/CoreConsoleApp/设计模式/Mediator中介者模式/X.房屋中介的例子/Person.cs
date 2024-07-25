/**
 * @file   : Person.cs
 * @date   : 2024/7/25 14:20:20
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.房屋中介的例子
{

    //抽象同事类
    public abstract class Person
    {
        protected string name;
        protected IMediator mediator;
        protected Person(string name, IMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }
    }
}

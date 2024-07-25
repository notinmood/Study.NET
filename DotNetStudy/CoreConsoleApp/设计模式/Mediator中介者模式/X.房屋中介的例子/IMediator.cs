/**
 * @file   : Mediator.cs
 * @date   : 2024/7/25 14:23:26
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Mediator中介者模式.X.房屋中介的例子
{
    //抽象中介者
    public interface IMediator
    {
        //申明一个联络方法
        void Constact(string message, Person person);
    }
}

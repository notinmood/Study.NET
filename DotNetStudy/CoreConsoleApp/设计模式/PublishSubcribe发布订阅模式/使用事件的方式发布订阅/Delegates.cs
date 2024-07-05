/**
 * @file   : Delegates.cs
 * @date   : 2024/7/5 20:21:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.使用事件的方式发布订阅
{
    // 定义一个委托类型，它确定了事件处理程序的方法签名
    //( 要用来定义事件的委托，通常其名称以“Handler”结尾)
    public delegate void MyEventHandler(string message);
}

/**
 * @file   : _1.cs
 * @date   : 2024/7/20 8:30:16
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using CoreConsoleApp.协变和逆变研究.Biz;

#pragma warning disable
namespace CoreConsoleApp.协变和逆变研究.泛型委托的协变逆变研究
{
    /// <summary>
    /// 不支持协变逆变的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="param"></param>
    public delegate void MyActionWithParam<T>(T param);//不支持逆变与协变的委托
    public delegate T MyActionWithParamAndResult<T>(T param);//不支持逆变与协变的委托

    internal static class 使用不带协变逆变功能的泛型委托
    {
        public static void Index()
        {
            Console.WriteLine("start!");

            //1. 用string实例化泛型委托
            //1.1. 创建委托实例
            MyActionWithParam<string> myActionString = new(Utils.DisplayInformation);
            //1.2. 调用委托实例
            myActionString("qingdao");


            //2. 用object实例化泛型委托
            //2.1. 创建委托实例
            MyActionWithParam<object> myActionObject = new MyActionWithParam<object>(Utils.DealInput<object>);
            ////以下写法都可以，Utils.DealInput 能自动推断为 Utils.DealInput<object>
            //MyActionWithParam<object> myActionObject2 = new MyActionWithParam<object>(Utils.DealInput);
            //MyActionWithParam<object> myActionObject3 = new(Utils.DealInput<object>);
            //MyActionWithParam<object> myActionObject4 = new(Utils.DealInput);
            //MyActionWithParam<object> myActionObject5 = Utils.DealInput<object>;
            //MyActionWithParam<object> myActionObject6 = Utils.DealInput;

            //2.2. 调用委托实例(不涉及到泛型结构对象的替换)
            myActionObject("qingdao");
            myActionObject(123);

            //2.3. 调用委托实例(涉及到泛型结构对象的替换)
            /**
             * 以下两种替换都不会成功，因为这两个实例所属的泛型结构的类型
             * MyActionWithParam<object>和MyActionWithParam<string>
             * 可以理解为他们都是MyActionWithParam<T>的子类，
             * 他们之间是兄弟关系，非继承关系，因此不满足李氏替换原则。
             */
            //myActionObject = myActionString;
            //myActionString = myActionObject;
            //myActionObject("qingdao");
            //myActionString("qingdao");


            //3.不带逆变协变的泛型委托使用，另外的例子
            MyActionWithParamAndResult<object> myActionPR = new MyActionWithParamAndResult<object>(Utils.DealInputOutput);
            object o = myActionPR(123);
            Console.WriteLine($"返回值为：{o}");

            //4. 使用不具备协变逆变能力的委托，更多的例子
            //4.0. 使用不具备协变逆变能力的委托，其不能将有派生关系的泛型参数声明的委托赋给目标类型声明的委托。
            MyActionWithParam<B> myActionB = new(Utils.DealInput);
            MyActionWithParam<A> myActionA = new(Utils.DealInput);
            MyActionWithParam<C> myActionC = new(Utils.DealInput);

            //4.1 以下演示实例化委托后的变量相互赋值
            //// 以下赋值都会出现问题。
            //myActionB = myActionC;
            //myActionB = myActionA;

            /** 说明：
             * 委托 MyActionCommon<A>、MyActionCommon<C> 没有从 MyActionCommon<B> 派生，
             * 相反这几个委托对象是同级的，他们从 MyActionCommon<T> 类型派生，后者又派生自object类型。
             * （其中 T 是一个未指定类型的泛型表述；而 A、B、C 是具体定义出的类型。）
             * MyActionCommon<A>、MyActionCommon<C>、MyActionCommon<B>没有相互之间的派生关系，因此赋值兼容性不适用。
             */


            //4.2 以下演示将泛型类型 T 进行实例化（实例化T的时候不涉及协变逆变）
            myActionB(new B());
            myActionB(new C());
            ////以下无法编译通过
            //myActionB(new A());
        }
    }
}

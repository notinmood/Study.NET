using System;
using CoreConsoleApp.协变和逆变研究.Biz;

namespace CoreConsoleApp.协变和逆变研究.泛型接口的协变逆变研究
{
    internal class QuickerIn
    {
        public interface IBase<in T>
        {
            void Test(T param);
        }

        public class Sub<T> : IBase<T>
        {
            public void Test(T param)
            {
                Console.WriteLine("do something");
            }
        }


#pragma warning disable

        public static void Index()
        {
            //1. 创建泛型接口的实例对象
            IBase<string> myBaseString = new Sub<string>();
            IBase<object> myBaseObject = new Sub<object>();

            //2. 直接调用实例对象的方法
            myBaseString.Test("qingdao");
            myBaseObject.Test("qingdao");
            myBaseObject.Test(true);

            //3. 两种不同的实例对象，交换赋值
            //myBaseObject = myBaseString; //这种赋值行不通
            myBaseString = myBaseObject; //这个可以。
            myBaseString.Test("China");//具体执行流程，查看“QuickerIn.md”文件。


            //其他的例子
            IBase<A> myBaseA = new Sub<A>();
            IBase<B> myBaseB = new Sub<B>();
            IBase<C> myBaseC = new Sub<C>();

            //直接执行方法
            myBaseA.Test(new A());

            //泛型接口的两种实例（已经是非泛型类型的实例了），交换赋值后执行方法
            myBaseB = myBaseA;
            myBaseB.Test(new B());
            myBaseB.Test(new C());//常规方法中（此处已经是非泛型方法了），满足直观的李氏替换。
            //myBaseB.Test(new A());//在常规方法中，用A的实例去替换B的实例，违背李氏替换了。

            ////以下代码无法编译通过
            //myBaseB = myBaseC;

        }
    }

#pragma warning restore
}

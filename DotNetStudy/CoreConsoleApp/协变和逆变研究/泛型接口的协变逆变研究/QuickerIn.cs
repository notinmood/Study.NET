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
            IBase<string> myBaseString = new Sub<string>();
            myBaseString.Test("qingdao");

            IBase<string> myBaseObject = new Sub<object>();
            myBaseObject.Test("qingdao");


            ////以下代码无法编译通过
            //IBase<object> myBase3 = new Sub<string>();
            //myBase3.Test(123);


            IBase<A> myBaseA = new Sub<A>();
            IBase<B> myBaseB = new Sub<B>();
            IBase<C> myBaseC = new Sub<C>();

            myBaseA.Test(new A());

            myBaseB = myBaseA;
            myBaseB.Test(new B());
            myBaseB.Test(new C());//常规方法中（此处已经是非泛型方法了），满足直观的李氏替换。

            ////以下代码无法编译通过
            //myBaseB = myBaseC;

        }
    }

#pragma warning restore
}

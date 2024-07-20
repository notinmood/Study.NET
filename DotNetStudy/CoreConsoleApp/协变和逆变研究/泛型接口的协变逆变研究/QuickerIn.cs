using System;

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
            IBase<string> myBase1 = new Sub<string>();
            myBase1.Test("qingdao");

            IBase<string> myBase2 = new Sub<object>();
            myBase2.Test("qingdao");


            ////以下代码无法编译通过
            //IBase<object> myBase3 = new Sub<string>();
            //myBase3.Test(123);
        }
    }

#pragma warning restore
}

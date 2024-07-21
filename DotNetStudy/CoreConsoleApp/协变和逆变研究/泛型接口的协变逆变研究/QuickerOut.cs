namespace CoreConsoleApp.协变和逆变研究.泛型接口的协变逆变研究
{
    internal class QuickerOut
    {
        public interface IBase<out T>
        {
            T Test();
        }
        public class Sub<T> : IBase<T>
        {
            public T Test() { return default; }
        }

        public void Index()
        {
            //1. 直接调用每个类型的方法
            IBase<string> myBase1 = new Sub<string>();
            myBase1.Test();

            IBase<object> myBase2 = new Sub<string>();
            myBase2.Test();

            //2. 接口的两种实例尝试彼此赋值，再调用方法。
            //myBase1 = myBase2; //这个不行
            myBase2 = myBase1; //这种可以
            myBase2.Test();

        }

    }
}

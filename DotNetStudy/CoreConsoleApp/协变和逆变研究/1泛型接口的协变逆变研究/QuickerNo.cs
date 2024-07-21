namespace CoreConsoleApp.协变和逆变研究.泛型接口的协变逆变研究
{
    internal class QuickerNo
    {
        public interface IBase<T>
        {
            T Test(T param);
        }

        public class Sub<T> : IBase<T>
        {
            public T Test(T param) { return default; }
        }

        public static void Index()
        {

            IBase<string> myBase1 = new Sub<string>();
            myBase1.Test("qingdao");

            // +--------------------------------------------------------------------------
            // |::说明·| 类型 IBase<T> 和 类型 Sub<T> 之间，
            // 1. 只有 T 相同，才有继承派生关系；
            // 2. 当T 不同的时候，两者间没有关系。
            //  即，类型 Base<Object> 和 Sub<string>，
            //  或者 Base<string> 和 Sub<object>
            //  之间没有任何继承派生关系
            // +--------------------------------------------------------------------------
            //IBase<object> myBase2 = new Sub<string>();
            //myBase2.Test(123);

            //IBase<string> myBase3 = new Sub<object>();
            //myBase3.Test("qingdao");
        }

    }
}

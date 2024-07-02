using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.协变和逆变研究
{
    internal class QuickerNo
    {
        public interface Base<T>
        {
            T Test(T param);
        }
        public class Sub<T> : Base<T>
        {
            public T Test(T param) { return default(T); }
        }

        public void index()
        {
            
            Base<string> myBase1 = new Sub<string>();
            myBase1.Test("qingdao");

            // +--------------------------------------------------------------------------
            // |::说明·| 类型 Base<T> 和 类型 Sub<T> 之间，
            // 1. 只有 T 相同，才有继承派生关系；
            // 2. 当T 不同的时候，两者间没有关系。
            //  即，类型 Base<Object> 和 Sub<string>，
            //  或者 Base<string> 和 Sub<object>
            //  之间没有任何继承派生关系
            // +--------------------------------------------------------------------------
            //Base<Object> myBase2 = new Sub<string>();
            //myBase2.Test(123);

            //Base<string> myBase3 = new Sub<object>();
            //myBase3.Test("qingdao");
        }

    }
}

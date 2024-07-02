using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.协变和逆变研究
{
    internal class QuickerOut
    {
        public interface Base<out T>
        {
            T Test();
        }
        public class Sub<T> : Base<T>
        {
            public T Test() { return default(T); }
        }

        public void index()
        {
            Base<string> myBase1 = new Sub<string>();
            myBase1.Test();

            Base<Object> myBase2 = new Sub<string>();
            myBase2.Test();

            //Base<string> myBase3 = new Sub<Object>();
            //myBase2.Test();
        }

    }
}

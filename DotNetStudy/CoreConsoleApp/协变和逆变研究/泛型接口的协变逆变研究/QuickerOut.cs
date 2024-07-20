using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IBase<string> myBase1 = new Sub<string>();
            myBase1.Test();

            IBase<object> myBase2 = new Sub<string>();
            myBase2.Test();

            //IBase<string> myBase3 = new Sub<object>();
            //myBase3.Test();
        }

    }
}

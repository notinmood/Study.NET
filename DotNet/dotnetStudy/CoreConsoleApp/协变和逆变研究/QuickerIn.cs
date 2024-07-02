using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.协变和逆变研究
{
    internal class QuickerIn
    {
        public interface Base<in T>
        {
            void Test(T param);
        }
        public class Sub<T> : Base<T>
        {
            public void Test(T param)
            {
                //do something;
            }
        }

        public void index()
        {
            Base<string> myBase1 = new Sub<string>();
            myBase1.Test("qingdao");

            Base<string> myBase2 = new Sub<object>();
            myBase2.Test("qingdao");

            //Base<object> myBase3 = new Sub<string>();
            //myBase3.Test(123);
        }

    }
}

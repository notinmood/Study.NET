using System;

#pragma warning disable
namespace CoreConsoleApp.协变和逆变研究.泛型委托的协变逆变研究
{
    internal class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        public static void DisplayInformation(string userName)
        {
            Console.WriteLine(string.Format("hello! {0}", userName));
        }

        public static void DealInput<T>(T input)
        {
            Console.WriteLine("T的类型为:" + typeof(T).ToString());
            Console.WriteLine("T的类型为:" + input.ToString());
        }

        public static T DealOutput<T>()
        {
            Console.WriteLine("T的类型为:" + typeof(T).ToString());
            //Console.WriteLine("T的类型为:" + input.ToString());
            return default(T);
        }


        public static T DealInputOutput<T>(T input)
        {
            Console.WriteLine("T的类型为:" + typeof(T).ToString());
            Console.WriteLine("T的类型为:" + input.ToString());
            return default(T);
        }

        public static P DealInputOutput<T, P>(T input)
        {
            Console.WriteLine("T的类型为:" + typeof(T).ToString());
            Console.WriteLine("T的类型为:" + input.ToString());
            Console.WriteLine("P的类型为" + typeof(P).ToString());
            return default(P);
        }
    }
}

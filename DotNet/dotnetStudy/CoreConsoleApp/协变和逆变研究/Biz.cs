using System;

namespace CoreConsoleApp.协变和逆变研究
{
    internal class Biz
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
            Console.WriteLine("T的类型为" + (typeof(T)).ToString());
            Console.WriteLine(input.ToString());
        }

        public static T DealOutput<T>()
        {
            return default(T);
        }

        public static T Deal<T>(T input)
        {
            return default(T);
        }

        public static T DealInputOutput<P, T>(P input)
        {
            return default(T);
        }
    }
}

/**
 * @file   : Index.cs
 * @date   : 2024/7/21 15:49:02
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.协变和逆变研究._3泛型类型不支持协变逆变
{
    internal static class Client
    {
        public static void Index()
        {
            BaseOperator<object> baseObjectOperator = new BaseOperator<object>();
            BaseOperator<string> baseStringOperator = new BaseOperator<string>();
            SubOperator<object> subObjectOperator = new SubOperator<object>();
            SubOperator<string> subStringOperator = new SubOperator<string>();

            //1. 可以直接调用
            baseObjectOperator.DealInput("China");
            baseStringOperator.DealOutput();
            subObjectOperator.DealOutput();
            subStringOperator.DealInput("China");


            //2. 类型具象化的实例，均不支持相互之间的赋值。就不要讲继续调用其内的方法了。
            //baseObjectOperator = baseStringOperator;
            //baseStringOperator = baseObjectOperator;

            //subObjectOperator = baseObjectOperator;
            //baseObjectOperator = subObjectOperator;
        }

    }
}

/**
 * @file   : Delegates.cs
 * @date   : 2024/7/6 8:23:12
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.事件研究._1.委托的引入
{
    /**
     * 此处定义的这个委托，代表了签名为一个string参数，一个int返回值的一些列方法。
     * 其实这里就是定义了一个类，这个类的实例是签名为参数string，返回值int的方法。
     */
    public delegate int MyDelegate(string s);

    public class MyClass
    {
        public MyClass() { }

        public void UseDelegate()
        {
            //1. 使用new(方法名称)的方式实例化一个委托对象。
            MyDelegate myd1 = new MyDelegate(this.GetLength);
            myd1("qingdao");

            //2. 或者直接将方法这个对象赋值给委托类型的变量。
            MyDelegate myd2 = this.GetLength;
            myd2("qingdao");
        }


        public int GetLength(string message)
        {
            return message.Length;
        }
    }
}

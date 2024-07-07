/**
 * @file   : Client.cs
 * @date   : 2024/7/7 23:50:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Builder构造器模式.最佳实践
{
    internal class Client
    {
        public void Index()
        {
            // 使用建造者模式创建对象
            var product = new Product.Builder()
                .SetPartA("ValueA")
                .SetPartB("ValueB")
                .Build();
        }

    }
}

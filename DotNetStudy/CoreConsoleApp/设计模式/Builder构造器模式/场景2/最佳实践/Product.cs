/**
 * @file   : Product.cs
 * @date   : 2024/7/7 23:39:16
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.Builder构造器模式.场景2.最佳实践
{
    public class Product
    {
        // 产品的属性
        public string PartA { get; private set; }
        public string PartB { get; private set; }

        // 私有构造函数，防止外部直接构造
        private Product()
        {
        }

        // 内部类，作为建造者
        public class Builder
        {
            private static readonly Product product = new Product();

            public Builder SetPartA(string partA)
            {
                product.PartA = partA;
                return this;
            }

            public Builder SetPartB(string partB)
            {
                product.PartB = partB;
                return this;
            }

            // 构建并返回产品实例
            public Product Build()
            {
                return product;
            }
        }
    }
}

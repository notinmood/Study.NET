/**
 * @file   : PriceContext.cs
 * @date   : 2024/7/8 7:15:37
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Strategy策略模式.UsePattern
{
    internal class PriceContext
    {
        /**
     * 持有一个具体的策略对象
     */
        private readonly IStrategy strategy = null;
        /**
         * 构造方法，传入一个具体的策略对象
         * @param aStrategy 具体的策略对象
         */
        public PriceContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        /**
         * 报价，计算对客户的报价
         * @param goodsPrice 商品销售原价
         * @return 计算出来的，应该给客户报的价格
         */
        public double Quote(double goodsPrice)
        {
            return this.strategy.CalcPrice(goodsPrice);
        }
    }
}

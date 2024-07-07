/**
 * @file   : Strategy.cs
 * @date   : 2024/7/8 7:11:26
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Strategy策略模式.UsePattern
{
    /**
 * 策略，定义计算报价算法的接口
 */
    public interface IStrategy
    {
        /**
         * 计算应报的价格
         * @param goodsPrice 商品销售原价
         * @return 计算出来的，应该给客户报的价格
         */
        public double CalcPrice(double goodsPrice);
    }
}

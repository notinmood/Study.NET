/**
 * @file   : Observer.cs
 * @date   : 2024/7/5 10:05:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Observer观察者模式.拉模式
{
    /**
     * 观察者，比如报纸的读者
     */
    public interface IObserver
    {
        /**
         * 被通知的方法
         * @param subject 具体的目标对象，可以获取报纸的内容
         */
        public void Update(Subject subject);
    }

}

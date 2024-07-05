/**
 * @file   : Observer.cs
 * @date   : 2024/7/5 10:05:54
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Observer观察者模式.推模式
{
    /**
     * 观察者，比如报纸的读者
     */
    public interface IObserver
    {
        /**
         * 被通知的方法，直接把报纸的内容推送过来
         * @param content 报纸的内容
         */
        public void Update(string content);
    }

}

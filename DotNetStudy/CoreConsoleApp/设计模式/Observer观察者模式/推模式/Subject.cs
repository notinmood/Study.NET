/**
 * @file   : Subject.cs
 * @date   : 2024/7/5 10:04:39
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Observer观察者模式.推模式
{
    /**
     * 目标对象，作为被观察者
     */
    public class Subject
    {
        /**
         * 用来保存注册的观察者对象，也就是报纸的订阅者
         */
        private List<IObserver> observers = [];

        /**
         * 报纸的读者需要先向报社订阅，先要注册
         * @param reader 报纸的读者
         * @return 是否注册成功
         */
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        /**
         * 报纸的读者可以取消订阅
         * @param reader 报纸的读者
         * @return 是否取消成功
         */
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        /**
         * 当每期报纸印刷出来后，就要迅速主动的被送到读者的手中，
         * 相当于通知读者，让他们知道
         */
        protected void NotifyObservers(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}

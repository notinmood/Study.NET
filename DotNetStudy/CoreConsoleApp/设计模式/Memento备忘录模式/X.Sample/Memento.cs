/**
 * @file   : Memento.cs
 * @date   : 2024/7/17 11:00:23
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.X.Sample
{
    // Memento: 备忘录
    class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return state;
        }
    }
}

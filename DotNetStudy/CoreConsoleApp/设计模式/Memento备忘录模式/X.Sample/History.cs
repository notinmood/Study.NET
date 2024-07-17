/**
 * @file   : History.cs
 * @date   : 2024/7/17 10:59:51
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.X.Sample
{
    // Caretaker: 管理者，负责保存和恢复备忘录
    class History
    {
        private List<Memento> history = new List<Memento>();

        public void PushMemento(Memento memento)
        {
            history.Add(memento);
        }

        public Memento PopMemento()
        {
            int lastIndex = history.Count() - 1;
            if (lastIndex >= 0)
            {
                var entity = history[lastIndex];
                history.RemoveAt(lastIndex);
                return entity;
            }
            return null;
        }
    }
}

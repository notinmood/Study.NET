/**
 * @file   : Editor.cs
 * @date   : 2024/7/17 10:58:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.X.Sample
{
    // Originator: 富文本编辑器
    class Editor
    {
        private string content;

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public Memento CreateMemento()
        {
            return new Memento(content);
        }

        public void RestoreFromMemento(Memento memento)
        {
            this.content = memento.getState();
        }
    }
}

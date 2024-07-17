/**
 * @file   : Client.cs
 * @date   : 2024/7/17 10:59:22
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Memento备忘录模式.X.Sample
{
    // Client: 示例代码
    public class Client
    {
        public static void Index()
        {
            Editor editor = new Editor();
            History history = new History();

            // 用户编辑内容
            editor.SetContent("First content");
            history.PushMemento(editor.CreateMemento());

            editor.SetContent("Second content");
            history.PushMemento(editor.CreateMemento());

            // 撤销操作
            editor.RestoreFromMemento(history.PopMemento());
            Console.WriteLine(editor.GetContent());  // Output: Second content

            editor.RestoreFromMemento(history.PopMemento());
            Console.WriteLine(editor.GetContent());  // Output: First content
        }
    }
}

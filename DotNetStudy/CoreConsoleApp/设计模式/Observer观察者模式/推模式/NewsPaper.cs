/**
 * @file   : NewsPaper.cs
 * @date   : 2024/7/5 11:53:00
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Observer观察者模式.推模式
{
    public class NewsPaper : Subject
    {
        private string content;
        public string getContent()
        {
            return content;
        }
        public void SetContent(string content)
        {
            this.content = content;
            //内容有了，说明又出报纸了，那就通知所有的读者
            NotifyObservers(content);
        }
    }
}

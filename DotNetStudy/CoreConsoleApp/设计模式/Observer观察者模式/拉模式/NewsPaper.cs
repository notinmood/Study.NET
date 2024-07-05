/**
 * @file   : NewsPaper.cs
 * @date   : 2024/7/5 10:05:21
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Observer观察者模式.拉模式
{
    /**
 * 报纸对象，具体的目标实现
 */
    public class NewsPaper : Subject
    {
        /**
         * 报纸的具体内容
         */
        private string content;
        /**
         * 获取报纸的具体内容
         * @return 报纸的具体内容
         */
        public string getContent()
        {
            return content;
        }

        /**
         * 示意，设置报纸的具体内容，相当于要出版报纸了
         * @param content 报纸的具体内容
         */
        public void setContent(string content)
        {
            this.content = content;
            //内容有了，说明又出报纸了，那就通知所有的读者
            notifyObservers();
        }
    }
}

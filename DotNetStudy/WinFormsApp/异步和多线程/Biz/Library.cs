/**
 * @file   : Library.cs
 * @date   : 2024/8/17 15:25:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace WinFormsApp.异步和多线程.Biz
{
    internal static class Library
    {

        public static readonly List<Book> Books = [
            new Book("封神演义",1),
            new Book("三国演义",2),
            new Book("水浒传",1),
            new Book("西游记",1),
            new Book("红楼梦",1),
            new Book("聊斋志异",1),
            new Book("儒林外史",1),
            new Book("隋唐演义",1)
        ];
    }
}

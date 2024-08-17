/**
 * @file   : Book.cs
 * @date   : 2024/8/17 15:15:59
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Diagnostics;

namespace WinFormsApp.异步和多线程.Biz
{
    internal class Book
    {
        public Book(string name, int durationSeconds)
        {
            Name = name;
            DurationSeconds = durationSeconds;
        }

        public string Name { get; }

        public int DurationSeconds { get; }

        public string Search()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(DurationSeconds * 1000);
            stopwatch.Stop();

            return Result(stopwatch.ElapsedMilliseconds);
        }

        public string Result(long milliSeconds)
        {
            return $"{Name.PadRight(12, '-')},用时{Convert.ToSingle(milliSeconds) / 1000}秒。";
        }
    }
}

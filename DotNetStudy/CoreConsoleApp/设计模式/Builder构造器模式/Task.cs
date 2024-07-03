using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式
{

    // https://www.cnblogs.com/javastack/p/14704723.html
    public class Task
    {
        private int count;
        private string name;
        private DateTime createTime;

        public static class TaskBuilder
        {
            private static int count;
            private static string name;
            private static DateTime createTime;

            //public static TaskBuilder setName(string name)
            //{
            //    TaskBuilder.name = name;
            //    return this;
            //}

        }
    }
}

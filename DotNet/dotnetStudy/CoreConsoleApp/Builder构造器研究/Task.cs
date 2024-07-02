using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleApp.BuilderStudy
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

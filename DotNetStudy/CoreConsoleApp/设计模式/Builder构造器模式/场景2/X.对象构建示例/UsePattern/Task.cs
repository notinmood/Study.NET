using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景2.X.对象构建示例.UsePattern
{
    public class Task
    {
        private string name;
        private int level;
        private int count;
        private DateTime createTime;
        private DateTime updateTime;
        private string description;

        private Task()
        {

        }


        public override string ToString()
        {
            return $"我是一个任务，name={name},level={level},count={count},creatTime={createTime},updateTime={updateTime},description={description}";
        }

        public class Builder
        {
            private static Task task = new Task();

            private string name;
            private int level;
            private int count;
            private DateTime createTime;
            private DateTime updateTime;
            private string description;

            public Task Build()
            {
                return task;
            }

            public Builder SetName(string name)
            {
                task.name = name;
                return this;
            }

            public Builder SetLevel(int level)
            {
                task.level = level;
                return this;
            }

            public Builder SetCount(int count)
            {
                task.count = count;
                return this;
            }

            public Builder SetDescription(string description)
            {
                task.description = description;
                return this;
            }

            public Builder SetCreateTime(DateTime createTime)
            {
                task.createTime = createTime;
                return this;
            }

            public Builder SetUpdateTime(DateTime updateTime)
            {
                task.updateTime = updateTime;
                return this;
            }
        }
    }
}

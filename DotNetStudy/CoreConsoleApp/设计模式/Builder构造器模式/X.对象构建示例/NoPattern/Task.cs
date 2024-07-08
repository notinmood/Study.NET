using System;

namespace CoreConsoleApp.设计模式.Builder构造器模式.X.对象构建示例.NoPattern
{
    public class Task
    {
        private string name;
        private int level;
        private int count;
        private DateTime createTime;
        private DateTime updateTime;
        private string description;


        public Task()
        {

        }

        public Task(string name, int count, DateTime createTime, DateTime updateTime, int level, string description)
        {
            this.name = name;
            this.count = count;
            this.createTime = createTime;
            this.updateTime = updateTime;
            this.level = level;
            this.description = description;
        }

        public int Count { get => count; set => count = value; }
        public int Level { get => level; set => level = value; }
        public string Description { get => description; set => description = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }
        public DateTime UpdateTime { get => updateTime; set => updateTime = value; }
        public string Name { get => name; set => name = value; }
    }
}

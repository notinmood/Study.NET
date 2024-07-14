/**
 * @file   : Student.cs
 * @date   : 2024/7/14 17:24:34
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.Linq使用研究.Biz
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        public int StuId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public int SchoolId { get; set; }


        public override string ToString()
        {
            return $"姓名:{Name};学号:{StuId};年龄:{Age};班级:{Class};学校编号:{SchoolId}.";
        }
    }
}

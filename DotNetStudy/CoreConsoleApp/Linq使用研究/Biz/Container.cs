/**
 * @file   : Container.cs
 * @date   : 2024/7/14 17:26:07
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.Linq使用研究.Biz
{
    internal static class Container
    {
        static Container()
        {
            schools.Add(new School() { SchoolId = 1, SchoolName = "BeiJing Middle School " });
            schools.Add(new School() { SchoolId = 2, SchoolName = "ShangHai Middle School " });
            schools.Add(new School() { SchoolId = 8, SchoolName = "GuangZhou Middle School " });

            students.Add(new Student() { StuId = 1, Name = "Li Lei", Age = 9, Class = "Grade Three", SchoolId = 1 });
            students.Add(new Student() { StuId = 2, Name = "Han Meimei", Age = 9, Class = "Grade Three", SchoolId = 1 });
            students.Add(new Student() { StuId = 3, Name = "Li Ming", Age = 6, Class = "Grade One", SchoolId = 2 });
            students.Add(new Student() { StuId = 4, Name = "Zou Qi", Age = 7, Class = "Grade One", SchoolId = 2 });
            students.Add(new Student() { StuId = 5, Name = "Wang Long", Age = 7, Class = "Grade One", SchoolId = 1 });
        }

        static readonly IList<School> schools = new List<School>();
        static readonly IList<Student> students = new List<Student>();

        public static IList<School> Schools { get { return schools; } }
        public static IList<Student> Students { get { return students; } }

    }
}

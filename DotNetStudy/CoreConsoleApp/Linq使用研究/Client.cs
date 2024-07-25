﻿/**
 * @file   : _1.cs
 * @date   : 2024/7/14 17:43:18
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using CoreConsoleApp.Linq使用研究.Biz;

namespace CoreConsoleApp.Linq使用研究
{
    internal static class Clinet
    {
        private static IList<Student> Students { get { return Container.Students; } }
        private static IList<School> Schools { get { return Container.Schools; } }

        public static void Index()
        {
            //Select投影();
            //Where过滤();
            //SelectMany投影();
            //OrderBy排序();
            //OrderByDescending排序();
            //ThenBy排序();
            //ThenByDescending排序();
            //Reverse逆转排序();
            //Join连接();
            //GroupJoin分组连接();
            GroupBy分组();
        }

        public static void Select投影()
        {
            Console.WriteLine("》》》以下为 Select投影 信息：");
            //方式1. 使用查询模式
            var result = from s in Container.Students select new { s.Name, s.Class };
            foreach (var s in result)
            {
                Console.WriteLine(s.Name);
            }

            var result2 = from s in Container.Students select $"学生姓名：{s.Name};学生班级：{s.Class}";
            foreach (var s in result2)
            {
                Console.WriteLine(s);
            }

            //方式2. 使用方法模式
            var result3 = Container.Students.Select(s => $"学生姓名：{s.Name};学生年龄：{s.Age}");
            foreach (var s in result3)
            {
                Console.WriteLine(s);
            }
        }

        public static void Where过滤()
        {
            Console.WriteLine("》》》以下为 Where过滤 信息：");
            //方式1. 使用查询模式
            var result = from s in Container.Students where s.Age == 9 select s;
            foreach (var s in result)
            {
                Console.WriteLine(s.Name);
            }

            //方式2. 使用方法模式
            var result2 = Container.Students.Where(s => s.Age == 9);
            foreach (var s in result2)
            {
                Console.WriteLine(s.Name);
            }
        }

        public static void SelectMany投影()
        {
            Console.WriteLine("》》》以下为 SelectMany投影 信息：");

            var result = Container.Students.SelectMany(s => s.Name.Split(" "));
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }

        public static void OrderBy排序()
        {
            Console.WriteLine("》》》以下为 OrderBy排序 信息：");

            var result = Container.Students.OrderBy(s => s.Age);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void OrderByDescending排序()
        {
            Console.WriteLine("》》》以下为 OrderByDescending排序 信息：");

            var result = Container.Students.OrderByDescending(s => s.Age);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void ThenBy排序()
        {
            Console.WriteLine("》》》以下为先OrderBy排序 再ThenBy排序 信息：");

            //先OrderBy再ThenBy，是在第一次排好序的基础上，对第一次排序中相同序号的item再次排序。
            var result = Container.Students.OrderBy(s => s.Age).ThenBy(p => p.Name);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //先OrderBy再ThenBy，是第一次排好序了，第二次又把所有的item再重新排序（第一次排序结果未保留）。
            Console.WriteLine("》》》以下为先OrderBy排序 再OrderBy排序 信息：");
            var result2 = Container.Students.OrderBy(s => s.Age).OrderBy(p => p.Name);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }

        public static void ThenByDescending排序()
        {
            Console.WriteLine("》》》以下为先OrderBy排序 再ThenByDescending排序 信息：");

            //先OrderBy再ThenBy，是在第一次排好序的基础上，对第一次排序中相同序号的item再次排序。
            var result = Container.Students.OrderBy(s => s.Age).ThenByDescending(p => p.Name);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void Reverse逆转排序()
        {
            Console.WriteLine("》》》以下为 Reverse逆转排序 信息：");

            //先OrderBy再ThenBy，是在第一次排好序的基础上，对第一次排序中相同序号的item再次排序。
            var result = Container.Students.Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void Join连接()
        {
            Console.WriteLine("》》》以下为 Join连接 信息：");
            var result = Students.Join(Schools, s => s.SchoolId, c => c.SchoolId, (s, c) => new { 姓名 = s.Name, 学校 = c.SchoolName });
            foreach (var s in result)
            {
                Console.WriteLine($"{s.姓名}({s.学校})");
            }
        }


        public static void GroupBy分组()
        {
            //方式1. 方法语法
            var result = Students.GroupBy(s => s.SchoolId);
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("──────────────────");
                foreach (var s in item)
                {
                    Console.WriteLine("\t" + s.Name);
                }
                Console.WriteLine();
            }

            //方式2. 查询语法（group和by关键字是分开的）
            result = from student in Students group student by student.SchoolId;
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("──────────────────");
                foreach (var s in item)
                {
                    Console.WriteLine("\t" + s.Name);
                }
                Console.WriteLine();
            }

            //其他说明：group子句后面的表达式具有select一样的能力（可以对元素进行投影）
        }


        public static void GroupJoin分组连接()
        {
            var enumerable = Schools.GroupJoin(Students, o => o.SchoolId, i => i.SchoolId, (o, ii) => new { SchoolName = o.SchoolName, StudentName = ii.Select(i => i.Name) });
            foreach (var item in enumerable)
            {
                Console.WriteLine(item.SchoolName);
                Console.WriteLine("──────────────────");
                foreach (var sn in item.StudentName)
                {
                    Console.WriteLine("\t" + sn);
                }
                Console.WriteLine();
            }
        }


    }
}

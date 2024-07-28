/**
 * @file   : SelectManyStudy.cs
 * @date   : 2024/7/26 9:30:59
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreConsoleApp.Linq使用研究
{
    /// <summary>
    /// 设备
    /// </summary>
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Point> Points { get; set; }

        public Device()
        {
            Points = new List<Point>();
        }
    }
    /// <summary>
    /// 状态点位
    /// </summary>
    public class Point
    {
        public string PointId { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }
    }


    internal static class SelectManyStudy
    {
        public static void Index()
        {
            与Select的比较();
            Product();
            MultiProduct();
        }

        private static void 与Select的比较()
        {
            //参考资料：https://piratewang.blog.csdn.net/article/details/139773872

            //数据初始化
            List<Device> list = new List<Device>();

            list.Add(new Device() { Id = 101, Name = "1号设备", });
            list.Add(new Device() { Id = 102, Name = "2号设备", });
            list.Add(new Device() { Id = 103, Name = "3号设备", });
            list.Add(new Device() { Id = 104, Name = "4号设备", });
            list[0].Points.Add(new Point { PointId = "101-1", Name = "测试1", Value = 50 });
            list[0].Points.Add(new Point { PointId = "101-2", Name = "测试2", Value = 50 });
            list[1].Points.Add(new Point { PointId = "102-3", Name = "测试3", Value = 50 });
            list[1].Points.Add(new Point { PointId = "102-4", Name = "测试4", Value = 50 });
            list[1].Points.Add(new Point { PointId = "102-1", Name = "测试1", Value = 20 });
            list[2].Points.Add(new Point { PointId = "103-2", Name = "测试2", Value = 3 });
            list[3].Points.Add(new Point { PointId = "104-3", Name = "测试3", Value = 40 });
            list[3].Points.Add(new Point { PointId = "104-4", Name = "测试4", Value = 40 });

            var pointsOfSelect = list.Select(s => s.Points);
            Console.WriteLine(pointsOfSelect);//返回一个二维数组
            foreach (var outer in pointsOfSelect)
            {
                Console.WriteLine("目前在外层循环：");
                foreach (var inner in outer)
                {
                    Console.WriteLine("  目前在内层循环：");
                    Console.WriteLine("  " + inner.Name + ":" + inner.Value);
                }
            }

            Console.WriteLine("──────────────────");
            var pointsOfSelectMany = list.SelectMany(x => x.Points);
            Console.WriteLine(pointsOfSelectMany);//返回一个扁平后的一维数组
            foreach (var item in pointsOfSelectMany)
            {
                Console.WriteLine(item.Name + ":" + item.Value);
            }
        }

        /// <summary>
        /// 求笛卡尔积
        /// </summary>
        public static void Product()
        {
            List<int> set1 = [1, 2, 3];
            List<string> set2 = ["a", "b", "c"];

            var cartesianProduct = set1.SelectMany(
                s => set2,
                (x1, x2) => new { X1 = x1, X2 = x2 }
            );

            foreach (var pair in cartesianProduct)
            {
                Console.WriteLine($"({pair.X1}, {pair.X2})");
            }
            //--output---
            //(1, a)
            //(1, b)
            //(1, c)
            //(2, a)
            //(2, b)
            //(2, c)
            //(3, a)
            //(3, b)
            //(3, c)
        }


        /// <summary>
        /// 求笛卡尔积
        /// </summary>
        public static void MultiProduct()
        {
            List<string[]> list = new List<string[]>();
            string[] s1 = { "A", "B", "C" };
            string[] s2 = { "1", "2" };
            string[] s3 = { "X", "Y" };
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);

            var result = list.Aggregate((acc, next) => acc.SelectMany(x => next.Select(y => x + y)).ToArray());
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //Console.ReadKey();


            //list.Aggregate()
        }
    }
}

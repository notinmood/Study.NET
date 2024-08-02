/**
 * @file   : Program.cs
 * @date   : 2024/8/3 6:26:29
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.类型关系研究.组合关系
{
    public static class Program
    {
        public static void Index()
        {
            NameClass testName = new NameClass() { ChineseName = "小明" };
            AddressClass testAddress = new AddressClass() { HomeAddress = "地球" };
            Student testStudent = new Student(testName, testAddress);
            Console.WriteLine("更改前的名称:" + testStudent.Name.ChineseName);
            Console.WriteLine("更改前的地址：" + testStudent.Address.HomeAddress);
            Console.WriteLine("开始更改 testName 与 testAddress 的值-------------");
            testName.ChineseName = "小明(更改后)";
            testAddress.HomeAddress = "地球（更改后）";
            Console.WriteLine("更改后的名称:" + testStudent.Name.ChineseName);
            Console.WriteLine("更改后的地址：" + testStudent.Address.HomeAddress);
        }
    }

    public class Student
    {
        public NameClass Name { get; set; }
        public AddressClass Address { get; set; }
        /*
         *此处Name和Address与Student是组合关系，
         *Name与Address在Student中开辟了新的存储空间，
         *传给Student的不是一个地址，而是一个独立的对象，
         *这个对象和外部的testName、testAddress已经没有关系，不会随之改变
         */
        public Student(NameClass name, AddressClass address)
        {
            //新创建NameClass和AddressClass的类型实例，
            //这个新创建的实例随着Student实例的生而生，亡而亡。
            this.Name = new NameClass() { ChineseName = name.ChineseName };
            this.Address = new AddressClass() { HomeAddress = address.HomeAddress };
        }
    }
    public class NameClass
    {
        public string ChineseName { get; set; }
    }

    public class AddressClass
    {
        public string HomeAddress { get; set; }
    }
}

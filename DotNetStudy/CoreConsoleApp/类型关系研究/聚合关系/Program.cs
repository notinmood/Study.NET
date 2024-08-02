/**
 * @file   : Program.cs
 * @date   : 2024/8/3 6:28:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.类型关系研究.聚合关系
{
    public static class Program
    {
        public static void Index()
        {
            Name testName = new Name() { ChineseName = "小明" };
            Address testAddress = new Address() { HomeAddress = "地球" };
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
        //public Name _name;
        //public Address _address;

        public Name Name { get; set; }

        public Address Address { get; set; }

        /*
         *此处Name和Address与Student是聚合关系，
         *子类Name与Address的生命周期不会随着Student的生命周期结束而结束
         *且此处Name与Address在Student中出现是以地址的形式，
         *并未开辟新的存储空间，而是将现有的对象的地址传递给了Student类的属性，
         *当外界name对象与address对象发生变化时，
         *Student的这两个属性会随之变换
         */
        public Student(Name name, Address address)
        {
            //此处的Name和Address只是外部testName、testAddress实例的引用。
            //Student实例的创建和消亡，跟外部testName、testAddress实例没有直接关系。
            this.Name = name;
            this.Address = address;
        }
    }
    public class Name
    {
        public string ChineseName { get; set; }
    }

    public class Address
    {
        public string HomeAddress { get; set; }
    }
}

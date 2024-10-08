﻿using System;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.UsePattern
{
    public class Client
    {
        public static void Index()
        {
            //创建装机工程师对象
            var engineer = new ComputerEngineer();
            //客户选择并创建需要使用的装机方案对象
            AbstractFactory schema = new Schema1();
            //告诉装机工程师自己选择的装机方案，让装机工程师组装电脑
            engineer.makeComputer(schema);
        }
    }
}

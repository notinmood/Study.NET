/**
 * @file   : Client.cs
 * @date   : 2024/8/3 11:33:53
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Composite组合模式.UsePattern
{
    public static class Client
    {
        public static void Index()
        {
            //定义所有的组合对象
            Component root = new Composite("服装");
            Component c1 = new Composite("男装");
            Component c2 = new Composite("女装");

            //定义所有的叶子对象
            Component leaf1 = new Leaf("衬衣");
            Component leaf2 = new Leaf("夹克");
            Component leaf3 = new Leaf("裙子");
            Component leaf4 = new Leaf("套装");

            //按照树的结构来组合组合对象和叶子对象
            root.addChild(c1);
            root.addChild(c2);
            c1.addChild(leaf1);
            c1.addChild(leaf2);
            c2.addChild(leaf3);
            c2.addChild(leaf4);
            //调用根对象的输出功能来输出整棵树
            root.printStruct("");
        }
    }
}

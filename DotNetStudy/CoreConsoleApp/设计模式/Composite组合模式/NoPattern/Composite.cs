/**
 * @file   : Composite.cs
 * @date   : 2024/8/3 11:01:03
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Composite组合模式.NoPattern
{
    /**
   * 组合对象，可以包含其它组合对象或者叶子对象
   */
    public class Composite
    {
        /**
         * 用来记录包含的其它组合对象
         */
        private readonly IList<Composite> childComposite = new List<Composite>();
        /**
         * 用来记录包含的其它叶子对象
         */
        private readonly IList<Leaf> childLeaf = new List<Leaf>();
        /**
         * 组合对象的名字
         */
        private readonly string name;

        /**
         * 构造方法，传入组合对象的名字
         * @param name 组合对象的名字
         */
        public Composite(string name)
        {
            this.name = name;
        }

        /**
         * 向组合对象加入被它包含的其它组合对象
         * @param c 被它包含的其它组合对象
         */
        public void addComposite(Composite c)
        {
            this.childComposite.Add(c);
        }
        /**
         * 向组合对象加入被它包含的叶子对象
         * @param leaf 被它包含的叶子对象
         */
        public void addLeaf(Leaf leaf)
        {
            this.childLeaf.Add(leaf);
        }
        /**
         * 输出组合对象自身的结构
         * @param preStr 前缀，主要是按照层级拼接的空格，实现向后缩进
         */
        public void printStruct(string preStr)
        {
            //先把自己输出去
            Console.WriteLine(preStr + "+" + this.name);
            //然后添加一个空格，表示向后缩进一个空格，输出自己包含的叶子对象
            preStr += " ";
            foreach (var item in childLeaf)
            {
                item.printStruct(preStr);
            }

            //输出当前对象的子对象了
            foreach (var item in childComposite)
            {
                item.printStruct(preStr);
            }
        }
    }
}

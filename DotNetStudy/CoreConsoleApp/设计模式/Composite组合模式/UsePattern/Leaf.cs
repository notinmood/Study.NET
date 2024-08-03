/**
 * @file   : Leaf.cs
 * @date   : 2024/8/3 11:31:48
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.Composite组合模式.UsePattern
{
    /**
   * 叶子对象
   */
    public class Leaf : Component
    {
        /**
         * 叶子对象的名字
         */
        private readonly string name;
        /**
         * 构造方法，传入叶子对象的名字
         * @param name 叶子对象的名字
         */
        public Leaf(string name)
        {
            this.name = name;
        }
        /**
         * 输出叶子对象的结构，叶子对象没有子对象，也就是输出叶子对象的名字
         * @param preStr 前缀，主要是按照层级拼接的空格，实现向后缩进
         */
        public override void printStruct(string preStr)
        {
            Console.WriteLine(preStr + "-" + name);
        }
    }
}

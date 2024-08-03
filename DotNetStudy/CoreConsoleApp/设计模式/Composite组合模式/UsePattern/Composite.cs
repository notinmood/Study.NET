/**
 * @file   : Composite.cs
 * @date   : 2024/8/3 11:33:05
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Composite组合模式.UsePattern
{
    /**
   * 组合对象，可以包含其它组合对象或者叶子对象
   */
    public class Composite : Component
    {
        /**
         * 用来存储组合对象中包含的子组件对象
         */
        private List<Component> childComponents = null;
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

        public override void addChild(Component child)
        {
            //延迟初始化
            if (childComponents == null)
            {
                childComponents = new List<Component>();
            }
            childComponents.Add(child);
        }
        /**
         * 输出组合对象自身的结构
         * @param preStr 前缀，主要是按照层级拼接的空格，实现向后缩进
         */
        public override void printStruct(string preStr)
        {
            //先把自己输出去
            Console.WriteLine(preStr + "+" + this.name);
            //如果还包含有子组件，那么就输出这些子组件对象
            if (this.childComponents != null)
            {
                //然后添加一个空格，表示向后缩进一个空格
                preStr += " ";
                //输出当前对象的子对象了
                foreach (var item in childComponents)
                {
                    //递归输出每个子对象
                    item.printStruct(preStr);
                }
            }
        }
    }
}

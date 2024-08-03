/**
 * @file   : Component.cs
 * @date   : 2024/8/3 11:27:10
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
    /**
   * 抽象的组件对象
   */
    public abstract class Component
    {
        /**
         * 输出组件自身的名称
         */
        public abstract void printStruct(string preStr);
        /**
         * 向组合对象中加入组件对象
         * @param child 被加入组合对象中的组件对象
         */
        public virtual void addChild(Component child)
        {
            throw new Exception("对象不支持这个功能");
        }
        /**
         * 从组合对象中移出某个组件对象
         * @param child 被移出的组件对象
         */
        public virtual void removeChild(Component child)
        {
            throw new Exception("对象不支持这个功能");
        }
        /**
         * 返回某个索引对应的组件对象
         * @param index 需要获取的组件对象的索引，索引从0开始
         * @return 索引对应的组件对象
         */
        public virtual Component getChildren(int index)
        {
            throw new Exception("对象不支持这个功能");
        }
    }

}

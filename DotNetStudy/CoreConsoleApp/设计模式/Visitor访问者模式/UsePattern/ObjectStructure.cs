/**
 * @file   : ObjectStructure.cs
 * @date   : 2024/8/1 15:44:06
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System.Collections.Generic;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.UsePattern
{
    public class ObjectStructure
    {
        /**
         * 要操作的客户集合
         */
        private readonly IList<Customer> collection = new List<Customer>();

        /**
         * 提供给客户端操作的高层接口，具体的功能由客户端传入的访问者决定
         * @param visitor 客户端需要使用的访问者
         */
        public void HandleRequest(IVisitor visitor)
        {
            //循环对象结构中的元素，接受访问
            foreach (var item in collection)
            {
                item.accept(visitor);
            }
        }

        /**
         * 组建对象结构，向对象结构中添加元素。
         * 不同的对象结构有不同的构建方式
         * @param ele 加入到对象结构的元素
         */
        public void AddElement(Customer ele)
        {
            this.collection.Add(ele);
        }
    }
}
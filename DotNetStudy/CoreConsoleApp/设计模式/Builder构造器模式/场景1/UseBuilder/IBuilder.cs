﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.UseBuilder
{
    /**
   * 生成器接口，定义创建一个输出文件对象所需的各个部件的操作
   */
    public interface IBuilder
    {
        /**
         * 构建输出文件的Header部分
         * @param ehm 文件头的内容
         */
        public void BuildHeader(HeaderModel ehm);
        /**
         * 构建输出文件的Body部分 
         * @param mapData 要输出的数据的内容
         */
        public void BuildBody(Dictionary<string, Collection<DataModel>> mapData);
        /**
         * 构建输出文件的Footer部分
         * @param efm 文件尾的内容
         */
        public void BuildFooter(FooterModel efm);

        public StringBuilder GetResult();
    }

}

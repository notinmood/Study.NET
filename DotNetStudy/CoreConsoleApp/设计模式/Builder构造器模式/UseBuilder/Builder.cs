using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoreConsoleApp.设计模式.Builder构造器模式.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.UseBuilder
{
    /**
   * 生成器接口，定义创建一个输出文件对象所需的各个部件的操作
   */
    public interface Builder
    {
        /**
         * 构建输出文件的Header部分
         * @param ehm 文件头的内容
         */
        public void buildHeader(ExportHeaderModel ehm);
        /**
         * 构建输出文件的Body部分 
         * @param mapData 要输出的数据的内容
         */
        public void buildBody(Dictionary<string, Collection<ExportDataModel>> mapData);
        /**
         * 构建输出文件的Footer部分
         * @param efm 文件尾的内容
         */
        public void buildFooter(ExportFooterModel efm);
    }

}

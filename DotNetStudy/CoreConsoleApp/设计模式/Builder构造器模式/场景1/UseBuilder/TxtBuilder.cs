using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.UseBuilder
{
    /**
    * 实现导出数据到文本文件的的生成器对象
    */
    public class TxtBuilder : Builder
    {
        /**
         * 用来记录构建的文件的内容，相当于产品
         */
        private StringBuilder buffer = new StringBuilder();

        public void buildBody(Dictionary<string, Collection<DataModel>> mapData)
        {
            foreach (string tblName in mapData.Keys)
            {
                //先拼接表名称
                buffer.Append(tblName + "\n");
                //然后循环拼接具体数据
                foreach (DataModel edm in mapData[tblName])
                {
                    buffer.Append(edm.getProductId() + "," + edm.getPrice() + "," + edm.getAmount() + "\n");
                }
            }
        }
        public void buildFooter(FooterModel efm)
        {
            buffer.Append(efm.getExportUser());
        }
        public void buildHeader(HeaderModel ehm)
        {
            buffer.Append(ehm.getDepId() + "," + ehm.getExportDate() + "\n");
        }
        public StringBuilder getResult()
        {
            return buffer;
        }
    }
}

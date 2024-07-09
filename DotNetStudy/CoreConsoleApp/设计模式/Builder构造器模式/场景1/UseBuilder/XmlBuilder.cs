using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.UseBuilder
{
    /**
   * 实现导出数据到XML文件的的生成器对象
   */
    public class XmlBuilder : IBuilder
    {
        /**
         * 用来记录构建的文件的内容，相当于产品
         */
        private StringBuilder buffer = new StringBuilder();

        public void BuildBody(Dictionary<string, Collection<DataModel>> mapData)
        {
            buffer.Append("  <Body>\n");
            foreach (string tblName in mapData.Keys)
            {
                //先拼接表名称
                buffer.Append("    <Datas TableName=\"" + tblName + "\">\n");
                //然后循环拼接具体数据
                foreach (DataModel edm in mapData[tblName])
                {
                    buffer.Append("      <Data>\n");
                    buffer.Append("        <ProductId>" + edm.getProductId() + "</ProductId>\n");
                    buffer.Append("        <Price>" + edm.getPrice() + "</Price>\n");
                    buffer.Append("        <Amount>" + edm.getAmount() + "</Amount>\n");
                    buffer.Append("      </Data>\n");
                }
                buffer.Append("    </Datas>\n");
            }
            buffer.Append("  </Body>\n");
        }
        public void BuildFooter(FooterModel efm)
        {
            buffer.Append("  <Footer>\n");
            buffer.Append("    <ExportUser>" + efm.getExportUser() + "</ExportUser>\n");
            buffer.Append("  </Footer>\n");
            buffer.Append("</Report>\n");
        }
        public void BuildHeader(HeaderModel ehm)
        {
            buffer.Append("<?xml version='1.0' encoding='gb2312'?>\n");
            buffer.Append("<Report>\n");
            buffer.Append("  <Header>\n");
            buffer.Append("    <DepId>" + ehm.getDepId() + "</DepId>\n");
            buffer.Append("    <ExportDate>" + ehm.getExportDate() + "</ExportDate>\n");
            buffer.Append("  </Header>\n");
        }
        public StringBuilder GetResult()
        {
            return buffer;
        }
    }
}

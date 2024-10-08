﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoreConsoleApp.设计模式.Builder构造器模式.场景1.Biz;

namespace CoreConsoleApp.设计模式.Builder构造器模式.场景1.UseBuilder
{
    /**
   * 指导者，指导使用生成器的接口来构建输出的文件的对象
   */
    public class Director
    {
        /**
         * 持有当前需要使用的生成器对象
         */
        private readonly IBuilder builder;
        /**
         * 构造方法，传入生成器对象
         * @param builder 生成器对象
         */
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        /**
         * 指导生成器构建最终的输出的文件的对象
         * @param ehm 文件头的内容
         * @param mapData 数据的内容
         * @param efm 文件尾的内容
         */
        public void Construct(HeaderModel ehm, Dictionary<string, Collection<DataModel>> mapData, FooterModel efm)
        {
            //1：先构建Header
            builder.BuildHeader(ehm);
            //2：然后构建Body
            builder.BuildBody(mapData);
            //3：然后构建Footer
            builder.BuildFooter(efm);
        }
    }
}
/**
 * @file   : DepModel.cs
 * @date   : 2024/7/28 10:09:22
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Proxy代理模式.Biz
{
    internal class DepModel
    {
        public DepModel(string depId, string depName,string depDesc="")
        {
            this.DepId = depId;
            this.DepName = depName;
            this.DepDesc = depDesc;
        }

        public string DepName { get; set; }
        public string DepId { get; set; }


        public string DepDesc { get; set; }
    }
}

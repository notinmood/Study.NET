/**
 * @file   : UserModelApi.cs
 * @date   : 2024/7/28 9:29:08
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.Proxy代理模式.Biz
{
    /**
   * 定义用户数据对象的接口
   */
    public interface IUserModel
    {
        public string GetUserId();
        public void SetUserId(string userId);
        public string GetName();
        public void SetName(string name);
        public string GetDepId();
        public void SetDepId(string depId);
        public string GetSex();
        public void SetSex(string sex);

        public string GetDepName();

        public string GetDepDesc();
    }

}

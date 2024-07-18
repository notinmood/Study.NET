/**
 * @file   : UserModel.cs
 * @date   : 2024/7/12 7:14:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.NoPattern
{
    /**
 * 描述用户信息的数据模型
 */
    public class NormalModel
    {
        private string uuid, userId, pwd, name;
        public string GetUuid()
        {
            return uuid;
        }
        public void SetUuid(string uuid)
        {
            this.uuid = uuid;
        }
        public string GetUserId()
        {
            return userId;
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        public string getPwd()
        {
            return pwd;
        }
        public void SetPwd(string pwd)
        {
            this.pwd = pwd;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }
}

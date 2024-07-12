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
        public string getUuid()
        {
            return uuid;
        }
        public void setUuid(string uuid)
        {
            this.uuid = uuid;
        }
        public string getUserId()
        {
            return userId;
        }
        public void setUserId(string userId)
        {
            this.userId = userId;
        }
        public string getPwd()
        {
            return pwd;
        }
        public void setPwd(string pwd)
        {
            this.pwd = pwd;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}

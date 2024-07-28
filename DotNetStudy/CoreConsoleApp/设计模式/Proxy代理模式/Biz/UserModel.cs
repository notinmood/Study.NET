/**
 * @file   : UserModel.cs
 * @date   : 2024/7/13 23:13:56
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */
namespace CoreConsoleApp.设计模式.Proxy代理模式.Biz
{
    /**
  * 描述用户数据的对象
  */
    public class UserModel : IUserModel
    {
        public UserModel(string userId, string userName, string depId, string sex)
        {
            name = userName;
            this.userId = userId;
            this.depId = depId;
            this.sex = sex;
        }

        /**
         * 用户编号
         */
        private string userId;
        /**
         * 用户姓名
         */
        private string name;
        /**
         * 部门编号
         */
        private string depId;
        /**
         * 性别
         */
        private string sex;

        /**
         * 部门名称
         */
        private string depName;

        /**
         * 部门描述
         */
        private string depDesc;

        public string GetUserId()
        {
            return userId;
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetDepId()
        {
            return depId;
        }
        public void SetDepId(string depId)
        {
            this.depId = depId;
        }
        public string GetSex()
        {
            return sex;
        }
        public void SetSex(string sex)
        {
            this.sex = sex;
        }

        public string GetDepName()
        {
            return depName;
        }

        public void SetDepName(string depName)
        {
            this.depName = depName;
        }

        public string GetDepDesc()
        {
            return depDesc;
        }

        public void SetDepDesc(string depDesc)
        {
            this.depDesc = depDesc;
        }

        public override string ToString()
        {
            return "userId=" + userId + ",name=" + name + ",depId=" + depId + ",sex=" + sex;
        }
    }

}

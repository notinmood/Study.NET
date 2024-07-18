/**
 * @file   : LoginModel.cs
 * @date   : 2024/7/12 7:13:52
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.NoPattern
{
    /**
 * 描述登录人员登录时填写的信息的数据模型
 */
    public class NormalLoginModel
    {
        private string userId, pwd;
        public string getUserId()
        {
            return userId;
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        public string GetPwd()
        {
            return pwd;
        }
        public void SetPwd(string pwd)
        {
            this.pwd = pwd;
        }
    }

}

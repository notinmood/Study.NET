/**
 * @file   : LoginModel.cs
 * @date   : 2024/7/12 7:45:59
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.UsePattern
{
    /**
 * 封装进行登录控制所需要的数据
 */
    public class LoginModel
    {
        /**
         * 登录人员的编号，通用的，可能是用户编号，也可能是工作人员编号
         */
        private string loginId;
        /**
         * 登录的密码
         */
        private string pwd;
        public string GetLoginId()
        {
            return loginId;
        }
        public void SetLoginId(string loginId)
        {
            this.loginId = loginId;
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

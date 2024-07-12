/**
 * @file   : NormalLogin.cs
 * @date   : 2024/7/12 8:19:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.TemplateMethod模板方法模式.UsePattern
{
    /**
 * 普通用户登录控制的逻辑处理
 */
    public class NormalLogin : LoginTemplate
    {
        public override LoginModel findLoginUser(String loginId)
        {
            // 这里省略具体的处理，仅做示意，返回一个有默认数据的对象
            LoginModel lm = new LoginModel();
            lm.setLoginId(loginId);
            lm.setPwd("testpwd");
            return lm;
        }
    }

}

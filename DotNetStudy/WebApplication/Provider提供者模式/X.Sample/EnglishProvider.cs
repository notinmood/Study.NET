/**
 * @file   : EnglishProvider.cs
 * @date   : 2024/7/8 17:04:01
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    public class EnglishProvider : ParentProvider
    {
        public override string ShowData()
        {
            return "hello ,welcome to china";
        }
    }
}

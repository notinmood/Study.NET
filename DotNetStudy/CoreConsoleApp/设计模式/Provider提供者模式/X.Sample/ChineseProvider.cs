/**
 * @file   : ChineseProvider.cs
 * @date   : 2024/7/8 17:03:34
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.Provider提供者模式.X.Sample
{
    public class ChineseProvider : LanguageProvider
    {
        public override string ShowData()
        {
            return "你好，欢迎来到中国";
        }
    }

}

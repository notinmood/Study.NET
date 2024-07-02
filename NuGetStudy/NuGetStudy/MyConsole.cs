using ClassStandardLibrary;
using System;

namespace NuGetStudy
{
    public class MyConsole
    {
        /// <summary>
        /// 获取版本信息
        /// </summary>
        /// <returns>版本号</returns>
        public static string GetVersion()
        {
            return "1.0.3";
        }

        /// <summary>
        /// 获取当前时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetDate() {
            return MyClass.GetDate();
        }
    }
}

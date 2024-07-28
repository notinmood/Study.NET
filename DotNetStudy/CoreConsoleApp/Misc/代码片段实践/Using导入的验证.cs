/**
 * @file   : Using.cs
 * @date   : 2024/7/8 10:17:08
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;


namespace CoreConsoleApp.Misc.代码片段实践
{
    internal static class Using导入的验证
    {
        public static void Index()
        {

            // +--------------------------------------------------------------------------
            // |::说明·|
            //  以下代码片段（以及最开头的`using System;`）是通过输入 sqrt+两次TAB自动添加上的。
            //  而sqrt是在代码片段管理，里面自定义的代码片段。
            // +--------------------------------------------------------------------------
            double root = Math.Sqrt(9);

            Console.WriteLine(root);
        }
    }
}

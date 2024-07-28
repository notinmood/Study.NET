using System.Linq;

namespace CoreConsoleApp.OnlyForTest
{
    public static class MyBiz
    {
        /// <summary>
        /// 获取三角形类型.
        /// </summary>
        /// <param name="sideArr">三角形三边长度数组.</param>
        /// <returns>返回三角形类型名称.</returns>
        public static string GetTriangle(int[] sideArr)
        {
            if (sideArr.Count() < 3)
            {
                return "不构成三角形";
            }

            int a = sideArr[0];
            int b = sideArr[1];
            int c = sideArr[2];
            if (a + b < c || a + c < b && b + c < a)
            {
                return "不构成三角形";
            }

            if (a == b && a == c)
            {
                return "等边三角形";
            }

            if (a == b || a == c || b == c)
            {
                return "等腰三角形";
            }

            return "一般三角形";
        }
    }
}

/**
 * @file   : Client.cs
 * @date   : 2024/7/7 8:05:50
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.UsePatternBetter
{
    public class Client
    {
        public static void Index()
        {
            Context context = new Context(new VoteManager());
            for (int i = 0; i < 8; i++)
            {
                context.Vote("u1", "A");
            }
        }
    }

}

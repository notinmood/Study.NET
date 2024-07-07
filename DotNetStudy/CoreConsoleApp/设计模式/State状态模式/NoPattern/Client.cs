/**
 * @file   : Client.cs
 * @date   : 2024/7/7 7:32:38
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.NoPattern
{
    public class Client
    {
        public static void Index()
        {
            VoteManager vm = new VoteManager();
            for (int i = 0; i < 8; i++)
            {
                vm.vote("u1", "A");
            }
        }
    }

}

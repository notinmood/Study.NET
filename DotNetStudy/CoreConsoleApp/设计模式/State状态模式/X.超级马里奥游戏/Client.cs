/**
 * @file   : Client.cs
 * @date   : 2024/7/23 8:12:55
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{
    internal class Client
    {

        public static void Index()
        {
            Mario mario = new();

            mario.HandEvent(Events.MUSHROOM);
            mario.HandEvent(Events.FIRE_FLOWER);
            mario.HandEvent(Events.ENEMY_ATTACK);
            mario.HandEvent(Events.FALL_INTO_PIT);
        }
    }
}

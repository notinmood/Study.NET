/**
 * @file   : MarioDeadState.cs
 * @date   : 2024/7/23 8:33:37
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{
    public class DeadState : IStatus
    {
        private readonly Mario mario;
        public DeadState(Mario mario)
        {
            this.mario = mario;
        }

        public void EatMushroom()
        {
            Console.WriteLine("马里奥已死亡");
        }

        public void EatFireFlower()
        {
            Console.WriteLine("马里奥已死亡");
        }

        public void EnemyAttack()
        {
            Console.WriteLine("马里奥已死亡");
        }

        public void FallFit()
        {
            Console.WriteLine("马里奥已死亡");
        }
    }
}

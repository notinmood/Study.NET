/**
 * @file   : MairoSmallState.cs
 * @date   : 2024/7/23 8:15:11
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{
    public class SmallState : IStatus
    {
        private readonly Mario mario;
        public SmallState(Mario mario)
        {
            this.mario = mario;
        }

        public void EatMushroom()
        {
            Console.WriteLine("小马里奥吃了蘑菇变大了");
            // 修改状态
            mario.ChangeState(new BigState(mario));
        }

        public void EatFireFlower()
        {
            Console.WriteLine("小马里奥吃了火焰没变化");
        }

        public void EnemyAttack()
        {
            Console.WriteLine("小马里奥遇到敌人，死亡");
            mario.ChangeState(new DeadState(mario));
        }

        public void FallFit()
        {
            Console.WriteLine("小马里奥掉坑里，死亡");
            mario.ChangeState(new DeadState(mario));
        }
    }
}

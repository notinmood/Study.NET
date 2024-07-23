/**
 * @file   : MarioFireState.cs
 * @date   : 2024/7/23 8:32:44
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{
    public class FireState : IStatus
    {
        private readonly Mario mario;
        public FireState(Mario mario)
        {
            this.mario = mario;
        }

        public void EatMushroom()
        {
            Console.WriteLine("火焰马里奥吃了蘑菇没变化");
        }

        public void EatFireFlower()
        {
            Console.WriteLine("火焰马里奥吃了火焰没变化");
        }

        public void EnemyAttack()
        {
            Console.WriteLine("火焰马里奥遇到敌人，变成小马里奥");
            mario.ChangeState(new SmallState(mario));
        }

        public void FallFit()
        {
            Console.WriteLine("火焰马里奥掉坑里，死亡");
            mario.ChangeState(new DeadState(mario));
        }
    }
}

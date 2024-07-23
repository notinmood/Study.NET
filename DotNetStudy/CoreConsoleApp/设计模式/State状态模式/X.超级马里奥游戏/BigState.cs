/**
 * @file   : MarioBigState.cs
 * @date   : 2024/7/23 8:31:14
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;

namespace CoreConsoleApp.设计模式.State状态模式.X.超级马里奥游戏
{

    public class BigState : IStatus
    {
        private readonly Mario mario;

        public BigState(Mario mario)
        {
            this.mario = mario;
        }

        public void EatMushroom()
        {
            Console.WriteLine("大马里奥吃了蘑菇，没变化");
        }

        public void EatFireFlower()
        {
            Console.WriteLine("小马里奥吃了火焰，变成火焰马里奥");
            mario.ChangeState(new FireState(mario));
        }

        public void EnemyAttack()
        {
            Console.WriteLine("大马里奥遇到敌人，变成小马里奥");
            mario.ChangeState(new SmallState(mario));
        }

        public void FallFit()
        {
            Console.WriteLine("大马里奥掉坑里，死亡");
            mario.ChangeState(new DeadState(mario));
        }
    }
}

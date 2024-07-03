using System;

namespace CoreConsoleApp.设计模式.Factory工厂模式.Biz
{
    internal class Airplane : Enemy
    {
        public Airplane(int x, int y) : base(x, y)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"飞机绘制在坐标x={x},y={y}");
            Console.WriteLine("飞机正在发起攻击...");
        }
    }
}

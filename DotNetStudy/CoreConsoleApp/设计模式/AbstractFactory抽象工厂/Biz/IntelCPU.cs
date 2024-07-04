using System;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz
{
    /** 
   * Intel的CPU实现 
   */
    public class IntelCPU : ICPU
    {
        /** 
         * CPU的针脚数目 
         */
        private int pins = 0;
        /** 
         * 构造方法，传入CPU的针脚数目 
         * @param pins CPU的针脚数目 
         */
        public IntelCPU(int pins)
        {
            this.pins = pins;
        }
        public void calculate()
        {
            Console.WriteLine("now in Intel CPU,pins=" + pins);
        }
    }

}

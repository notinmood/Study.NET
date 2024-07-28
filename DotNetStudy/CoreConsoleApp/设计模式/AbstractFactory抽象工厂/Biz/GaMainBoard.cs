using System;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz
{
    /** 
   * 技嘉的主板 
   */
    public class GaMainBoard : IMainBoard
    {
        /** 
         * CPU插槽的孔数 
         */
        private int cpuHoles = 0;
        /** 
         * 构造方法，传入CPU插槽的孔数 
         * @param cpuHoles CPU插槽的孔数 
         */
        public GaMainBoard(int cpuHoles)
        {
            this.cpuHoles = cpuHoles;
        }

        public void installCPU()
        {
            Console.WriteLine("now in GAMainboard,cpuHoles=" + cpuHoles);
        }
    }
}

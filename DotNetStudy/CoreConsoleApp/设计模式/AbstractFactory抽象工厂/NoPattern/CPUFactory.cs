using CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.NoPattern
{
    /** 
      * 创建CPU的简单工厂 
      */
    public class CPUFactory
    {
        /** 
         * 创建CPU接口对象的方法 
         * @param type 选择CPU类型的参数 
         * @return CPU接口对象的方法 
         */
        public static ICPU createCPUApi(int type)
        {
            ICPU cpu = null;
            //根据参数来选择并创建相应的CPU对象  
            if (type == 1)
            {
                cpu = new IntelCPU(1156);
            }
            else if (type == 2)
            {
                cpu = new AMDCPU(939);
            }
            return cpu;
        }
    }
}

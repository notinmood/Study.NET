using CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.UsePattern
{
    /** 
   * 抽象工厂的接口，声明创建抽象产品对象的操作 
   */
    public interface AbstractFactory
    {
        /** 
         * 创建CPU的对象 
         * @return CPU的对象 
         */
        public ICPU createCPUApi();
        /** 
         * 创建主板的对象 
         * @return 主板的对象 
         */
        public IMainboard createMainboardApi();
    }
}

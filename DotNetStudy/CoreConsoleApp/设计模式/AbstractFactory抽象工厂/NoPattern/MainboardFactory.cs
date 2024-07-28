using CoreConsoleApp.设计模式.AbstractFactory抽象工厂.Biz;

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.NoPattern
{
    /** 
   * 创建主板的简单工厂 
   */
    public class MainboardFactory
    {
        /** 
         * 创建主板接口对象的方法 
         * @param type 选择主板类型的参数 
         * @return 主板接口对象的方法 
         */
        public static IMainBoard createMainboardApi(int type)
        {
            IMainBoard mainBoard = null;
            //根据参数来选择并创建相应的主板对象  
            if (type == 1)
            {
                mainBoard = new GaMainBoard(1156);
            }
            else if (type == 2)
            {
                mainBoard = new MsiMainBoard(939);
            }
            return mainBoard;
        }
    }

}

namespace CoreConsoleApp.设计模式.AbstractFactory抽象工厂.NoPattern
{
    public class Client
    {
        public static void Index()
        {
            //创建装机工程师对象
            ComputerEngineer engineer = new ComputerEngineer();
            //告诉装机工程师自己选择的配件，让装机工程师组装电脑  
            engineer.makeComputer(1, 1);
        }
    }

}
